using SQLite;
using System.Runtime.CompilerServices;

namespace GROUP9Project.DataBase;

public class Plane 
{
    //Defines the collums of the tables.
    [PrimaryKey, AutoIncrement]
    public int PlaneId { get; set; }//Generic Id of this plane
    public string PlaneName { get; set; }
    public int Capacity { get; set; }


}

public class Flights
{ 
    

}

