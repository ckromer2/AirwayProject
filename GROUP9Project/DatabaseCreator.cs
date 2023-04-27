/*
 * By: Cobey Kromer
 * Date: 4/16/23
 * For: To initialize the database with test data
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUP9Project
{
    static class DatabaseCreator
    {
        // Run this in the Program.cs class for these items to be added to the database
        public static void CreateUserData()
        {
            DataBase.User user1 = new DataBase.User(100000, "Customer", "Peters", "hello", "9999999999999999", DataBase.UserDesignation.Customer, "1234 Street Rd. Toledo Ohio", 21, "419-921-1234"); 
            ApplicationData.Connection.AddUser(user1);

            DataBase.User user2 = new DataBase.User(100001, "Accountant", "Peters", "hello", "9999999999999999", DataBase.UserDesignation.Accountant, "1234 Street Rd. Toledo Ohio", 21, "419-921-1234");
            ApplicationData.Connection.AddUser(user2);

            DataBase.User user3 = new DataBase.User(100002, "LoadEngineer", "Peters", "hello", "9999999999999999", DataBase.UserDesignation.LoadEngineer, "1234 Street Rd. Toledo Ohio", 21, "419-921-1234");
            ApplicationData.Connection.AddUser(user3);

            DataBase.User user4 = new DataBase.User(100003, "MarketingManager", "Peters", "hello", "9999999999999999", DataBase.UserDesignation.MarketingManager, "1234 Street Rd. Toledo Ohio", 21, "419-921-1234");
            ApplicationData.Connection.AddUser(user4);

            DataBase.User user5 = new DataBase.User(100004, "FlightManager", "Peters", "hello", "9999999999999999", DataBase.UserDesignation.FlightManager, "1234 Street Rd. Toledo Ohio", 21, "419-921-1234");
            ApplicationData.Connection.AddUser(user5);
        }
    }
}
