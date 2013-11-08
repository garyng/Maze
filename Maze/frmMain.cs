using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MazeGen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        MazeRec mr = new MazeRec(10,10);
        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVisual_Click(object sender, EventArgs e)
        {
            picVisual.Image = mr.Visualize(new Size(32,32));
        }
    }
}