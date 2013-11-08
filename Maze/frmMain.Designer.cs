namespace MazeGen
{
    partial class frmMain
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
            this.btnVisual = new System.Windows.Forms.Button();
            this.pnlCon = new System.Windows.Forms.Panel();
            this.picVisual = new System.Windows.Forms.PictureBox();
            this.pnlCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisual
            // 
            this.btnVisual.Location = new System.Drawing.Point(205, 12);
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Size = new System.Drawing.Size(75, 35);
            this.btnVisual.TabIndex = 1;
            this.btnVisual.Text = "Visualize";
            this.btnVisual.UseVisualStyleBackColor = true;
            this.btnVisual.Click += new System.EventHandler(this.btnVisual_Click);
            // 
            // pnlCon
            // 
            this.pnlCon.AutoScroll = true;
            this.pnlCon.Controls.Add(this.picVisual);
            this.pnlCon.Location = new System.Drawing.Point(12, 70);
            this.pnlCon.Name = "pnlCon";
            this.pnlCon.Size = new System.Drawing.Size(268, 184);
            this.pnlCon.TabIndex = 2;
            // 
            // picVisual
            // 
            this.picVisual.Location = new System.Drawing.Point(3, 3);
            this.picVisual.Name = "picVisual";
            this.picVisual.Size = new System.Drawing.Size(246, 142);
            this.picVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVisual.TabIndex = 1;
            this.picVisual.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.pnlCon);
            this.Controls.Add(this.btnVisual);
            this.Name = "frmMain";
            this.Text = "Maze";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlCon.ResumeLayout(false);
            this.pnlCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisual;
        private System.Windows.Forms.Panel pnlCon;
        private System.Windows.Forms.PictureBox picVisual;
    }
}

