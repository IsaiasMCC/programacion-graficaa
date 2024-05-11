using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Estructura_Basica_Grafica.helper;
namespace Estructura_Basica_Grafica
{
    public class Escenario: IObject
    {
        public VectorThree center { get; set; }
        public Dictionary<string, Objeto> objects { get; set; }

        public Escenario(VectorThree center)
        {
            this.center = center;
            this.objects = new Dictionary<string, Objeto>();
        }

        public void Add(String key, Objeto Value)
        {
            this.objects.Add(key, Value);
        }
        public void Draw()
        {
            foreach (KeyValuePair<string, Objeto> objecto in objects)
            {
                objecto.Value.Draw();
            }
        }

        public void Scale(float size)
        {
            foreach (KeyValuePair<string, Objeto> objecto in objects)
            {
                objecto.Value.Scale(size, center);
            }
        }

        public void Translate(float x, float y, float z)
        {
            foreach (KeyValuePair<string, Objeto> objecto in objects)
            {
                objecto.Value.Translate(x, y, z);
            }
           
        }

        public void Rotate(float angle, float x, float y, float z)
        {
            foreach (KeyValuePair<string, Objeto> objecto in objects)
            {
                objecto.Value.Rotate(angle, x, y, z, center);
            }
        }

        public Objeto Get(string key)
        {
            Objeto value = null;
            foreach (KeyValuePair<string, Objeto> objeto in objects)
            {
                if (objeto.Key == key)
                {
                    value = objeto.Value;
                }
            }
            return value;
        }
        public void setCenter(float x, float y, float z)
        {
            this.center = new VectorThree(x, y, z);
        }

     
    }
}
