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
            g//ghost piece represents no piece in the board dictionary
        };
        public enum Colour
        {
            black, white, w//a ghost is white
        };

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    
}
