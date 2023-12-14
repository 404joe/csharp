// Practice Lesson 4 Task 1

int[] myArray = new int[10];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Enter element[{i}]=");
    myArray[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"element[{i}]={myArray[i]}");
}

// Result
// Enter element[0]= 12
// Enter element[1]= 45
// Enter element[2]= 21
// Enter element[3]= 33
// Enter element[4]= 42
// Enter element[5]= 10
// Enter element[6]= 18
// Enter element[7]= 72
// Enter element[8]= 23
// Enter element[9]= 17
// element[0]=12
// element[1]=45
// element[2]=21
// element[3]=33
// element[4]=42
// element[5]=10
// element[6]=18
// element[7]=72
// element[8]=23
// element[9]=17
