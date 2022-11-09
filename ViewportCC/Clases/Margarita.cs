using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Margarita : Circulo
    {
        public Margarita(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {

        }

        public override void encender()
        {
            float t = 0;
            float dt = 0.001f;

            Vector v = new Vector(BITS, VIEWPORT, COLOR0);
            
            do
            {
                v.X0 = X0 + (RADIO * Math.Cos(4 * t) *  Math.Cos(t));
                v.Y0 = Y0 + (RADIO * Math.Cos(4 * t) * Math.Sin(t));
                v.encender();
                t += dt;
            }
            while (t <= 6.28);

        }
    }
}
