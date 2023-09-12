using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
Console.WriteLine("Enter First Value to Multiply: ");
string val = Console.ReadLine();
int x;
x = Convert.ToInt32(val);

Console.WriteLine("Enter Second Value to Multiply: ");
string val2 = Console.ReadLine();
int y;
y = Convert.ToInt32(val2);
Console.WriteLine(x*y);

     }
  }
}