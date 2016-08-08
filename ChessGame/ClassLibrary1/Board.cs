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
        Piece p;
        public Board()
        {
            Piece _p = new Piece();
            _p.colour = Piece.Colour.w;//white
            _p.name = Piece.Name.g;//ghost
            positions = positionsMethod(_p);//gets the board
            p = _p;
            int wkInitialRow = new int();
            wkInitialRow = 1;
            setupBoard(positions, wkInitialRow);//puts pieces on the board
        }

        static Dictionary<string, Piece> positionsMethod(Piece _p)
        {
            //Make positions on a board.
            string[] rowArray = new string[8] { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] colArray = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h" };//create the array.
            int numberOfPositions = new int();
            numberOfPositions = rowArray.Length * colArray.Length;
            Dictionary<string, Piece> _positions = new Dictionary<string, Piece>(numberOfPositions);
            for (int r = 0; r < rowArray.Length; r++)
            {
                for (int c = 0; c < colArray.Length; c++)
                {
                    _positions.Add(colArray[c] + rowArray[r], _p);
                }
            }
            return _positions;
        }

        public int move(string initialPosition, string finalPosition)
        {
            //is it a valid move?
            //use a rules class method

            //do the move if valid
            Piece piece = new Piece();
            piece = positions[initialPosition];
            positions[initialPosition] = p;
            positions[finalPosition] = piece;
            return 1;
        }

        public void printPositionsAndPieces()
        {
            int j1 = new int();//Print positions with reversed rows (intuitive layout).
            for (int j = 7; j > -1; j--)//print the array.
            {
                j1 = 8 * j;
                for (int k = 0; k < 8; k++)
                {
                    Console.Write((positions.ElementAt(j1).Key + " " + positions.ElementAt(j1).Value.colour + " " + positions.ElementAt(j1++).Value.name + " ").PadRight(16));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void printPositions()
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

        public void printPositionsFrom0thElement()
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

        //Makes pieces and puts them on the board
        static void setupBoard(Dictionary<string, Piece> positions, int wkInitialRow)
        {
            //assume a parameter exists to specify side white king is on at initial setup,
            //is it on row 8 or row 1? e.g.
            //wkInitialRow = 1;

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

            #region Position white pieces
            positions["a2"] = wpa;//pawns
            positions["b2"] = wpb;
            positions["c2"] = wpc;
            positions["d2"] = wpd;
            positions["e2"] = wpe;
            positions["f2"] = wpf;
            positions["g2"] = wpg;
            positions["h2"] = wph;

            positions["a1"] = wra;//rooks
            positions["h1"] = wrh;

            positions["b1"] = wkb;//knights
            positions["g1"] = wkg;

            positions["c1"] = wbc;//bishops
            positions["f1"] = wbf;

            positions["d1"] = wqd;//queen

            positions["e1"] = wke;//king
            #endregion

            #region Position black pieces
            positions["a7"] = bpa;//pawns
            positions["b7"] = bpb;
            positions["c7"] = bpc;
            positions["d7"] = bpd;
            positions["e7"] = bpe;
            positions["f7"] = bpf;
            positions["g7"] = bpg;
            positions["h7"] = bph;

            positions["a8"] = bra;//rooks
            positions["h8"] = brh;

            positions["b8"] = bkb;//knights
            positions["g8"] = bkg;

            positions["c8"] = bbc;//bishops
            positions["f8"] = bbf;

            positions["d8"] = bqd;//queen

            positions["e8"] = bke;//king
            #endregion


        }




    }
}
