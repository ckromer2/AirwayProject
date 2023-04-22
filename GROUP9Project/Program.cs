using System.Security.Cryptography;
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
        ApplicationData.Connection.AddRecord(new DataBase.BookingRecord(999, 926177, 9000, 0, true)); 
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }

}



