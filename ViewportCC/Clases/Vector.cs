using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Vector
    {
        private double x0;
        private double y0;
        private Color Color0;
        private PictureBox viewport;
        private Bitmap bits;

        const double x1 = -7;
        const double y1 = -5;
        const double x2 = 5;
        const double y2 = 4;

        const double sx1 = 0;
        const double sy1 = 0;
        const double sx2 = 700;
        const double sy2 = 500;


        /*-------------SETTERS and GETTERS------------*/
        public double X0 {
            set => this.x0 = value;
            get => this.x0;
        }
        public double Y0 {
            set => this.y0 = value;
            get => this.y0;
        }

        public PictureBox VIEWPORT {
            set => this.viewport = value;
            get => this.viewport;
        }

        public Bitmap BITS { 
            set => this.bits = value;
            get => this.bits;
        }
        public Color COLOR0 { 
            set => this.Color0 = value;
            get => this.Color0;
        }

        public Vector() { }
        public Vector (double x0, double y0, Color Color0,Bitmap bits, PictureBox viewport)
        {
            this.x0 = x0; 
            this.y0 = y0; 
            this.viewport = viewport;
            this.Color0 = Color0;
            this.bits = bits;
        }
        public Vector(double x0, double y0, Color Color0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.Color0 = Color0;
        }

        public Vector(Bitmap bits, PictureBox viewport)
        {
            this.viewport = viewport;
            this.bits = bits;
        }


        public virtual void encender()
        {
            int[] sx_sy_values = Pantalla(x0, y0);
            int Sx = sx_sy_values[0];
            int Sy = sx_sy_values[1];

            if ((Sx >= 0 && Sx < 700) && (Sy >= 0 && Sy < 500))
                bits.SetPixel(Sx, Sy, Color0);
            
            viewport.Image = bits;
        }

        public void apagar ()
        {

        }

        private int[] Pantalla (double x, double y)
        {
            int sx, sy;

            sx = (int) ((((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1);
            sy = (int) ((((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1);

            return new int[] { sx, sy };
        }
    }
}
