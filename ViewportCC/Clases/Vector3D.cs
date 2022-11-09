using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewportCC.Clases
{
    internal class Vector3D : Vector
    {
        private double z0;
        public double Z0
        {
            set => this.z0 = value;
            get => this.z0;
        }

        

        public Vector3D(double x0, double y0, Color Color0, Bitmap bits, PictureBox viewport) : base(x0, y0, Color0, bits, viewport)
        {
        }

        public Vector3D(double x0, double y0, Color Color0) : base(x0, y0, Color0)
        {
        }


        public Vector3D(Bitmap bits, PictureBox viewport) : base(bits, viewport)
        {
        }

        public Vector3D(double x0, double y0, double z0, Bitmap bits, PictureBox viewport) : base(x0,y0,bits, viewport)
        {
            this.Z0 = z0;
        }

        public Vector3D(Bitmap bits, PictureBox viewport, Color color) : base(bits, viewport, color)
        {
        }

        public Vector3D(double x0, double y0, double z0) : base(x0,y0)
        {
            this.z0 = z0;
        }

        public Vector3D(double x0, double y0) : base(x0, y0)
        {
        }

        public Vector3D(double x0, double y0, Bitmap bits, PictureBox viewport) : base(x0, y0, bits, viewport)
        {
        }

        private void Axonometria(double x, double y, double z)
        {
            const double alfa = Math.PI / 4; //0.785

            x = x / 2;

            base.X0 = (y - (x * Math.Cos(alfa)));
            base.Y0 = (z - (x * Math.Sin(alfa)));

        }

        public override void encender()
        {
            Axonometria(X0, Y0, z0);
            base.encender();
        }

    }
}
