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
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.Location = new System.Drawing.Point(13, 13);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(913, 727);
            this.pnChessBoard.TabIndex = 0;
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 751);
            this.Controls.Add(this.pnChessBoard);
            this.Name = "Sudoku";
            this.Text = "Sudoku";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChessBoard;
    }
}

