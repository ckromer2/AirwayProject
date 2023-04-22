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

        public static void Booking( )
        {



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