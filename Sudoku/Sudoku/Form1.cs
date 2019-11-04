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
        ChessBoard chessBoard;
        Solution s = new Solution();
        private int level=0;
        int oldRow = -1;
        int oldCol = -1;
        private bool isNewGame = false;
        private TimeSpan elapsed;
        private readonly Stopwatch stopwatch = new Stopwatch();  
        private bool isPause = false;


        #endregion
        public Sudoku()
        {
            InitializeComponent();
            chessBoard = new ChessBoard(pnChessBoard);
            chessBoard.LoadChessBoard(Const.rootMatrix);
            progressBar.Visible = false;
            cbbLevel.Focus();
            btnSolve.Visible = false;
            btnPause.Visible = false;
            btnUndo.Visible = false;
            btnRedo.Visible = false;
            
        }


        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (Const.undoStack.Count != 0)
            {
                var temp = Const.undoStack.Pop();
                ChessBoard.curMap[temp.Row, temp.Col] = 0;
                Const.redoStack.Push(temp);
                ChessBoard.matrix[temp.Row][temp.Col].Text = temp.Num;
                if (oldRow != -1 && (oldCol != temp.Col || oldRow != temp.Row)
                    && oldCol != 1)
                    ChessBoard.matrix[oldRow][oldCol].Text = " ";
                oldRow = temp.Row;
                oldCol = temp.Col;
            }
            else
            {
                if (oldCol != -1 && oldRow != -1)
                {
                    ChessBoard.matrix[oldRow][oldCol].Text = " ";
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập số");
                }
            }

        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {

            if (Const.redoStack.Count != 0)
            {
                var temp = Const.redoStack.Pop();
                Const.undoStack.Push(temp);
                ChessBoard.matrix[temp.Row][temp.Col].Text = temp.Num;
            }

        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            if (isNewGame == true)
                chessBoard.PrintSolution();
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
                btnSolve.Visible = true;
                btnPause.Visible = true;
                btnUndo.Visible = true;
                btnRedo.Visible = true;
                progressBar.Visible = true;
                progressBar.Value = 0;
                progressBar.MaximumValue = level;
                Const.undoStack.Clear();
                Const.undoStack.Clear();
                oldCol = -1;
                oldRow = -1;
                s.ResetMatrix(Const.rootMatrix);
                s.ResetMatrix(ChessBoard.curMap);
                //reset static value and function
                Const.rootMatrix[0, 0] = RanDomNumBer(1, 9);
                Const.rootMatrix[2, 7] = RanDomNumBer(1, 9);
                Const.rootMatrix[7, 2] = RanDomNumBer(1, 9);
                Const.rootMatrix[8, 8] = RanDomNumBer(1, 9);
                Const.rootMatrix[4, 4] = RanDomNumBer(1, 9);
                //random pre_value;
                s.Solve_Sodoku();
                DelCell(Const.rootMatrix, level);
                //solved with pre_value and dell n value with level 
                if (progressBar.Value == level)
                {
                    chessBoard.CreateNewMatrix();

                    progressBar.Visible = false;
                }
                level = 0;
                isNewGame = true;
                timerPlay.Enabled = true;
                stopwatch.Restart();
            //    stopwatch.Start();
                lbTime.Visible = true; 

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
        private void timerPlay_Tick(object sender, EventArgs e)
        {

            elapsed = stopwatch.Elapsed;
            string text = "";
            text += elapsed.Hours.ToString("00") + ":" +
            elapsed.Minutes.ToString("00") + ":" +
            elapsed.Seconds.ToString("00");
            lbTime.Text = text;

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isPause == false)
            {
                stopwatch.Stop();
                timerPlay.Enabled = false;
                btnPause.ButtonText = "Resume";
                isPause = true;
                btnRender.Visible = false;
                btnSolve.Visible = false;
                btnUndo.Visible = false;
                btnRedo.Visible = false;
                pnChessBoard.Visible = false;
            }
            else
            {
                stopwatch.Start();
                timerPlay.Enabled = true;
                btnPause.ButtonText = "Pause";
                isPause = false;
                btnRender.Visible = true;
                btnSolve.Visible = true;
                btnUndo.Visible = true;
                btnRedo.Visible = true;
                pnChessBoard.Visible = true;
            }
        }

      
    }
   
}
