// Practice Lesson 3 Task 3 IF and SWITCH
Console.Write("Enter a number in the range [1 - 19]: ");
int number = int.Parse( Console.ReadLine() );

switch ( number ) 
{        
    case  1 : Console.WriteLine("One");       break; 
    case  2 : Console.WriteLine("Two");       break;    
    case  3 : Console.WriteLine("Three");     break;
    case  4 : Console.WriteLine("Four");      break;
    case  5 : Console.WriteLine("Five");      break;
    case  6 : Console.WriteLine("Six");       break;
    case  7 : Console.WriteLine("Seven");     break;
    case  8 : Console.WriteLine("Eight");     break;
    case  9 : Console.WriteLine("Nine");      break;
    case 10 : Console.WriteLine("Ten");       break;
    case 11 : Console.WriteLine("Eleven");    break; 
    case 12 : Console.WriteLine("Twelve");    break;    
    case 13 : Console.WriteLine("Thirteen");  break;
    case 14 : Console.WriteLine("Fourteen");  break;
    case 15 : Console.WriteLine("Fifteen");   break;
    case 16 : Console.WriteLine("Sixteen");   break;
    case 17 : Console.WriteLine("Seventeen"); break;
    case 18 : Console.WriteLine("Eighteen");  break;
    case 19 : Console.WriteLine("Nineteen");  break;
    default : Console.WriteLine("The number is not in the range [1, 19]"); break;
}  

// Result: 
// Enter a number in the range [1 - 19]: 13
// Thirteen