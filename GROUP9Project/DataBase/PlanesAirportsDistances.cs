using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GROUP9Project.DataBase;

public struct Airport
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

public class PlanesAirportsDistances
{
    public List<Airport> Airports { get; private set; }
    public List<Plane> Planes { get; private set; }
    public List<(int Start, int Destination)> Distances { get; private set; }

    public PlanesAirportsDistances() 
    {
        //Constructs the list of Planes
        Planes = new List<Plane>();
        Planes.Add(new Plane("", 0));
        //Constructs the list of Airports
        Airports = new List<Airport>();
        Airports.Add(new Airport("",""));
        //Constructs the distanst graph
        Distances = new List<(int Start, int Destination)>{ { }, { }, { } };
    }

}