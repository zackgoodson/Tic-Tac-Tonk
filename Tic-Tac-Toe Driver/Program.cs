using System;

namespace Tic_Tac_Toe_Driver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome, to the glorious game of Tic-Tac-Toe!");

            //Dclares and Initializes board array
            char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

            bool win = false;
            int indexMark = 0;
            char mark = 'X';
            PrintBoard(board);


            while (win == false) {

                // Prompts user for index number to change to X
                Console.WriteLine("Select a number for " + mark + "(0-8): ");
                indexMark = Convert.ToInt32(Console.ReadLine());

                //marks the selected index number to X
                board[indexMark] = mark;

                //Switch marks
                if (mark == 'X')
                {
                    mark = 'O';
                }
                else if (mark == 'O')
                {
                    mark = 'X';
                }

                //sends array to print and check if there is a win
                PrintBoard(board);
                win = GetWin();
            }

        }
    }
}
