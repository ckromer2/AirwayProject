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
    private PlaneEnum planeId;
    public PlaneEnum PlaneId 
    {
        get { return planeId; }
        set
        {
            planeId = value;
            if ((int)planeId >= 0)
                TotalCapacity = PlanesAirportsDistances.Planes[(int)planeId].Capacity;
            else
                TotalCapacity = 0;
        }
    }
    public int RouteId { get; set; }
    public DateTime FlightDate { get; set; }
    public int CurrentCapacity { get; set; }
    public int TotalCapacity { get; set; }

    public Flight()
    {
        PlaneId = PlaneEnum.UNSET;
        RouteId = 0;
        FlightDate = DateTime.MinValue;
        CurrentCapacity = 0;
        if((int)PlaneId>=0)
            TotalCapacity = PlanesAirportsDistances.Planes[(int)PlaneId].Capacity; 
        else
            TotalCapacity = 0;
    }

    public Flight(PlaneEnum pId, int rId, DateTime fDate)
    {
        PlaneId = pId;
        RouteId = rId;
        FlightDate = fDate;
        CurrentCapacity = 0;
        if ((int)PlaneId >= 0)
            TotalCapacity = PlanesAirportsDistances.Planes[(int)PlaneId].Capacity;
        else
            TotalCapacity = 0;
    }

    public void ChangePlane(PlaneEnum pId) { PlaneId = pId; }


}

