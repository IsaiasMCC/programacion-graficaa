using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Basica_Grafica
{
    public class Color
    {
        public double red { get; set; }
        public double green { get; set; }
        public double blue { get; set; }

        public Color(double red, double green, double blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

    }
}
