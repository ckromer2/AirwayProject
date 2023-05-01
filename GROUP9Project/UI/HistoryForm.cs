using GROUP9Project.DataBase;

namespace GROUP9Project.UI;

public partial class HistoryForm : Form
{
    public HistoryForm()
    {
        InitializeComponent();
        FillListBoxes();
        ShowEmployeeTab();
        LogedInLable.Text = "Logged in as: " + ApplicationData.AppUser.FisrtName + " " + ApplicationData.AppUser.LastName + "\nUser ID: " + ApplicationData.AppUser.UserId;
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/15/23
     *  
     * This function upadates the list boxes on the history page at load and when a flight is cancelled.
     */
    private void FillListBoxes()
    {
        //Stops printing and clears all relavent data
        BookedFlightsListBox.BeginUpdate();
        TakenFlightsListBox.BeginUpdate();
        CancelledFlightsListBox.BeginUpdate();

        
        BookedFlightsListBox.Items.Clear();
        TakenFlightsListBox.Items.Clear();
        CancelledFlightsListBox.Items.Clear();

        if (BookedFlights != null)
        {
            BookedFlights.Clear();
            TakenFlights.Clear();
            CancelledFlights.Clear();
        }

        //Adds entries to the booked flights list box checking to make sure something was returned by the query
        BookedFlights = ApplicationData.Connection.GetRecordsByUserNotCancelledUndeparted(ApplicationData.AppUser.UserId);
        foreach (DataBase.BookingRecord entry in BookedFlights)
        {
            BookedFlightsListBox.Items.Add(DataBase.PrintFunctions.PrintFlightInfo(entry));
        }
        //Adds entries to the taken flights list box checking to make sure something was returned by the query
        TakenFlights = ApplicationData.Connection.GetRecordsByUserNotCancelledDeparted(ApplicationData.AppUser.UserId);
        foreach (DataBase.BookingRecord entry in TakenFlights)
        {
            TakenFlightsListBox.Items.Add(DataBase.PrintFunctions.PrintFlightInfo(entry));
        }
        //Adds entries to the cancelled flights list box checking to make sure something was returned by the query
        CancelledFlights = ApplicationData.Connection.GetRecordsByUserCancelled(ApplicationData.AppUser.UserId);
        foreach (DataBase.BookingRecord entry in CancelledFlights)
        {
            CancelledFlightsListBox.Items.Add(DataBase.PrintFunctions.PrintFlightInfo(entry));
        }
        //Re-enables printing of the list boxes
        BookedFlightsListBox.EndUpdate();
        TakenFlightsListBox.EndUpdate();
        CancelledFlightsListBox.EndUpdate();

    }

    private void ShowEmployeeTab()
    {
        if (ApplicationData.AppUser.UserType == UserDesignation.Customer)
        {
            EmployeeTab.Visible = false;
        }
    }

    private void CancelFlightButtonClick(object sender, EventArgs e)
    {
        if (BookedFlightsListBox.SelectedIndex != -1)
        {
            BookedFlights.ElementAt(BookedFlightsListBox.SelectedIndex).Cancel();
            if (BookedFlights.ElementAt(BookedFlightsListBox.SelectedIndex).PayedInPoints)
            {
                ApplicationData.AppUser.AddPoints(BookedFlights.ElementAt(BookedFlightsListBox.SelectedIndex).Points);
                ApplicationData.Connection.UpdateUser(ApplicationData.AppUser);
            }

            ApplicationData.Connection.UpdateRecord(BookedFlights.ElementAt(BookedFlightsListBox.SelectedIndex));
            FillListBoxes();
        }
    }

    private void FlightsTab_Click(object sender, EventArgs e)
    {
        this.Hide();
        UI.FlightsForm flightsForm = new UI.FlightsForm();
        flightsForm.Closed += (s, args) => this.Close();
        flightsForm.Show();
        flightsForm.SetDesktopLocation(this.Location.X, this.Location.Y);

    }

    private void RewardsTab_Click(object sender, EventArgs e)
    {
        this.Hide();
        UI.RewardsForm rewardsForm = new UI.RewardsForm();
        rewardsForm.Closed += (s, args) => this.Close();
        rewardsForm.Show();
        rewardsForm.SetDesktopLocation(this.Location.X, this.Location.Y);

    }

    private void PrintPassButton_Click(object sender, EventArgs e)
    {
        if (BookedFlightsListBox.SelectedIndex != -1)
        {
            Flight tmpFlight = ApplicationData.Connection.GetFlight(BookedFlights.ElementAt(BookedFlightsListBox.SelectedIndex).FlightId);
            //TimeSpan tmp2 = tmpFlight.FlightDate - DateTime.Now;
            TimeSpan tmp2 = tmpFlight.FlightDate - new DateTime(2023,4,28).AddHours(4).AddMinutes(2);
            if (tmp2.TotalHours < 1)
            {
                this.Hide();
                UI.BoardingPassForm boardingPassForm = new UI.BoardingPassForm(BookedFlights.ElementAt(BookedFlightsListBox.SelectedIndex));
                boardingPassForm.Closed += (s, args) => this.Close();
                boardingPassForm.Show();
                boardingPassForm.SetDesktopLocation(this.Location.X, this.Location.Y);
            } 
            else
                MessageBox.Show("To early to print the ticket.");
        }
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
            UI.AddRouteForm loadManagerForm = new UI.AddRouteForm();
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
