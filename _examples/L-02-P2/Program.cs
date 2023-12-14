// Practice Lesson 2 Task 2

Console.Write("Enter temperature in Celsius T(c) = ");

double tc = double.Parse( Console.ReadLine() );
double tf = tc * 1.8 + 32;

Console.WriteLine($" {tc} degrees in Celsius equals {tf} degrees in Farenheit");

// Result : 
// Enter temperature in Celsius T(c) = 25
// 25 degrees in Celsius equals 77 degrees in Farenheit