﻿using GROUP9Project.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP9Project.UI
{
    public partial class ManifestForm : Form
    {
        public ManifestForm(Flight flight)
        {
            InitializeComponent();
            ShowEmployeeTab();
            LogedInLable.Text = "Logged in as: " + ApplicationData.AppUser.FisrtName + " " + ApplicationData.AppUser.LastName + "\nUser ID: " + ApplicationData.AppUser.UserId;

            List<BookingRecord> Records = ApplicationData.Connection.GetRecordsByFlight(flight.FlightId);
            foreach (BookingRecord record in Records)
            {
                User user = ApplicationData.Connection.GetUser(record.UserId);
                PassengerListBox.Items.Add(user.FisrtName + " " + user.LastName);
            }
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
        }

        private void RewardsTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI.RewardsForm rewardsForm = new UI.RewardsForm();
            rewardsForm.Closed += (s, args) => this.Close();
            rewardsForm.Show();
        }

        private void HistoryTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI.HistoryForm historyForm = new UI.HistoryForm();
            historyForm.Closed += (s, args) => this.Close();
            historyForm.Show();
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
}
