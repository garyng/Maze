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
            this.components = new System.ComponentModel.Container();
            this.pnlCon = new System.Windows.Forms.Panel();
            this.picVisual = new System.Windows.Forms.PictureBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlgo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblSelMet = new System.Windows.Forms.Label();
            this.cbSelMet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmsSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sntInterval = new System.Windows.Forms.ScrollNumText();
            this.sntCellHeight = new System.Windows.Forms.ScrollNumText();
            this.sntCellWidth = new System.Windows.Forms.ScrollNumText();
            this.sntHeight = new System.Windows.Forms.ScrollNumText();
            this.sntWidth = new System.Windows.Forms.ScrollNumText();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisual)).BeginInit();
            this.cmsSave.SuspendLayout();
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
            this.pnlCon.Location = new System.Drawing.Point(12, 121);
            this.pnlCon.Name = "pnlCon";
            this.pnlCon.Size = new System.Drawing.Size(425, 236);
            this.pnlCon.TabIndex = 2;
            // 
            // picVisual
            // 
            this.picVisual.ContextMenuStrip = this.cmsSave;
            this.picVisual.Location = new System.Drawing.Point(3, 3);
            this.picVisual.Name = "picVisual";
            this.picVisual.Size = new System.Drawing.Size(246, 142);
            this.picVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVisual.TabIndex = 1;
            this.picVisual.TabStop = false;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(12, 363);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(425, 25);
            this.pbProgress.TabIndex = 4;
            this.pbProgress.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Width : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Height : ";
            // 
            // cbAlgo
            // 
            this.cbAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgo.FormattingEnabled = true;
            this.cbAlgo.Location = new System.Drawing.Point(79, 60);
            this.cbAlgo.Name = "cbAlgo";
            this.cbAlgo.Size = new System.Drawing.Size(183, 21);
            this.cbAlgo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Algorithms :";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(282, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(155, 96);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblSelMet
            // 
            this.lblSelMet.AutoSize = true;
            this.lblSelMet.Location = new System.Drawing.Point(9, 82);
            this.lblSelMet.Name = "lblSelMet";
            this.lblSelMet.Size = new System.Drawing.Size(125, 26);
            this.lblSelMet.TabIndex = 13;
            this.lblSelMet.Text = "Cell Selection Method : \r\n( For Growing Tree Algo.)";
            // 
            // cbSelMet
            // 
            this.cbSelMet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelMet.FormattingEnabled = true;
            this.cbSelMet.Location = new System.Drawing.Point(140, 87);
            this.cbSelMet.Name = "cbSelMet";
            this.cbSelMet.Size = new System.Drawing.Size(123, 21);
            this.cbSelMet.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cell Height : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cell Width : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Interval (ms) : ";
            // 
            // cmsSave
            // 
            this.cmsSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.cmsSave.Name = "cmsSave";
            this.cmsSave.Size = new System.Drawing.Size(153, 48);
            // 
            // sntInterval
            // 
            this.sntInterval.Location = new System.Drawing.Point(215, 35);
            this.sntInterval.Max = 100;
            this.sntInterval.Min = 0;
            this.sntInterval.Name = "sntInterval";
            this.sntInterval.ShortcutsEnabled = false;
            this.sntInterval.Size = new System.Drawing.Size(32, 20);
            this.sntInterval.TabIndex = 20;
            this.sntInterval.Text = "0";
            this.sntInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sntCellHeight
            // 
            this.sntCellHeight.Location = new System.Drawing.Point(165, 35);
            this.sntCellHeight.Max = 32;
            this.sntCellHeight.Min = 0;
            this.sntCellHeight.Name = "sntCellHeight";
            this.sntCellHeight.ShortcutsEnabled = false;
            this.sntCellHeight.Size = new System.Drawing.Size(32, 20);
            this.sntCellHeight.TabIndex = 16;
            this.sntCellHeight.Text = "0";
            this.sntCellHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sntCellWidth
            // 
            this.sntCellWidth.Location = new System.Drawing.Point(165, 9);
            this.sntCellWidth.Max = 32;
            this.sntCellWidth.Min = 0;
            this.sntCellWidth.Name = "sntCellWidth";
            this.sntCellWidth.ShortcutsEnabled = false;
            this.sntCellWidth.Size = new System.Drawing.Size(32, 20);
            this.sntCellWidth.TabIndex = 15;
            this.sntCellWidth.Text = "0";
            this.sntCellWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sntHeight
            // 
            this.sntHeight.Location = new System.Drawing.Point(56, 35);
            this.sntHeight.Max = 20;
            this.sntHeight.Min = 0;
            this.sntHeight.Name = "sntHeight";
            this.sntHeight.ShortcutsEnabled = false;
            this.sntHeight.Size = new System.Drawing.Size(32, 20);
            this.sntHeight.TabIndex = 7;
            this.sntHeight.Text = "0";
            this.sntHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sntWidth
            // 
            this.sntWidth.Location = new System.Drawing.Point(56, 9);
            this.sntWidth.Max = 20;
            this.sntWidth.Min = 0;
            this.sntWidth.Name = "sntWidth";
            this.sntWidth.ShortcutsEnabled = false;
            this.sntWidth.Size = new System.Drawing.Size(32, 20);
            this.sntWidth.TabIndex = 6;
            this.sntWidth.Text = "0";
            this.sntWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save Maze";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 400);
            this.Controls.Add(this.sntInterval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSelMet);
            this.Controls.Add(this.sntCellHeight);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSelMet);
            this.Controls.Add(this.sntCellWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAlgo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sntHeight);
            this.Controls.Add(this.sntWidth);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.pnlCon);
            this.Name = "frmMain";
            this.Text = "Maze Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlCon.ResumeLayout(false);
            this.pnlCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisual)).EndInit();
            this.cmsSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCon;
        private System.Windows.Forms.PictureBox picVisual;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ScrollNumText sntWidth;
        private System.Windows.Forms.ScrollNumText sntHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlgo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblSelMet;
        private System.Windows.Forms.ComboBox cbSelMet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ScrollNumText sntCellHeight;
        private System.Windows.Forms.ScrollNumText sntCellWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ScrollNumText sntInterval;
        private System.Windows.Forms.ContextMenuStrip cmsSave;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

