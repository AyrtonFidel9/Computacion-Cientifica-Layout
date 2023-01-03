using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class SuperficieV : Vector3D
    {
        double tipo; // identifica a la superficie
        double Rd;

        public SuperficieV(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {
        }

        public SuperficieV(double x0, double y0) : base(x0, y0)
        {
        }

        public SuperficieV(double x0, double y0, Color Color0) : base(x0, y0, Color0)
        {
        }

        public SuperficieV(Bitmap bits, PictureBox viewport, Color color) : base(bits, viewport, color)
        {
        }

        public SuperficieV(double x0, double y0, double z0) : base(x0, y0, z0)
        {
        }

        public SuperficieV(double x0, double y0, Bitmap bits, PictureBox viewport) : base(x0, y0, bits, viewport)
        {
        }

        public SuperficieV(double x0, double y0, Color Color0, Bitmap bits, PictureBox viewport) : base(x0, y0, Color0, bits, viewport)
        {
        }

        public SuperficieV(double x0, double y0, double z0, Bitmap bits, PictureBox viewport) : base(x0, y0, z0, bits, viewport)
        {
        }

        public double TIPO
        {
            set => this.tipo = value;
            get => this.tipo;
        }

        public double RD
        {
            set => this.Rd = value;
            get => this.Rd;
        }

        public override void encender()
        {
            Vector3D v = new Vector3D(BITS, VIEWPORT, COLOR0);

            if(tipo == 1)
            {
                double t = 0;
                double dt = 0.1; // no poner incrementos altos, para tener buenas superficienes y q no esten muy pegaos los vectores
                do
                {
                    double h = 0;
                    double dh = 0.15;
                    do
                    {
                        v.X0 = X0 + (Rd * Math.Cos(t));// X0, Y0, Z0, sirven para posicionar el elemento en el espacio 
                        v.Y0 = Y0 + (Rd * Math.Sin(t));
                        v.Z0 = Z0 + h;

                        v.encender();
                        h += dh;
                    }
                    while (h <= 4);
                    t += dt;
                }
                while (t <= 2 * Math.PI);
            }

            if (tipo == 2)
            {
                double t = -Math.PI/2;
                double dt = 0.1;
                do
                {
                    double h = 0;
                    double dh = 0.15;
                    do
                    {
                        v.X0 = X0 + (Rd * Math.Cos(t)*Math.Cos(h)); 
                        v.Y0 = Y0 + (Rd * Math.Cos(t)*Math.Sin(h));
                        v.Z0 = Z0 + (Rd * Math.Sin(t));

                        v.encender();
                        h += dh;
                    }
                    while (h <= (2*Math.PI));
                    t += dt;
                }
                while (t <= (Math.PI / 2));
            }

            if (tipo == 3)
            {
                double t = 0;
                double dt = 0.05;
                do
                {
                    double h = 0;
                    double dh = 0.05;
                    do
                    {
                        v.X0 = X0 + (Rd * (3+ Math.Cos(t)) * Math.Cos(h));
                        v.Y0 = Y0 + (Rd * (3+ Math.Cos(t)) * Math.Sin(h));
                        v.Z0 = Z0 + (Rd * Math.Sin(t));

                        v.encender();
                        h += dh;
                    }
                    while (h <= 2 * Math.PI);
                    t += dt;
                }
                while (t <= 2 * Math.PI);
            }

            if (tipo == 4)
            {
                double t = -2;
                double dt = 0.03;
                do
                {
                    double h = 0;
                    double dh = 0.03;
                    do
                    {
                        v.X0 = (Math.Cosh(t) * Math.Cos(h));
                        v.Y0 = (Math.Cosh(t) * Math.Sin(h));
                        v.Z0 = Math.Sinh(t);

                        v.encender();
                        h += dh;
                    }
                    while (h <= 2 * Math.PI);
                    t += dt;
                }
                while (t <= 2);
            }

            // epsilon tipo 5
            if(tipo == 5)
            {

            }
        }

    }
}
