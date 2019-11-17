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
        //Đối tượng chưa các methods tác động trực tiếp đến ma trận.
        #region Methods
        #region isOK _ Kiểm tra tính đúng đắn của ma trận
        //Điều kiện đúng của ma trận
        //Dòng và cột là các số từ 1 đến 9 không trùng nhau
        //Từng ô 3x3 (đã được đánh dấu trên giao diện) là các số từ 1 đến 9 không trùng nhau
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
        #region Solve_Soduku Thuật toán giải game Sudoku
        //Nguồn lấy thuật toán: https://www.geeksforgeeks.org/sudoku-backtracking-7/
        //Giải thích. Sử dụng đệ quy để giải.
        public bool Solve_Sodoku()
        {
                int row = -1;
                int col = -1;
                bool isEmpty = true;
                for (int i = 0; i < Const.rootMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < Const.rootMatrix.GetLength(0); j++)
                    {
                        if (Const.rootMatrix[i, j] == 0)
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
                for (int num = 1; num <= Const.rootMatrix.GetLength(1); num++)
                {
                    if (isOK(num, row, col, Const.rootMatrix) ==1)
                    {
                    Const.rootMatrix[row, col] = num;
                        if (Solve_Sodoku())
                        {
                            for (int i = 0; i < Const.rootMatrix.GetLength(1); i++)
                            {
                                  for (int j = 0; j < Const.rootMatrix.GetLength(0); j++)
                                  {
                                    Const.solveMatrix[i, j] = Const.rootMatrix[i, j];
                                  }
                            }
                            return true;
                        }
                        else
                        {
                            Const.rootMatrix[row, col] = 0; // replace it 
                        }
                    }
                }
                return false;
        }
        #endregion
        #region ResetMatrix
        public void ResetMatrix(int[,] matrix) //Reset lại ma trận để bắt đầu 1 game mới
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        #endregion
        #endregion
    }
}

