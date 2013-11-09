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
            this.pnlCon = new System.Windows.Forms.Panel();
            this.picVisual = new System.Windows.Forms.PictureBox();
            this.btnGenRec = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.btnGenPrim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sntHeight = new System.Windows.Forms.ScrollNumText();
            this.sntWidth = new System.Windows.Forms.ScrollNumText();
            this.pnlCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCon
            // 
            this.pnlCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCon.AutoScroll = true;
            this.pnlCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCon.Controls.Add(this.picVisual);
            this.pnlCon.Location = new System.Drawing.Point(12, 70);
            this.pnlCon.Name = "pnlCon";
            this.pnlCon.Size = new System.Drawing.Size(287, 189);
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
            // btnGenRec
            // 
            this.btnGenRec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenRec.Location = new System.Drawing.Point(225, 12);
            this.btnGenRec.Name = "btnGenRec";
            this.btnGenRec.Size = new System.Drawing.Size(75, 52);
            this.btnGenRec.TabIndex = 3;
            this.btnGenRec.Text = "Recursive Backtracker ";
            this.btnGenRec.UseVisualStyleBackColor = true;
            this.btnGenRec.Click += new System.EventHandler(this.btnGenRec_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(12, 265);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(287, 25);
            this.pbProgress.TabIndex = 4;
            this.pbProgress.Visible = false;
            // 
            // btnGenPrim
            // 
            this.btnGenPrim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenPrim.Location = new System.Drawing.Point(144, 12);
            this.btnGenPrim.Name = "btnGenPrim";
            this.btnGenPrim.Size = new System.Drawing.Size(75, 52);
            this.btnGenPrim.TabIndex = 5;
            this.btnGenPrim.Text = "Prim\'s Algorithm";
            this.btnGenPrim.UseVisualStyleBackColor = true;
            this.btnGenPrim.Click += new System.EventHandler(this.btnGenPrim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Height";
            // 
            // sntHeight
            // 
            this.sntHeight.Location = new System.Drawing.Point(50, 38);
            this.sntHeight.Max = 20;
            this.sntHeight.Min = 0;
            this.sntHeight.Name = "sntHeight";
            this.sntHeight.ShortcutsEnabled = false;
            this.sntHeight.Size = new System.Drawing.Size(32, 20);
            this.sntHeight.TabIndex = 7;
            this.sntHeight.Text = "10";
            this.sntHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sntWidth
            // 
            this.sntWidth.Location = new System.Drawing.Point(50, 9);
            this.sntWidth.Max = 20;
            this.sntWidth.Min = 0;
            this.sntWidth.Name = "sntWidth";
            this.sntWidth.ShortcutsEnabled = false;
            this.sntWidth.Size = new System.Drawing.Size(32, 20);
            this.sntWidth.TabIndex = 6;
            this.sntWidth.Text = "10";
            this.sntWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sntHeight);
            this.Controls.Add(this.sntWidth);
            this.Controls.Add(this.btnGenPrim);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnGenRec);
            this.Controls.Add(this.pnlCon);
            this.Name = "frmMain";
            this.Text = "Maze Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlCon.ResumeLayout(false);
            this.pnlCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCon;
        private System.Windows.Forms.PictureBox picVisual;
        private System.Windows.Forms.Button btnGenRec;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ScrollNumText sntWidth;
        private System.Windows.Forms.ScrollNumText sntHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenPrim;
    }
}

