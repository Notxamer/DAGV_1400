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
		{ Console.WriteLine("Stay hydrated and enjoy the warm weather!");
		//If its below 30 it writes this message
		} else if (Temp>19)
		{ Console.WriteLine("Maybe wear a bit warmer clothing and enjoy!");
		}else if (Temp>9)
		{ Console.WriteLine("Beware its getting cold! Wear a jacket!");
		}else if (Temp>0)
		{ Console.WriteLine("Its very Cold! Wear a jacket or a sweater!");
		}else 
		{ Console.WriteLine("Its freezing! Wear warm winter cloths!!");
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
			Console.WriteLine("Which is your Favorite Subject: 1:Math 2:Science 3:English 4:PE 5:History 6:Art 7:Music");
		int Sub = Convert.ToInt32(Console.ReadLine());
		switch (Sub)
		{ case 1:
		 Console.WriteLine("Keep on solving those problems!");
		 break;
		 case 2:
		 Console.WriteLine("Awsome! If you keep on this path you could be a scientist!");
		 break;
		 case 3:
		 Console.WriteLine("Cool! If you love english you should try writing stories");
		 break;
		 case 4:
		 Console.WriteLine("Sweet! You could train to make you self even better!");
		 break;
		 case 5:
		 Console.WriteLine("Interesting! You can research many things and discover amazing things about history!");
		 break;
		 case 6:
		 Console.WriteLine("Art is super creative! Keep practicing!");
		 break;
		 case 7:
		 Console.WriteLine("Music is soo nice! There are so many different types and feilds");
		 break;
		 default:
		 Console.WriteLine("That wasn't an option!!");
		 break;
		}
	}
}