/*
 * By: Cobey Kromer
 * Date: 4/16/23
 * For: Controller class for actions taken by customers
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
                string enteredHashedPassword = GetSHA512Hash(password);

                // If the password matches that stored we return true and update AppUser
                if (enteredHashedPassword.Equals(user.Password))
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
            string hashedPassword = GetSHA512Hash(pWord);
            User user = new User(fName, lName, hashedPassword, ccn, UserDesignation.Customer, addr, ag, pn);
            Console.WriteLine(user.UserId); 
            ApplicationData.AppUser = user;
            ApplicationData.Connection.AddUser(user); 
        }

        
        // Helper method to get SHA512
        private static string GetSHA512Hash(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public static void Rewards()
        {
        }

        public static void Booking()
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