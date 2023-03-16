/*
 * By: Spencer P. Lowery
 *
 * The class holding the main database of the opperation.
 * 
 *  
 * Update History
 * 
 * March 8: Initial creation and construction.
 * March 9: Added support to change user passwords.
 */

using SQLite;

namespace GROUP9Project.DataBase;

//This class is the interface between all of the data and the user side. It will be by far the largest class containing many functions.
public class DataBase
{
    private SQLiteConnection db;
    private Random UIdGenerator = new Random();

    //called when the server starts to initialize the database
    public DataBase()
    {
        //if the database file allready exists then it is connected, if not a new database file is created
        if (File.Exists("database.db"))
        {
            db = new SQLiteConnection("database.db");
        }
        else
        {
            //Creates the database connection and adds the new tables
            db = new SQLiteConnection("database.db");
            //One of these lines will ahve to be added for each and every table we want to add.
            db.CreateTable<User>();
            db.CreateTable<BookingRecord>();
        }

    }

    //called when the we server shuts down to close the db file
    ~DataBase() { db.Close(); }

   /*
    * By: Spencer P. Lowery
    *
    * Date: 3/08/23
    * 
    * In: 
    *      Data elements of the user class. Some left optional as they are not used in the program itself.
    *      
    * Out:
    *      1: Success
    *      Any: Failure
    *      
    * Creates a new user and adds them to the database.
    */
    public int CreateUser(string fName, string lName, string pWord, string ccn, UserDesignation type, string addr = "", uint ag = 0, string pn = "")
    {
        User NewUser = new User(UIdGenerator.Next(100000, 999999), fName, lName, pWord, ccn, type, addr, ag, pn);
        return db.Insert(NewUser);
    }

   /*
    * By: Spencer P. Lowery
    *
    * Date: 3/08/23
    * 
    * In: 
    *      Data elements of the user class. Some left optional as they are not used in the program.
    *      
    * Out:
    *      1: Success
    *      Any: Failure
    *      
    * Creates a new user and adds them to the database.
    */
    public int BookFlight(int fId, int uId, bool payedP, uint P = 0, uint D = 0)
    { 
        BookingRecord NewRecord = new BookingRecord(fId, uId, P, D, payedP);
        return db.Insert(NewRecord);
    }

   /*
    * By: Spencer P. Lowery
    *
    * Date: 3/08/23
    * 
    * In: 
    *      uId: The ID of the user who's password will be changed.
    *      
    * Out:
    *      A list of all the bookings made by a given user.
    *      
    * This function will output a list of all bookings made by a given user. 
    */
    public List<BookingRecord> GetRecords(int uId) 
    { 
        var Output = db.Table<BookingRecord>().Where(t => t.UserId == uId).ToList();
        return Output;
    }

   /*
    * By: Spencer P. Lowery
    *
    * Date: 3/09/23
    * 
    * In: 
    *      uId: The ID of the user who's password will be changed.
    *      cPass: String containing the "current" password.
    *      nPass: String containing the new password.
    *      
    * Out:
    *      1: Success
    *      Any: Failure
    *      
    * Function pull the given user's data and attempt to change the password. 
    */
    public int ChangePassword(int uId, string cPass, string nPass)
    {
        var Output = db.Table<User>().Where(t => t.UserId == uId).ToList()[0];//There will only ever be 1 element in this list so this action is safe.
        if (Output.ChangePassword(cPass, nPass) != 0) { return -1; }//Attempts to change the password, return an error code if that opperation failed.

        return db.Update(Output); //Returns the number of rows updated, should only every be 1.
    }


}