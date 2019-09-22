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
        public virtual void isOK( int value)
        {
           
                int i = 0, j = 0;
                for (i = 0; i < 9; i++)
                {
                    if (Matrix[value][i] == k) return 0;
                }
                for (i = 0; i < 9; i++)
                {
                    if ([i][y] == k) return 0;
                }
                int a = x / 3, b = y / 3;
                for (i = 3 * a; i < 3 * a + 3; i++)
                {
                    for (j = 3 * b; j < 3 * b + 3; j++)
                    {
                        if (S[i][j] == k) return 0;
                    }
                }
                return 1;

            }
        }
        public void SolveSudoku()
        {
            for ( int i=0; i< matrix.GetLength(1); i++)
            {

            }

        }
    }
}
