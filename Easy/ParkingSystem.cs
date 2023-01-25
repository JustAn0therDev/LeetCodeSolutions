using System.Runtime.InteropServices.JavaScript;

namespace Easy;

public class ParkingSystem {

    enum ParkingSpotType
    {
        Big = 1, Medium = 2, Small = 3
    }
    
    private int Big { get; set; }
    private int Medium { get; set; }
    private int Small { get; set; }

    public ParkingSystem(int big, int medium, int small)
    {
        Big = big;
        Medium = medium;
        Small = small;
    }
    
    public bool AddCar(int carType)
    {
        ParkingSpotType requestSpotType = (ParkingSpotType)carType;

        if (requestSpotType == ParkingSpotType.Small && Small > 0)
        {
            Small--;
            return true;
        }

        if (requestSpotType == ParkingSpotType.Medium && Medium > 0)
        {
            Medium--;
            return true;
        }

        if (requestSpotType == ParkingSpotType.Big && Big > 0)
        {
            Big--;
            return true;
        }

        return false;
    }
}