using System;
					
public class Program
{
	public static void Main()
	{
		//User enters the Pyramid size
		Console.WriteLine("Enter the size of your pyramid: ");
		int Size = Convert.ToInt32(Console.ReadLine());
		int Num = 1;
		int count = 0;
		 do
		 { Console.WriteLine();
		  do
		  { Console.Write(Num);
		   count ++;
		  } while ( count < Num);
		  count = 0;
		  Num ++;
		 } while (Size >= Num);
		
		
	}
}