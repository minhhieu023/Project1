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

        #region Value
        ChessBoard chessBoard;      
        //Solution s = new Solution();
        private int level = 0;
        public static Stopwatch stopwatch = new Stopwatch();
        private bool isNewGame = false;  //Biến bool kiểm tra đã bấm NewGame hay chưa     
      //  public readonly Stopwatch stopwatch = new Stopwatch();  
        private bool isPause = false;
        #endregion
        public Sudoku()
        {
            InitializeComponent();
           
            chessBoard = new ChessBoard(pnChessBoard);
            chessBoard.LoadChessBoard();
            lbName.Text = Const.player.PlayerName;
           
            progressBar.Visible = false;
            cbbLevel.Focus();
            btnSolve.Visible = false;
            btnPause.Visible = false;
            btnUndo.Visible = false;
            btnRedo.Visible = false;          
        }
        #region Event
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            chessBoard.Undo();

        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {

            chessBoard.Redo();

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

            private void btnRender_Click(object sender, EventArgs e)
            {
                if (level != 0)
                {
                    btnSolve.Visible = true;
                    btnPause.Visible = true;
                    btnUndo.Visible = true;
                    btnRedo.Visible = true;
                    //progressBar.Visible = true;
                    //progressBar.Value = 0;
                    //progressBar.MaximumValue = level;
                    chessBoard.CreateNewMatrix();
                    chessBoard.DelCell(level);
                    //progressBar.Value = level;
                    ////solved with pre_value and dell n value with level 
                    //if (progressBar.Value == level)
                    //{
                        chessBoard.ResetEvent();
                       
                    //    progressBar.Visible = false;
                    //}
                    level = 0;
                    isNewGame = true;
                    timerPlay.Enabled = true;
                    stopwatch.Restart();        
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
            Const.player.Time = stopwatch.Elapsed;
            string text = "";
            text += Const.player.Time.Hours.ToString("00") + ":" +
            Const.player.Time.Minutes.ToString("00") + ":" +
            Const.player.Time.Seconds.ToString("00");
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
        #endregion
    }
}
