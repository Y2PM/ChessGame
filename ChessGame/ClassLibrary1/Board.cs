using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Board
    {   //Each position on the board will have a property and the property will be assigned a value indicating what's in that location.

        int boolStandardSetup;

        public Board(int _boolStandardSetup)
        {
            _boolStandardSetup = boolStandardSetup;
        }

        public Piece a1 { get; set; }
        public Piece a2 { get; set; }
        public Piece a3 { get; set; }
        public Piece a4 { get; set; }
        public Piece a5 { get; set; }
        public Piece a6 { get; set; }
        public Piece a7 { get; set; }
        public Piece a8 { get; set; }

        public Piece b1 { get; set; }
        public Piece b2 { get; set; }
        public Piece b3 { get; set; }
        public Piece b4 { get; set; }
        public Piece b5 { get; set; }
        public Piece b6 { get; set; }
        public Piece b7 { get; set; }
        public Piece b8 { get; set; }

        public Piece c1 { get; set; }
        public Piece c2 { get; set; }
        public Piece c3 { get; set; }
        public Piece c4 { get; set; }
        public Piece c5 { get; set; }
        public Piece c6 { get; set; }
        public Piece c7 { get; set; }
        public Piece c8 { get; set; }

        public Piece d1 { get; set; }
        public Piece d2 { get; set; }
        public Piece d3 { get; set; }
        public Piece d4 { get; set; }
        public Piece d5 { get; set; }
        public Piece d6 { get; set; }
        public Piece d7 { get; set; }
        public Piece d8 { get; set; }

        public Piece e1 { get; set; }
        public Piece e2 { get; set; }
        public Piece e3 { get; set; }
        public Piece e4 { get; set; }
        public Piece e5 { get; set; }
        public Piece e6 { get; set; }
        public Piece e7 { get; set; }
        public Piece e8 { get; set; }

        public Piece f1 { get; set; }
        public Piece f2 { get; set; }
        public Piece f3 { get; set; }
        public Piece f4 { get; set; }
        public Piece f5 { get; set; }
        public Piece f6 { get; set; }
        public Piece f7 { get; set; }
        public Piece f8 { get; set; }

        public Piece g1 { get; set; }
        public Piece g2 { get; set; }
        public Piece g3 { get; set; }
        public Piece g4 { get; set; }
        public Piece g5 { get; set; }
        public Piece g6 { get; set; }
        public Piece g7 { get; set; }
        public Piece g8 { get; set; }

        public Piece h1 { get; set; }
        public Piece h2 { get; set; }
        public Piece h3 { get; set; }
        public Piece h4 { get; set; }
        public Piece h5 { get; set; }
        public Piece h6 { get; set; }
        public Piece h7 { get; set; }
        public Piece h8 { get; set; }


    }
}
