using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class Feature
    {
        private Panel inputPad;      
        public Panel InputPad
        {
            get => inputPad;
            set => inputPad = value;
        }
        public Feature ( Panel inputPad)
        {
            this.InputPad = inputPad;
        }
        public void LoadInputPad()
        {
            for ( int i =0;  i< 9; i ++)
            {
                Button btnNumber = new Button()
                {
                  Width = 50,
                  Height = 50,
                  Text = (i + 1).ToString()
                };
                InputPad.Controls.Add(btnNumber);
            }
        }
    }
}
