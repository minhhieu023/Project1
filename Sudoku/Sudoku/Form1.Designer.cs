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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChessBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.pnChessBoard.Location = new System.Drawing.Point(13, 13);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(810, 810);
            this.pnChessBoard.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(829, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 376);
            this.panel1.TabIndex = 1;
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 842);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sudoku";
            this.Text = "Sudoku";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.Panel panel1;
    }
}

