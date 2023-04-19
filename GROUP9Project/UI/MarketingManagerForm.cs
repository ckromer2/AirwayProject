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
    public partial class MarketingManagerForm : Form
    {
        public MarketingManagerForm()
        {
            InitializeComponent();
            ShowEmployeeTab();
        }

        private void ShowEmployeeTab()
        {
            if (ApplicationData.AppUser.UserType == UserDesignation.Customer)
            {
                EmployeeTab.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
