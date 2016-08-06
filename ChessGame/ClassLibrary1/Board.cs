using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Board
    {



        public Board()
        {


            #region MyRegion

            string[] rowArray = new string[8] { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] colArray = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h" };
            int numberOfPositions = new int();
            numberOfPositions = rowArray.Length * colArray.Length;
            string[] positions = new string[numberOfPositions];
            int i = new int();
            i = 0;
            for (int r = 0; r < rowArray.Length; r++)
            {
                for (int c = 0; c < colArray.Length; c++)
                {
                    positions[i++] = colArray[c] + rowArray[r];
                }
            }

            #endregion

        }






    }
}
