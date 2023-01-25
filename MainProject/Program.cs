using Easy;

int[] nums = {1,15,6,3};

ParkingSystem ps = new(1, 1, 0);

Console.WriteLine(ps.AddCar(1));
Console.WriteLine(ps.AddCar(2));
Console.WriteLine(ps.AddCar(3));
Console.WriteLine(ps.AddCar(1));
