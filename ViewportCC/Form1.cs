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
            lazo1.RADIO = 0.8;
            lazo1.X0 = 2.8;
            lazo1.Y0 = 0;
            lazo1.COLOR0 = Color.Green;

            lazo1.Dibujar();

            Margarita margarita = new Margarita(bits, pbLienzo);
            margarita.RADIO = 1.4;
            margarita.X0 = 0;
            margarita.Y0 = -1;
            margarita.COLOR0 = Color.Red;


            margarita.Dibujar();
        }
    }
}