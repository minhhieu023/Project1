using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sudoku
{
    public partial class Sudoku : Form
    {
        #region Properties
        CheckBoardManager ChessBoard;
        Solution s = new Solution();
        private int level=0;
        public static int[,] virtualMatrix;
        int oldRow = -1;
        int oldCol = -1;
        private bool isNewGame = false;
      

        #endregion
        public Sudoku()
        {
            InitializeComponent();
            ChessBoard = new CheckBoardManager(pnChessBoard);
            ChessBoard.LoadChessBoard(Solution.rootMatrix);
            progressBar.Visible = false;

        }


        private void Button1_Click(object sender, EventArgs e)
        {

            if (Interface.undoStack.Count != 0)
            {
                var temp = Interface.undoStack.Pop();
                CheckBoardManager.curMap[temp.Row, temp.Col] = 0;
                Interface.redoStack.Push(temp);
                CheckBoardManager.matrix[temp.Row][temp.Col].Text = temp.Num;
                if (oldRow != -1 && (oldCol != temp.Col || oldRow != temp.Row)
                    && oldCol != 1)
                    CheckBoardManager.matrix[oldRow][oldCol].Text = " ";
                oldRow = temp.Row;
                oldCol = temp.Col;
            }
            else
            {
                CheckBoardManager.matrix[oldRow][oldCol].Text = " ";
                return;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (Interface.redoStack.Count != 0)
            {
                var temp = Interface.redoStack.Pop();
                Interface.undoStack.Push(temp);
                CheckBoardManager.matrix[temp.Row][temp.Col].Text = temp.Num;
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (isNewGame == true)
                ChessBoard.PrintSolution();
            else MessageBox.Show("Bạn chưa bấm New Game", "Waring");
           
        }

        private void Sudoku_Load(object sender, EventArgs e)
        {

        }
        private int RanDomNumBer(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
        private void DelCell(int[,] matrix, int level)
        {
            int count = 0;   
            int x;
            int y;
            while (count < level)
            {
                x = RanDomNumBer(0, 9);
                y = RanDomNumBer(0, 9);
                if (matrix[x, y] != 0)
                {
                    matrix[x, y] = 0;
                    count++;
                    progressBar.Value++;
                }
                else if (matrix[y, x] != 0)
                {
                    matrix[y, x] = 0;
                    count++;
                    progressBar.Value++;
                }
            }
        }
        private void btnRender_Click(object sender, EventArgs e)
        {
            if (level != 0)
            {
                progressBar.Visible = true;
                progressBar.Value = 0;
                progressBar.MaximumValue = level;
                Interface.undoStack.Clear();
                Interface.undoStack.Clear();
                btnRedo.Enabled = true;
                btnUndo.Enabled = true;
                s.ResetMatrix(Solution.rootMatrix);
                s.ResetMatrix(CheckBoardManager.curMap);
                Solution.rootMatrix[0, 0] = RanDomNumBer(1, 9);
                Solution.rootMatrix[2, 7] = RanDomNumBer(1, 9);
                Solution.rootMatrix[7, 2] = RanDomNumBer(1, 9);
                Solution.rootMatrix[8, 8] = RanDomNumBer(1, 9);
                Solution.rootMatrix[4, 4] = RanDomNumBer(1, 9);
                s.Solve_Sodoku();
                DelCell(Solution.rootMatrix, level);
                if (progressBar.Value == level)
                {
                    ChessBoard.CreateNewMatrix();

                    progressBar.Visible = false;
                }
                level = 0;
                isNewGame = true;
            }
            else MessageBox.Show("Vui lòng chọn level trước khi bắt đầu.", "Waring");
        }



        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbbLevel.Text == "Test") level = 5;
            else if (cbbLevel.Text == "Easy") level = 24;
            else if (cbbLevel.Text == "Medium") level = 28;
            else if (cbbLevel.Text == "Hard") level = 37;
           
        }

      

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuThinButton23_Click(sender, e);
        }
    }
   
}
