// Practice Lesson 2 Task 7
Console.Write("Enter angle in Degrees = ");
int degrees = int.Parse( Console.ReadLine() );

double radians = degrees * (Math.PI / 180.0);
double sine    = Math.Sin(radians);
Console.WriteLine($"sin({degrees}) = {sine}");

// Result:
// Enter angle in Degrees = 90
// sin(90) = 1