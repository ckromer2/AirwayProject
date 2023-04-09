namespace GROUP9Project;

public class ApplicationData
{
    public DataBase.User AppUser { get; set; } //Holds all the data for the logged in user
    private DataBase.DataBase Connection { get; set; }  //Acts like the conection to the "Server"
    
    public ApplicationData()
    {
        
        Connection = new DataBase.DataBase();
        AppUser = new DataBase.User();
        
    }

}
