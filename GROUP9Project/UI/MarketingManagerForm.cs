using GROUP9Project.DataBase;

namespace GROUP9Project.UI
{
    public partial class MarketingManagerForm : Form
    {
        public MarketingManagerForm()
        {
            InitializeComponent();
            ShowEmployeeTab();
            PopulateBoxes();
            LogedInLable.Text = "Logged in as: " + ApplicationData.AppUser.FisrtName + " " + ApplicationData.AppUser.LastName + "\nUser ID: " + ApplicationData.AppUser.UserId;
        }

        private void PopulateBoxes()
        {
            //Stops updates for the list box and clears the current contents
            FlightListBox.BeginUpdate();
            FlightListBox.Items.Clear();
            //Adds the planes to the drop down
            foreach(Plane t in PlanesAirportsDistances.Planes)
                PlaneBox.Items.Add(t.PlaneName);

            //Gets the list of flights with no plane and adds them to the listbox.
            FlightList = ApplicationData.Connection.GetFlightNoPlane();
            foreach (Flight f in FlightList)
                FlightListBox.Items.Add(PrintFunctions.PrintFlightInfo(f));

            //Ends update and returns
            FlightListBox.EndUpdate();
        }



        private void ShowEmployeeTab()
        {
            if (ApplicationData.AppUser.UserType == UserDesignation.Customer)
            {
                EmployeeTab.Visible = false;
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

        private void HistoryTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI.HistoryForm historyForm = new UI.HistoryForm();
            historyForm.Closed += (s, args) => this.Close();
            historyForm.Show();
            historyForm.SetDesktopLocation(this.Location.X, this.Location.Y);
        }

        private void ChangePlaneButton_Click(object sender, EventArgs e)
        {
            //Changes the data of the given flight then updates the database
            if (FlightListBox.SelectedIndex >= 0 && PlaneBox.SelectedIndex >= 0)
            {
                FlightList.ElementAt(FlightListBox.SelectedIndex).PlaneId = (PlaneEnum)PlaneBox.SelectedIndex;
                FlightList.ElementAt(FlightListBox.SelectedIndex).TotalCapacity = PlanesAirportsDistances.Planes.ElementAt(PlaneBox.SelectedIndex).Capacity;
                ApplicationData.Connection.UpdateFlight(FlightList.ElementAt(FlightListBox.SelectedIndex));

                //Re-Prints the data in the list box
                PopulateBoxes();
            }
        }
    }
}
