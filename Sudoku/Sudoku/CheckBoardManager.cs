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
        public void LoadChessBoard()
        {
            Button oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };          
            //TODO: Dòng 1
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Button btn = new Button();
                        btn.Width = Cons.Btn_Width;
                        btn.Height = Cons.Btn_Hight;
                        btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                         btn.Click += btn_Click;
                        ChessBoard.Controls.Add(btn);
                        oldbtn = btn;                       
                    }
                    oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.Btn_Hight);

                    oldbtn.Width = 0;
                    oldbtn.Height = 0;
                }
            //    oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.Btn_Hight);
            oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(Cons.Btn_Hight*3 +2, 0)
            };
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(Cons.Btn_Hight*3+2, Cons.Btn_Width + oldbtn.Location.Y);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
            oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(Cons.Btn_Hight * 6 + 4, 0)
            };
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(Cons.Btn_Hight * 6 + 4, Cons.Btn_Width + oldbtn.Location.Y);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
            //TODO: Dòng 2
            oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(0, Cons.Btn_Width*3 +2)
            };
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
    
                 
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.Btn_Hight);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
            oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(Cons.Btn_Hight * 3 + 2, Cons.Btn_Width*3 + 2)
            };
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(Cons.Btn_Hight * 3 + 2, Cons.Btn_Width + oldbtn.Location.Y);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
            oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(Cons.Btn_Hight * 6 + 4, Cons.Btn_Width * 3 + 2)
            };
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(Cons.Btn_Hight * 6 + 4, Cons.Btn_Width + oldbtn.Location.Y);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
            //TODO: Dòng 3
            oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(0, Cons.Btn_Width * 6 + 4)
            };
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.Btn_Hight);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }

            oldbtn.Width = 0;
            oldbtn.Location = new Point(Cons.Btn_Hight * 3 + 2, Cons.Btn_Width * 6 + 4);
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(Cons.Btn_Hight * 3 + 2, Cons.Btn_Width + oldbtn.Location.Y);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
            oldbtn = new Button()
            {
                Width = 0,
                Location = new Point(Cons.Btn_Hight * 6 + 4, Cons.Btn_Width * 6 +4)
            };
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.Btn_Width;
                    btn.Height = Cons.Btn_Hight;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(Cons.Btn_Hight * 6 + 4, Cons.Btn_Width + oldbtn.Location.Y);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;           
        }
        #endregion

    }
}
