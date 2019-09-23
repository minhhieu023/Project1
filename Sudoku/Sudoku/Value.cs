using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Value
    {
        #region Properties
        public int [,] matrix =  new int[9, 9]
            {
                {5,6,0,0,7,0,0,0,2 },
                {6,0,0,1,9,5,0,0,0 },
                {0,9,8,0,0,0,0,6,0 },
                {8,0,0,0,6,0,0,0,3 },
                {4,0,0,8,0,3,0,0,1 },
                {7,0,0,0,2,0,0,0,6 },
                {0,6,0,0,0,0,2,8,0 },
                {0,0,0,4,1,9,0,0,5 },
                {0,0,0,0,8,0,0,7,9 },
            };
        #endregion

        #region Initialize
        public Value()
        {
           
        }
        #endregion

        #region Methods
        #region isOK
        public int isOK(int curValue, int row, int col)
        {

            int i = 0, j = 0;
            for (i = 0; i < 9; i++)
            {
                if (matrix[row, i] == curValue) return 0;
            }
            for (i = 0; i < 9; i++)
            {
                if (matrix[i, col] == curValue) return 0;
            }
            int a = row / 3, b = col / 3;
            for (i = 3 * a; i < 3 * a + 3; i++)
            {
                for (j = 3 * b; j < 3 * b + 3; j++)
                {
                    if (matrix[i, j] == curValue) return 0;
                }
            }
            return 1;
        }
        #endregion
        #region Solve_Soduku
        public int[,] a1;
        public void Solve_Sodoku(int curRow, int curCol)
        {
            if (curCol == 9)
            {
                if (curRow == 8)
                {
                    return;
                }
                else
                {
                    Solve_Sodoku(curRow + 1, 0);
                }
            }
            else if (matrix[curRow, curCol] == 0)
            {
                int k = 0;
                for (k = 1; k <= 9; k++)
                {
                    if (isOK(k, curRow, curCol) == 1)
                    {
                        matrix[curRow, curCol] = k;
                        Solve_Sodoku(curRow, curCol + 1);
                        matrix[curRow, curCol] = 0;
                    }
                }
            }
            else
            {
                Solve_Sodoku(curRow, curCol + 1);
            }

        }
        
        #endregion
        #endregion

    }
}
