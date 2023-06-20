public class Program
{

    public static int SumR(int n)
    {
        if (n == 1) // if n reaches 1, it terminates
        {           // the execution; /exit condition/
            return 1;
        }
        else // if n > 1, the current value  
        {    // of n + SumR(n - 1); is returned
            return n + SumR(n - 1);
        }
    }
    
    public static int SumF(int n)
    {
        int sum = 0;
        for (int i = n; i >= 1; i--)
        {
            sum += i; // equivalent to sum = sum + i: we add i to sum
        }
        return sum;
    }

    public static void Main()
    {
        // Usage of recursive function: 
        int result = SumR(100);
        Console.WriteLine($"Recursive : {result}"); // Result: 5050
        
        // Usage of the FOR version, /non recursive/:
        result = SumF(100);
        Console.WriteLine($"For       : {result}"); // Result: 5050        
    }
}