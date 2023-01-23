using System;

namespace TicTacToe
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the best Tic Tac Toe game ever!");
            Console.WriteLine("Player 1 is X, Player 2 is O. Player 1 goes first.");
            //call "driver here"
            string[] boardArray = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            //initialize flag
            bool gameOver = false;

            while (!gameOver) // same as (gameOver == false);
            {
                //logic for the game
                //call the "display" class + instantiate object
                Display d = new Display();
                //call print board to display
                d.printBoard();
                //collect inputs
                Console.Write("Player 1, select your square: ");
                string player1Choice = (string)Console.ReadLine();

                Console.Write("Player 2, select your square: ");
                string player2Choice = (string)Console.ReadLine();

            }
        }
    }
}
