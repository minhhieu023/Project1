using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class InputPad : Form
    {
        public string curNumber;
        public bool isClick;
        public Point newPoint = new Point(0, 0);
        public Button btnNum;     
     //   public static string CurNumber { get => curNumber; set => curNumber = value; }
        ChessBoard chessBoard = new ChessBoard();

        public InputPad()
        {
            InitializeComponent();
            
            DrawInput();
            this.ShowInTaskbar = false;
        }
        void DrawInput()
        {
            int num = 1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    btnNum = new Button();
                    btnNum.Width = Const.Btn_InputPad;
                    btnNum.Height = Const.Btn_InputPad;
                    btnNum.Text = num.ToString();
                    btnNum.Location = new Point(newPoint.X + Const.Btn_InputPad*j, 
                    newPoint.Y + Const.Btn_InputPad*i);
                    num++;
                    btnNum.Click += BtnNum_Click;
                    this.Controls.Add(btnNum);                  
                }
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button btnNum = sender as Button;
            isClick = true;
        
            chessBoard.ProcessInsertText(btnNum.Text);
        }

 

        private void InpudPad_Load(object sender, EventArgs e)
        {

        }

        private void InpudPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChessBoard.isShow = false;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            chessBoard.Hint();
        }
    }
}
