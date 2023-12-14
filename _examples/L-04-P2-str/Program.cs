// Practice Lesson 4 Symbolic Arrays Practice Task 2
Console.Write("Enter a symbol string s = ");
string s = Console.ReadLine(), s2 = "";

int len   = s.Length;


for( int i = len - 1; i >=0; i-- )
{
    s2 += s[i];
}

Console.WriteLine($"The string - {s} - turned into - {s2} - reversed");

// Result : 
// Enter a symbol string s = hold my beer
// The string - hold my beer - turned into - reeb ym dloh - reversed