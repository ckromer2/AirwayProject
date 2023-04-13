//A simple class to handle the printing of a database object to strings for the UI
//By: Spencer Lowery
//Created: 04/11/23
//Updated: 04/11/23

namespace GROUP9Project.DataBase;

public static class PrintFunctions
{
    public static string PrintFlightInfo(BookingRecord Record)
    {
        Flight rFlight = ApplicationData.Connection.GetFlight(Record.FlightId);
        Route pRoute = ApplicationData.Connection.GetRoute(rFlight.RouteId);

        string Output = Record.FlightId.ToString() + ": " + PlanesAirportsDistances.Airports.ElementAt((int)pRoute.Start) + 
            " to " + PlanesAirportsDistances.Airports.ElementAt((int)pRoute.End) + " Leaving at " + rFlight.FlightDate.ToString();

        return Output;
    }

}
