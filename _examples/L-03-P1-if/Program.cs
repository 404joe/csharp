// Practice Lesson 3 Task 1 IF and SWITCH
Console.Write("Enter a number: ");
int number = int.Parse( Console.ReadLine() );

if (number %2 == 0)
{
    Console.WriteLine($"The number {number} is even");
} 
else 
{
    Console.WriteLine($"The number {number} is odd");
}

// Result:
// Enter a number: 42
// The number 42 is even