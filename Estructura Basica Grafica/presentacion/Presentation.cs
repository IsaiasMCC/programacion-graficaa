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
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Estructura_Basica_Grafica.presentacion
{
    
    public partial class Presentation : Form
    {
        GLControl glControl;


        private void Presentation_Load(object sender, EventArgs e)
        {
            this.glControl = new GLControl();
            this.glControl.BackColor = System.Drawing.Color.CadetBlue;
            this.glControl.Location = new System.Drawing.Point(450, 0);
            this.glControl.Name = "glControl1";
            this.glControl.Size = new System.Drawing.Size(this.Width - 470, this.Height - 44);//(780, this.Height);
            this.glControl.TabIndex = 1;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.Resize += new System.EventHandler(glControl_Resize);
            this.Controls.Add(this.glControl);
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            GL.Enable(EnableCap.DepthTest);


        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            //GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            glControl.MakeCurrent();
            //-----------------------
            escenario.Draw();
            //-----------------------
            glControl.Invalidate();
            glControl.SwapBuffers();
        }

        private void glControl_Resize(object sender, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            int w = glControl.Width;
            int h = glControl.Height;
            float d = 1.5f;
            GL.Viewport(0, 0, w, h);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-70, 70, -70, 70, 5, 50);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            glControl.Invalidate();
        }

       

       
    }
}
