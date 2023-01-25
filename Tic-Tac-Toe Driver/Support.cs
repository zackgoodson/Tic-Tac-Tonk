using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission3
{
    public class Support
    {
        //Printing the board 
        public static void printBoard(char[] board)
        {
            //Printing the board that we receive
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine("-----");
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine("-----");
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }

        // Method that will check for winner
        public static int getWin(char[] board)
        {
            int flag = 0;

            //Checking row 1 for winner
            if ((board[0] == board[1]) && (board[1] == board[2]))
            {
                //check if winner is "X"
                if (board[0] == 'X')
                {
                    //print out who won
                    Console.WriteLine("Player 1 has won");

                    //indicate that there is a winner to communicate with main class
                    flag = 1;
                }

                //check if winner is "O"
                else if (board[0] == 'O')
                {
                    //print out who won
                    Console.WriteLine("Player 2 has won");

                    //indicate that there is a winner
                    flag = 1;
                }
            }

            //Checking for row 2 winner
            else if ((board[3] == board[4]) && (board[4] == board[5]))
            {
                //check if winner is "X"
                if (board[3] == 'X')
                {
                    //print winner
                    Console.WriteLine("Player 1 has won");

                    //indicate that there is a winner
                    flag = 1;
                }

                //check if winner is "O"
                else if (board[3] == 'O')
                {
                    //print winner
                    Console.WriteLine("Player 2 has won");

                    //indicate that there is a winner
                    flag = 1;
                }
            }

            //Checking row 3 for winner
            else if ((board[6] == board[7]) && (board[7] == board[8]))
            {
                //check if winner is "X"
                if (board[6] == 'X')
                {
                    //print out who won
                    Console.WriteLine("Player 1 has won");

                    //indicate that there is a winner to communicate with main class
                    flag = 1;
                }

                //check if winner is "O"
                else if (board[6] == 'O')
                {
                    //print out who won
                    Console.WriteLine("Player 2 has won");

                    //indicate that there is a winner
                    flag = 1;
                }
            }

            //Checking column 1 for winner
            else if ((board[0] == board[3]) && (board[3] == board[6]))
            {
                //check if winner is "X"
                if (board[0] == 'X')
                {
                    //print out who won
                    Console.WriteLine("Player 1 has won");

                    //indicate that there is a winner to communicate with main class
                    flag = 1;
                }

                //check if winner is "O"
                else if (board[0] == 'O')
                {
                    //print out who won
                    Console.WriteLine("Player 2 has won");

                    //indicate that there is a winner
                    flag = 1;
                }
            }

            //Checking column 2 for winner
            else if ((board[1] == board[4]) && (board[4] == board[7]))
            {
                //check if winner is "X"
                if (board[1] == 'X')
                {
                    //print out who won
                    Console.WriteLine("Player 1 has won");

                    //indicate that there is a winner to communicate with main class
                    flag = 1;
                }

                //check if winner is "O"
                else if (board[1] == 'O')
                {
                    //print out who won
                    Console.WriteLine("Player 2 has won");

                    //indicate that there is a winner
                    flag = 1;
                }
            }

            //Checking column 3 for winner
            else if ((board[2] == board[5]) && (board[5] == board[8]))
            {
                //check if winner is "X"
                if (board[2] == 'X')
                {
                    //print out who won
                    Console.WriteLine("Player 1 has won");

                    //indicate that there is a winner to communicate with main class
                    flag = 1;
                }

                //check if winner is "O"
                else if (board[2] == 'O')
                {
                    //print out who won
                    Console.WriteLine("Player 2 has won");

                    //indicate that there is a winner
                    flag = 1;
                }
            }

            //Checking decreasing diagonal for winner
            else if ((board[0] == board[4]) && (board[4] == board[8]))
            {
                //check if winner is "X"
                if (board[0] == 'X')
                {
                    //print out who won
                    Console.WriteLine("Player 1 has won");

                    //indicate that there is a winner to communicate with main class
                    flag = 1;
                }

                //check if winner is "O"
                else if (board[0] == 'O')
                {
                    //print out who won
                    Console.WriteLine("Player 2 has won");

                    //indicate that there is a winner
                    flag = 1;
                }
            }

            //Checking increasing diagonal for winner
            else if ((board[2] == board[4]) && (board[4] == board[6]))
            {
                //check if winner is "X"
                if (board[2] == 'X')
                {
                    //print out who won
                    Console.WriteLine("Player 1 has won");

                    //indicate that there is a winner to communicate with main class
                    flag = 1;
                }

                //check if winner is "O"
                else if (board[2] == 'O')
                {
                    //print out who won
                    Console.WriteLine("Player 2 has won");

                    //indicate that there is a winner
                    flag = 1;
                }
            }

            //Checking for draw
            else if ((board[0] != 0) && (board[1] != 1) && (board[2] != 2) && (board[3] != 3) && (board[4] != 4) && (board[5] != 5) && (board[6] != 6) && (board[7] != 7) && (board[8] != 8))
            {
                //printing there is no winner
                Console.WriteLine("There are no winners :(");

                //indicating a draw
                flag = -1;
            }

            //If there are no winners
            else
            {
                flag = 0;
            }

            return flag;
        }
    }
}
