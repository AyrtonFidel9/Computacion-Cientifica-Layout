using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Onda : Vector
    {

        public double t;
        public double w;
        public double v;
        public double m;

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


        public void Onda3D()
        {
            double x, y, z, d, i, j;

           
            x = -9;
            do
            {
                y = -6.5;
                do
                {
                    Vector3D vector3D = new Vector3D(x, y, COLOR0, BITS, VIEWPORT);
                    d = Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));
                    z = w * (d - (t * v));
                    z = (m) * Math.Sin(z) + 1;
                    vector3D.X0 = x; 
                    vector3D.Y0 = y;
                    vector3D.Z0 = z;
                    vector3D.encender();

                    y += 0.1;

                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }

        public void Lamina3D()
        {
            double x, y, z, d, i, j;


            x = -9;
            do
            {
                y = -6.5;
                do
                {
                    Vector3D vector3D = new Vector3D(x, y, COLOR0, BITS, VIEWPORT);
                    d = (x * 0) + (y*2);
                    z = w * (d - (t * v));
                    z = (m) * Math.Sin(z);
                    vector3D.X0 = x;
                    vector3D.Y0 = y;
                    vector3D.Z0 = z;
                    vector3D.encender();

                    y += 0.1;

                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }

        public void Interferencia3D_2f()
        {
            double x, y, z1, d1, d2, z2;



            x = -9;
            do
            {
                y = -6.5;
                do
                {
                    Vector3D vector3D = new Vector3D(x, y, COLOR0, BITS, VIEWPORT);
                    d1 = Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3));
                    z1 = w * (d1 - (t * v));
                    z1 = (m) * Math.Sin(z1);

                    d2 = Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3));
                    z2 = w * (d2 - (t * v));
                    z2 = (m) * Math.Sin(z2);

                    vector3D.X0 = x;
                    vector3D.Y0 = y;
                    vector3D.Z0 = z1 + z2;

                    vector3D.encender();

                    y += 0.1;

                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }

        public void Interferencia3D_3f()
        {
            double x, y, z1, d1, d2, z2, d3, z3;



            x = -9;
            do
            {
                y = -6.5;
                do
                {
                    Vector3D vector3D = new Vector3D(x, y, COLOR0, BITS, VIEWPORT);
                    d1 = Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3));
                    z1 = w * (d1 - (t * v));
                    z1 = (m) * Math.Sin(z1);

                    d2 = Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3));
                    z2 = w * (d2 - (t * v));
                    z2 = (m) * Math.Sin(z2);

                    d3 = Math.Sqrt((x - 2) * (x - 2) + (y - 4) * (y - 4));
                    z3 = w * (d3 - (t * v)); 
                    z3 = (m) * Math.Sin(z3);

                    vector3D.X0 = x;
                    vector3D.Y0 = y;
                    vector3D.Z0 = z1 + z2 + z3;

                    vector3D.encender();

                    y += 0.1;

                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }


        public void ExamenP3 ()
        {
            //double x, y, z1, d1, d2, z2, d3, z3;



            //x = -9;
            //do
            //{
            //    y = -6.5;
            //    do
            //    {
            //        Vector3D vector3D = new Vector3D(x, y, COLOR0, BITS, VIEWPORT);
            //        for (int i = -6; i < 5; i++)
            //        {
            //            d1 = Math.Sqrt((x + i) * (x + i) + (y + i) * (y - i));
            //            z1 = w * (d1 - (t * v));
            //            z1 = (m) * Math.Sin(z1);
            //            vector3D.Z0 += z1;
            //        }


            //        vector3D.X0 = x;
            //        vector3D.Y0 = y;

            //        vector3D.encender();

            //        y += 0.1;

            //    } while (y <= 6.5);
            //    x += 0.1;
            //} while (x <= 9);

            //double x, y, z = 0, z1, z2, z3;
            //double w = 1.1;
            //double v = 9.3;
            //for (int i = 0; i < 700; i++)
            //{
            //    for (int j = 0; j < 500; j++)
            //    {
            //        double[] val = Vreal(i, j);
            //        x = val[0];
            //        y = val[1];

            //        for (int k = -6; k < 5; k++)
            //        {
            //            z1 = w * (Math.Sqrt(((x + k) * (x + k)) + ((y + k) * (y + k)))) - (v * t);
            //            z1 = Math.Sin(z1) + 1;
            //            z += z1;

            //        }

            //        Debug.WriteLine(z);
            //        int color = (int)(z * 0.68);
            //        if (color < 16)
            //        {
            //            Debug.WriteLine(color);
            //            Color COLOR0 = Utils.Paleta()[color];
            //            BITS.SetPixel(i, j, COLOR0);

            //        }
            //    }
            //}
            //VIEWPORT.Image = BITS;

            double x, y, z, z1, z2, z3, z4, z5, z6, z7, z8, z9, z10, z11;
            double w = 1.1;
            double v = 9.3;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    double[] val = Vreal(i, j);
                    x = val[0];
                    y = val[1];
                    z1 = w * (Math.Sqrt(((x - 6) * (x - 6)) + ((y - 6) * (y - 6)))) - (v * t);
                    z2 = w * (Math.Sqrt(((x - 5) * (x - 5)) + ((y - 5) * (y - 5)))) - (v * t);
                    z3 = w * (Math.Sqrt(((x - 4) * (x - 4)) + ((y - 4) * (y - 4)))) - (v * t);
                    z4 = w * (Math.Sqrt(((x - 3) * (x - 3)) + ((y - 3) * (y - 3)))) - (v * t);
                    z5 = w * (Math.Sqrt(((x - 2) * (x - 2)) + ((y - 2) * (y - 2)))) - (v * t);
                    z6 = w * (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)))) - (v * t);
                    z7 = w * (Math.Sqrt(((x + 0) * (x + 0)) + ((y + 0) * (y + 0)))) - (v * t);
                    z8 = w * (Math.Sqrt(((x + 1) * (x + 1)) + ((y + 1) * (y + 1)))) - (v * t);
                    z9 = w * (Math.Sqrt(((x + 2) * (x + 2)) + ((y + 2) * (y + 2)))) - (v * t);
                    z10 = w * (Math.Sqrt(((x + 3) * (x + 3)) + ((y + 3) * (y + 3)))) - (v * t);
                    z11 = w * (Math.Sqrt(((x + 4) * (x + 4)) + ((y + 4) * (y + 4)))) - (v * t);

                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                    z4 = Math.Sin(z4) + 1;
                    z5 = Math.Sin(z5) + 1;
                    z6 = Math.Sin(z6) + 1;
                    z7 = Math.Sin(z7) + 1;
                    z8 = Math.Sin(z8) + 1;
                    z9 = Math.Sin(z9) + 1;
                    z10 = Math.Sin(z10) + 1;
                    z11 = Math.Sin(z11) + 1;

                    z = z1 + z2 + z3 + z4 +z5 + z6 + z7+ z8 +z9 +z10 +z11;
                    int color = (int)(z * 0.68);
                    Color COLOR0 = Utils.Paleta()[color];
                    BITS.SetPixel(i, j, COLOR0);
                }
            }
            VIEWPORT.Image = BITS;
        }

    }


}

