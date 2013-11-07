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

        private void frmMain_Load(object sender, EventArgs e)
        {
            MazeRec mr = new MazeRec(10,10);
            mr.Visualize(new Size(8, 8));

            Bitmap b = new Bitmap(8, 8);
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.White);
            //g.DrawRectangle(Pens.Black, new Rectangle(0, 0, 7, 7));
            //g.DrawLine(Pens.White, new Point(0, 7), new Point(7, 7));

            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(0, 0, 7, 0); //-
            gp.AddLine(0, 0, 0, 7); //|
            gp.AddLine(0,7,7,7); //_
            gp.AddLine(7, 0, 7, 7);// |
            g.DrawPath(Pens.Black,gp);
        }
    }
}