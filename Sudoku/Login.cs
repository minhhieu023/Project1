using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Sudoku
{
    public partial class Login : Form
    {
       // Player player = new Player();
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=NguoiChoi;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string tk = txtUsername.Text;
                    string mk = txtPassword.Text;
                    string sql = "select * from NguoiDung where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MessageBox.Show("Dang Nhap Thanh Cong");
                        Const.player.PlayerName = tk;
                        Const.player.PassWord = mk; 
                        Sudoku frm = new Sudoku();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                        this.ShowInTaskbar = false;

                    }
                    else
                    {
                        MessageBox.Show("Dang Nhap That bai");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("loi ket noi");
                }
            }
        }

    }
}
