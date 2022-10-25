using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Segmento : Vector
    {
        private double xf;
        private double yf;

        public double XF { set => this.xf = value; }
        public double YF { set => this.yf = value; }


        public Segmento (Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {

        }

        public void Dibujar()
        {
            double t = 0;
            double dt = 0.001;

            double auxX0 = X0;
            double auxY0 = Y0;

            do
            {
                X0 = auxX0 + (xf - auxX0) * t;
                Y0 = auxY0 + (yf - auxY0) * t;
                encender();
                t += dt;
            }
            while (t <= 1);
        }
    }
}
