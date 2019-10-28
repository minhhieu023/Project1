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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sudoku));
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.progressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btnRender = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUndo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRedo = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSolve = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnChessBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChessBoard.Controls.Add(this.progressBar);
            this.pnChessBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.pnChessBoard.Location = new System.Drawing.Point(13, 13);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(810, 810);
            this.pnChessBoard.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Silver;
            this.progressBar.BorderRadius = 5;
            this.progressBar.Location = new System.Drawing.Point(170, 383);
            this.progressBar.MaximumValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.Teal;
            this.progressBar.Size = new System.Drawing.Size(383, 43);
            this.progressBar.TabIndex = 0;
            this.progressBar.Value = 0;
            // 
            // btnRender
            // 
            this.btnRender.ActiveBorderThickness = 1;
            this.btnRender.ActiveCornerRadius = 20;
            this.btnRender.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRender.ActiveForecolor = System.Drawing.Color.White;
            this.btnRender.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRender.BackColor = System.Drawing.Color.SkyBlue;
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
            this.btnRender.Location = new System.Drawing.Point(95, 51);
            this.btnRender.Margin = new System.Windows.Forms.Padding(5);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(112, 47);
            this.btnRender.TabIndex = 13;
            this.btnRender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.BackgroundImage")));
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageActive = null;
            this.btnUndo.Location = new System.Drawing.Point(71, 231);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(58, 59);
            this.btnUndo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUndo.TabIndex = 12;
            this.btnUndo.TabStop = false;
            this.btnUndo.Zoom = 10;
            this.btnUndo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRedo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRedo.BackgroundImage")));
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.ImageActive = null;
            this.btnRedo.Location = new System.Drawing.Point(169, 231);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(58, 59);
            this.btnRedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRedo.TabIndex = 11;
            this.btnRedo.TabStop = false;
            this.btnRedo.Zoom = 10;
            this.btnRedo.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.SkyBlue;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Pause";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(95, 108);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(112, 47);
            this.bunifuThinButton23.TabIndex = 9;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.ActiveBorderThickness = 1;
            this.btnSolve.ActiveCornerRadius = 20;
            this.btnSolve.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSolve.ActiveForecolor = System.Drawing.Color.White;
            this.btnSolve.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSolve.BackColor = System.Drawing.Color.SkyBlue;
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
            this.btnSolve.Location = new System.Drawing.Point(95, 165);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(5);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(112, 47);
            this.btnSolve.TabIndex = 5;
            this.btnSolve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSolve.Click += new System.EventHandler(this.Button3_Click);
            // 
            // cbbLevel
            // 
            this.cbbLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbLevel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "Test",
            "Easy",
            "Medium",
            "Hard"});
            this.cbbLevel.Location = new System.Drawing.Point(71, 14);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(156, 29);
            this.cbbLevel.TabIndex = 0;
            this.cbbLevel.Text = "Chọn level ";
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.cbbLevel_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRender);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.btnSolve);
            this.panel1.Controls.Add(this.cbbLevel);
            this.panel1.Location = new System.Drawing.Point(822, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(821, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 237);
            this.panel2.TabIndex = 1;
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 832);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnChessBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Sudoku_Load);
            this.pnChessBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.ComboBox cbbLevel;
        private Bunifu.Framework.UI.BunifuProgressBar progressBar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSolve;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuImageButton btnRedo;
        private Bunifu.Framework.UI.BunifuImageButton btnUndo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

