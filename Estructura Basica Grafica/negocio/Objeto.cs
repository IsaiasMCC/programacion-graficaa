using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Estructura_Basica_Grafica.helper;


namespace Estructura_Basica_Grafica
{
    public class Objeto: IObject
    {
        public VectorThree center { get; set; }
        public Dictionary<string, Parte> parts { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float depth { get; set; }
        public float size { get; set; }

        public Objeto(VectorThree center, float width, float height, float depth, float size)
        {
            this.center = center;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.size = size;
            this.parts = new Dictionary<string, Parte>();
        }

        public void Draw()
        {
            foreach (KeyValuePair<string, Parte> part in parts)
            {
                part.Value.Draw();
            }
        }

        public void Scale(float size, VectorThree centerEsc)
        {
            foreach (KeyValuePair<string, Parte> parte in parts)
            {
                parte.Value.Scale(size, centerEsc);
            }
        }

        public void Translate(float x, float y, float z)
        {
            foreach (KeyValuePair<string, Parte> parte in parts)
            {
                parte.Value.Translate(x, y, z);
            }
           
        }

        public void Rotate(float angle, float x, float y, float z, VectorThree c)
        {
            foreach (KeyValuePair<string, Parte> parte in parts)
            {
                parte.Value.Rotate(angle, x, y, z, c);
            }
        }

        public void Add(string key, Parte value)
        {
            this.parts.Add(key, value);
        }

        public Parte Get(string key)
        {
            Parte value = null;
            foreach (KeyValuePair<string, Parte> objeto in parts)
            {
                if (objeto.Key == key)
                {
                    value = objeto.Value;
                }
            }
            return value;
        }

        public void Remove(string key)
        {
            this.parts.Remove(key);
        }
        public void setCenter(float x, float y, float z)
        {
            this.center = new VectorThree(x, y, z);
        }

    }
}
