using GROUP9Project.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GROUP9Project.UI
{
    public partial class AddRouteForm : Form
    {
        public AddRouteForm()
        {
            InitializeComponent();
            PopulateBoxes();
            ShowEmployeeTab();
            LogedInLable.Text = "Logged in as: " + ApplicationData.AppUser.FisrtName + " " + ApplicationData.AppUser.LastName + "\nUser ID: " + ApplicationData.AppUser.UserId;
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

        //on add take RoutID, departPort, arrivePort, departDate, departTime create Route add to Flight.cs Route
        private void AddRouteButton_Click(object sender, EventArgs e)
        {
            DataBase.Route newRoute = new DataBase.Route();
            int start = DepartComboBox.SelectedIndex;
            int end = ArriveComboBox.SelectedIndex;
            if (start > end)
                end = ArriveComboBox.SelectedIndex;
            else
                end = ArriveComboBox.SelectedIndex + 1;
            
            newRoute.Start = (AirportEnum)start;
            newRoute.End = (AirportEnum)end;
            newRoute.ScheduleDate = DepartureDatePicker.Value.DayOfWeek;
            DateTime j = departTime.Value;
            int i = int.Parse(j.ToString("HHmmss"));
            newRoute.SchedualTime = i;
            ApplicationData.Connection.AddRoute(newRoute);
            PopulateBoxes();
            //DepartComboBox.SelectedIndex = start;
            //ArriveComboBox.SelectedIndex = end;
        }
        //remove route
        private void RemoveRouteButton_Click(object sender, EventArgs e)
        {
            Route removeRoute = RoutesListBox.SelectedItem as Route;
            ApplicationData.Connection.DeleteRoute(removeRoute);
            PopulateBoxes();
        }
        //onn modify find data entry by RoutID replace data with RoutID, departPort, arrivePort, departDate, departTime fields
        private void ModifyRouteButton_Click(object sender, EventArgs e)
        {
            Route updateRoute = RoutesListBox.SelectedItem as Route;
            int start = DepartComboBox.SelectedIndex;
            int end = ArriveComboBox.SelectedIndex;
            if (start > end)
                end = ArriveComboBox.SelectedIndex;
            else
                end = ArriveComboBox.SelectedIndex + 1;
            updateRoute.Start = (AirportEnum)start;
            updateRoute.End = (AirportEnum)end;
            updateRoute.ScheduleDate = DepartureDatePicker.Value.DayOfWeek;
            DateTime j = departTime.Value;
            int i = int.Parse(j.ToString("HHmmss"));
            updateRoute.SchedualTime = i;
            ApplicationData.Connection.UpdateRoute(updateRoute); 
            PopulateBoxes();
        }

        private void PopulateBoxes()
        {
            RoutesListBox.Items.Clear();
            DepartComboBox.Items.Clear();
            ArriveComboBox.Items.Clear();
            int i = 0;
            Route[] routeArray = ApplicationData.Connection.GetAllRoutes();
            while (i < routeArray.Length)
            {
                RoutesListBox.Items.Add(routeArray[i]);
                i++;
            }
            DepartComboBox.Items.AddRange(PlanesAirportsDistances.AirportsCode.ToArray());
            ArriveComboBox.Items.AddRange(PlanesAirportsDistances.AirportsCode.ToArray());
            DepartureDatePicker.Format = DateTimePickerFormat.Custom;
            DepartureDatePicker.CustomFormat = "MMM, dd yyyy";
            DepartureDatePicker.MinDate = DateTime.Today;
            DepartureDatePicker.MaxDate = DateTime.Today.AddMonths(6);
        }
        private void DepartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArriveComboBox.Items.Clear();
            ArriveComboBox.Items.AddRange(PlanesAirportsDistances.AirportsCode.ToArray());
            ArriveComboBox.Items.RemoveAt(DepartComboBox.SelectedIndex);
        }

        private void RouteListBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string RouteId = ((Route)e.ListItem).RouteId.ToString();
            string Start = ((Route)e.ListItem).Start.ToString();
            string End = ((Route)e.ListItem).End.ToString();
            string ScheduleDate = ((Route)e.ListItem).ScheduleDate.ToString();
            string SchedualTime = ((Route)e.ListItem).SchedualTime.ToString();
            e.Value = RouteId + "  " + Start + "  " + End + "  " + ScheduleDate + "  " + SchedualTime;
        }
    }
}
