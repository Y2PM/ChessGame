using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Piece
    {
        public Name name { get; set; }
        public Colour colour { get; set; }

        public enum Name
        {
            king,
            rook,
            bishop,
            queen,
            knight,
            pawn
        };
        public enum Colour
        {
            black, white
        };
        
    }
    
}
