using ClassLibrary1;
using System;

namespace ChessGame.Project
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            MoveDetails predictedLastMove = new MoveDetails();
            predictedLastMove.fpos = "ab5";
            predictedLastMove.ipos = "cd6";
            predictedLastMove.movenum = 3;

            MoveDetails actualLastMove = new MoveDetails();
            actualLastMove.fpos = "ab5";
            actualLastMove.ipos = "cd6";
            actualLastMove.movenum = 3;
            //Object.ReferenceEquals(predictedLastMove, actualLastMove)
            if (predictedLastMove.Equals(actualLastMove))
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("false");
                Console.ReadLine();
            }
            */

            /*
            string str1 = "abc";
            string str2 = "c";
            
            Console.WriteLine(str1[2]);
            Console.WriteLine(str2);
            Console.WriteLine(str1[2].ToString().Equals(str2));
            Console.ReadLine();
            */

            /*
            string str1 = "abc";
            Console.WriteLine(str1[2]);
            Console.ReadLine();
            */

            
            #region Lets try it out
            //

            string moves = "";
            Board board = new Board();
            while (moves != "exit")
            {
                board.printPositionsAndPieces();
                Console.WriteLine();
                Console.WriteLine("Press enter for further instructions.");
                
                Console.ReadLine();
                Console.WriteLine("To move a piece input the initial and final positions respectively then press enter, e.g. a2a4. To exit input exit then enter.");
                moves = Console.ReadLine().PadRight(4);
                if (moves != "exit")
                {
                    board.move(moves.Substring(0, 2), moves.Substring(2, 2));
                }

            }

            Console.WriteLine("Thankyou come again.");
            Console.WriteLine("The moves were: ");
            foreach (var item in board.moveHistory)
            {
                Console.WriteLine(item.Value.colour + " " + item.Value.name + " " + item.Key.ipos + item.Key.fpos +" "+item.Key.movenum);
            }
            Console.WriteLine("Press enter to close window.");
            Console.ReadLine();

            // 
            #endregion
            

            /*
            Board board2 = new Board();
            //board2.printPositionsAndPieces();
            board2.printPositionsFrom0thElement();
            */
        }
    }
}
