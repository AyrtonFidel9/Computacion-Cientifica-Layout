using ViewportCC.Clases;

namespace ViewportCC
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnPintar(object sender, EventArgs e)
        {
            Color amarillo = Color.FromArgb(255,255,0); //amarillo
            Color verde = Color.FromArgb(0,255,0); //verde
            pintarLienzoMitad(pbLienzo, amarillo, verde);
        }

        void pintarLienzoMitad(PictureBox lienzo,Color color1, Color color2)
        {
            int width = lienzo.Width;
            int height = lienzo.Height;

            Bitmap bits = new Bitmap(width, height);

            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                    bits.SetPixel(i, j, i <= 350 ? color1 : color2);

            lienzo.Image = bits;
        }

        void degradarBanderaAmarilloVerde(PictureBox lienzo)
        {

            int width = lienzo.Width;
            int height = lienzo.Height;

            Bitmap bits = new Bitmap(width, height);

            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                    bits.SetPixel(i, j, i <= 350 ?
                        Color.FromArgb((-51 * i / 140) + 255, 255, 0) :
                        Color.FromArgb((-51 * i / 140) + 255, 255, 0));

            lienzo.Image = bits;
        }

        void degradarBanderaColors(PictureBox lienzo)
        {
            Color color1 = Color.FromArgb(50, 79, 109);
            Color color2 = Color.FromArgb(233, 123, 90);

            int width = lienzo.Width;
            int height = lienzo.Height;

            Bitmap bits = new Bitmap(width, height);

            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                    bits.SetPixel(i, j, i <= 350 ?
                        Color.FromArgb((int)(0.261 * i) + 50, 
                                        (int)(0.063 * i) + 79, 
                                        (int)(-0.028 * i) + 109) :
                        Color.FromArgb((int)(0.261 * i) + 50, 
                                        (int)(0.063 * i) + 79, 
                                        (int)(-0.028 * i) + 109));

            lienzo.Image = bits;
        }
        private void btnDegradar_Click(object sender, EventArgs e)
        {
            degradarBanderaAmarilloVerde(pbLienzo);
        }

        private void btnDegragarMyColors_Click(object sender, EventArgs e)
        {
            degradarBanderaColors(pbLienzo);
        }

        private void btnPintarMisColores_Click(object sender, EventArgs e)
        {
            Color color1 = Color.FromArgb(50, 79, 109);
            Color color2 = Color.FromArgb(233, 123, 90);

            pintarLienzoMitad(pbLienzo, color1, color2);
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            Bitmap bits = new Bitmap(pbLienzo.Width, pbLienzo.Height);

            double x = -1;
            Vector vector1 = new Vector(bits, pbLienzo);
            do
            {
                vector1.X0 = x;
                vector1.Y0 = x*x-5;
                vector1.COLOR0 = Color.Red;
                vector1.encender();
                x += 0.0001;
            }
            while (x <= 3);
        }

        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Bitmap bits = new Bitmap(pbLienzo.Width, pbLienzo.Height);

            Circulo cir = new Circulo(bits, pbLienzo);
            cir.X0 = 2.8;
            cir.Y0 = 0;
            cir.RADIO = 2;
            cir.COLOR0 = Color.Green;

            cir.Dibujar();

            Segmento segmento = new Segmento(bits, pbLienzo);

            segmento.X0 = -4;
            segmento.Y0 = 3;
            segmento.XF = 4;
            segmento.YF = -4;
            segmento.COLOR0 = Color.Red;

            segmento.Dibujar();

            Segmento linea2 = new Segmento(bits, pbLienzo);
            linea2.X0 = 3;
            linea2.Y0 = 3;
            linea2.XF = -4;
            linea2.YF = -3;
            linea2.COLOR0 = Color.Black;

            linea2.Dibujar();

            Segmento linea3 = new Segmento(bits, pbLienzo);
            linea3.X0 = -3;
            linea3.Y0 = 3;
            linea3.XF = -3;
            linea3.YF = -4;
            linea3.COLOR0 = Color.Violet;

            linea3.Dibujar();

            Circulo cir2 = new Circulo(bits, pbLienzo);
            cir2.X0 = -2;
            cir2.Y0 = 0;
            cir2.RADIO = 0.8;
            cir2.COLOR0 = Color.Brown;

            cir2.Dibujar();

            Circulo cir3 = new Circulo(bits, pbLienzo);
            cir3.X0 = -0.4;
            cir3.Y0 = 2;
            cir3.RADIO = 1.2;
            cir3.COLOR0 = Color.Blue;

            cir3.Dibujar();

        }

        private void btnLazos_Click(object sender, EventArgs e)
        {
            Bitmap bits = new Bitmap(pbLienzo.Width, pbLienzo.Height);
            
            Lazo lazo1 = new Lazo(bits, pbLienzo);
            lazo1.RADIO = 1;
            lazo1.X0 = 3;
            lazo1.Y0 = 2;
            lazo1.COLOR0 = Color.Green;

            lazo1.Dibujar();


            Lazo lazo2 = new Lazo(bits, pbLienzo);
            lazo2.RADIO = 1.3;
            lazo2.X0 = 2;
            lazo2.Y0 = -2;
            lazo2.COLOR0 = Color.Black;

            lazo2.Dibujar();


            Margarita margarita = new Margarita(bits, pbLienzo);
            margarita.RADIO = 2;
            margarita.X0 = -4;
            margarita.Y0 = 1.7;
            margarita.COLOR0 = Color.Red;

            margarita.Dibujar();

            Margarita margarita2 = new Margarita(bits, pbLienzo);
            margarita2.RADIO = 0.6;
            margarita2.X0 = -4;
            margarita2.Y0 = -2;
            margarita2.COLOR0 = Color.Brown;

            margarita2.Dibujar();

            Circulo circulo = new Circulo(bits, pbLienzo);
            circulo.X0 = 0;
            circulo.Y0 = 0;
            circulo.RADIO = 1;
            circulo.COLOR0 = Color.BlueViolet;
            circulo.Dibujar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bits = new Bitmap(pbLienzo.Width, pbLienzo.Height);

            Vector vector = new Vector(bits, pbLienzo);
            vector.COLOR0 = Color.Red;  

            float t = -5.5f;
            float dt = 0.001f;
            do
            {
                vector.X0 = t;
                vector.Y0 = (t * t) - 3;
                vector.encender();
                t += dt;
            }
            while (t <= 5.5);

            Vector vector2 = new Vector(bits, pbLienzo);
            vector2.COLOR0 = Color.Green;
            t = -5.5f;
            dt = 0.001f;
            do
            {
                vector2.X0 = t;
                vector2.Y0 = Math.Pow(2, t);
                vector2.encender();
                t += dt;
            }
            while (t <= 5.5);

            Vector vector3 = new Vector(bits, pbLienzo);
            vector3.COLOR0 = Color.Orange;
            t = -5.5f;
            dt = 0.001f;
            do
            {
                vector3.X0 = t;
                vector3.Y0 = Math.Sin(t);
                vector3.encender();
                t += dt;
            }
            while (t <= 5.5);

            dibujarEjes(bits);
            
        }

        private void btnEjes_Click(object sender, EventArgs e)
        {
            Bitmap bits = new Bitmap(pbLienzo.Width, pbLienzo.Height);
            Segmento ejeX = new Segmento(bits, pbLienzo);
            ejeX.COLOR0 = Color.Black;
            ejeX.X0 = -7;
            ejeX.Y0 = 0;
            ejeX.XF = 7;
            ejeX.YF = 0;

            ejeX.Dibujar();


            Segmento ejeY = new Segmento(bits, pbLienzo);
            ejeY.COLOR0 = Color.Black;
            ejeY.X0 = 0;
            ejeY.Y0 = 5;
            ejeY.XF = 0;
            ejeY.YF = -5;

            ejeY.Dibujar();
        }

        private void dibujarEjes(Bitmap bits)
        {
            Segmento ejeX = new Segmento(bits, pbLienzo);
            ejeX.COLOR0 = Color.Black;
            ejeX.X0 = -7;
            ejeX.Y0 = 0;
            ejeX.XF = 7;
            ejeX.YF = 0;

            ejeX.Dibujar();


            Segmento ejeY = new Segmento(bits, pbLienzo);
            ejeY.COLOR0 = Color.Black;
            ejeY.X0 = 0;
            ejeY.Y0 = 5;
            ejeY.XF = 0;
            ejeY.YF = -5;

            ejeY.Dibujar();
        }
    }
}