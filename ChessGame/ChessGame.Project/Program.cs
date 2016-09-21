using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Project
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Lets try it out
            //

            string moves = "";
            Board board = new Board();
            while (moves != "exit")
            {
                Console.WriteLine("Press enter for further instructions.");
                board.printPositionsAndPieces();
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
                Console.WriteLine(item.Value.colour + " " + item.Value.name + " " + item.Key);
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
