using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Value
    {
        private int[,] matrix;
        public Value()
        {
            matrix = new int[9, 9]
            {
                {5,6,0,0,7,0,0,0,0 },
                {6,0,0,1,9,5,0,0,0 },
                {0,9,8,0,0,0,0,6,0 },
                {8,0,0,0,6,0,0,0,3 },
                {4,0,0,8,0,3,0,0,1 },
                {7,0,0,0,2,0,0,0,6 },
                {0,6,0,0,0,0,2,8,0 },
                {0,0,0,4,1,9,0,0,5 },
                {0,0,0,0,8,0,0,7,9 },
            };
        }
        public int[,] Matrix { get => matrix; set => matrix = value; }
        
    }
}
