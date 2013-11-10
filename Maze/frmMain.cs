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

        List<Control> _controls = new List<Control>();
        List<string> _mazeAlgo = new List<string>()
        {
            "Recursive Backtracker",
            "Prim's Algorithm"
        };

        private void frmMain_Load(object sender, EventArgs e)
        {
            _controls.Add(sntHeight);
            _controls.Add(sntWidth);
            _controls.Add(btnGenerate);
            _controls.Add(cbAlgo);

            sntHeight.Text = "10";
            sntWidth.Text = "10";

            _mazeAlgo.ForEach(item => cbAlgo.Items.Add(item));
            cbAlgo.SelectedIndex = 0;
        }

        void ToggleButtonState(bool isEnabled)
        {
            _controls.ForEach(item => item.Enabled = isEnabled);
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
                    pbProgress.Value = 0;
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            switch (cbAlgo.SelectedIndex)
            {
                case 0:
                    VisualizeMaze(new MazeRec(Convert.ToInt32(sntWidth.Text), Convert.ToInt32(sntHeight.Text)));
                    break;
                case 1:
                    VisualizeMaze(new MazePrim(Convert.ToInt32(sntWidth.Text), Convert.ToInt32(sntHeight.Text)));
                    break;
            }
        }

    }
}