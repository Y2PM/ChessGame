using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Position
    {

        public Position()
        {


            int[] rowArray = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] colArray = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h" };
            Dictionary<int, string> positions = new Dictionary<int, string>();
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    positions.Add(rowArray[row], colArray[col]);
                }
            }
        }
        public string[] verticalPosition { get; set; }

        public string[] horizontalPosition { get; set; }
        /*
        public enum VerticalPosition
        {
            v1, v2, v3, v4, v5, v6, v7, v8
        };
        public enum HorizontalPosition
        {
            a, b, c, d, e, f, g, h
        };
        */

    }
}
