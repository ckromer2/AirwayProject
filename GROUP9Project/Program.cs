using GROUP9Project.DataBase;
using GROUP9Project.UI;

namespace GROUP9Project;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        //ApplicationData.Connection.AddFlight(new DataBase.Flight(PlaneEnum.B737,10, new DateTime(2023,4,20).AddHours(5)));
        //ApplicationData.Connection.AddFlight(new DataBase.Flight(PlaneEnum.B737, 2, new DateTime(2023, 4, 20).AddHours(14)));
        //ApplicationData.Connection.AddFlight(new DataBase.Flight(PlaneEnum.B737, 5, new DateTime(2023, 4, 20).AddHours(8)));
        //DatabaseCreator.CreateUserData(); 
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }

}



