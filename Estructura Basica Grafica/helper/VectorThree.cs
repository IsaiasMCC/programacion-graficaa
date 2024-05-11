using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Basica_Grafica.helper
{
    public class VectorThree
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public VectorThree(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public VectorThree() : this(0, 0, 0) { }
    }
}
