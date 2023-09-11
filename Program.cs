using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
//First and Last Names ar 2 seperate strings
string FirstName = "John";
string LastName = "Doe" ;
//Conbines First and Last Name
Console.WriteLine(FirstName + " " + LastName);
// Writes guess age and the user guesses
Console.WriteLine("Guess age 1-40: ");
string val = Console.ReadLine();
int age;
age = Convert.ToInt32(val);
//Writes guessed age and if it is true or false
Console.WriteLine("Age: " + age); 
bool TF = age == 32;
Console.WriteLine(TF); 
     }
  }
}