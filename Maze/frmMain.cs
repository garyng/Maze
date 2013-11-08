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
using System.Threading;

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

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            MazeRec mr = new MazeRec(50,50);
            List<Bitmap> progress = new List<Bitmap>();
            pbProgress.Visible = true;
            mr.ProgressChanged += (int done,int total) =>
            {
                progress.Add(mr.Visualize(new Size(8, 8)));
                pbProgress.Invoke((MethodInvoker)delegate()
                {
                    pbProgress.Value = (int)(((double)done / (double)total) * 100);
                });
            };
            new Thread(delegate()
            {
                mr.Generate();
            }) { IsBackground = true }.Start();

            mr.Completed += () =>
                {
                    pbProgress.Invoke((MethodInvoker)delegate()
                    {
                        pbProgress.Visible = false;
                    });
                    new Thread(delegate()
                    {
                        for (int i = 0; i < progress.Count; i++)
                        {
                            picVisual.Invoke((MethodInvoker)delegate()
                            {
                                picVisual.Image = progress[i];
                            });
                            Thread.Sleep(25);
                        }
                    }) { IsBackground = true }.Start();
                };
        }
    }
}