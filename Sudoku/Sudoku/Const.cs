using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Const
    {
        public static int Btn_Width = 90;
        public static int Btn_Height = 90;
        public static int Btn_InputPad = 50;
        public static Point defaultPoint = new Point(0, 0);
        public static int[,] rootMatrix = new int[9, 9]
            {
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
            };
        public static int[,] solveMatrix = new int[9, 9];
        public static Stack<Cell> undoStack = new Stack<Cell>();
        public static Stack<Cell> redoStack = new Stack<Cell>();

    }
}
