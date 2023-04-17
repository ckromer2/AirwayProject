﻿//A simple class to handle the printing of a database object to strings for the UI
//By: Spencer Lowery
//Created: 04/11/23
//Updated: 04/15/23

namespace GROUP9Project.DataBase;

public static class PrintFunctions
{
    public static string PrintFlightInfo(BookingRecord Record)
    {
        Flight pFlight = ApplicationData.Connection.GetFlight(Record.FlightId);
        Route pRoute = ApplicationData.Connection.GetRoute(pFlight.RouteId);

        string Output = Record.FlightId.ToString() + ": " + PlanesAirportsDistances.AirportsCode.ElementAt((int)pRoute.Start) + 
            " to " + PlanesAirportsDistances.AirportsCode.ElementAt((int)pRoute.End) + " Leaving at " + pFlight.FlightDate.ToString();

        return Output;
    }

    public static string PrintRoute(Route pRoute)
    {
        string output = PlanesAirportsDistances.AirportsCode.ElementAt((int)pRoute.Start) + " -> " + PlanesAirportsDistances.AirportsCode.ElementAt((int)pRoute.End);
        return output;
    }

    internal static object PrintRouteDual(Route pDRoute, Route pARoute)
    {
        string output = PlanesAirportsDistances.AirportsCode.ElementAt((int)pDRoute.Start) + " -> " + PlanesAirportsDistances.AirportsCode.ElementAt((int)pDRoute.End) 
            + " -> " + PlanesAirportsDistances.AirportsCode.ElementAt((int)pARoute.Start);
        return output;
    }
}
