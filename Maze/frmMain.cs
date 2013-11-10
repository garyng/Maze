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
            "Prim's Algorithm",
            "Growing Tree Algorithm"
        };

        List<string> _cellSelMethod = new List<string>()
        {
            "Latest",
            "Oldest",
            "Random"
        };

        private void frmMain_Load(object sender, EventArgs e)
        {
            _controls.Add(sntHeight);
            _controls.Add(sntWidth);
            _controls.Add(btnGenerate);
            _controls.Add(cbAlgo);
            _controls.Add(cbSelMet);
            _controls.Add(sntCellHeight);
            _controls.Add(sntCellWidth);
            _controls.Add(sntInterval);

            sntHeight.Text = "10";
            sntWidth.Text = "10";

            sntCellWidth.Text = "8";
            sntCellHeight.Text = "8";

            sntInterval.Text = "50";

            _mazeAlgo.ForEach(item => cbAlgo.Items.Add(item));
            cbAlgo.SelectedIndex = 0;

            _cellSelMethod.ForEach(item => cbSelMet.Items.Add(item));
            cbSelMet.SelectedIndex = 0;
        }

        void ToggleButtonState(bool isEnabled)
        {
            _controls.ForEach(item => item.Enabled = isEnabled);
        }

        private void VisualizeMaze(Maze maze, int selectMethod = -1)
        {
            int interval = Convert.ToInt32(sntInterval.Text);
            Size cellSz = new Size(Convert.ToInt32(sntCellWidth.Text), Convert.ToInt32(sntCellHeight.Text));

            ToggleButtonState(false);
            List<Bitmap> progress = new List<Bitmap>();
            pbProgress.Visible = true;
            maze.ProgressChanged += (int done, int total) =>
            {
                progress.Add(maze.Visualize(cellSz));
                pbProgress.Invoke((MethodInvoker)delegate()
                {
                    pbProgress.Value = (int)(((double)done / (double)total) * 100);
                });
            };
            new Thread(delegate()
            {
                cbSelMet.Invoke((MethodInvoker)delegate()
                {
                    maze.SelectionMethod = cbSelMet.SelectedIndex;
                });
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
                        Thread.Sleep(interval);
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
                case 2:
                    VisualizeMaze(new MazeTree(Convert.ToInt32(sntWidth.Text), Convert.ToInt32(sntHeight.Text)),cbSelMet.SelectedIndex);
                    break;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "maze.png";
            sfd.Filter = "PNG|*PNG";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                picVisual.Image.Save(sfd.FileName, ImageFormat.Png);
            }
        }

    }
}