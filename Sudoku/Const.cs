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
        public static int[,] rootMatrix = new int[9, 9] //Ma trận gốc ban đầu, ma trận gốc sẽ được random với những phần tử bị thiếu
            {
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0},
            };
        public static int[,] solveMatrix = new int[9, 9]; //Sau khi sử dụng hàm giải để giải ma trận thì 1 ma trận mới được sinh ra với đẩy đủ các số.
        public static Stack<Cell> undoStack = new Stack<Cell>(); // 1 Stack chứa các CELL để undo
        public static Stack<Cell> redoStack = new Stack<Cell>();//1 Stack chứa các CELL để redo.
        public static Player player = new Player(); //Khởi tạo 1 người chơi mới. Với điểm là thời gian của người chơi.
        public static Stopwatch stopwatch = new Stopwatch(); //Dùng để dếm thời gian và lấy nó làm điểm của người chơi.
        public static int[,] curMap = new int[9, 9]; //Ma trận được thay đổi khi người chơi nhập số vào
    }
}
