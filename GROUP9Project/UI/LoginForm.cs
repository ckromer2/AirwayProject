using GROUP9Project.Controllers;

namespace GROUP9Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            // If all text boxes have stuff in them
            if (IdTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                // If the customer manager allows a login
                if (CustomerManager.Login(IdTextBox.Text, PasswordTextBox.Text))
                {
                    this.Hide();
                    UI.FlightsForm flightsForm = new UI.FlightsForm();
                    flightsForm.Closed += (s, args) => this.Close();
                    flightsForm.Show();
                    flightsForm.SetDesktopLocation(this.Location.X, this.Location.Y);
                }
                else
                    MessageBox.Show("Invalid Login.");

            }

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // If all the text boxes have information in them
            if (FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && PasswordSignUpTextBox.Text != "" && CreditCardTextBox.Text != "" && AddressTextBox.Text != "" && AgeTextBox.Text != "" && PhoneNumberTextBox.Text != "")
            {
                CustomerManager.SignUp(FirstNameTextBox.Text, LastNameTextBox.Text, PasswordSignUpTextBox.Text, CreditCardTextBox.Text, AddressTextBox.Text, Convert.ToUInt32(AgeTextBox.Text), PhoneNumberTextBox.Text);
                this.Hide();
                UI.FlightsForm flightsForm = new UI.FlightsForm();
                flightsForm.Closed += (s, args) => this.Close();
                flightsForm.Show();
                flightsForm.SetDesktopLocation(this.Location.X, this.Location.Y);
                MessageBox.Show("Account Created with id: " + ApplicationData.AppUser.UserId);

            }

        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            // If all text boxes have stuff in them
            if (IdTextBoxForCP.Text != "" && PasswordTextBoxCP.Text != "" && NewPasswordTextBoxCP.Text != "")
            {
                // If the customer manager allows a login
                if (CustomerManager.ChangePassword(IdTextBoxForCP.Text, PasswordTextBoxCP.Text, NewPasswordTextBoxCP.Text))
                {
                    this.Hide();
                    UI.FlightsForm flightsForm = new UI.FlightsForm();
                    flightsForm.Closed += (s, args) => this.Close();
                    flightsForm.Show();
                    flightsForm.SetDesktopLocation(this.Location.X, this.Location.Y);
                }
                else
                    MessageBox.Show("Invalid Login.");

            }
        }
    }

}