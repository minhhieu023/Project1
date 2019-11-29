using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class Const
    {
        public static int Btn_Width = 90; //Gán kích thước của btn trong Panel
        public static int Btn_Height = 90; //Gán kích thước của btn trong Panel
        public static int Btn_InputPad = 50; //Gán kích thước của btn trong form Inputpad 

        public static Player player = new Player(); //Khởi tạo 1 người chơi mới. Với điểm là thời gian của người chơi.
        //Dùng để dếm thời gian và lấy nó làm điểm của người chơi.    
    }
}
