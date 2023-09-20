using System;
					
public class Program
{
	public static void Main()
	{
		//User enters the Temperature
		Console.WriteLine("What is the Temp. is it in Celcius outside?");
		int Temp = Convert.ToInt32(Console.ReadLine());
		
		//If its above 30 it writes this message
		if (Temp>30) 
		{ Console.WriteLine("Stay hydrated and try to avoid the sun");
		//If its below 30 it writes this message
		} else
		{ Console.WriteLine("Enjoy the weather!");
		}
		//User enters their grade
		Console.WriteLine("What is your grade percentage?");
		int Grade = Convert.ToInt32(Console.ReadLine());
		if (Grade>89) 
		{ Console.WriteLine("You have an A!");
		 
		 //Checks thier percentage and grades accordingly
			} else if (Grade>79) 
		{ Console.WriteLine("You got a B!");
		} else if (Grade>69) 
		{ Console.WriteLine("You have a C :|");
		} else if (Grade>59) 
		{ Console.WriteLine("a D :(");
		} else 
		{ Console.WriteLine("You are failing!!!!");
		}
			
	}
}