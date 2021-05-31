using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing.Imaging;

namespace tomogram_visualizer
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        bool needReload = false;

        Bin bin = new Bin();
        View view = new View();

        private int curWidth;
        private int curHeight;

        int currentLayer;
        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();

                trackBar1.Maximum = Bin.Z - 1;

                view.TFMin = trackBar2.Value;
                view.TFWidth = trackBar3.Value;
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (radioButton1.Checked )
                {
                    view.DrawQuads(currentLayer);
                    glControl1.SwapBuffers();
                }
                else if (radioButton2.Checked)
                {
                    if (needReload)
                    {
                        view.generateTextureImage(currentLayer);
                        view.Load2DTexture();
                        //needReload = false;
                    }
                    view.DrawTexture();
                    glControl1.SwapBuffers();
                }
                else if (radioButton3.Checked )
                {
                    view.DrawQuadsStrip(currentLayer);
                    glControl1.SwapBuffers();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;

            curWidth = this.Width;
            curHeight = this.Height;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps={0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }

            FrameCount++;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
            currentLayer = trackBar1.Value;
            needReload = true;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar2, trackBar2.Value.ToString());
            view.TFMin = trackBar2.Value;
            needReload = true;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar3, trackBar3.Value.ToString());
            view.TFWidth = trackBar3.Value;
            needReload = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            radioButton3.Checked = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
        }

    }
}
