using System;
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
        private Panel chessBoard;
        Value value = new Value();       
        public Panel ChessBoard
        {
            get => chessBoard;
            set => chessBoard = value;
        }
        #endregion

        #region Initialize
        public CheckBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        #endregion

        #region Methods

        public void LoadChessBoard(int[,] map) 
        {
           

            for (int i = 0; i < map.GetLength(1); i++)
            {

              
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(defaultPoint.X + Cons.Btn_Width * j, defaultPoint.Y + Cons.Btn_Hight * i);
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.Font = new Font("Times New Roman", 16);
                    ChessBoard.Controls.Add(btn);
                    btn.Click += btn_Click;
                    btn.MouseMove += Btn_MouseMove;
                    btn.MouseLeave += Btn_MouseLeave;
                    if ((i == 0 || i == 1 || i == 2 || i == 7 || i == 8 || i == 6) &&
                        (j == 0 || j == 1 || j == 2 || j == 7 || j == 8 || j == 6) ||
                        (i == j) || (i == 3 || i == 4) && (j == 5 || j == 4) || (i == 5 || i == 4) 
                        && (j == 3 || j == 4))

                    {
                        btn.BackColor = Color.PaleTurquoise;
                                     
                    }
                    if (map[i, j] != 0)
                    {
                      
                        btn.Text = map[i, j].ToString();
                        
                        btn.ForeColor = Color.Black;
                      //  btn.Enabled = true;
                                 
                    }
                }
            }
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatStyle = FlatStyle.Popup;

        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
          
            int col = (btn.Location.X - defaultPoint.X) / Cons.Btn_Width;
            int row = (btn.Location.Y - defaultPoint.Y) / Cons.Btn_Hight;
            if (btn.Text != "")
                return;
            btn.Text = "1";
            int curvalue = Int32.Parse(btn.Text.ToString());
            if (value.isOK(curvalue, row, col) == 1)
                btn.ForeColor = Color.Blue;
            else btn.ForeColor = Color.Red;
                btn.Focus();
        }
        #endregion

    }
}
