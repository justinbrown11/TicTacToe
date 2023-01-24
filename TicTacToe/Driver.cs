using System;

namespace TicTacToe
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the best Tic Tac Toe game ever!");
            Console.WriteLine("Player 1 is X, Player 2 is O. Player 1 goes first.");

            //create array
            string[] boardArray = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            //initialize flag
            bool gameOver = false;

            //call the "display" class + instantiate object
            Display d = new Display();

            while (!gameOver) // same as (gameOver == false);
            {
                //logic for the game
                
                //call print board to display
                d.printBoard(boardArray);

                int player1Choice = 0; //instantiate choice

                //collect inputs and validate data
                bool inputValid = false;

                Console.Write("Player 1, select your square: ");

                while (!inputValid) //same as == false
                {
                    try //use this in case they enter an invalid input
                    {
                        player1Choice = Convert.ToInt32(Console.ReadLine());

                        if (player1Choice >= 1 && player1Choice <= 9 && boardArray[player1Choice-1] != "X" && boardArray[player1Choice - 1] != "O")
                        {
                            inputValid = true;
                        }
                        else
                        {
                            Console.Write("Invalid input. Please choose a valid square.");
                        }
                    }
                    catch
                    {
                        Console.Write("Invalid input. Please choose a valid square.");
                    }
                }
                //input is valid, update array with X or O for player 1
                boardArray[player1Choice - 1] = "X";

                //check for a winner
                string winner = d.printWinner(boardArray);

                if (winner == "X")
                {
                    d.printBoard(boardArray);
                    Console.Write("Congratulations, Player 1! You win!");
                    gameOver = true;
                    break;
                }
                else if (winner == "O")
                {
                    d.printBoard(boardArray);
                    Console.Write("Congratulations, Player 2! You win!");
                    gameOver = true;
                    break;
                }
                else if (winner == "C")
                {
                    d.printBoard(boardArray);
                    Console.Write("Cat's! It's a tie! Please play again.");
                    gameOver = true;
                    break;
                }

                //nobody won and not a tie so continue playing (means "winner" must be "")
                d.printBoard(boardArray);//print the board
                int player2Choice = 0; //instantiate choice
                inputValid = false; //reset inputValid to false
                //player 2's turn
                while (!inputValid) //same as == false
                {
                    try //use this in case they enter an invalid input
                    {
                        player2Choice = Convert.ToInt32(Console.ReadLine());

                        if (player2Choice >= 1 && player2Choice <= 9 && boardArray[player2Choice - 1] != "X" && boardArray[player2Choice - 1] != "O")
                        {
                            inputValid = true;
                        }
                        else
                        {
                            Console.Write("Invalid input. Please choose a valid square.");
                        }
                    }
                    catch
                    {
                        Console.Write("Invalid input. Please choose a valid square.");
                    }
                }
                //input is valid, update array with X or O for player 1
                boardArray[player2Choice - 1] = "O";

                //check for winner after player 2's turn (which returns a boolean and who)
                winner = d.printWinner(boardArray);

                if (winner == "X")
                {
                    d.printBoard(boardArray);
                    Console.Write("Congratulations, Player 1! You win!");
                    gameOver = true;
                }
                else if (winner == "O")
                {
                    d.printBoard(boardArray);
                    Console.Write("Congratulations, Player 2! You win!");
                    gameOver = true;
                }
                else if (winner == "C")
                {
                    d.printBoard(boardArray);
                    Console.Write("Cat's! It's a tie! Please play again.");
                    gameOver = true;
                }
                //nobody won and not a tie so continue playing (means "winner" must be "")
            }
            Console.WriteLine("Game over, thanks for playing.");
        }
    }
}
