// Practice Lesson 2 Task 3
Console.Write("Enter a = ");
double a = double.Parse( Console.ReadLine() );

Console.Write("Enter the height to the side a: ha = ");
double ha = double.Parse( Console.ReadLine() );

Console.Write("Enter b = ");
double b = double.Parse( Console.ReadLine() );

Console.Write("Enter c = ");
double c = double.Parse( Console.ReadLine() );

double p = a + b + c;

Console.WriteLine($" Perimeter is P = a + b + c = {p}" );
Console.WriteLine($" The area is S = a * ha / 2 = {a*ha/2}" );

p = p / 2;
Console.WriteLine($" The area by Heron S = {Math.Sqrt(p*(p-a)*(p-b)*(p-c))}" );

// Result : 
// Enter a = 3
// Enter the height to the side a: ha = 4
// Enter b = 4
// Enter c = 5
//  Perimeter is P = a + b + c = 12
//  The area is S = a * ha / 2 = 6
//  The area by Heron S = 6
