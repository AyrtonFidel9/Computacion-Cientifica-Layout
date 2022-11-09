using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Epicicloide : Circulo
    {

        private double radio2;

        public double RADIO2
        {
            set => this.radio2 = value;
            get => this.radio2;
        }

        public Epicicloide(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {

        }

        public override void encender()
        {

            double t = 0;
            double dt = 0.001;


            double limite = 25 * Math.PI;

            Vector v = new Vector(BITS, VIEWPORT, COLOR0);

            do
            {                                
                v.X0 = (RADIO + radio2) * Math.Cos(t) + radio2 * Math.Cos(t * (1 + (RADIO / radio2)));
                v.Y0 = (RADIO + radio2) * Math.Sin(t) + radio2 * Math.Sin(t * (1 + (RADIO / radio2)));
                int r = (int)Utils.interpolar2Puntos(v.X0, -2*RADIO, 255, 2*RADIO, 0);
                int g = (int)Utils.interpolar2Puntos(v.X0, -2*RADIO, 255, 2*RADIO, 255);
                int b = (int)Utils.interpolar2Puntos(v.X0, -2*RADIO, 0.0, 2*RADIO, 0);

                if (r < 0 || g < 0|| b < 0 || r > 255 || g > 255 || b > 255)
                {
                    r = 10;
                    g = 20;
                    b = 30;
                }

                v.COLOR0 = Color.FromArgb(r, g, b);
                v.encender();
                t += dt;
            }
            while (t <= limite);


        }
    }
}
