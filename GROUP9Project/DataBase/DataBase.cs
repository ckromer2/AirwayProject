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
            db.CreateTable<Flight>();
            db.CreateTable<Route>();
        }

    }

    //called when the we server shuts down to close the db file
    ~DataBase() { db.Close(); }


    //All user related function bellow

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      nUser: The user object to be added to the databse.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function to add a new user to the database 
     */
    public int AddUser(User uUser)
    {
        return db.Insert(uUser); //Returns the number of rows added, should only every be 1.
    }


    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/08/23
     * 
     * In: 
     *      uId: The ID of the user that is attempting to login.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function pull the databse for a given user object 
     */
    public User GetUser(int uId)
    {
        var Output = db.Table<User>().Where(t => t.UserId == uId).ToList()[0];//There will only ever be 1 element in this list so this action is safe.

        return Output; //Returns the user pulled form the database with the given number.
    }
    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      uUser: The user that will be updated.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function to update a given user in the database. 
     */
    public int UpdateUser(User uUser)
    {
        return db.Update(uUser); //Returns the number of rows updated, should only every be 1.
    }

    //All BookingRecord opperations bellow

    /*
     * By: Spencer P. Lowery
     *
     * Date: 3/08/23
     * 
     * In: 
     *      nRecord: The record object to be added to the database.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Adds a new booking record to the database.
     */
    public int AddRecord(BookingRecord nRecord)
    { 
        return db.Insert(nRecord);
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 3/08/23
     * 
     * In: 
     *      uId: The Id of the use whose flight records are being pulled.
     *      
     * Out:
     *      A list of all the bookings made by a given user.
     *      
     * This function will output a list of all bookings made by a given user. 
     */
    public List<BookingRecord> GetRecordsByUserNotCancelledUndeparted(int uId) 
    { 
        var Output = db.Table<BookingRecord>().Where(t => t.UserId == uId && t.Canceled == false && t.Departed == false).ToList();
        return Output;
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/13/23
     * 
     * In: 
     *      uId: The Id of the use whose flight records are being pulled.
     *      
     * Out:
     *      A list of all the bookings made by a given user.
     *      
     * This function will output a list of all bookings made by a given user. 
     */
    public List<BookingRecord> GetRecordsByUserNotCancelledDeparted(int uId)
    {
        var Output = db.Table<BookingRecord>().Where(t => t.UserId == uId && t.Canceled == false && t.Departed == true).ToList();
        return Output;
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/13/23
     * 
     * In: 
     *      uId: The Id of the use whose flight records are being pulled.
     *      
     * Out:
     *      A list of all the bookings made by a given user.
     *      
     * This function will output a list of all bookings made by a given user. 
     */
    public List<BookingRecord> GetRecordsByUserCancelled(int uId)
    {
        var Output = db.Table<BookingRecord>().Where(t => t.UserId == uId && t.Canceled == true).ToList();
        return Output;
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     *      
     * Out:
     *      A list of all the bookings made by a given user.
     *      
     * This function will output a list of all bookings that are not cancelled 
     */
    public List<BookingRecord> GetRecordsNotCancelled()
    {
        var Output = db.Table<BookingRecord>().Where(t => t.Canceled == false).ToList();
        return Output;
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 3/09/23
     * 
     * In: 
     *      fId: The fligth Id of that all ouputs will share in common.
     *      
     * Out:
     *      A list of all the bookings made by a given user.
     *      
     * This function will output a list of all bookings for a specific flight that where not cancelled. 
     */
    public List<BookingRecord> GetRecordsByFlight(int fId)
    {
        var Output = db.Table<BookingRecord>().Where(t => t.FlightId == fId && t.Canceled == false).ToList();
        return Output;
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 3/09/23
     * 
     * In: 
     *      fId: The fligth Id of that all ouputs will share in common.
     *      
     * Out:
     *      A list of all the bookings made by a given user.
     *      
     * This function will output a list of all bookings for a specific flight that where payed in points.
     * Used to pay out points when a flight leaves, also must not be cancelled
     */
    public List<BookingRecord> GetRecordsByFlightPoints(int fId)
    {
        var Output = db.Table<BookingRecord>().Where(t => t.FlightId == fId && t.PayedInPoints == true && t.Canceled == false).ToList();
        return Output;
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 3/09/23
     * 
     * In: 
     *      uRecord: The record of object to be updated 
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * This function upadates a supplied record in the databse
     */
    public int GetRecordsByFlightPoints(BookingRecord uRecord)
    {
        return db.Update(uRecord);
    }

    //All flight opperations bellow

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      nFlight: The flight object to be added to the databse.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function to add a new flight to the database 
     */
    public int AddFlight(Flight uFlight)
    {
        return db.Insert(uFlight); //Returns the number of rows added, should only every be 1.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      fId: The ID of the flight to be searched.
     *      
     * Out:
     *      A list of all flights matching the above criteria
     *      
     * Function pull the databse for a given route object 
     */
    public Flight GetFlight(int fId)
    {
        var Output = db.Table<Flight>().Where(t => t.FlightId == fId).ToList()[0];//There will only ever be 1 element in this list so this action is safe.
        return Output; //Returns the user pulled form the database with the given number.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      rId: The ID of the route to search for.
     *      
     * Out:
     *      A list of all flights matching the above criteria
     *      
     * Function searches the database for all flights with a given route Id. 
     */
    public List<Flight> GetFlightRoute(int rId)
    {
        var Output = db.Table<Flight>().Where(t => t.RouteId == rId).ToList();
        return Output; //Returns the user pulled form the database with the given number.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      Time: The current time of the flight
     *      
     * Out:
     *      A list of all flights that have departed but who's status is yet to be updated
     *      
     * Function searches the database for all flights that have past the departure time but have not been set to the departed status
     */
    public List<Flight> GetFlightDeparted(DateTime Time)
    {
        var Output = db.Table<Flight>().Where(t => t.FlightDate <= Time).ToList();
        return Output; //Returns the user pulled form the database with the given number.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      uFlight: The flight that will be updated.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function to update a given flight in the database. 
     */
    public int UpdateFlight(User uFlight)
    {
        return db.Update(uFlight); //Returns the number of rows updated, should only every be 1.
    }

    //All route opperations bellow
    
    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      nRoute: The route object to be added to the databse.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function to add a new route to the database 
     */
    public int AddRoute(Route uRoute)
    {
        return db.Insert(uRoute); //Returns the number of rows added, should only every be 1.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      rId: The ID of the route to be searched.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function to pull the databse for a given route object 
     */
    public Route GetRoute(int rId)
    {
        var Output = db.Table<Route>().Where(t => t.RouteId == rId).ToList()[0];//There will only ever be 1 element in this list so this action is safe.
        return Output; //Returns the user pulled form the database with the given number.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      sId: The ID of the starting location.
     *      eId: The ID of the ending location.
     *      
     * Out:
     *      A list of all routes matching the stard and destination listed above
     *      
     * Function to pull the databse routes flying between two points
     */
    public List<Route> GetRouteStartEnd(AirportEnum sId, AirportEnum eId)
    {
        var Output = db.Table<Route>().Where(t => t.Start == sId && t.End == eId).ToList();
        return Output; //Returns the user pulled form the database with the given number.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      sId: The ID of the starting location.
     *      
     * Out:
     *      A list of all routes matching the stard listed above
     *      
     * Function to pull the databse routes flying from the starting point
     */
    public List<Route> GetRouteStart(AirportEnum sId)
    {
        var Output = db.Table<Route>().Where(t => t.Start == sId).ToList();
        return Output; //Returns the user pulled form the database with the given number.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      eId: The ID of the ending location.
     *      
     * Out:
     *      A list of all routes matching destination listed above
     *      
     * Function to pull the databse routes flying to the destination.
     */
    public List<Route> GetRouteEnd(AirportEnum eId)
    {
        var Output = db.Table<Route>().Where(t => t.End == eId).ToList();
        return Output; //Returns the user pulled form the database with the given number.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      uRoute: The route that will be updated.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function to update a given route in the database. 
     */
    public int UpdateRoute(User uRoute)
    {
        return db.Update(uRoute); //Returns the number of rows updated, should only every be 1.
    }

    /*
     * By: Spencer P. Lowery
     *
     * Date: 4/09/23
     * 
     * In: 
     *      dRoute: The route that will be deleted.
     *      
     * Out:
     *      1: Success
     *      Any: Failure
     *      
     * Function to update a given route in the database. 
     */
    public int DeleteRoute(User dRoute)
    {
        return db.Delete(dRoute); //Returns the number of rows updated, should only every be 1.
    }


}