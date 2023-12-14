// Practice Lesson 4 Task 1

int[] numbers = {21, 53, 13, 14, 45, 12, 43, 32, 48, 22};

int evenIdx = -1;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0 )
    {
          evenIdx = i;
          break;
      
    }
    
}

Console.WriteLine($"the  Index of First Even element is : {evenIdx} ");

// Result
// the  Index of First Even element is : 3
