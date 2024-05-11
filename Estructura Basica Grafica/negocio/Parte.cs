using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructura_Basica_Grafica.helper;


namespace Estructura_Basica_Grafica
{
    public class Parte
    {
        public VectorThree center { get; set; }
        public List<Cara> caras { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float depth { get; set; }
        public float size { get; set; }

        public Parte(VectorThree center, float width, float height, float depth, float size)
        {
            this.caras = new List<Cara>();
            this.center = center;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.size = size;
        }

        public void Draw()
        {
            foreach (Cara cara in caras)
            {
                cara.Draw(center);
            }
        }

        public void Scale(float size, VectorThree centerObj)
        {
            foreach (Cara cara in caras)
            {
                cara.Scale(size, centerObj);
            }
        }

        public void Translate(float x, float y, float z)
        {
            foreach (Cara cara in caras)
            {
                cara.Translate(x, y, z);
            }
        }

        public void Rotate(float angle, float x, float y, float z, VectorThree c)
        {
            foreach (Cara cara in caras)
            {
                cara.Rotate(angle, x, y, z, c);
            }
        }

        public void Add(Cara value)
        {
            this.caras.Add(value);
        }

        public void Remove(Cara cara)
        {
            this.caras.Remove(cara);
        }

        public void setCenter(float x, float y, float z)
        {
            this.center = new VectorThree(x, y, z);
        }
    }
}
