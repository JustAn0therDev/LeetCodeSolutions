namespace Easy;

public class SubtractProductAndSum
{
    public int Solve(int n) {
        int multiply = 1;
        int sum = 0;
        string digits = n.ToString();

        foreach (char digit in digits)
        {
            multiply *= (int)char.GetNumericValue(digit);
            sum += (int)char.GetNumericValue(digit);
        }
        
        return multiply - sum;
    }
}