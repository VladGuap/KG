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

namespace Raytracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        View view = new View();
        
        
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            view.Draw();
            glControl1.SwapBuffers();
            GL.UseProgram(0);
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            
            view.InitShaders();
            view.InitBufferData();
        }
    }
}
