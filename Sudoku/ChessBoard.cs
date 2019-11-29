using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class ChessBoard : Solution
    {
        #region Propeties
        private Panel chessBoard; //bảng game là 1 panel

        private int[,] curMap = new int[9, 9];
       
        private Cell cell;
        private static Stack<Cell> undoStack = new Stack<Cell>(); // 1 Stack chứa các CELL để undo
        private static Stack<Cell> redoStack = new Stack<Cell>();//1 Stack chứa các CELL để redo.
        private int oldCol = -1;
        private int oldRow = -1;

        private static List<List<Button>> matrix; //Khởi tạo 2 list lồng nhau(như 1 mảng 2 chiều), phần tử của list là các button.
        private Button btn; // Khai báo 1 button
        private static int curCol; //Vị trí hiện tại ứng với ma trận của khi trỏ vào button
        private static int curRow; //Vị trí hiện tại ứng với ma trận của khi trỏ vào button
        
        private InputPad inpuPad;
        public static bool isShow = false; //kiểm tra inputpad đã mở hay chưa

        private Point defaultPoint = new Point(0, 0);//Location mặc định, sử dụng để khởi tạo bảng game đầu tiên
       
        public Panel PnChessBoard
        {
            get => chessBoard;
            set => chessBoard = value;
        }
        #endregion
        #region Initialize
        public ChessBoard(Panel chessBoard)
        {
            this.PnChessBoard = chessBoard;
        }
        public ChessBoard()
        {

        }
        #endregion
        #region Methods
        #region LoadChessBoard
        //Khởi tạo 1 ma trận 9x9 gồm 81 Button. Ban đầu map có giá trị {0}
        public void LoadChessBoard()
        {
            matrix = new List<List<Button>>();
            for (int i = 0; i < 9; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < 9; j++)
                {
                    btn = new Button();
                    btn.Width = Const.Btn_Width;
                    btn.Height = Const.Btn_Height;
                    btn.Location = new Point(defaultPoint.X + Const.Btn_Width * j,
                        defaultPoint.Y + Const.Btn_Height * i);
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.Font = new Font("Times New Roman", 25);
                    btn.ForeColor = Color.Black;
                    btn.Enabled = false;
                    matrix[i].Add(btn);
                    PnChessBoard.Controls.Add(btn);

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
                }
            }
        }
        #endregion
        #region PrintSolution
        //Ứng dụng hàm giải ở class Solution để giải quyết bài toán khi gặp khó khăn.
        public void PrintSolution()
        {
            for (int i = 0; i < solveMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < solveMatrix.GetLength(0); j++)
                {
                    matrix[i][j].Text = solveMatrix[i, j].ToString();
                    matrix[i][j].ForeColor = Color.Blue;
                }
            }
        }
        #endregion
        #region AlwaysCheck
        //Liên tục kiểm tra các số được nhập vào
        //Nếu đúng có màu xanh
        //Sai thì có màu đỏ
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
                    if (isOK(temp, i, j, curMap) == 0)
                    {
                        curMap[i, j] = temp;
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
            Random r = new Random();
            ResetMatrix(rootMatrix);
            ResetMatrix(curMap);
            //reset static value and function
            rootMatrix[0, 0] = r.Next(1, 9);
            rootMatrix[2, 7] = r.Next(1, 9);
            rootMatrix[7, 2] = r.Next(1, 9);
            rootMatrix[8, 8] = r.Next(1, 9);
            rootMatrix[4, 4] = r.Next(1, 9);
            Solve_Sodoku();
         
        }
        public void DelCell(int level)
        {
            Random r = new Random();

            int count = 0;
            int x;
            int y;
            while (count < level)
            {
                x = r.Next(0, 9);
                y = r.Next(0, 9);
                if (rootMatrix[x, y] != 0)
                {
                    rootMatrix[x, y] = 0;
                    count++;
                    
                }
                else if (rootMatrix[y, x] != 0)
                {
                    rootMatrix[y, x] = 0;
                    count++;
                    
                }
            }
        }
        //Gán các sự kiện của button cho ma trận khi render các số.
        public void ResetEvent()
        {
           
            for (int i = 0; i <rootMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < rootMatrix.GetLength(0); j++)
                {
                    matrix[i][j].TextChanged -= Btn_TextChanged;
                    matrix[i][j].ResetText();
                    matrix[i][j].Enabled = true;
                    if (rootMatrix[i, j] != 0)
                    {
                        matrix[i][j].Text =rootMatrix[i, j].ToString();
                        matrix[i][j].ForeColor = Color.Black;
                        matrix[i][j].Enabled = false;
                    }
                    else matrix[i][j].TextChanged += Btn_TextChanged;
                    curMap[i, j] = rootMatrix[i, j];
                }
            }
           undoStack.Clear();
           redoStack.Clear();
        }

        #endregion
        #region Hint 
        //Cho phép người chơi shown giá trị đúng của 1 button
        public void Hint()
        {
            matrix[curRow][curCol].Text = solveMatrix[curRow, curCol].ToString();
            matrix[curRow][curCol].ForeColor = Color.Black;
        }
        #endregion
        #region Xữ lý số nhập vào từ 1 form khác
        public void ProcessInsertText(string curNumber) //Lấy giá trị từ bảng inputpab bỏ vào trong button và đồng thời bỏ nó vào trong Stack để undo
        {
            matrix[curRow][curCol].Text = curNumber;
            cell = new Cell(matrix[curRow][curCol].Text, curCol, curRow);
            undoStack.Push(cell);
        }
        #endregion
        #region Envent
        //Các event của button
        private void Btn_TextChanged(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            curCol = (btn.Location.X - defaultPoint.X) / Const.Btn_Width;
            curRow = (btn.Location.Y - defaultPoint.Y) / Const.Btn_Height;
            if (matrix[curRow][curCol].Text != " ")
            {
                int temp = Int32.Parse(matrix[curRow][curCol].Text);
                if (isOK(temp, curRow, curCol, curMap) == 1)
                {
                    btn.ForeColor = Color.Blue;
                }
                else btn.ForeColor = Color.Red;
                curMap[curRow, curCol] = temp;
                if (AlwaysCheckIsOK(curMap) == 1) //Khi tất cả đều điền đúng thì sẽ hiện thông báo đúng.
                {
                    Sudoku.stopwatch.Reset();
                    if (isShow == true)
                        this.inpuPad.Close();
                    
                    FormWin formWin = new FormWin();
                    formWin.ShowDialog();
                    formWin.ShowInTaskbar = false;
                }
            }
        }

        public void btn_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            curCol = (btn.Location.X - defaultPoint.X) / Const.Btn_Width;
            curRow = (btn.Location.Y - defaultPoint.Y) / Const.Btn_Height;

            if (isShow == true)
            {
                if (curRow == 8 || curRow == 7)
                {
                    inpuPad.Location = new Point(defaultPoint.X + 180 +
                        btn.Location.X, defaultPoint.Y - 120 + btn.Location.Y);
                }
                else
                    inpuPad.Location = new Point(defaultPoint.X + 180 +
                        btn.Location.X, defaultPoint.Y + 180 + btn.Location.Y);
                inpuPad.Focus();
            }
            else
            {
                inpuPad = new InputPad();
                inpuPad.Show();
                if (curRow == 8 || curRow == 7)
                {
                    inpuPad.Location = new Point(defaultPoint.X + 180 +
                        btn.Location.X, defaultPoint.Y - 120 + btn.Location.Y);
                }
                else
                    inpuPad.Location = new Point(defaultPoint.X + 180 +
                        btn.Location.X, defaultPoint.Y + 180 + btn.Location.Y);

                isShow = true;
            }
        }
        #region Undo, Redo
        public void Undo()
        {
            if (undoStack.Count != 0)
            {
                var temp = undoStack.Pop();
                curMap[temp.Row, temp.Col] = 0;
                redoStack.Push(temp);
                matrix[temp.Row][temp.Col].Text = temp.Num;
                if (oldRow != -1 && (oldCol != temp.Col || oldRow != temp.Row)
                    && oldCol != 1)
                    matrix[oldRow][oldCol].Text = " ";
                oldRow = temp.Row;
                oldCol = temp.Col;
            }
            else
            {
                if (oldCol != -1 && oldRow != -1)
                {
                    matrix[oldRow][oldCol].Text = " ";
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập số");
                }
            }
        }
        public void Redo()
        {
            if (redoStack.Count != 0)
            {
                var temp = redoStack.Pop();
                undoStack.Push(temp);
                matrix[temp.Row][temp.Col].Text = temp.Num;
            }
        }
        #endregion

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatStyle = FlatStyle.Flat;
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

