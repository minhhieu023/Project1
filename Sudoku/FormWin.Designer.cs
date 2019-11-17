namespace Sudoku
{
    partial class FormWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbplayerName = new System.Windows.Forms.Label();
            this.lbTimePoint = new System.Windows.Forms.Label();
            this.btnContinue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSwicth = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnQuit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOU WIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // lbplayerName
            // 
            this.lbplayerName.AutoSize = true;
            this.lbplayerName.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbplayerName.Location = new System.Drawing.Point(174, 123);
            this.lbplayerName.Name = "lbplayerName";
            this.lbplayerName.Size = new System.Drawing.Size(70, 27);
            this.lbplayerName.TabIndex = 3;
            this.lbplayerName.Text = "Name";
            // 
            // lbTimePoint
            // 
            this.lbTimePoint.AutoSize = true;
            this.lbTimePoint.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimePoint.Location = new System.Drawing.Point(174, 173);
            this.lbTimePoint.Name = "lbTimePoint";
            this.lbTimePoint.Size = new System.Drawing.Size(60, 27);
            this.lbTimePoint.TabIndex = 4;
            this.lbTimePoint.Text = "Time";
            // 
            // btnContinue
            // 
            this.btnContinue.ActiveBorderThickness = 1;
            this.btnContinue.ActiveCornerRadius = 20;
            this.btnContinue.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnContinue.ActiveForecolor = System.Drawing.Color.White;
            this.btnContinue.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnContinue.BackColor = System.Drawing.SystemColors.Control;
            this.btnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinue.BackgroundImage")));
            this.btnContinue.ButtonText = "Continue";
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnContinue.IdleBorderThickness = 1;
            this.btnContinue.IdleCornerRadius = 20;
            this.btnContinue.IdleFillColor = System.Drawing.Color.White;
            this.btnContinue.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnContinue.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnContinue.Location = new System.Drawing.Point(46, 218);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(5);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnContinue.Size = new System.Drawing.Size(122, 47);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnSwicth
            // 
            this.btnSwicth.ActiveBorderThickness = 1;
            this.btnSwicth.ActiveCornerRadius = 20;
            this.btnSwicth.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSwicth.ActiveForecolor = System.Drawing.Color.White;
            this.btnSwicth.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSwicth.BackColor = System.Drawing.SystemColors.Control;
            this.btnSwicth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwicth.BackgroundImage")));
            this.btnSwicth.ButtonText = "Switch Acc";
            this.btnSwicth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwicth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwicth.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSwicth.IdleBorderThickness = 1;
            this.btnSwicth.IdleCornerRadius = 20;
            this.btnSwicth.IdleFillColor = System.Drawing.Color.White;
            this.btnSwicth.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSwicth.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSwicth.Location = new System.Drawing.Point(210, 218);
            this.btnSwicth.Margin = new System.Windows.Forms.Padding(5);
            this.btnSwicth.Name = "btnSwicth";
            this.btnSwicth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSwicth.Size = new System.Drawing.Size(122, 47);
            this.btnSwicth.TabIndex = 6;
            this.btnSwicth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSwicth.Click += new System.EventHandler(this.btnSwicth_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.ActiveBorderThickness = 1;
            this.btnQuit.ActiveCornerRadius = 20;
            this.btnQuit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnQuit.ActiveForecolor = System.Drawing.Color.White;
            this.btnQuit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnQuit.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.ButtonText = "Quit";
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnQuit.IdleBorderThickness = 1;
            this.btnQuit.IdleCornerRadius = 20;
            this.btnQuit.IdleFillColor = System.Drawing.Color.White;
            this.btnQuit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnQuit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnQuit.Location = new System.Drawing.Point(122, 275);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnQuit.Size = new System.Drawing.Size(122, 47);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FormWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(360, 347);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSwicth);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lbTimePoint);
            this.Controls.Add(this.lbplayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbplayerName;
        private System.Windows.Forms.Label lbTimePoint;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContinue;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSwicth;
        private Bunifu.Framework.UI.BunifuThinButton2 btnQuit;
    }
}