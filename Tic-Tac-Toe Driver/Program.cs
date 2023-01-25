﻿using System;


namespace mission3

{
    public class Program
    {

        public static int Check(ref char[] board, ref int indexMark)
        {
            if ((board[indexMark] == 'X') | (board[indexMark] == 'O'))
            {
                while ((board[indexMark] == 'X') | (board[indexMark] == 'O')) {

                    Console.WriteLine("You must choose an empty space");

                    indexMark = Convert.ToInt32(Console.ReadLine());
                }

                return (indexMark);
            }
            else
            {
                return (indexMark);
            }
         }


        public static void Main(string[] args)
        {

            Support su = new Support();

            char mark = 'X';

            Console.WriteLine("Welcome, to the glorious game of Tic-Tac-Toe!");

            // Declares and Initializes board array
            char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

            int flag = 0;
            int indexMark = 0;

            // Prints initial board
            Support.printBoard(board);

            // Main game functionality
            while (flag == 0) {

                Console.WriteLine("Select a number for " + mark + "(0-8): ");
                indexMark = Convert.ToInt32(Console.ReadLine());
                Program.Check(ref board, ref indexMark);

                // marks the selected index number to X
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
                Support.printBoard(board);
                flag = Support.getWin(board);
            }

        }
    }
}
