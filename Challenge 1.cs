uusing System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        String Name = "Me";
        double two = 2.2;
        bool TruFal = true;
Console.WriteLine("Enter First Value to use: ");
string val = Console.ReadLine();

int x;
x = Convert.ToInt32(val);

Console.WriteLine("Enter Second Value to use: ");
string val2 = Console.ReadLine();
int y;
y = Convert.ToInt32(val2);
Console.WriteLine("Multiplied: " + x*y);
Console.WriteLine("Divided: " + x/y);
Console.WriteLine("Added: " + x+y);
Console.WriteLine("Remainder: " + x % y);
     }
  }
}