using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rules//everything here that is stated as allowed is allowed and the rest isn't allowed.
    {

        string[] positionsMap;
        int wkInitialRow;
        Dictionary<MoveDetails, Piece> moveHistory;
        string diagonally = "";
        public Rules(int _wkInitialRow, string[] _positionsMap, Dictionary<MoveDetails, Piece> _moveHistory)
        {
            wkInitialRow = _wkInitialRow;//white king initial row probably 1.
            positionsMap = _positionsMap;
            moveHistory = _moveHistory;

        }

        public int testMoveIsValid(Dictionary<string, Piece> positions, string initialPosition, string finalPosition)
        {

            #region exit codes
            //0 := false
            //1 := true
            //2 := true En passant white left
            //3 := true En passant white right
            //4 := true En passant black left
            //5 := true En passant black right
            #endregion

            #region White pawn rules
            if (positions[initialPosition].name == Piece.Name.pawn && positions[initialPosition].colour == Piece.Colour.white)
            {
                int initialIndex = Array.IndexOf(positionsMap, initialPosition);
                int finalIndex = Array.IndexOf(positionsMap, finalPosition);
                diagonally = "";//reset diagonally
                //Make rule to say one step forward is allowed for a pawn.
                if (finalIndex - initialIndex == 8)//one step forward
                {
                    //rules to check nothing in the way.
                    if (positions[finalPosition].name != Piece.Name.g)//final position check, for move forward.
                    {
                        return 0;
                    }
                    return 1;
                }
                if (finalIndex - initialIndex == 16)//two steps forward
                {
                    if (initialPosition[1].ToString().Equals("2") == false)
                    {
                        return 0;
                    }
                    //rules to check nothing in the way.
                    if (positions[finalPosition].name != Piece.Name.g)//final position check, for move forward.
                    {
                        return 0;
                    }
                    string positionHalfway = positionsMap[initialIndex + 8];
                    if (positions[positionHalfway].name != Piece.Name.g)//check if a piece is in the way.
                    {
                        return 0;
                    }
                    return 1;
                }
                //what direction are you moving diagonally?:
                if (finalIndex - initialIndex == 7)//left forward
                {
                    diagonally = "left";
                }
                if (finalIndex - initialIndex == 9)//right forward
                {
                    diagonally = "right";
                }
                //in the case of taking diagonally:
                if (diagonally != "" && positions[finalPosition].colour == Piece.Colour.black)
                {
                    return 1;
                }
                //En passant rule:
                if (diagonally != "" && positions[finalPosition].name == Piece.Name.g)
                {
                    //Build a dictionary of moves and numbers from the move history and get the last move number:
                    Dictionary<int, string> movesAndNumbers = new Dictionary<int, string>(moveHistory.Count);
                    foreach (var item in moveHistory.Keys)
                    {
                        movesAndNumbers.Add(item.movenum, item.ipos + item.fpos);
                    }
                    int lastMoveNum = new int();
                    lastMoveNum = movesAndNumbers.Keys.Max();//

                    if (diagonally == "left")
                    {
                        if (positions[positionsMap[initialIndex - 1]].name == Piece.Name.pawn && positions[positionsMap[initialIndex - 1]].colour == Piece.Colour.black)
                        {

                            MoveDetails predictedLastMove = new MoveDetails();//Predicted last move in the case of moving 2 spaces forward for En passant.
                            predictedLastMove.fpos = positionsMap[initialIndex - 1];
                            predictedLastMove.ipos = positionsMap[initialIndex + 15];

                            MoveDetails actualLastMove = new MoveDetails();
                            actualLastMove.fpos = movesAndNumbers[lastMoveNum].Substring(2, 2);
                            actualLastMove.ipos = movesAndNumbers[lastMoveNum].Substring(0, 2);

                            if (predictedLastMove.fpos == actualLastMove.fpos && predictedLastMove.ipos == actualLastMove.ipos)
                            {
                                return 2;
                            }
                        }
                    }
                    if (diagonally == "right")
                    {
                        if (positions[positionsMap[initialIndex + 1]].name == Piece.Name.pawn && positions[positionsMap[initialIndex + 1]].colour == Piece.Colour.black)
                        {
                            MoveDetails predictedLastMove = new MoveDetails();//Predicted last move in the case of moving 2 spaces forward for En passant.
                            predictedLastMove.fpos = positionsMap[initialIndex + 1];
                            predictedLastMove.ipos = positionsMap[initialIndex + 17];

                            MoveDetails actualLastMove = new MoveDetails();
                            actualLastMove.fpos = movesAndNumbers[lastMoveNum].Substring(2, 2);
                            actualLastMove.ipos = movesAndNumbers[lastMoveNum].Substring(0, 2);

                            if (predictedLastMove.fpos == actualLastMove.fpos && predictedLastMove.ipos == actualLastMove.ipos)
                            {
                                return 3;
                            }
                        }
                    }
                }
            }
            #endregion

            #region Black pawn rules
            if (positions[initialPosition].name == Piece.Name.pawn && positions[initialPosition].colour == Piece.Colour.black)
            {
                int initialIndex = Array.IndexOf(positionsMap, initialPosition);
                int finalIndex = Array.IndexOf(positionsMap, finalPosition);
                diagonally = "";//reset diagonally
                //Make rule to say one step forward is allowed for a pawn.
                if (finalIndex - initialIndex == -8)//one step forward
                {
                    //rules to check nothing in the way.
                    if (positions[finalPosition].name != Piece.Name.g)//final position check, for move forward.
                    {
                        return 0;
                    }
                    return 1;
                }
                if (finalIndex - initialIndex == -16)//two steps forward
                {
                    if (initialPosition[1].ToString().Equals("7") == false)
                    {
                        return 0;
                    }
                    //rules to check nothing in the way.
                    if (positions[finalPosition].name != Piece.Name.g)//final position check, for move forward.
                    {
                        return 0;
                    }
                    string positionHalfway = positionsMap[initialIndex - 8];
                    if (positions[positionHalfway].name != Piece.Name.g)//check if a piece is in the way.
                    {
                        return 0;
                    }
                    return 1;
                }
                //what direction are you moving diagonally?:
                if (finalIndex - initialIndex == -7)//left forward from black perspective
                {
                    diagonally = "left";
                }
                if (finalIndex - initialIndex == -9)//right forward from black perspective
                {
                    diagonally = "right";
                }
                //in the case of taking diagonally:
                if (diagonally != "" && positions[finalPosition].colour == Piece.Colour.white)
                {
                    return 1;
                }
                //En passant rule:
                if (diagonally != "" && positions[finalPosition].name == Piece.Name.g)
                {
                    //Build a dictionary of moves and numbers from the move history and get the last move number:
                    Dictionary<int, string> movesAndNumbers = new Dictionary<int, string>(moveHistory.Count);
                    foreach (var item in moveHistory.Keys)
                    {
                        movesAndNumbers.Add(item.movenum, item.ipos + item.fpos);
                    }
                    int lastMoveNum = new int();
                    lastMoveNum = movesAndNumbers.Keys.Max();//

                    if (diagonally == "left")
                    {
                        if (positions[positionsMap[initialIndex + 1]].name == Piece.Name.pawn && positions[positionsMap[initialIndex + 1]].colour == Piece.Colour.white)
                        {

                            MoveDetails predictedLastMove = new MoveDetails();//Predicted last move in the case of moving 2 spaces forward for En passant.
                            predictedLastMove.fpos = positionsMap[initialIndex + 1];
                            predictedLastMove.ipos = positionsMap[initialIndex - 15];

                            MoveDetails actualLastMove = new MoveDetails();
                            actualLastMove.fpos = movesAndNumbers[lastMoveNum].Substring(2, 2);
                            actualLastMove.ipos = movesAndNumbers[lastMoveNum].Substring(0, 2);

                            if (predictedLastMove.fpos == actualLastMove.fpos && predictedLastMove.ipos == actualLastMove.ipos)
                            {
                                return 4;
                            }
                        }
                    }
                    if (diagonally == "right")
                    {
                        if (positions[positionsMap[initialIndex - 1]].name == Piece.Name.pawn && positions[positionsMap[initialIndex - 1]].colour == Piece.Colour.white)
                        {
                            MoveDetails predictedLastMove = new MoveDetails();//Predicted last move in the case of moving 2 spaces forward for En passant.
                            predictedLastMove.fpos = positionsMap[initialIndex - 1];
                            predictedLastMove.ipos = positionsMap[initialIndex - 17];

                            MoveDetails actualLastMove = new MoveDetails();
                            actualLastMove.fpos = movesAndNumbers[lastMoveNum].Substring(2, 2);
                            actualLastMove.ipos = movesAndNumbers[lastMoveNum].Substring(0, 2);

                            if (predictedLastMove.fpos == actualLastMove.fpos && predictedLastMove.ipos == actualLastMove.ipos)
                            {
                                return 5;
                            }
                        }
                    }
                }
            }
            #endregion

            if (positions[initialPosition].name == Piece.Name.rook)
            {

                return 0;
            }
            if (positions[initialPosition].name == Piece.Name.queen)
            {

                return 0;
            }
            if (positions[initialPosition].name == Piece.Name.knight)
            {

                return 0;
            }
            if (positions[initialPosition].name == Piece.Name.king)
            {

                return 0;
            }
            if (positions[initialPosition].name == Piece.Name.bishop)
            {

                return 0;
            }
            else
            {
                return 0;
            }


        }

    }
}
