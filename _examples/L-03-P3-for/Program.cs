// Practice Lesson 3 Task 3 FOR
Console.Write("Enter a = ");
int a = int.Parse( Console.ReadLine() );

Console.Write("Enter b = ");
int b = int.Parse( Console.ReadLine() );

int sum = 0;

for (int i = b; i >= 1; i -- ) 
{
    sum += a;
}

Console.WriteLine( $"a * b = {a} * {b} = {sum}" );

// Result: 
// Enter a = 3
// Enter b = 4
// a * b = 3 * 4 = 12
