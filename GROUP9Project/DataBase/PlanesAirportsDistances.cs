namespace GROUP9Project.DataBase;

//Used to make sure the lists dont overrun the buffer size.
public enum AirportEnum 
{
    CLE = 0,
    BNA = 1,
    TPA = 2,
    IAD = 3,
    LAX = 4,
    SEA = 5,
    JFK = 6,
    ORD = 7,
    MSP = 8,
    DFW = 9,
    DEN = 10,
    LAS = 11,
    DTW = 12
}

public enum PlaneEnum 
{ 
    B737 = 0,
    B787 = 1,
    B777 = 2
}


public class Airport
{
    public string AirportName { get; private set; }
    public string AirportCode { get; private set; }

    public Airport(string aName, string aCode)
    {
        AirportName = aName;
        AirportCode = aCode;
    }
}

public class Plane
{
    public string PlaneName { get; private set; }
    public int Capacity { get; private set; }

    public Plane(string PName, int Cap)
    {
        PlaneName = PName;
        Capacity = Cap;
    }

}

public static class PlanesAirportsDistances
{
    public static readonly List<Airport> Airports = new List<Airport> 
    {  
        new Airport("Cleveland Hopkins International Airport", "CLE"),
        new Airport("Nashville International Airport", "BNA"),
        new Airport("Tampa International Airport", "TPA"),
        new Airport("Washington Dulles Intl airport", "IAD"),
        new Airport("Los Angeles International Airport", "LAX"),
        new Airport("Seattle-Tacoma International Airport", "SEA"),
        new Airport("John F. Kennedy International Airport", "JFK"),
        new Airport("Chicago O'Hare International Airport", "ORD"),
        new Airport("Minneapolis−Saint Paul International Airport", "MSP"),
        new Airport("Dallas Fort Worth International Airport", "DFW"),
        new Airport("Denver International Airport", "DEN"),
        new Airport("Las Vegas International Airport", "LAS"),
        new Airport("Detroit Metropolitan Wayne County Airport", "DTW")
    };

    public static List<Plane> Planes = new List<Plane> 
    {  
        new Plane("Boeing 737", 186),
        new Plane("Boeing 787", 351),
        new Plane("Boeing 777", 513)
    };
    public static List<List<float>> Distances = new List<List<float>> 
    {   
        new List<float> { 0, 447.69f, 928.5f, 287.35f, 2049, 2016, 424, 315, 621, 1021, 1198, 1821, 96 },
        new List<float> { 447.69f, 0, 613, 541.29f, 1794, 1974, 765, 410, 696, 631, 1012, 1584, 457 },
        new List<float> { 928.5f, 613, 0, 812.43f, 2154, 2518, 1007, 1014, 1308, 928, 1506, 1981, 985 },
        new List<float> { 287.35f, 541.29f , 812.43f, 0, 2282.91f, 2300, 228, 588, 907, 1170, 1449, 2061, 383 },
        new List<float> { 2049, 1794 , 2154, 2282.91f, 0, 954.98f, 2470, 1742, 1534, 1233, 861, 237, 1975 },
        new List<float> { 2016, 1974, 2518, 2300, 954.98f, 0, 2415.04f, 1717, 1395, 1658, 1023, 867, 1922 },
        new List<float> { 424, 765, 1007, 228, 2470, 2415.04f, 0, 738.33f, 1027, 1389, 1622, 2263, 508 },
        new List<float> { 315, 410, 1014, 588, 1742, 1717, 738.33f, 0, 333.56f, 802, 887, 1511, 234 },
        new List<float> { 621, 696, 1308, 907, 1534, 1395, 1027, 333.56f, 0, 852.89f, 679.18f, 1298, 528 },
        new List<float> { 1021, 631, 928, 1170, 1233, 1658, 1389, 802, 852.89f, 0, 640.93f, 1054, 986 },
        new List<float> { 1198, 1012, 1506, 1449, 861, 1023, 1622, 887, 679.18f, 640.93f, 0, 626.85f, 1120.5f },
        new List<float> { 1821, 1584, 1981, 2061, 237, 867, 2263, 1511, 1298, 1054, 626.85f, 0, 1745.17f },
        new List<float> { 96, 457, 985, 383, 1975, 1922, 508, 234, 528, 986, 1120.5f, 1745.17f, 0 }
    };
}