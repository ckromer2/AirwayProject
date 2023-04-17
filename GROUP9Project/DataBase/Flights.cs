using SQLite;
using System.DirectoryServices.ActiveDirectory;

namespace GROUP9Project.DataBase;

public class Route
{
    [PrimaryKey, AutoIncrement]
    public int RouteId { get; private set; }
    public AirportEnum Start { get; private set; }
    public AirportEnum End { get; private set; }
    public DayOfWeek ScheduleDate { get; private set; }
    public int SchedualTime { get; private set; }

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
    public int FlightId { get; private set; }
    public PlaneEnum PlainId { get; private set; }
    public int RouteId { get; private set; }
    public DateTime FlightDate { get; private set; }

    public Flight()
    {
        PlainId = 0;
        RouteId = 0;
        FlightDate = DateTime.MinValue;
    }

    public Flight(PlaneEnum pId, int rId, DateTime fDate)
    {
        PlainId = pId;
        RouteId = rId;
        FlightDate = fDate;
    }

    public void ChangePlane(PlaneEnum pId) { PlainId = pId; }


}

