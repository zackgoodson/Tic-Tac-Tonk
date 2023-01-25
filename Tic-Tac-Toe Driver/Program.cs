using System;


namespace mission3

{
    public class Program
    {

        public static int Check(ref char[] board, ref int indexMark)
        {

            if ((indexMark < 0) | (indexMark > 8))
            {
                while ((indexMark < 0) | (indexMark > 8))
                {

                    Console.WriteLine("You must choose an available space");

                    indexMark = Convert.ToInt32(Console.ReadLine()) - 1;
                }

                return (indexMark);
            }

            if ((board[indexMark] == 'X') | (board[indexMark] == 'O'))
            {
                while ((board[indexMark] == 'X') | (board[indexMark] == 'O')) {

                    Console.WriteLine("You must choose an empty space");

                    indexMark = Convert.ToInt32(Console.ReadLine()) - 1;

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
            char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            int flag = 0;
            int indexMark = 1;

            // Prints initial board
            Support.printBoard(board);

            // Main game functionality
            while (flag == 0) {

                Console.WriteLine("Select a number for " + mark + "(1-9): ");
                indexMark = Convert.ToInt32(Console.ReadLine()) - 1;
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
