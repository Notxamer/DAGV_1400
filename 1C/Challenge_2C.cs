using System;
					
public class Program
{
	public static void Main()
	{
		//User enters his/hers favorite food
		Console.WriteLine("Enter your three favorite foods");
		string[] Foods = {"", "", ""};
		int Num = 0;
		do
		{
		 Foods[Num] = Console.ReadLine();
			Num ++;
		} while (Num <= 2);
		
		//Outputs users anwers with add line
		Console.WriteLine(Foods[0] + " is delicious!");
		Console.WriteLine("I love myself some " + Foods[1] + "!");
		Console.WriteLine(Foods[2] + " is my favorite!");
		
		
		
		 
		
		
		
	}
}