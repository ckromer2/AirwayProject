
namespace GROUP9Project.UI;

public partial class HistoryForm : Form
{
    public HistoryForm()
    {
        InitializeComponent();
        FillListBoxes();
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/15/23
     *  
     * This function upadates the list boxes on the history page at load and when a flight is cancelled.
     */
    private void FillListBoxes()
    {
        //Stops printing and clears all relavent data
        BookedFlightsListBox.BeginUpdate();
        TakenFlightsListBox.BeginUpdate();
        CancelledFlightsListBox.BeginUpdate();

        
        BookedFlightsListBox.Items.Clear();
        TakenFlightsListBox.Items.Clear();
        CancelledFlightsListBox.Items.Clear();

        if (BookedFlights != null)
        {
            BookedFlights.Clear();
            TakenFlights.Clear();
            CancelledFlights.Clear();
        }

        //Adds entries to the booked flights list box
        BookedFlights = ApplicationData.Connection.GetRecordsByUserNotCancelledUndeparted(ApplicationData.AppUser.UserId);
        foreach (DataBase.BookingRecord entry in BookedFlights)
        {
            BookedFlightsListBox.Items.Add(DataBase.PrintFunctions.PrintFlightInfo(entry));
        }

        //Adds entries to the taken flights list box
        TakenFlights = ApplicationData.Connection.GetRecordsByUserNotCancelledDeparted(ApplicationData.AppUser.UserId);
        foreach (DataBase.BookingRecord entry in TakenFlights)
        {
            TakenFlightsListBox.Items.Add(DataBase.PrintFunctions.PrintFlightInfo(entry));
        }

        //Adds entries to the cancelled flights list box
        CancelledFlights = ApplicationData.Connection.GetRecordsByUserCancelled(ApplicationData.AppUser.UserId);
        foreach (DataBase.BookingRecord entry in CancelledFlights)
        {
            CancelledFlightsListBox.Items.Add(DataBase.PrintFunctions.PrintFlightInfo(entry));
        }

        //Re-enables printing of the list boxes
        BookedFlightsListBox.EndUpdate();
        TakenFlightsListBox.EndUpdate();
        CancelledFlightsListBox.EndUpdate();

    }

    private void CancelFlightButtonClick(object sender, EventArgs e)
    {
        BookedFlights.ElementAt(BookedFlightsListBox.SelectedIndex).Cancel();
        ApplicationData.Connection.UpdateRecord(BookedFlights.ElementAt(BookedFlightsListBox.SelectedIndex));
        FillListBoxes();
    }

}
