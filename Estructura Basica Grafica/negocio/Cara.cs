using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using Estructura_Basica_Grafica.helper;


namespace Estructura_Basica_Grafica
{
    public class Cara
    {
        public float width { get; set; }
        public float height { get; set; }
        public float depth { get; set; }
        public List<helper.VectorThree> vertices { get; set; }
        public Color color { get; set; }
        public Matrix4 matrixMain { get; set; }

       
        public Cara()
        {
            vertices = new List<helper.VectorThree>();
            color = new Color(0, 0, 0);
            matrixMain = Matrix4.Identity;
        }

        public Cara(float width, float height, float depth, List<helper.VectorThree> vertices, Color color)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.vertices = vertices;
            this.color = color;
            matrixMain = Matrix4.Identity;
        }
        public void Draw(VectorThree center)
        {
            SetColor();
            GL.Begin(PrimitiveType.Polygon);
            foreach (helper.VectorThree vertex in vertices)
            {
                Vector4 v4 = new Vector4(center.X + (vertex.X * width), center.Y + (vertex.Y * height), center.Z + (vertex.Z * depth), 1);
                Vector4 res = v4 * matrixMain;
                //v4 = Vector4.Transform(v4, matrixMain);
                GL.Vertex4(res);
            }
            GL.End();
        }
        public void SetColor()
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Color4(color.red, color.green, color.blue, 1);
        }

        public void Translate(float x, float y, float z)
        {
            matrixMain *= Matrix4.CreateTranslation(x, y, z);
        }
        public void Scale(float size, VectorThree center)
        {
            Matrix4 mTraslateOrigin = Matrix4.CreateTranslation(-center.X, -center.Y, -center.Z);
            Matrix4 mScale = Matrix4.CreateScale(size, size, size);
            Matrix4 mTraslate = Matrix4.CreateTranslation(center.X, center.Y, center.Z);
            matrixMain = mTraslateOrigin * mScale * mTraslate * matrixMain;
        }
        public void Rotate(float angle, float x, float y, float z, VectorThree center)
        {
            Matrix4 mTraslateOrigin = Matrix4.CreateTranslation(-center.X, -center.Y, -center.Z);
            Matrix4 mRotate = new Matrix4();
            if (x == 1)
            {
                mRotate = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angle));
            } else
            if (y == 1)
            {
                mRotate = Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angle));
            } else
            if (z == 1)
            {
                mRotate = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle));
            }
            Matrix4 mTraslate = Matrix4.CreateTranslation(center.X, center.Y, center.Z);
            matrixMain = mTraslateOrigin * mRotate * mTraslate * matrixMain;
        }

    }
}
