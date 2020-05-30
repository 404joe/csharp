public class Program
{

    public static int SumR(int n)
    {
        if (n == 1) // ако n стигнало до 1, се прекратява 
        {           // изпълнението; условие за изход
            return 1;
        }
        else // ако n > 1, се връща текущата 
        {    // стойност на n + SumR(n - 1);
            return n + SumR(n - 1);
        }
    }
    
    public static int SumF(int n)
    {
        int sum = 0;
        for (int i = n; i >= 1; i--)
        {
            sum += i; // еквивалентно на sum = sum + i: добавяме i към sum
        }
        return sum;
    }

    public static void Main()
    {
        // Употреба на рекурсивна функция :
        int result = SumR(100);
        Console.WriteLine($"Recursive : {result}"); // Резултат: 5050
        
        // Употреба на for версията /без рекурсия/:
        result = SumF(100);
        Console.WriteLine($"For       : {result}"); // Резултат: 5050        
    }
}