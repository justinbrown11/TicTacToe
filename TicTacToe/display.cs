﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Display
    {
        public void printBoard(string[] board)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + board[0] + "  |  " + board[1] + "  |  " + board[2] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + board[3] + "  |  " + board[4] + "  |  " + board[5] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + board[6] + "  |  " + board[7] + "  |  " + board[8] + "  ");
            Console.WriteLine("     |     |     ");
            printWinner(board);
        }
        public void printWinner(string[] board)
        {
            string placeHolder = "";
            for (int i = 0; i < 9; i++)
            {
                placeHolder += board[i];
            }


            //Horizontal
            if ((board[0] == board[1]) && (board[1] == board[2]))
            {
                if (board[0] == "X")
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                }

            }
            else if ((board[3] == board[4]) && (board[4] == board[5]))
            {
                if (board[0] == "X")
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                }

            }
            else if ((board[6] == board[7]) && (board[7] == board[8]))
            {
                if (board[0] == "X")
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                }

            }
            //Vertical
            else if ((board[0] == board[3]) && (board[3] == board[6]))
            {
                if (board[0] == "X")
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                }

            }
            else if ((board[1] == board[4]) && (board[4] == board[7]))
            {
                if (board[0] == "X")
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                }

            }
            else if ((board[2] == board[5]) && (board[5] == board[8]))
            {
                if (board[0] == "X")
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                }

            }
            //Diagonal
            else if ((board[0] == board[4]) && (board[4] == board[8]))
            {
                if (board[0] == "X")
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                }

            }
            else if ((board[2] == board[4]) && (board[4] == board[6]))
            {
                if (board[0] == "X")
                {
                    Console.WriteLine("X"); //"X"
                }
                else
                {
                    Console.WriteLine("O"); //"O"
                }
            }
            //No winner
            //else if ((board[0] == "X" || board[0] == "O") &&
            //       (board[0] == "X" || board[0] == "O")
            //  )
            //int i = Array.IndexOf(board, "X");

            //else if (xyz.Contains("X"))
            //{
            //     Console.WriteLine("No Winner");//"C"
            //}
            else if (
                placeHolder.Contains("1") ||
                placeHolder.Contains("2") ||
                placeHolder.Contains("3") ||
                placeHolder.Contains("4") ||
                placeHolder.Contains("5") ||
                placeHolder.Contains("6") ||
                placeHolder.Contains("7") ||
                placeHolder.Contains("8") ||
                placeHolder.Contains("9"))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("C");
            }
        }
    }
}

