// Practice Lesson 3 Task 1 FOR
Console.Write("Enter a number: ");
double num = double.Parse( Console.ReadLine() );

for (double i = num; i >= 0; i -= 0.25 ) 
{
    Console.WriteLine($"i = {i}");
}

// Result: 
// Enter a number: 4
// i = 4
// i = 3.75
// i = 3.5
// i = 3.25
// i = 3
// i = 2.75
// i = 2.5
// i = 2.25
// i = 2
// i = 1.75
// i = 1.5
// i = 1.25
// i = 1
// i = 0.75
// i = 0.5
// i = 0.25
// i = 0