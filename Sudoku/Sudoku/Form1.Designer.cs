namespace Sudoku
{
    partial class Sudoku
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sudoku));
            this.btnRender = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPause = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSolve = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.progressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnChessBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRender
            // 
            this.btnRender.ActiveBorderThickness = 1;
            this.btnRender.ActiveCornerRadius = 20;
            this.btnRender.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRender.ActiveForecolor = System.Drawing.Color.White;
            this.btnRender.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRender.BackColor = System.Drawing.Color.LightBlue;
            this.btnRender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRender.BackgroundImage")));
            this.btnRender.ButtonText = "New Game";
            this.btnRender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRender.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRender.IdleBorderThickness = 1;
            this.btnRender.IdleCornerRadius = 20;
            this.btnRender.IdleFillColor = System.Drawing.Color.White;
            this.btnRender.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRender.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRender.Location = new System.Drawing.Point(122, 117);
            this.btnRender.Margin = new System.Windows.Forms.Padding(5);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(122, 47);
            this.btnRender.TabIndex = 0;
            this.btnRender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnPause
            // 
            this.btnPause.ActiveBorderThickness = 1;
            this.btnPause.ActiveCornerRadius = 20;
            this.btnPause.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnPause.ActiveForecolor = System.Drawing.Color.White;
            this.btnPause.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPause.BackColor = System.Drawing.Color.LightBlue;
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.ButtonText = "Pause";
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPause.IdleBorderThickness = 1;
            this.btnPause.IdleCornerRadius = 20;
            this.btnPause.IdleFillColor = System.Drawing.Color.White;
            this.btnPause.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnPause.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPause.Location = new System.Drawing.Point(122, 174);
            this.btnPause.Margin = new System.Windows.Forms.Padding(5);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(122, 47);
            this.btnPause.TabIndex = 0;
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.ActiveBorderThickness = 1;
            this.btnSolve.ActiveCornerRadius = 20;
            this.btnSolve.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSolve.ActiveForecolor = System.Drawing.Color.White;
            this.btnSolve.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSolve.BackColor = System.Drawing.Color.LightBlue;
            this.btnSolve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSolve.BackgroundImage")));
            this.btnSolve.ButtonText = "Solve";
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSolve.IdleBorderThickness = 1;
            this.btnSolve.IdleCornerRadius = 20;
            this.btnSolve.IdleFillColor = System.Drawing.Color.White;
            this.btnSolve.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSolve.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSolve.Location = new System.Drawing.Point(122, 231);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(5);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(122, 47);
            this.btnSolve.TabIndex = 0;
            this.btnSolve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // cbbLevel
            // 
            this.cbbLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbLevel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "Test",
            "Easy",
            "Medium",
            "Hard"});
            this.cbbLevel.Location = new System.Drawing.Point(104, 60);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(160, 35);
            this.cbbLevel.TabIndex = 0;
            this.cbbLevel.Text = "Chọn level ";
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.cbbLevel_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 201);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnRender);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnSolve);
            this.panel1.Controls.Add(this.cbbLevel);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 359);
            this.panel1.TabIndex = 0;
            // 
            // btnRedo
            // 
            this.btnRedo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRedo.BackgroundImage")));
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRedo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Location = new System.Drawing.Point(199, 286);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(65, 64);
            this.btnRedo.TabIndex = 14;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.BackgroundImage")));
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Location = new System.Drawing.Point(104, 286);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 64);
            this.btnUndo.TabIndex = 13;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 630);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 1000;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(85, 207);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(182, 50);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "00:00:00";
            this.lbTime.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(829, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 807);
            this.panel3.TabIndex = 1;
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChessBoard.Controls.Add(this.progressBar);
            this.pnChessBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.pnChessBoard.Location = new System.Drawing.Point(12, 13);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(810, 810);
            this.pnChessBoard.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Silver;
            this.progressBar.BorderRadius = 5;
            this.progressBar.Location = new System.Drawing.Point(207, 386);
            this.progressBar.MaximumValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.Teal;
            this.progressBar.Size = new System.Drawing.Size(383, 43);
            this.progressBar.TabIndex = 0;
            this.progressBar.Value = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(810, 810);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 832);
            this.Controls.Add(this.pnChessBoard);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Sudoku_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnChessBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbLevel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSolve;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPause;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnChessBoard;
        private Bunifu.Framework.UI.BunifuProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
    }
}

