﻿using GROUP9Project.Controllers;
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

namespace GROUP9Project.UI
{
    public partial class AccountantForm : Form
    {
        public AccountantForm()
        {
            InitializeComponent();
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

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            PercentFullListBox.Items.Clear();
            FlightsListBox.Items.Clear();
            IncomeListBox.Items.Clear();
            List<Flight> flights = EmployeeManager.FlightsForAccountant(StartDatePicker.Value, EndDatePicker.Value);
            List<uint> income = EmployeeManager.IncomeOfFlights(flights);
            foreach (Flight x in flights)
            {
                PercentFullListBox.Items.Add(Math.Round((((float)x.CurrentCapacity / (float)x.TotalCapacity) * 100), 2) + "%");
                FlightsListBox.Items.Add(PrintFunctions.PrintFlightInfo(x));


            }

            float sum = 0;
            foreach (uint x in income)
            {
                IncomeListBox.Items.Add((float)x /100f);
                sum += (float)x /100f;
            }
            TotalIncome.Text = Convert.ToString(sum);
            TotalFlights.Text = Convert.ToString(flights.Count);


        }
    }
}
