using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sudoku
{
    class Solution
    {
        #region Properties

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

        //{   
        //    {5,0,0,0,7,0,0,1,0},
        //    {0,0,2,0,9,0,0,0,0 },
        //    {0,0,0,0,0,2,0,6,0 } ,
        //    {0,0,0,0,6,0,4,0,0 },
        //    {0,0,0,0,0,0,0,0,0 },
        //    {0,0,0,9,0,0,8,0,6 },
        //    {0,0,0,0,0,0,2,0,0 },
        //    {0,0,7,0,0,0,0,0,0 },
        //    { 3,0,0,0,8,0,0,0,9} 
        //};

    public static int[,] solveMatrix = new int[9, 9];
        #endregion
        #region Initialize
        #endregion
        #region Methods
        #region isOK
        public int isOK(int curValue, int row, int col, int[,] matrix)
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
        public bool Solve_Sodoku()
        {
            {
                //        if (curCol == 9 )
                //        {
                //             if (curRow == 8)
                //             {
                //             for (int i = 0; i < rootMatrix.GetLength(1); i++)
                //             {
                //                     for (int j = 0; j < rootMatrix.GetLength(0); j++)
                //                     {
                //                         solveMatrix[i, j] = rootMatrix[i, j];
                //                     }

                //             }
                //             return;
                //             }
                //             else
                //             {
                //                 Solve_Sodoku(curRow + 1, 0);
                //             }

                //        }
                //         else 
                //         if (rootMatrix[curRow, curCol] == 0)
                //         {
                //         if (curCol != preCell.Col && curRow != preCell.Row)
                //         {
                //             int k = 0;
                //             for (k = 1; k <= 9; k++)
                //             {
                //                 if (isOK(k, curRow, curCol, rootMatrix) == 1)
                //                 {
                //                     rootMatrix[curRow, curCol] = k;
                //                     preCell = new Cell(rootMatrix[curRow, curCol].ToString(), curCol, curRow);
                //                     Solve_Sodoku(curRow, curCol + 1);

                //                 }

                //             }
                //             if (isOK(9, curRow, curCol, rootMatrix) == 0)
                //             {
                //                 rootMatrix[curRow, curCol] = 0;
                //                 rootMatrix[preCell.Row, preCell.Col] = 0;
                //                 Solve_Sodoku(preCell.Row, preCell.Col);
                //             }
                //         }
                //         else
                //         {
                //             for ( int m = Int32.Parse(preCell.Num); m <=9; m++)
                //             {
                //                 if (isOK(m, curRow, curCol, rootMatrix) == 1)
                //                 {
                //                     rootMatrix[curRow, curCol] = m;
                //                     preCell = new Cell(rootMatrix[curRow, curCol].ToString(), curCol, curRow);
                //                     Solve_Sodoku(curRow, curCol + 1);

                //                 }
                //             }
                //         }


                //         }

                //         else
                //         {

                //             Solve_Sodoku(curRow, curCol + 1);
                //      //   if (curRow == 8 && curCol == 8) return; 
                //         }
                ////     return;
                ///
            } 
                int row = -1;
                int col = -1;
                bool isEmpty = true;
                for (int i = 0; i < rootMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < rootMatrix.GetLength(0); j++)
                    {
                        if (rootMatrix[i, j] == 0)
                        {
                            row = i;
                            col = j;

                            // we still have some remaining 
                            // missing values in Sudoku 
                            isEmpty = false;
                            break;
                        }
                    }
                    if (!isEmpty)
                    {
                        break;
                    }
                }

                // no empty space left 
                if (isEmpty)
                {
                    return true;
                }

                // else for each-row backtrack 
                for (int num = 1; num <= rootMatrix.GetLength(1); num++)
                {
                    if (isOK(num, row, col, rootMatrix)==1)
                    {
                        rootMatrix[row, col] = num;
                        if (Solve_Sodoku())
                        {
                            for (int i = 0; i < rootMatrix.GetLength(1); i++)
                            {
                                  for (int j = 0; j < rootMatrix.GetLength(0); j++)
                                  {
                              solveMatrix[i, j] = rootMatrix[i, j];
                                  }

                            }
                            return true;
                        }
                        else
                        {
                            rootMatrix[row, col] = 0; // replace it 
                        }
                    }
                }
                return false;
        }
        #endregion
        #region ResetMatrix
        public void ResetMatrix(int [,] matrix)
        {
            matrix = new int [9,9]
                {
               { 0,0,0,0,0,0,0,0,0},
               { 0,0,0,0,0,0,0,0,0},
               { 0,0,0,0,0,0,0,0,0},
               { 0,0,0,0,0,0,0,0,0},
               { 0,0,0,0,0,0,0,0,0},
               { 0,0,0,0,0,0,0,0,0},
               { 0,0,0,0,0,0,0,0,0},
               { 0,0,0,0,0,0,0,0,0},
               { 0,0,0,0,0,0,0,0,0},
            };
        }
        #endregion
        #endregion
    }
}

