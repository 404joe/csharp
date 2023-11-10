// Practice Symbolic Arrays Task 1
Console.WriteLine("Enter a symbol string s = ");
string s = Console.ReadLine();

Console.WriteLine("Ente a single character ch = ");
char ch = char.Parse(Console.ReadLine());

int count = 0;
int len   = s.Length;

for( int i = 0; i < len; i++ )
{
    if( ch==s[i] )
    {
        count++;
    }
}

Console.WriteLine($"The character {ch} has {count} occurrences");

// Input    s  : dxqeqdlmkqpwqopk
//          ch : q
// Result : The character q has 4 occurrences