
namespace GROUP9Project.UI;

public partial class BoardingPassForm : Form
{
    public BoardingPassForm()
    {
        InitializeComponent();
        LogedInLable.Text = "Loged in as: " + ApplicationData.AppUser.FisrtName + " " + ApplicationData.AppUser.LastName + "\nUser ID: " + ApplicationData.AppUser.UserId;
    }

    private void BoardingPassForm_Load(object sender, EventArgs e)
    {

    }
}
