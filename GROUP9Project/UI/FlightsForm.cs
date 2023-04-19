﻿using GROUP9Project.DataBase;


namespace GROUP9Project.UI;

public partial class FlightsForm : Form
{
    public FlightsForm()
    {
        InitializeComponent();
        PopulateBoxes();
        ShowEmployeeTab();
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/16/23
     * 
     * Function takes the present data in the form and uses it to find routes or sets of routes to fullfill those conditions.
     * If the return trip box is selected the arrival and destination airports are switched and finalized.
     */
    private void SearchButtonClick(object sender, EventArgs e)
    {
        FirstFlightListBox.BeginUpdate();
        if (PossibleRoutes1 != null)
            PossibleRoutes1.Clear();

        if (ListBoxToRoute1 != null)
            ListBoxToRoute1.Clear();
        else
            ListBoxToRoute1 = new List<int>();

        if (PossibleRoutes2 != null)
            PossibleRoutes2.Clear();
        
        if (ListBoxToRoute2 != null)
            ListBoxToRoute2.Clear();
        else
            ListBoxToRoute2 = new List<int>();

        FirstFlightListBox.Items.Clear();
        SecondFlightListBox.Items.Clear();

        //Finds all the routes that match the criteria
        PossibleRoutes1 = FindRoutes((AirportEnum)DepartComboBox.SelectedIndex, (AirportEnum)ArriveComboBox.SelectedIndex, DepartureDatePicker.Value.DayOfWeek);
        //Loops through the list printing the string for the single case as well as the dual case
        if (PossibleRoutes1.Count != 0)
        {
            for (int i = 0; i < PossibleRoutes1.Count; i++)
            {
                var tmp = PossibleRoutes1.ElementAt(i);
                if (tmp.End == (AirportEnum)ArriveComboBox.SelectedIndex)
                {
                    FirstFlightListBox.Items.Add(PrintFunctions.PrintRoute(tmp));
                    ListBoxToRoute1.Add(i);
                }
                else
                {
                    FirstFlightListBox.Items.Add(PrintFunctions.PrintRouteDual(tmp, PossibleRoutes1.ElementAt(i + 1)));
                    ListBoxToRoute1.Add(i);
                    i++;
                }
            }

            if (RoundTripCheckBox.Checked == true)
            {
                //Finds all the routes that match the criteria
                PossibleRoutes2 = FindRoutes((AirportEnum)ArriveComboBox.SelectedIndex, (AirportEnum)DepartComboBox.SelectedIndex, ReturnDatePicker.Value.DayOfWeek);
                //Loops through the list printing the string for the single case as well as the dual case
                if (PossibleRoutes2.Count != 0)
                {
                    for (int i = 0; i < PossibleRoutes2.Count; i++)
                    {
                        var tmp = PossibleRoutes2.ElementAt(i);
                        if (tmp.End == (AirportEnum)DepartComboBox.SelectedIndex)
                        {
                            SecondFlightListBox.Items.Add(PrintFunctions.PrintRoute(tmp));
                            ListBoxToRoute2.Add(i);
                        }
                        else
                        {
                            SecondFlightListBox.Items.Add(PrintFunctions.PrintRouteDual(tmp, PossibleRoutes2.ElementAt(i + 1)));
                            ListBoxToRoute2.Add(i);
                            i++;
                        }
                    }
                }
                else
                    MessageBox.Show("No flights availible for the selected return date.");
            }
        }
        else
            MessageBox.Show("No flights availible for the selected departure date.");
        FirstFlightListBox.EndUpdate();
    }

    //Populates the boxes with startup information.
    private void PopulateBoxes()
    {
        
        DepartComboBox.Items.AddRange(PlanesAirportsDistances.AirportsCode.ToArray());
        ArriveComboBox.Items.AddRange(PlanesAirportsDistances.AirportsCode.ToArray());

        DepartureDatePicker.Format = DateTimePickerFormat.Custom;
        DepartureDatePicker.CustomFormat = "MMM, dd yyyy";
        DepartureDatePicker.MinDate = DateTime.Today;
        DepartureDatePicker.MaxDate = DateTime.Today.AddMonths(6);

        ReturnDatePicker.Format = DateTimePickerFormat.Custom;
        ReturnDatePicker.CustomFormat = "MMM, dd yyyy";
        ReturnDatePicker.MinDate = DateTime.Today.AddDays(1);
        ReturnDatePicker.MaxDate = DateTime.Today.AddMonths(6);

        ReturnDatePicker.Visible = false;
        ReturnDateLable.Visible = false;

    }

    //Removes the departure airport from the arival airports box.
    private void DepartComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        ArriveComboBox.Items.Clear();
        ArriveComboBox.Items.AddRange(PlanesAirportsDistances.AirportsCode.ToArray());
        ArriveComboBox.Items.RemoveAt(DepartComboBox.SelectedIndex);
    }

    //Checks the state of the round trip box hiding or showing elements as needed.
    private void RoundTripCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (RoundTripCheckBox.Checked == false)
        {
            ReturnDatePicker.Visible = false;
            ReturnDateLable.Visible = false;
        }
        else
        {
            ReturnDatePicker.Visible = true;
            ReturnDateLable.Visible = true;
        }
    }

    private void ShowEmployeeTab()
    {
        if (ApplicationData.AppUser.UserType == UserDesignation.Customer)
        {
            EmployeeTab.Visible = false;
        }
    }


    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/16/23
     * 
     * In: 
     *      Start: The Departure Airport
     *      End: The final destination airport
     *      Day: The day of week selected to seach for flights with.
     *      
     * Out:
     *      A list of the routs that its possible to take.
     *      
     * Function takes in a starting point and destination in order to find a set of routs the user could fly to get from point a to point b
     * First the function gets any direct routes on the selected day, then the system builds two lists, one for every flight leaving the departure airport and one for all flights going to the destination
     * These are then trimmed to fit either the given day or the next day in the case of connection flights.
     * Finally these lists are combined in order to find connecting routes.
     * All found routes are added to the list.
     */
    private List<Route> FindRoutes(AirportEnum Start, AirportEnum End, DayOfWeek Day)
    {
        //Generates a list of fligths to show the user
        List<Route> OutputRoutes = new List<Route>();
        OutputRoutes.AddRange(ApplicationData.Connection.GetRouteStartEnd(Start, End));
        //Loops through the direct routes and removes ones that dont match the day of week supplied.
        if (OutputRoutes.ElementAt(0) != ApplicationData.nullRoute)
        {
            foreach (Route route in OutputRoutes)
            {
                if (route.ScheduleDate != Day && route.SchedualTime < DateTime.Now.Hour)
                {
                    OutputRoutes.Remove(route);
                }
            }
        }
        else
        {
            OutputRoutes.Remove(ApplicationData.nullRoute);
        }
        //Now Comes the hard part
        //Gets the routes from the departure airport removeing the direct routes
        List<Route> IDRoutes = ApplicationData.Connection.GetRouteStart(Start);
        List<int> RemovalTracker = new List<int>();
        int rIndex = 0;
        foreach (Route route in IDRoutes)
        {
            if ((route.ScheduleDate != Day && route.SchedualTime < DateTime.Now.Hour) || route.End == End || route == ApplicationData.nullRoute)
            {
                RemovalTracker.Add(rIndex);
            }
            rIndex++;
        }
        foreach (int i in RemovalTracker)
        {
            IDRoutes.Remove(IDRoutes.ElementAt(i));
        }

   

        //Gets all the routes to the destination airport removing the direct routes
        List<Route> IARoutes = ApplicationData.Connection.GetRouteStart(End);
        RemovalTracker.Clear();
        rIndex = 0;
        foreach (Route route in IARoutes)
        {
            //removes all the fligths not schedualled for this day or the next
            if ((route.ScheduleDate != Day && route.SchedualTime < DateTime.Now.Hour) || route.ScheduleDate != Day+1 || route.Start == Start || route == ApplicationData.nullRoute)
            {
                RemovalTracker.Add(rIndex);
            } 
            rIndex++;
        }
        foreach (int i in RemovalTracker)
        {
            IDRoutes.Remove(IARoutes.ElementAt(i));
        }

        //Loops through all the routs from the departure airport and to the destination if any share an intermediate link
        if (IDRoutes.Count != 0 && IARoutes.Count != 0)
        {
            foreach (Route DRoute in IDRoutes)
            {
                foreach (Route ARoute in IARoutes)
                {
                    //Checks if the routs have the same midpoint and that there is enough time for the first flight to finish and with extra time added in
                    if (DRoute.End == ARoute.Start &&
                        ((DRoute.ScheduleDate == ARoute.ScheduleDate && DRoute.SchedualTime + PlanesAirportsDistances.GetRouteTime(DRoute) + 1 < ARoute.SchedualTime)
                        || (DRoute.ScheduleDate < ARoute.ScheduleDate)))
                    {
                        //Adds the found routes to the system while removing the selected secondary routes.
                        OutputRoutes.Add(DRoute);
                        OutputRoutes.Add(ARoute);
                        IARoutes.Remove(ARoute);
                        break;
                    }
                }
            }
        }
        return OutputRoutes;
    }

    private void RewardsTab_Click(object sender, EventArgs e)
    {
        this.Hide();
        UI.RewardsForm rewardsForm = new UI.RewardsForm();
        rewardsForm.Closed += (s, args) => this.Close();
        rewardsForm.Show();
        rewardsForm.SetDesktopLocation(this.Location.X, this.Location.Y);

    }

    private void HistoryTab_Click(object sender, EventArgs e)
    {
        this.Hide();
        UI.HistoryForm historyForm = new UI.HistoryForm();
        historyForm.Closed += (s, args) => this.Close();
        historyForm.Show();
        historyForm.SetDesktopLocation(this.Location.X, this.Location.Y);

    }

    private void PurchaseButton_Click(object sender, EventArgs e)
    {
        
    }

    private void EmployeeTab_Click(object sender, EventArgs e)
    {
        if (ApplicationData.AppUser.UserType == UserDesignation.Accountant)
        {
            this.Hide();
            UI.AccountantForm accountantForm = new UI.AccountantForm();
            accountantForm.Closed += (s, args) => this.Close();
            accountantForm.Show();
            accountantForm.SetDesktopLocation(this.Location.X, this.Location.Y);
        }
        else if (ApplicationData.AppUser.UserType == UserDesignation.FlightManager)
        {
            this.Hide();
            UI.FlightManagerForm flightManagerForm = new UI.FlightManagerForm();
            flightManagerForm.Closed += (s, args) => this.Close();
            flightManagerForm.Show();
            flightManagerForm.SetDesktopLocation(this.Location.X, this.Location.Y);
        }
        else if (ApplicationData.AppUser.UserType == UserDesignation.LoadEngineer)
        {
            this.Hide();
            UI.LoadManagerForm loadManagerForm = new UI.LoadManagerForm();
            loadManagerForm.Closed += (s, args) => this.Close();
            loadManagerForm.Show();
            loadManagerForm.SetDesktopLocation(this.Location.X, this.Location.Y);
        }
        else if (ApplicationData.AppUser.UserType == UserDesignation.MarketingManager)
        {
            this.Hide();
            UI.MarketingManagerForm marketingManagerForm = new UI.MarketingManagerForm();
            marketingManagerForm.Closed += (s, args) => this.Close();
            marketingManagerForm.Show();
            marketingManagerForm.SetDesktopLocation(this.Location.X, this.Location.Y);
        }
    }
}
