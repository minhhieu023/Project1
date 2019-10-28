﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{  
    public class CheckBoardManager
    {
        #region Propeties
        public Point defaultPoint = new Point(0, 0);
        Solution solution = new Solution();
        public  InpudPad inpuPad;
        public Point p = new Point();
        private Panel chessBoard;
        public static bool isShow= false;
        public static List<List <Button>> matrix;
        public static int[,] curMap = new int[9,9];
        public static bool rendered=false;
        public Button btn;
        public static int curRow;
        public static int curCol;
        public Panel ChessBoard
        {
            get => chessBoard;
            set => chessBoard = value;
        }
        #endregion

        #region Initialize
        public CheckBoardManager(Panel chessBoard )
        {
            this.ChessBoard = chessBoard;        
        }
       
        #endregion

        #region Methods
        #region LoadChessBoard

        public void LoadChessBoard(int[,] map) 
        {
         //   CreatedMatrix();
            matrix = new List<List<Button>>();
            for (int i = 0; i < map.GetLength(1); i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(defaultPoint.X + Cons.Btn_Width* j, 
                        defaultPoint.Y + Cons.Btn_Hight * i);
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.Font = new Font("Times New Roman",25  );
                 
                    matrix[i].Add(btn);
                    ChessBoard.Controls.Add(btn);
    
                    btn.Click += btn_Click;              
                    btn.MouseMove += btn_MouseMove;
                    btn.MouseLeave += btn_MouseLeave;
                    
                    if ((i == 0 || i == 1 || i == 2 || i == 7 || i == 8 || i == 6) &&
                        (j == 0 || j == 1 || j == 2 || j == 7 || j == 8 || j == 6) ||
                        (i == j) || (i == 3 || i == 4) && (j == 5 || j == 4) || (i == 5 || i == 4) 
                        && (j == 3 || j == 4))

                    {
                        btn.BackColor = Color.MediumSeaGreen;                      
                    }
                    //if (map[i, j] != 0)
                    //{              
                    //    btn.Text = map[i, j].ToString();           
                    //    btn.ForeColor = Color.Black;
                    //    btn.Enabled = false;                              
                    //}
                    //else btn.TextChanged += Btn_TextChanged;
                    //curMap[i, j] = map[i, j];
                    rendered = true;
                }
            }
        }
        #endregion
        #region PrintSolution
        public void PrintSolution()
        {
            //solution.Solve_Sodoku();
            for (int i = 0; i < Solution.solveMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < Solution.solveMatrix.GetLength(0); j++)
                {
                    matrix[i][j].Text = Solution.solveMatrix[i, j].ToString();
                    matrix[i][j].ForeColor = Color.Blue;
                }
            }
        }
        #endregion
        #region AlwaysCheck
        public int AlwaysCheckIsOK(int[,] curMap)
        {
            for (int i = 0; i < curMap.GetLength(1); i++)
            {
                for (int j = 0; j < curMap.GetLength(0); j++)
                {
                    if (curMap[i, j] == 0)
                        return 0;
                }               
            }
            for (int i = 0; i < curMap.GetLength(1); i++)
            {
                for (int j = 0; j < curMap.GetLength(0); j++)
                {
                    int temp = curMap[i, j];
                    curMap[i, j] = 0;
                    if (solution.isOK(temp, i, j, curMap) == 0)
                    {
                        curMap[i,j] = temp;
                        return 0;
                    }
                    curMap[i, j] = temp;

                }
            }

                    return 1;
        }
        #endregion
        #region CreatedMatrix
        public void CreateNewMatrix()
        {
            for (int i = 0; i < Solution.rootMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < Solution.rootMatrix.GetLength(0); j++)
                {                  
                    matrix[i][j].TextChanged -= Btn_TextChanged;
                    matrix[i][j].ResetText();
                    matrix[i][j].Enabled = true;
                    if (Solution.rootMatrix[i, j] != 0)
                    {
                        matrix[i][j].Text = Solution.rootMatrix[i, j].ToString();
                        matrix[i][j].ForeColor = Color.Black;
                        matrix[i][j].Enabled = false;
                    }
                    else matrix[i][j].TextChanged += Btn_TextChanged;
                    curMap[i, j] = Solution.rootMatrix[i, j];

                }
            }
        }
        #endregion
        #region Envent
        private void Btn_TextChanged(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            curCol = (btn.Location.X - defaultPoint.X) / Cons.Btn_Width;
            curRow = (btn.Location.Y - defaultPoint.Y) / Cons.Btn_Hight;
            if (matrix[curRow][curCol].Text != " ")
            {
                int temp = Int32.Parse(matrix[curRow][curCol].Text);
                if (solution.isOK(temp, curRow, curCol, curMap) == 1)
                {
                    btn.ForeColor = Color.Blue;               
                }
                else btn.ForeColor = Color.Red;
                curMap[curRow, curCol] = temp;
                if (AlwaysCheckIsOK(curMap) == 1)

                {
                    if( isShow == true)
                    this.inpuPad.Close();
                    MessageBox.Show("You win");
                }                 
            }
        }
        public static void ProcessInsertText()
        { 
            matrix[curRow][curCol].Text = InpudPad.CurNumber;
            Cell cell = new Cell(matrix[curRow][curCol].Text, curCol, curRow);
            Interface.undoStack.Push(cell);
        }
        public void btn_Click(object sender, EventArgs e)
        { 
           
            Button btn = sender as Button;
            curCol = (btn.Location.X - defaultPoint.X) / Cons.Btn_Width;
            curRow = (btn.Location.Y - defaultPoint.Y) / Cons.Btn_Hight;    
        
            if (isShow == true)
            {
                inpuPad.Location = new Point(defaultPoint.X + 180 + btn.Location.X, defaultPoint.Y + 180 + btn.Location.Y);
                inpuPad.Focus();          
            }
            else
            {
                inpuPad = new InpudPad();
                inpuPad.Show();
                inpuPad.Location = new Point(defaultPoint.X + 180 + btn.Location.X, defaultPoint.Y + 180 + btn.Location.Y);
                isShow = true;               
            }              
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatStyle = FlatStyle.Flat;
            p.X = e.X;
            p.Y = e.Y;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatStyle = FlatStyle.Popup;
        }
        public static void Hint()
        {
            matrix[curRow][curCol].Text = Solution.solveMatrix[curRow, curCol].ToString();
            matrix[curRow][curCol].ForeColor = Color.Black;
            matrix[curRow][curCol].Enabled = false;
        }
        #endregion
       
        #endregion

    }
}
