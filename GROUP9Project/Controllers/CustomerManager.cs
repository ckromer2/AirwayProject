/*
 * By: Cobey Kromer
 * Date: 4/16/23
 * For: Controller class for actions taken by customers
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

using GROUP9Project.DataBase;
namespace GROUP9Project.Controllers
{
    
    public static class CustomerManager
    {
        public static bool Login(string id, string password)
        {
            User user = ApplicationData.Connection.GetUser(int.Parse(id));

            // If the user id is not found in the database user does not exist thus skip password validation
            if (user.UserId != -1)
            {
                // If the password matches that stored we return true and update AppUser
                if (user.Validate(password))
                {
                    ApplicationData.AppUser = user;
                    return true; 
                }
            }

            // Invalid username or password
            return false; 
        }

        public static void SignUp(string fName, string lName, string pWord, string ccn, string addr, uint ag, string pn)
        {
            // Get hash of string password then create a new user and add them to the database and then set AppUser to the current user
            User user = new User(fName, lName, pWord, ccn, UserDesignation.Customer, addr, ag, pn);
            Console.WriteLine(user.UserId); 
            ApplicationData.AppUser = user;
            ApplicationData.Connection.AddUser(user); 
        }

        // Method used to calculate the used points of a specific user(used on rewards page)
        public static uint calculateUsedRewards()
        {
            // Sum up all the records that used points and make that the used points label
            var listOfRecordsNotCancelled = ApplicationData.Connection.GetRecordsByUserNotCancelled(ApplicationData.AppUser.UserId);
            uint sum = 0;
            foreach (BookingRecord rec in listOfRecordsNotCancelled)
                if (rec.PayedInPoints == true)
                    sum += rec.Points;
            return sum; 
        }

        //Used when points are involved
        public static void BookingPoints(Flight F1, float F1P, Flight? F2 = null, float F2P = 0, Flight? F3 = null, float F3P = 0, Flight? F4 = null, float F4P = 0)
        {
            BookingRecord rec1 = new BookingRecord(F1.FlightId ,ApplicationData.AppUser.UserId, (uint)F1P * 100 * 100, 0, true);
            ApplicationData.Connection.AddRecord(rec1);
            if (F2 != null)
            {
                BookingRecord rec2 = new BookingRecord(F2.FlightId, ApplicationData.AppUser.UserId, (uint)F2P * 100 * 100, 0, true);
                ApplicationData.Connection.AddRecord(rec2);
            }
            if (F3 != null)
            {
                BookingRecord rec3 = new BookingRecord(F3.FlightId, ApplicationData.AppUser.UserId, (uint)F3P * 100 * 100, 0, true);
                ApplicationData.Connection.AddRecord(rec3);
            }
            if (F4 != null)
            {
                BookingRecord rec4 = new BookingRecord(F4.FlightId, ApplicationData.AppUser.UserId, (uint)F4P * 100 * 100, 0, true);
                ApplicationData.Connection.AddRecord(rec4);
            }
        }
        
        //Used when points are not involved
        public static void BookingNoPoints(Flight F1, float F1P, Flight? F2 = null, float F2P = 0, Flight? F3 = null, float F3P = 0, Flight? F4 = null, float F4P = 0)
        {
            BookingRecord rec1 = new BookingRecord(F1.FlightId, ApplicationData.AppUser.UserId, 0, (uint)F1P*100, false);
            ApplicationData.Connection.AddRecord(rec1);

            if (F2 != null)
            {
                BookingRecord rec2 = new BookingRecord(F2.FlightId, ApplicationData.AppUser.UserId, 0, (uint)F2P * 100, false);
                ApplicationData.Connection.AddRecord(rec2);
            }
            if(F3 != null)
            {
                BookingRecord rec3 = new BookingRecord(F3.FlightId, ApplicationData.AppUser.UserId, 0, (uint)F3P * 100, false);
                ApplicationData.Connection.AddRecord(rec3);
            }
            if (F4 != null)
            {
                BookingRecord rec4 = new BookingRecord(F4.FlightId, ApplicationData.AppUser.UserId, 0, (uint)F4P * 100, false);
                ApplicationData.Connection.AddRecord(rec4);
            }



        }

        public static void Cancellation()
        {

        }

        public static void PrintBoardingPass()
        {

        }

        public static void BrowseFlights()
        {

        }

        public static void CreateAccount()
        {

        }

    }

    
}