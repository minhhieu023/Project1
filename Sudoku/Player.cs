using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Player
    {
        private string playerName;
        private string passWord;
        private DateTime dateTime;

        public string PlayerName { get => playerName; set => playerName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
    }
}
