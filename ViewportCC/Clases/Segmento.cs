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

        public override void encender()
        {
            double t = 0;
            double dt = 0.001;

            Vector v = new Vector(BITS, VIEWPORT, COLOR0);

            do
            {
                v.X0 = X0 + (xf - X0) * t;
                v.Y0 = Y0 + (yf - Y0) * t;
                v.encender();
                t += dt;
            }
            while (t <= 1);

        }
    }
}
