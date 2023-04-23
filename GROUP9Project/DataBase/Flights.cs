using SQLite;
using System.DirectoryServices.ActiveDirectory;

namespace GROUP9Project.DataBase;

public class Route
{
    [PrimaryKey, AutoIncrement]
    public int RouteId { get; set; }
    public AirportEnum Start { get; set; }
    public AirportEnum End { get; set; }
    public DayOfWeek ScheduleDate { get; set; }
    public int SchedualTime { get; set; }

    public Route() 
    {
        Start = 0;
        End = 0;
        ScheduleDate = 0;
        SchedualTime = 0;
    }

    public Route(AirportEnum s, AirportEnum e, DayOfWeek sDay, int sTime)
    { 
        Start = s;
        End = e;
        ScheduleDate = sDay;
        SchedualTime = sTime;
    }


}

public class Flight
{
    [PrimaryKey, AutoIncrement]
    public int FlightId { get; set; }
    public PlaneEnum PlainId { get; set; }
    public int RouteId { get; set; }
    public DateTime FlightDate { get; set; }
    public int currentCapacity { get; set; }
    public int totalCapacity; 

    public Flight()
    {
        PlainId = 0;
        RouteId = 0;
        FlightDate = DateTime.MinValue;
        currentCapacity = 0; 
        totalCapacity = PlanesAirportsDistances.Planes[(int)PlainId].Capacity; 
    }

    public Flight(PlaneEnum pId, int rId, DateTime fDate)
    {
        PlainId = pId;
        RouteId = rId;
        FlightDate = fDate;
        currentCapacity = 0;
        totalCapacity = PlanesAirportsDistances.Planes[(int)PlainId].Capacity;
    }

    public void ChangePlane(PlaneEnum pId) { PlainId = pId; }


}

