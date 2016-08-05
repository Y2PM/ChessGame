using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IPiece
    {
        enum name
        {
            king,
            rook,
            bishop,
            queen,
            knight,
            pawn
        };
        enum colour
        {
            black, white
        };
    }
}
