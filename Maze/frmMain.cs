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

        List<Button> _buttons = new List<Button>();
        private void frmMain_Load(object sender, EventArgs e)
        {
            _buttons.Add(btnGenPrim);
            _buttons.Add(btnGenRec);
            sntHeight.Text = "10";
            sntWidth.Text = "10";
        }

        void ToggleButtonState(bool isEnabled)
        {
            _buttons.ForEach(item => item.Enabled = isEnabled);
        }

        private void btnGenRec_Click(object sender, EventArgs e)
        {
            VisualizeMaze(new MazeRec(Convert.ToInt32(sntWidth.Text), Convert.ToInt32(sntHeight.Text)));
        }

        private void btnGenPrim_Click(object sender, EventArgs e)
        {
            VisualizeMaze(new MazePrim(Convert.ToInt32(sntWidth.Text), Convert.ToInt32(sntHeight.Text)));
        }

        private void VisualizeMaze(Maze maze)
        {
            ToggleButtonState(false);
            List<Bitmap> progress = new List<Bitmap>();
            pbProgress.Visible = true;
            maze.ProgressChanged += (int done, int total) =>
            {
                progress.Add(maze.Visualize(new Size(8, 8)));
                pbProgress.Invoke((MethodInvoker)delegate()
                {
                    pbProgress.Value = (int)(((double)done / (double)total) * 100);
                });
            };
            new Thread(delegate()
            {
                maze.Generate();
            }) { IsBackground = true }.Start();

            maze.Completed += () =>
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
                        Thread.Sleep(50);
                    }
                    this.Invoke((MethodInvoker)delegate()
                    {
                        ToggleButtonState(true);
                    });
                }) { IsBackground = true }.Start();
            };
        }

    }
}