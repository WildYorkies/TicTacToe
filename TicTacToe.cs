using System;
					
public class Program
{
	static string gameBoard = "1|2|3\n-+-+-\n4|5|6\n-+-+-\n7|8|9";
	
	public static void Main()
	{
		
		bool loop = true;
		bool keepPlaying = false;
		
		Console.WriteLine(gameBoard);
		
		do
		{
			Console.WriteLine("Type a number to place an X");
			string userChoice = Console.ReadLine();
		
			for (int i=1; i==9; i++)
			{
				if (gameBoard.Contains(Convert.ToString(i)))
				{
					keepPlaying = true;
				}
			}
			
			GameBoardRefresh(userChoice);
			
		} while (keepPlaying == false);
		
	
	}
	
	public static void GameBoardRefresh(string userIn)
	{
		if (gameBoard.Contains(userIn))
		{
			gameBoard = gameBoard.Replace(userIn, "X"); //[index] = "X";
		}
		
		Console.WriteLine(gameBoard);
	}
}
