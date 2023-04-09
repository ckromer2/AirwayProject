using SQLite;
using System.Runtime.CompilerServices;

namespace GROUP9Project.DataBase;
//This class keeps track booking records including the price payed, in points or dollars, this includeds flights that have been cancelled as well.
public class BookingRecord
{
    //Defines the collums of the tables.
    [PrimaryKey, AutoIncrement]
    public int RecordId { get; private set; }//Generic Id of this record, internal use only.
    public int FlightId { get; private set; }//Id of the flight this recored involves.
    public int LinkedId { get; private set; }
    public int UserId { get; private set; }//Id of the user to whome this record belongs.
    public uint Points { get; private set; }//Amount of points payed for the flight.
    public uint Dollars { get; private set; }//Dollar amount payed * 10 to avoid floating point issues.
    public bool PayedInPoints { get; private set; }//Decies which currency to refund as well as what to count for accounting purposes.
    public bool Canceled { get; set; }//Removes the record from the accounting but leaves it on the user's dashboard.
                                       
    //Default constructor used by the database this should never be called by the main program.
    public BookingRecord()
    { 
        FlightId = 0;
        UserId = 0;
        Points = 0;
        Dollars = 0;
        PayedInPoints = false;
        Canceled = false;
    }
    //Full constructor used by the program. Points and Dollars are left optional as one of them will be zero deppending on the purchase method.
    public BookingRecord(int fId, int uId, uint P, uint D, bool payedP)
    {
        FlightId = fId;
        UserId = uId;
        Points = P;
        Dollars = D;
        PayedInPoints = payedP;
        Canceled = false;
    }

}

