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
        InpudPad inpuPad = new InpudPad();
        public Point p = new Point();
        private Panel chessBoard;
        public static bool isShow= false;
        public static List<List <Button>> matrix;
        public Button btn;
        public static int curRow;
        public static int curCol;
        public static bool flag;
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
                    btn.Font = new Font("Times New Roman", 16);
                    matrix[i].Add(btn);
                    ChessBoard.Controls.Add(btn);
                    btn.TextChanged += Btn_TextChanged;
                    btn.Click += btn_Click;              
                    btn.MouseMove += btn_MouseMove;
                    btn.MouseLeave += btn_MouseLeave;                  
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
                        btn.Enabled = false;
                                 
                    }                                    
                }
            }
        }

        private void Btn_TextChanged(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (matrix[curRow][curCol].Text != " ")
            {
                int temp = Int32.Parse(matrix[curRow][curCol].Text);
                if (Solution.isOK(temp, curRow, curCol) == 1)
                    btn.ForeColor = Color.Blue;
                else btn.ForeColor = Color.Red;
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
                inpuPad.Location = Cursor.Position;
                inpuPad.Focus();
             
            }
            else
            {
               
                inpuPad.Show();
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
      
        #endregion     
        #endregion

    }
}
