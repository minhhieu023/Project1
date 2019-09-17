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
        public 
        public void LoadChessBoard()
        {
            Button oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    if (j == 3 || j == 6)
                    {
                        if (i == 3)
                            btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + 2, oldbtn.Location.Y);
                        else
                            btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + 2, oldbtn.Location.Y);
                    }
                    else
                        btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.Btn_Hight);
                oldbtn.Width = 0;
                oldbtn.Height = 0;

            }
        }
        #endregion

    }
}
