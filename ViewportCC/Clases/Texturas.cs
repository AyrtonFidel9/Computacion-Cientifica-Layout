using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Texturas
    {
        public static Color[] Madera()
        {
            Color[] paleta = new Color[16];
            for (int i = 0; i < 16; i++) {
                int r = (int)Utils.interpolar2Puntos(i, 0, 200, 15, 180);
                int g = (int)Utils.interpolar2Puntos(i, 0, 90, 15, 130);
                paleta[i] = Color.FromArgb(180, g, 40);
            }
            return paleta;
        }

        public static Color[] Nieve()
        {
            Color[] paleta = new Color[16];
            for (int i = 0; i < 16; i++)
            {
                int r = (int)Utils.interpolar2Puntos(i, 0, 209, 15, 255);
                paleta[i] = Color.FromArgb(r, r, r);
            }
            return paleta;
        }
        public static Color[] TelaJean()
        {
            Color[] paleta = new Color[16];
            for (int i = 0; i < 16; i++)
            {
                int r = (int)Utils.interpolar2Puntos(i, 0, 0, 15, 112);
                int g = (int)Utils.interpolar2Puntos(i, 0, 35, 15, 151);
                int b = (int)Utils.interpolar2Puntos(i, 0, 94, 15, 205);
                paleta[i] = Color.FromArgb(r, g, b);
            }
            return paleta;
        }
        public static Color[] Agua()
        {
            Color[] paleta = new Color[16];
            for (int i = 0; i < 16; i++)
            {
                int r = (int)Utils.interpolar2Puntos(i, 0, 72, 15, 204);
                int g = (int)Utils.interpolar2Puntos(i, 0, 145, 15, 213);
                int b = (int)Utils.interpolar2Puntos(i, 0, 236, 15, 218);
                paleta[i] = Color.FromArgb(r, g, b);
            }
            return paleta;
        }
        public static Color[] Grises()
        {
            Color[] paleta = new Color[16];
            for (int i = 0; i < 16; i++)
            {
                int r = (int)Utils.interpolar2Puntos(i, 0, 100, 15, 230);
                int g = (int)Utils.interpolar2Puntos(i, 0, 100, 15, 230);
                int b = (int)Utils.interpolar2Puntos(i, 0, 105, 15, 220);
                paleta[i] = Color.FromArgb(r, g, b);
            }
            return paleta;
        }
    }
}
