using System;

namespace TicTacToe
{
    class Driver
    {
        static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("Welcome to the best Tic Tac Toe game ever!\n");

            // Simple instructions
            Console.WriteLine("Player 1 is X, Player 2 is O. Player 1 goes first.\n");

            // Instantiate board array
            string[] boardArray = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

            //initialize gameover flag
            bool gameOver = false;

            // instantiate display object
            Display d = new Display();

            // Start the game
            while (!gameOver)
            {
                // Display the current board
                Console.WriteLine("\n");
                d.printBoard(boardArray);
                Console.WriteLine("\n");

                int player1Choice = 0; //instantiate player 1 choice

                // Checks if data is valid for loop
                bool inputValid = false;

                // Prompt for player 1 choice
                Console.Write("\nPlayer 1 (X), select your square: ");

                // Loop until their input is valid
                while (!inputValid)
                {
                    // Catch errors if they occur in catch
                    try
                    {
                        // Grab player input and convert to int
                        player1Choice = Convert.ToInt32(Console.ReadLine());

                        // If player choice is not between 1 and 9 and has not already been selected
                        if (player1Choice >= 1 && player1Choice <= 9 && boardArray[player1Choice-1] != "X" && boardArray[player1Choice - 1] != "O")
                        {
                            // Input is valid
                            inputValid = true;
                        }

                        // Player choice is not valid, prompt user
                        else
                        {
                            Console.Write("\nInvalid input. Please choose a valid square: ");
                        }
                    }

                    // Error occured, prompt user for valid input
                    catch
                    {
                        Console.Write("\nInvalid input. Please choose a valid square: ");
                    }
                }

                // Update board with player 1 choice (always X)
                boardArray[player1Choice - 1] = "X";

                // Check for a winner
                string winner = d.printWinner(boardArray);

                // If there is a winner and it is player 1 (X)
                if (winner == "X")
                {
                    // Display the board
                    Console.WriteLine("\n");
                    d.printBoard(boardArray);
                    Console.WriteLine("\n");

                    // Congratulate user that won
                    Console.WriteLine("\nCongratulations, Player 1! You win!");
                    
                    // End the game (breaking loop)
                    gameOver = true;
                    break;
                }

                // If there is a winner and it is player 2 (O)
                else if (winner == "O")
                {
                    // Display the board
                    Console.WriteLine("\n");
                    d.printBoard(boardArray);
                    Console.WriteLine("\n");

                    // Congratulate user that won
                    Console.WriteLine("\nCongratulations, Player 2! You win!");

                    // End game (breaking loop)
                    gameOver = true;
                    break;
                }

                // If the game ended in a tie
                else if (winner == "C")
                {
                    // Display the board
                    Console.WriteLine("\n");
                    d.printBoard(boardArray);
                    Console.WriteLine("\n");

                    // Notify users of the tie
                    Console.WriteLine("\nCat's! It's a tie! Please play again.");

                    // End game (breaking loop)
                    gameOver = true;
                    break;
                }

                //nobody won and not a tie so continue playing (means "winner" must be "")

                Console.WriteLine("\n");
                d.printBoard(boardArray);//print the board
                Console.WriteLine("\n");

                int player2Choice = 0; //instantiate player 2 choice
                inputValid = false; //reset inputValid to false

                // Prompt player 2 for input
                Console.Write("\nPlayer 2 (O), select your square: ");

                //Loop until player 2 input is valid
                while (!inputValid)
                {
                    // Catch any errors
                    try
                    {
                        // Grab user input and convert to int
                        player2Choice = Convert.ToInt32(Console.ReadLine());

                        // If the choice was between 1 and 9 and has not already been selected, input is valid
                        if (player2Choice >= 1 && player2Choice <= 9 && boardArray[player2Choice - 1] != "X" && boardArray[player2Choice - 1] != "O")
                        {
                            inputValid = true;
                        }

                        // Input is not valid, prompt to enter again
                        else
                        {
                            Console.Write("\nInvalid input. Please choose a valid square: ");
                        }
                    }

                    // Catch error, prompt for valid input
                    catch
                    {
                        Console.Write("\nInvalid input. Please choose a valid square: ");
                    }
                }

                // Update board with player 2 choice (always O)
                boardArray[player2Choice - 1] = "O";

                //check for winner after player 2's turn
                winner = d.printWinner(boardArray);

                // If winner is player 1
                if (winner == "X")
                {
                    // Display the board
                    Console.WriteLine("\n");
                    d.printBoard(boardArray);
                    Console.WriteLine("\n");

                    // Congratulate player 1
                    Console.WriteLine("\nCongratulations, Player 1! You win!");

                    // End game
                    gameOver = true;
                }

                // If winner is player 2
                else if (winner == "O")
                {
                    // Display board
                    Console.WriteLine("\n");
                    d.printBoard(boardArray);
                    Console.WriteLine("\n");

                    // Congratulate player 2
                    Console.WriteLine("\nCongratulations, Player 2! You win!");

                    // End game
                    gameOver = true;
                }

                // Game ended in tie
                else if (winner == "C")
                {
                    // Display board
                    Console.WriteLine("\n");
                    d.printBoard(boardArray);
                    Console.WriteLine("\n");

                    // Notify users of tie
                    Console.WriteLine("\nCat's! It's a tie! Please play again.");

                    // End game
                    gameOver = true;
                }
            }

            // Game has ended, goodbye message
            Console.WriteLine("\n\nGame over! Thanks for playing.");
        }
    }
}
