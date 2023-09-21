using System;
					
public class Program
{
	public static void Main()
	{
		//Program Picks Random Number 1-10
		Random rnd = new Random();
		int Ans = rnd.Next(10);
		int Gs;
		
		//Player gets to guess
		do
		{ Console.WriteLine("What is your guess 1-10? ");
		 Gs = Convert.ToInt32(Console.ReadLine());
		 if (Gs > Ans)
			 Console.WriteLine("Too High!");
		 else if (Gs < Ans)
			 Console.WriteLine("Too Low!");
		} while (Gs != Ans);
		Console.WriteLine("You Win!!");
		
		
		 
		
		
		
	}
}