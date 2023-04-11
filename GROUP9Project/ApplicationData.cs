namespace GROUP9Project;

public static class ApplicationData
{
    public static DataBase.User AppUser = new DataBase.User(); //Holds all the data for the logged in user
    public static DataBase.DataBase Connection = new DataBase.DataBase();  //Acts like the conection to the "Server"
}
