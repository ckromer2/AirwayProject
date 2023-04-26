
using GROUP9Project.DataBase;

namespace GROUP9Project.UI;

public partial class BoardingPassForm : Form
{
    public BoardingPassForm(BookingRecord Test)
    {
        InitializeComponent();
        ShowEmployeeTab();
        LogedInLable.Text = "Logged in as: " + ApplicationData.AppUser.FisrtName + " " + ApplicationData.AppUser.LastName + "\nUser ID: " + ApplicationData.AppUser.UserId;
        NameLable.Text = "Name: " + ApplicationData.AppUser.FisrtName + " " + ApplicationData.AppUser.LastName;
        AccountLable.Text = "Account: " + ApplicationData.AppUser.UserId;

        var tmp = ApplicationData.Connection.GetFlight(Test.FlightId);
        TimeLable.Text = "Time: " + tmp.FlightDate.ToString();
        var tmp2 = ApplicationData.Connection.GetRoute(tmp.FlightId);
        DepartureLable.Text = "Departure: " + PlanesAirportsDistances.AirportsName.ElementAt((int)tmp2.Start);
        ArrivalLable.Text = "Arrival: " + PlanesAirportsDistances.AirportsName.ElementAt((int)tmp2.End);
    }

    private void HistoryTab_Click(object sender, EventArgs e)
    {
        this.Hide();
        UI.HistoryForm historyForm = new UI.HistoryForm();
        historyForm.Closed += (s, args) => this.Close();
        historyForm.Show();
        historyForm.SetDesktopLocation(this.Location.X, this.Location.Y);
    }
    private void ShowEmployeeTab()
    {
        if (ApplicationData.AppUser.UserType == UserDesignation.Customer)
        {
            EmployeeTab.Visible = false;
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

    private void RewardsTab_Click(object sender, EventArgs e)
    {
        this.Hide();
        UI.RewardsForm rewardsForm = new UI.RewardsForm();
        rewardsForm.Closed += (s, args) => this.Close();
        rewardsForm.Show();
        rewardsForm.SetDesktopLocation(this.Location.X, this.Location.Y);
    }

    private void FlightsTab_Click(object sender, EventArgs e)
    {
        this.Hide();
        UI.FlightsForm flightsForm = new UI.FlightsForm();
        flightsForm.Closed += (s, args) => this.Close();
        flightsForm.Show();
        flightsForm.SetDesktopLocation(this.Location.X, this.Location.Y);
    }
}
