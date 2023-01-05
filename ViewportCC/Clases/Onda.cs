using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Onda : Vector
    {

        public double t;

        public Onda(double x0, double y0) : base(x0, y0)
        {
        }

        public Onda(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {
        }

        public Onda(double x0, double y0, Color Color0) : base(x0, y0, Color0)
        {
        }

        public Onda(Bitmap bits, PictureBox viewport, Color color) : base(bits, viewport, color)
        {
        }

        public Onda(double x0, double y0, Bitmap bits, PictureBox viewport) : base(x0, y0, bits, viewport)
        {
        }

        public Onda(double x0, double y0, Color Color0, Bitmap bits, PictureBox viewport) : base(x0, y0, Color0, bits, viewport)
        {
        }

        public void GrafO()
        {
            double x, y, z;
            double w = 1.1;
            double v = 9.3;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    double[] val = Vreal(i,j);
                    x = val[0];
                    y = val[1];
                    z = w * (Math.Sqrt(x * x + y * y)) - v * t;
                    z = Math.Sin(z) + 1;
                    int color = (int)(z * 7.5);
                    Color COLOR0 = Texturas.Grises()[color];
                    BITS.SetPixel(i,j, COLOR0);
                }
            }
            VIEWPORT.Image = BITS;
        }


        public void interferencia()
        {
            double x, y, z, z1, z2;
            double w = 1.2;
            double v = 9.3;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    double[] val = Vreal(i, j);
                    x = val[0];
                    y = val[1];
                    z1= w * (Math.Sqrt((x-0)*(x-0)+(y-3)*(y-3))) - (v * t);
                    z2= w * (Math.Sqrt((x-0)*(x-0)+(y+3)*(y+3))) - (v * t);
                    z1 = Math.Sin(z1)+1;
                    z2 = Math.Sin(z2)+1;
                    z = z1 + z2;
                    int color = (int)(z * 3.75);
                    Color COLOR0 = Texturas.Grises()[color];
                    BITS.SetPixel(i, j, COLOR0);
                }
            }
            VIEWPORT.Image = BITS;
        }

        public void interferencia3fuentes()
        {
            double x, y, z, z1, z2,z3;
            double w = 1.1;
            double v = 9.3;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    double[] val = Vreal(i, j);
                    x = val[0];
                    y = val[1];
                    z1 = w * (Math.Sqrt(((x - 0) * (x - 0)) + ((y - 3) * (y - 3)))) - (v * t);
                    z2 = w * (Math.Sqrt(((x - 0) * (x - 0)) + ((y + 3) * (y + 3)))) - (v * t);
                    z3 = w * (Math.Sqrt(((x + 1) * (x + 1)) + ((y + 2) * (y + 2)))) - (v * t);
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                    z = z1 + z2 + z3;
                    int color = (int)(z * 2.5);
                    Color COLOR0 = Utils.Paleta()[color];
                    BITS.SetPixel(i, j, COLOR0);
                }
            }
            VIEWPORT.Image = BITS;
        }
    }
}
