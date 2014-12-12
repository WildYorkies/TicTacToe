using System;
					
public class Program
{
	
	static string gameBoard = "1|2|3\n-+-+-\n4|5|6\n-+-+-\n7|8|9";
	
	public static void Main()
	{
		
		bool keepPlaying = false;
		
		do
		{
			Console.WriteLine(gameBoard);
			Console.WriteLine("Type a number to place an X");
			string userChoice = Console.ReadLine();
			
			GameBoardRefresh(userChoice); // Rewrite this to make gameBoard an object & have "Refresh" be a behavior?
		
			// Checks to see if there are still numbers in the board
			// Why won't this work correctly?
			for (int i=1; i==9; i++)
			{
				if (gameBoard.Contains(Convert.ToString(i)))
				{
					keepPlaying = true;
					break;
				}
				else 
				{
					keepPlaying = false;
				}
			}
		} while (keepPlaying == false);
		
		Console.WriteLine("Good job!");
	}
	
	public static void GameBoardRefresh(string userIn)
	{
		if (gameBoard.Contains(userIn))
		{
			gameBoard = gameBoard.Replace(userIn, "X");
		}		
	}
	
}
