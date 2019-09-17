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
        #endregion
        public Sudoku()
        {
            InitializeComponent();
            ChessBoard = new CheckBoardManager(pnChessBoard);
            ChessBoard.LoadChessBoard();
        }
       
    }
}
