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
    public partial class Sudoku : Form
    {
        #region Properties
        CheckBoardManager ChessBoard;

        int oldRow = -1;
        int oldCol = -1;
        #endregion
        public Sudoku()
        { 
            InitializeComponent();          
            ChessBoard = new CheckBoardManager(pnChessBoard);
            ChessBoard.LoadChessBoard(Solution.matrix);           
        }

        private void Sudoku_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (Interface.undoStack.Count != 0)
            { 
               var temp = Interface.undoStack.Pop();
                Interface.redoStack.Push(temp);
                CheckBoardManager.matrix[temp.Row][temp.Col].Text = temp.Num;
                if (oldRow != -1 && (oldCol != temp.Col || oldRow != temp.Row)
                    && oldCol != 1)
                    CheckBoardManager.matrix[oldRow][oldCol].Text = " ";
                oldRow = temp.Row;
                oldCol = temp.Col;
            }
            else
                CheckBoardManager.matrix[oldRow][oldCol].Text = " ";

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (Interface.redoStack.Count != 0)
            {
                var temp = Interface.redoStack.Pop();
                Interface.undoStack.Push(temp);
                CheckBoardManager.matrix[temp.Row][temp.Col].Text = temp.Num;          
            }
            else
                CheckBoardManager.matrix[oldRow][oldCol].Text = " ";
        }
    }
}
