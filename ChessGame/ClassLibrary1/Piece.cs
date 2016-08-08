using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Piece : ICloneable
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
            pawn,
            ghost//ghost piece represents no piece in the board dictionary
        };
        public enum Colour
        {
            black, white
        };

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    
}
