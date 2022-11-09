using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Circulo : Vector
    {
        private double radio;
        public double RADIO { 
            set => this.radio = value; 
            get => this.radio;
        }

        public Circulo (Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {

        }

        public override void encender()
        {
            double t = 0;
            double dt = 0.001;

            Vector v = new Vector(BITS, VIEWPORT, COLOR0);

            do
            {
                v.X0 = X0 + (radio * Math.Cos(t));
                v.Y0 = Y0 + (radio * Math.Sin(t));
                v.encender();
                t += dt;
            }
            while (t <= 6.28);
        }
    }
}
