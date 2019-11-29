using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    //Đối tượng người chơi gồm tên, password và điểm ( tính bằng thời gian)
    class Player
    {
        private string playerName;
        private string passWord;
        private TimeSpan time;
        public string PlayerName { get => playerName; set => playerName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public Player()
        {

        }
    }
}
