using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracing
{
    class View
    {
        int BasicProgramID;
        int BasicVertexShader;
        int BasicFragmentShader;
        int vbo_position;
        Vector3[] vertdata;
        public void loadShader(String filename, ShaderType type, int program, out int address)
        {
            address = GL.CreateShader(type);
            using (System.IO.StreamReader sr=new StreamReader(filename))
            {
                GL.ShaderSource(address, sr.ReadToEnd());
            }
            GL.CompileShader(address);
            GL.AttachShader(program, address);
            Console.WriteLine(GL.GetShaderInfoLog(address));
        }
        public void InitShaders()
        {
            BasicProgramID = GL.CreateProgram();
            loadShader("..\\..\\raytracing.vert", ShaderType.VertexShader, BasicProgramID, out BasicVertexShader);
            loadShader("..\\..\\raytracing.frag", ShaderType.FragmentShader, BasicProgramID, out BasicFragmentShader);
            GL.LinkProgram(BasicProgramID);
            int status = 0;
            GL.GetProgram(BasicProgramID, GetProgramParameterName.LinkStatus, out status);
            Console.WriteLine(GL.GetProgramInfoLog(BasicProgramID));
        }
        public void InitBufferData()
        {
            vertdata = new Vector3[]
            {
                new Vector3(-1f,-1f,0f),
                new Vector3(1f,-1f,0f),
                new Vector3(1f,1f,0f),
                new Vector3(-1f,1f,0f) };
            GL.GenBuffers(1, out vbo_position);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer, (IntPtr)(vertdata.Length * Vector3.SizeInBytes), vertdata, BufferUsageHint.StaticDraw);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.UseProgram(BasicProgramID);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
        }
        public void Draw()
        {
            GL.ClearColor(Color.AliceBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();
            GL.UseProgram(BasicProgramID);
            GL.DrawArrays(PrimitiveType.Quads, 0, 4);
            
            
        }
    }
}
