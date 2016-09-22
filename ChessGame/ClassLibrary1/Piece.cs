using System;

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
            black,
            white,
            w//ghosts are white
        };

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    
}
