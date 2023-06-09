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
    public partial class FlightManagerForm : Form
    {
        public FlightManagerForm()
        {
            InitializeComponent();
            ShowEmployeeTab();
            PopulateBoxes();
            LogedInLable.Text = "Logged in as: " + ApplicationData.AppUser.FisrtName + " " + ApplicationData.AppUser.LastName + "\nUser ID: " + ApplicationData.AppUser.UserId;

        }

        private void PopulateBoxes()
        {
            FlightList = ApplicationData.Connection.GetFlightAfterTime(DateTime.Now);
            foreach (Flight f in FlightList)
                FlightsListBox.Items.Add(PrintFunctions.PrintFlightInfo(f));
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

        private void PrintManifestButton_Click(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex >= 0)
            {
                this.Hide();
                UI.ManifestForm manifestForm = new UI.ManifestForm(FlightList.ElementAt(FlightsListBox.SelectedIndex));
                manifestForm.Closed += (s, args) => this.Close();
                manifestForm.Show();
                manifestForm.SetDesktopLocation(this.Location.X, this.Location.Y);
            }
        }
    }
}
