using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Utils
    {

        public static double interpolar2Puntos(double x, double x1, double y1, double x2, double y2)
        {
            return (y1 * ((x - x2) / (x1 - x2))) + (y2 * ((x - x1) / (x2 - x1)));
        }
        public static double interpolar3Puntos(double x, double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return ((y1 * (((x - x2) * (x - x3)) / ((x1 - x2) * (x1 - x3)))) +
                    (y2 * (((x - x1) * (x - x3)) / ((x2 - x1) * (x2 - x3)))) +
                    (y3 * (((x - x1) * (x - x2)) / ((x3 - x1) * (x3 - x2)))));
        }
        public static Color[] Paleta()
        {
            Color[] paleta = new Color[16];
            paleta[0] = Color.Black;
            paleta[1] = Color.Navy;
            paleta[2] = Color.Green;
            paleta[3] = Color.Aqua;
            paleta[4] = Color.Red;
            paleta[5] = Color.Purple;
            paleta[6] = Color.Maroon;
            paleta[7] = Color.LightGray;
            paleta[8] = Color.DarkGray;
            paleta[9] = Color.Blue;
            paleta[10] = Color.Lime;
            paleta[11] = Color.Silver;
            paleta[12] = Color.Teal;
            paleta[13] = Color.Fuchsia;
            paleta[14] = Color.Yellow;
            paleta[15] = Color.White;
            return paleta;
        }



        public static int Fibonacci(int numberElements)
        {
            int v1 = 0;
            int v2 = 1;

            for (int i = 0; i < numberElements; i++)
            {
                int temp = v1;
                v1 = v2;
                v2 = temp + v1;
            }

            return v1;
        }
    }
}
