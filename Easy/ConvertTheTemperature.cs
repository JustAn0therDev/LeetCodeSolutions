namespace Easy;

public class ConvertTheTemperature
{
    public double[] Solve(double celsius)
    {
        return new [] { celsius + 273.15, celsius * 1.80 + 32 };
    }
}