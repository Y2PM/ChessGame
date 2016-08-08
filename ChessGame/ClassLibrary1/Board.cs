using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Board
    {

        Dictionary<string, Piece> positions;

        public Board()
        {
            //Make positions on a board.
            Piece p = new Piece();
            string[] rowArray = new string[8] { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] colArray = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h" };//create the array.
            int numberOfPositions = new int();
            numberOfPositions = rowArray.Length * colArray.Length;
            Dictionary<string, Piece> _positions = new Dictionary<string, Piece>(numberOfPositions);
            //int i = new int();
            //i = 0;//Don't need to set to 0 as it's default value.
            for (int r = 0; r < rowArray.Length; r++)
            {
                for (int c = 0; c < colArray.Length; c++)
                {
                  
                    _positions.Add(colArray[c] + rowArray[r], p);
                }
            }
            positions = _positions;




        }



        public void PrintPositions()
        {
            int j1 = new int();//Print positions with reversed rows (intuitive layout).
            for (int j = 7; j > -1; j--)//print the array.
            {
                j1 = 8 * j;
                for (int k = 0; k < 8; k++)
                {
                    Console.Write(positions.ElementAt(j1++).Key + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void PrintPositionsFrom0thElement()
        {
            int j1 = new int();//Print positions.
            j1 = 0;
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Console.Write(positions.ElementAt(j1++).Key + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        /*
        //Make pieces to put on the board
        public Dictionary<string,Piece> SetupBoard()
        {
            Piece wpa = new Piece();//white pawn a.
            wpa.name = Piece.Name.pawn;
            wpa.colour = Piece.Colour.white;


        }
        */



    }
}
