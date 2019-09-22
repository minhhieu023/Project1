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
        private Panel chessBoard;
        public Panel ChessBoard
        { get => chessBoard;
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
            Button oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            for ( int i=0; i< map.GetLength(1); i++ )
            {
               
                for ( int j=0; j< map.GetLength(0); j++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    if (map[i, j] != 0)
                    {
                        btn.Text = map[i, j].ToString();
                        btn.Font = new Font("Times New Roman", 16);
                        
                        btn.Enabled = false;
                    }
                    btn.Click += btn_Click;
               
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.Btn_Hight);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = "ok";
            btn.Focus();

        }




        #endregion

    }
}
