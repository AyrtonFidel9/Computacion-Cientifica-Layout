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

        public virtual void Dibujar()
        {
            double t = 0;
            double dt = 0.001;

            double auxX0 = X0;
            double auxY0 = Y0;

            do
            {
                X0 = auxX0 + (radio * Math.Cos(t));
                Y0 = auxY0  + (radio * Math.Sin(t));
                encender();
               
                t += dt;
            }
            while (t <= 6.28);
        }
    }
}
