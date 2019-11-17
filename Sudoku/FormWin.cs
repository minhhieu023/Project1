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
    public partial class FormWin : Form
    {
        public FormWin()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            lbplayerName.Text = Const.player.PlayerName;
            string text = "";
            text += Const.player.Time.Hours.ToString("00") + ":" +
            Const.player.Time.Minutes.ToString("00") + ":" +
            Const.player.Time.Seconds.ToString("00");
            lbTimePoint.Text = text;
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();           
        }

        private void btnSwicth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
            
            this.ShowInTaskbar = false;
        }

        private void btnQuit_Click(object sender,EventArgs e)
        {

            if (MessageBox.Show("Are you sure want to exit?",
                "My First Application",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Information) == DialogResult.OK)
                Environment.Exit(1);
               
        }
    
    }
}
