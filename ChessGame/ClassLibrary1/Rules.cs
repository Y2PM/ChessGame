using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rules//everything here that is stated as allowed is allowed and the rest isnt allowed.
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
        string[] positionsMap;
        int wkInitialRow;
        public Rules(int _wkInitialRow, string[] _positionsMap)
        {
            wkInitialRow = _wkInitialRow;//white king initial row probably 1.
            positionsMap = _positionsMap;
        }

        public bool testMoveIsValid(Dictionary<string, Piece> positions, string initialPosition, string finalPosition)
        {
            if (positions[initialPosition].name == Piece.Name.pawn)
            {

                int initialIndex = Array.IndexOf(positionsMap, initialPosition);
                int finalIndex = Array.IndexOf(positionsMap, finalPosition);

                


                //Make rule to say one step forward is allowed for a pawn.
                if (finalIndex - initialIndex == 8)//one step forward
                {
                    //rules to check nothing in the way.
                    if (positions[finalPosition].name != Piece.Name.g)//final position check, for move forward.
                    {
                        return false;
                    }
                    return true;
                }
                if (finalIndex - initialIndex == 16)//two steps forward
                {
                    //rules to check nothing in the way.
                    if (positions[finalPosition].name != Piece.Name.g)//final position check, for move forward.
                    {
                        return false;
                    }
                    string positionHalfway = positionsMap[initialIndex + 8];
                    if (positions[positionHalfway].name != Piece.Name.g)//check if a piece is in the way.
                    {
                        return false;
                    }
                    return true;
                }
                //in the case of taking diagonally:
                if ((finalIndex - initialIndex == 7 || finalIndex - initialIndex == 9) && positions[finalPosition].name != Piece.Name.g)
                {
                    return true;
                }


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
