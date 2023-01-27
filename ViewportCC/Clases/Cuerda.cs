using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Cuerda : Vector
    {
        double t = 1;
        double l = 4;
        double c = 1;

        public double T { get => t; set => t = value; }

        public Cuerda(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {
        }

        public Cuerda(Bitmap bits, PictureBox viewport, Color color) : base(bits, viewport, color)
        {
        }

        public void graficarCuerda()
        {
            double h = 0;
            Vector v = new Vector(BITS, VIEWPORT, COLOR0);
            do
            {
                v.X0 = h;
                double fou = Fourier(h);
                v.Y0 = fou;
                v.encender();
                h += 0.001;
            } while (h <= 4);
        }

        public double Fourier(double x)
        {
            double ak, bk, sumF;
            double n;
            sumF = 0; n = 0;

            do
            {
                n++;
                ak = (2 / 3) * ( 0 + 4 * f(2) * Math.Sin(n * Math.PI/2) + f(4) * Math.Sin(n * Math.PI));
                ak *= 0.5;
                bk = (0.6666667) * ( 0 + 4 * g(2) * Math.Sin(n * Math.PI/2) + g(4) * Math.Sin(n * Math.PI));
                bk *= 2 / (n * Math.PI * c);
                sumF += (ak * Math.Cos((n * Math.PI * c * t) / 4) + 
                    bk * Math.Sin((n * Math.PI * c * t) / 4)) 
                    * Math.Sin(n * Math.PI * x / 4);
            }
            while (n <= 20);

            return sumF;
        }


        public double f(double x)
        {
            double res = (-x * (x - 4)) / 2;
            return res;
        }


        public double g(double x)
        {
            return x;
        }
    }
}
