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
                    DepartFlight();
                    return true;
                }
            }

            // Invalid username or password
            return false; 
        }

        public static bool ChangePassword(string id, string password, string newPassword)
        {
            User user = ApplicationData.Connection.GetUser(int.Parse(id));

            // If the user id is not found in the database user does not exist thus skip password validation
            if (user.UserId != -1)
            {
                // If the password matches that stored we return true and update AppUser
                if (user.Validate(password))
                {
                    user.ChangePassword(newPassword);
                    ApplicationData.Connection.UpdateUser(user); 
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
            BookingRecord rec1 = new BookingRecord(F1.FlightId ,ApplicationData.AppUser.UserId, (uint)(F1P * 100f), 0, true);
            ApplicationData.Connection.AddRecord(rec1);
            if (F2 != null)
            {
                BookingRecord rec2 = new BookingRecord(F2.FlightId, ApplicationData.AppUser.UserId, (uint)(F2P * 100f), 0, true);
                ApplicationData.Connection.AddRecord(rec2);
            }
            if (F3 != null)
            {
                BookingRecord rec3 = new BookingRecord(F3.FlightId, ApplicationData.AppUser.UserId, (uint)(F3P * 100f), 0, true);
                ApplicationData.Connection.AddRecord(rec3);
            }
            if (F4 != null)
            {
                BookingRecord rec4 = new BookingRecord(F4.FlightId, ApplicationData.AppUser.UserId, (uint)(F4P * 100f), 0, true);
                ApplicationData.Connection.AddRecord(rec4);
            }
        }
        
        //Used when points are not involved
        public static void BookingNoPoints(Flight F1, float F1P, Flight? F2 = null, float F2P = 0, Flight? F3 = null, float F3P = 0, Flight? F4 = null, float F4P = 0)
        {
            BookingRecord rec1 = new BookingRecord(F1.FlightId, ApplicationData.AppUser.UserId, 0, (uint)(F1P* 100f), false);
            ApplicationData.Connection.AddRecord(rec1);

            if (F2 != null)
            {
                BookingRecord rec2 = new BookingRecord(F2.FlightId, ApplicationData.AppUser.UserId, 0, (uint)(F2P * 100f), false);
                ApplicationData.Connection.AddRecord(rec2);
            }
            if(F3 != null)
            {
                BookingRecord rec3 = new BookingRecord(F3.FlightId, ApplicationData.AppUser.UserId, 0, (uint)(F3P * 100f), false);
                ApplicationData.Connection.AddRecord(rec3);
            }
            if (F4 != null)
            {
                BookingRecord rec4 = new BookingRecord(F4.FlightId, ApplicationData.AppUser.UserId, 0, (uint)(F4P * 100f), false);
                ApplicationData.Connection.AddRecord(rec4);
            }
        }


        //Creates a new flight is a ticket is purchases for a flight that does not exist
        public static Flight CreateFlight(int routeId, DateTime dateTime)
        {
            Flight nFlight = new Flight(PlaneEnum.UNSET, routeId, dateTime);
            ApplicationData.Connection.AddFlight(nFlight);
            return nFlight;
        }

        //On login will look and see if any flights the user has purchased and adds the point to thier account if they have.
        public static void DepartFlight()
        {
            var Tickets = ApplicationData.Connection.GetRecordsByUserNotCancelledUndeparted(ApplicationData.AppUser.UserId);
            foreach (BookingRecord Ticket in Tickets)
            { 
                var tmpFlight = ApplicationData.Connection.GetFlight(Ticket.FlightId);
                if (tmpFlight.FlightDate < DateTime.Now)
                {
                    Ticket.Departed = true;
                    ApplicationData.Connection.UpdateRecord(Ticket);
                    if (!Ticket.PayedInPoints)
                    {
                        ApplicationData.AppUser.AddPoints((uint)Math.Floor(Ticket.Dollars / 100f) * 10);
                        ApplicationData.Connection.UpdateUser(ApplicationData.AppUser);
                    }
                }
            }
        }


    }

    
}