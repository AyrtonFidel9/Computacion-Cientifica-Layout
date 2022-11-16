using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Segmento3D : Vector3D
    {
        double xf;
        double yf;
        double zf;

        public Segmento3D(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {
        }

        public Segmento3D(double x0, double y0) : base(x0, y0)
        {
        }

        public Segmento3D(double x0, double y0, Color Color0) : base(x0, y0, Color0)
        {
        }

        public Segmento3D(Bitmap bits, PictureBox viewport, Color color) : base(bits, viewport, color)
        {
        }

        public Segmento3D(double x0, double y0, double z0) : base(x0, y0, z0)
        {
        }

        public Segmento3D(double x0, double y0, Bitmap bits, PictureBox viewport) : base(x0, y0, bits, viewport)
        {
        }

        public Segmento3D(double x0, double y0, Color Color0, Bitmap bits, PictureBox viewport) : base(x0, y0, Color0, bits, viewport)
        {
        }

        public Segmento3D(double x0, double y0, double z0, Bitmap bits, PictureBox viewport) : base(x0, y0, z0, bits, viewport)
        {
        }

        public double XF
        {
            set => this.xf = value;
            get => this.xf;
        }
        public double YF
        {
            set => this.yf = value;
            get => this.yf;
        }
        public double ZF
        {
            set => this.zf = value;
            get => this.zf;
        }

        public override void encender()
        {
            double t = 0;
            double dt = 0.001;
            Vector3D v3d = new Vector3D(BITS, VIEWPORT, COLOR0);

            do
            {
                v3d.X0 = X0 + (xf - X0) * t;
                v3d.Y0 = Y0 + (yf - Y0) * t;
                v3d.Z0 = Z0 + (zf - Z0) * t;
                v3d.encender();
                t = t + dt;
            }
            while (t <= 1);

        }

    }
}
