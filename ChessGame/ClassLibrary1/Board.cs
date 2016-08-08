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
            p.name = Piece.Name.ghost;
            string[] rowArray = new string[8] { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] colArray = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h" };//create the array.
            int numberOfPositions = new int();
            numberOfPositions = rowArray.Length * colArray.Length;
            Dictionary<string, Piece> _positions = new Dictionary<string, Piece>(numberOfPositions);
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

        //Make pieces to put on the board
        static void SetupBoard()
        {

            #region White pieces
            Piece wpa = new Piece();//white pawn a.
            wpa.name = Piece.Name.pawn;
            wpa.colour = Piece.Colour.white;

            Piece wpb = (Piece)wpa.Clone();
            Piece wpc = (Piece)wpa.Clone();
            Piece wpd = (Piece)wpa.Clone();
            Piece wpe = (Piece)wpa.Clone();
            Piece wpf = (Piece)wpa.Clone();
            Piece wpg = (Piece)wpa.Clone();
            Piece wph = (Piece)wpa.Clone();

            Piece wra = new Piece();//white rook a.
            wra.name = Piece.Name.rook;
            wra.colour = Piece.Colour.white;

            Piece wrh = (Piece)wra.Clone();

            Piece wkb = new Piece();
            wkb.name = Piece.Name.knight;
            wkb.colour = Piece.Colour.white;

            Piece wkg = (Piece)wkb.Clone();

            Piece wbc = new Piece();
            wbc.name = Piece.Name.bishop;
            wbc.colour = Piece.Colour.white;

            Piece wbf = (Piece)wbc.Clone();

            Piece wqd = new Piece();
            wqd.name = Piece.Name.queen;
            wqd.colour = Piece.Colour.white;

            Piece wke = new Piece();
            wke.name = Piece.Name.king;
            wke.colour = Piece.Colour.white;
            #endregion

            #region Black pieces
            Piece bpa = new Piece();//black pawn a.
            bpa.name = Piece.Name.pawn;
            bpa.colour = Piece.Colour.black;

            Piece bpb = (Piece)bpa.Clone();
            Piece bpc = (Piece)bpa.Clone();
            Piece bpd = (Piece)bpa.Clone();
            Piece bpe = (Piece)bpa.Clone();
            Piece bpf = (Piece)bpa.Clone();
            Piece bpg = (Piece)bpa.Clone();
            Piece bph = (Piece)bpa.Clone();

            Piece bra = new Piece();//black rook a.
            bra.name = Piece.Name.rook;
            bra.colour = Piece.Colour.black;

            Piece brh = (Piece)bra.Clone();

            Piece bkb = new Piece();
            bkb.name = Piece.Name.knight;
            bkb.colour = Piece.Colour.black;

            Piece bkg = (Piece)bkb.Clone();

            Piece bbc = new Piece();
            bbc.name = Piece.Name.bishop;
            bbc.colour = Piece.Colour.black;

            Piece bbf = (Piece)bbc.Clone();

            Piece bqd = new Piece();
            bqd.name = Piece.Name.queen;
            bqd.colour = Piece.Colour.black;

            Piece bke = new Piece();
            bke.name = Piece.Name.king;
            bke.colour = Piece.Colour.black;
            #endregion

        }




    }
}
