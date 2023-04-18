namespace GROUP9Project;

public static class ApplicationData
{
    public static DataBase.User AppUser = new DataBase.User(); //Holds all the data for the logged in user
    public static readonly DataBase.DataBase Connection = new DataBase.DataBase();  //Acts like the conection to the "Server"

    //Null versions of the structs to be returned during a querry where nothing is found.
    public static readonly DataBase.User nullUser = new DataBase.User(-1, "", "", "", "", 0, "", 0, "");
    public static readonly DataBase.BookingRecord nullRecord = new DataBase.BookingRecord(-1, -1, 0, 0, false);
    public static readonly DataBase.Flight nullFlight = new DataBase.Flight(0, -1, DateTime.MinValue);
    public static readonly DataBase.Route nullRoute = new DataBase.Route(0, 0, 0, -1);

}
