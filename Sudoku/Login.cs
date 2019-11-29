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
       
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
            btnRegister.Visible = false;
            
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
                        MessageBox.Show("Login successfully");
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
                        MessageBox.Show("Login failed");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something wrong");
                }
            }
        }

        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Focus();
            btnRegister.Visible = true;
            llbRegister.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=NguoiChoi;Integrated Security=True"))
            {
                try
                {
                    conn.Open();                
                    string sql = "Insert Into NguoiDung (TaiKhoan, MatKhau)";
                    sql += "Values (@TaiKhoan, @MatKhau)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TaiKhoan", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text);
                 //   cmd.Parameters.AddWithValue("@Point", null);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Done.");           
                    btnRegister.Visible = false;
                    llbRegister.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something wrong");
                }
            }
        }
    }
}
