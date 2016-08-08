using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rules
    {
        /*
        Dictionary<string, Piece> positions;
        string initialPosition;
        string finalPosition;
        public Rules(Dictionary<string, Piece> _positions, string _initialPosition, string _finalPosition)
        {
            positions = _positions;
            initialPosition = _initialPosition;
            finalPosition = _finalPosition;
        }
        */

        int wkInitialRow;
        public Rules(int _wkInitialRow)
        {
            wkInitialRow = _wkInitialRow;//whitekinginitialrow probably 1.
        }

        public bool testMoveIsValid(Dictionary<string, Piece> positions, string initialPosition, string finalPosition)
        {
            if (positions[initialPosition].name == Piece.Name.pawn)
            {

                return false;
            }
            if (positions[initialPosition].name == Piece.Name.rook)
            {

                return false;
            }
            if (positions[initialPosition].name == Piece.Name.queen)
            {

                return false;
            }
            if (positions[initialPosition].name == Piece.Name.knight)
            {

                return false;
            }
            if (positions[initialPosition].name == Piece.Name.king)
            {

                return false;
            }
            if (positions[initialPosition].name == Piece.Name.bishop)
            {

                return false;
            }
            else
            {
                return false;
            }


        }

    }
}
