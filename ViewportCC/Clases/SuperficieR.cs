using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class SuperficieR : Vector3D
    {
        double tipo;
        double Fv;

        public SuperficieR(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {
        }

        public SuperficieR(double x0, double y0) : base(x0, y0)
        {
        }

        public SuperficieR(double x0, double y0, Color Color0) : base(x0, y0, Color0)
        {
        }

        public SuperficieR(Bitmap bits, PictureBox viewport, Color color) : base(bits, viewport, color)
        {
        }

        public SuperficieR(double x0, double y0, double z0) : base(x0, y0, z0)
        {
        }

        public SuperficieR(double x0, double y0, Bitmap bits, PictureBox viewport) : base(x0, y0, bits, viewport)
        {
        }

        public SuperficieR(double x0, double y0, Color Color0, Bitmap bits, PictureBox viewport) : base(x0, y0, Color0, bits, viewport)
        {
        }

        public SuperficieR(double x0, double y0, double z0, Bitmap bits, PictureBox viewport) : base(x0, y0, z0, bits, viewport)
        {
        }

        public double TIPO
        {
            set => this.tipo = value;
            get => this.tipo;
        }

        public double FV
        {
            set => this.Fv = value;
            get => this.Fv;
        }

        public override void encender()
        {
            Vector3D v = new Vector3D(BITS, VIEWPORT, COLOR0);
            if (tipo == 1)
            {
                double x = -6;
                double dx = 0.05;
                do
                {
                    double y = -4;
                    double dy = 0.1;
                    do
                    {
                        v.X0 = x;
                        v.Y0 = y;
                        v.Z0 = Fv * (Math.Pow(x, 2) + Math.Pow(y, 2)) - 4;
                        v.encender();
                        y += dy;
                    }
                    while (y <= 4);
                    x += dx;
                }
                while (x <= 6);
            }
            if (tipo == 2)
            {
                double x = -2.4;
                double dx = 0.03;
                do
                {
                    double y = -2;
                    double dy = 0.03;
                    do
                    {
                        v.X0 = x;
                        v.Y0 = y;
                        v.Z0 = Fv * (Math.Pow(y, 2) - Math.Pow(x, 2));
                        v.encender();
                        y += dy;
                    }
                    while (y <= 2);
                    x += dx;
                }
                while (x <= 2.4);
            }

            // epsilon 
            if(tipo == 3)
            {
                double x = -4;
                double dx = 0.05;
                do
                {
                    double y = -4;
                    double dy = 0.05;
                    do
                    {
                        v.X0 = x;
                        v.Y0 = y;
                        v.Z0 = Fv * (Math.Pow(Math.E, -(x*x+y*y)));
                        v.encender();
                        y += dy;
                    }
                    while (y <= 4);
                    x += dx;
                }
                while (x <= 4);
            }
        }
    }
}
