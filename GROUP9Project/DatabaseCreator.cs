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
using System.Windows.Forms;
using GROUP9Project.DataBase; 
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

        public static void CreateRouteData()
        {
            // Cause we have the same flights every day
            for (int i = 0; i < 7; i++)
            {
                // CLE
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.BNA, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.BNA, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.BNA, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.DEN, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.DEN, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.DEN, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.JFK, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.JFK, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.JFK, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.TPA, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.TPA, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.CLE, AirportEnum.TPA, (DayOfWeek)i, 21));

                // BNA
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.DFW, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.DFW, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.DFW, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.JFK, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.JFK, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.JFK, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.TPA, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.TPA, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.TPA, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.SEA, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.SEA, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.BNA, AirportEnum.SEA, (DayOfWeek)i, 21));

                // TPA
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.MSP, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.MSP, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.MSP, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.DEN, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.DEN, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.DEN, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.JFK, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.JFK, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.JFK, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.LAS, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.LAS, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.TPA, AirportEnum.LAS, (DayOfWeek)i, 21));

                // IAD
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.JFK, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.JFK, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.JFK, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.LAX, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.LAX, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.LAX, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.DFW, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.DFW, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.DFW, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.SEA, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.SEA, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.IAD, AirportEnum.SEA, (DayOfWeek)i, 21));
                    
                // LAX
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.BNA, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.BNA, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.BNA, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.MSP, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.MSP, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.MSP, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.ORD, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.ORD, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.ORD, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.SEA, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.SEA, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAX, AirportEnum.SEA, (DayOfWeek)i, 21));

                // SEA
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.IAD, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.IAD, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.IAD, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.ORD, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.ORD, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.ORD, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.JFK, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.JFK, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.JFK, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.LAS, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.LAS, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.SEA, AirportEnum.LAS, (DayOfWeek)i, 21));

                // JFK
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.MSP, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.MSP, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.MSP, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.DFW, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.DFW, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.DFW, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.ORD, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.ORD, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.ORD, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.LAS, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.LAS, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.JFK, AirportEnum.LAS, (DayOfWeek)i, 21));
                    
                // ORD
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.SEA, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.SEA, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.SEA, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.LAS, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.LAS, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.LAS, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.IAD, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.IAD, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.IAD, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.BNA, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.BNA, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.ORD, AirportEnum.BNA, (DayOfWeek)i, 21));

                // MSP
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.TPA, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.TPA, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.TPA, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.DEN, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.DEN, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.DEN, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.JFK, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.JFK, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.JFK, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.LAX, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.LAX, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.MSP, AirportEnum.LAX, (DayOfWeek)i, 21));

                // DFW
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.BNA, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.BNA, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.BNA, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.ORD, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.ORD, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.ORD, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.LAS, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.LAS, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.LAS, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.SEA, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.SEA, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DFW, AirportEnum.SEA, (DayOfWeek)i, 21));

                // DEN
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.JFK, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.JFK, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.JFK, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.MSP, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.MSP, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.MSP, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.TPA, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.TPA, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.TPA, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.LAX, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.LAX, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DEN, AirportEnum.LAX, (DayOfWeek)i, 21));

                // LAS
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.IAD, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.IAD, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.IAD, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.DTW, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.DTW, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.DTW, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.BNA, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.BNA, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.BNA, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.ORD, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.ORD, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.LAS, AirportEnum.ORD, (DayOfWeek)i, 21));

                // DTW
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.SEA, (DayOfWeek)i, 8));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.SEA, (DayOfWeek)i, 13));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.SEA, (DayOfWeek)i, 18));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.TPA, (DayOfWeek)i, 9));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.TPA, (DayOfWeek)i, 14));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.TPA, (DayOfWeek)i, 19));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.IAD, (DayOfWeek)i, 10));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.IAD, (DayOfWeek)i, 15));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.IAD, (DayOfWeek)i, 20));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.JFK, (DayOfWeek)i, 11));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.JFK, (DayOfWeek)i, 16));
                ApplicationData.Connection.AddRoute(new Route(AirportEnum.DTW, AirportEnum.JFK, (DayOfWeek)i, 21));

            }

        }
    }
}
