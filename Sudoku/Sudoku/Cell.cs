using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Cell
    {
        private  string num;
        private  int row;
        private  int col;

     
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public string Num { get => num; set => num = value; }

        public Cell(string num, int col, int row)
        {
            this.col = col;      
            this.row = row;
            this.num = num;
        }
        
       
    }
}
