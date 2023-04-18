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
    public partial class RewardsForm : Form
    {
        public RewardsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RewardsForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeTab_Click(object sender, EventArgs e)
        {

        }

        private void HistoryTab_Click(object sender, EventArgs e)
        {
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

        }

        private void HistoryTab_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UI.HistoryForm historyForm = new UI.HistoryForm();
            historyForm.Closed += (s, args) => this.Close();
            historyForm.Show();
            historyForm.SetDesktopLocation(this.Location.X, this.Location.Y);

        }

        private void EmployeeTab_Click_1(object sender, EventArgs e)
        {

        }
    }
}
