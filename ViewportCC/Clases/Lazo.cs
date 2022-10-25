using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Lazo : Circulo
    {
        public Lazo(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {

        }

        public override void Dibujar()
        {
            float t = 0;
            float dt = 0.001f;

            double auxX0 = X0;
            double auxY0 = Y0;

            do
            {
                X0 = auxX0 + (RADIO * Math.Sin(2*t));
                Y0 = auxY0 + (RADIO * Math.Cos(3*t));
                base.encender();
                t += dt;
            }
            while (t <= 6.28);

        }
    }
}
