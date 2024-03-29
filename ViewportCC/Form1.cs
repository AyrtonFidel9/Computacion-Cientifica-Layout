using ViewportCC.Clases;

namespace ViewportCC
{
    public partial class Form1 : Form
    {

        Bitmap bits;
        int width;
        int height;
        Circulo circulo;

        public Form1()
        {
            InitializeComponent();
            bits = new Bitmap(pbLienzo.Width, pbLienzo.Height);
            width = pbLienzo.Width;
            height = pbLienzo.Height;

            circulo = new Circulo(bits, pbLienzo);
            circulo.X0 = 0;
            circulo.Y0 = 0;
            circulo.RADIO = 1;
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
            /*for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                    bits.SetPixel(i, j, i <= 350 ?
                        Color.FromArgb((-51 * i / 140) + 255, 255, 0) :
                        Color.FromArgb((-51 * i / 140) + 255, 255, 0));

            lienzo.Image = bits;*/

            

            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    int r = (int)Utils.interpolar2Puntos(i, 0, 255.0, 700, 0.0);
                    int g = (int)Utils.interpolar2Puntos(i, 0, 255, 700, 255);
                    int b = (int)Utils.interpolar2Puntos(i, 0, 0.0, 700, 0);
                    bits.SetPixel(i, j, Color.FromArgb(r,g,b));
                }

            lienzo.Image = bits;
        }

        void degradarBanderaColors(PictureBox lienzo)
        {
            Color color1 = Color.FromArgb(50, 79, 109);
            Color color2 = Color.FromArgb(233, 123, 90);

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

            Circulo cir = new Circulo(bits, pbLienzo);
            cir.X0 = 2.8;
            cir.Y0 = 0;
            cir.RADIO = 2;
            cir.COLOR0 = Color.Green;

            cir.encender();

            Segmento segmento = new Segmento(bits, pbLienzo);

            segmento.X0 = -4;
            segmento.Y0 = 3;
            segmento.XF = 4;
            segmento.YF = -4;
            segmento.COLOR0 = Color.Red;

            segmento.encender();

            Segmento linea2 = new Segmento(bits, pbLienzo);
            linea2.X0 = 3;
            linea2.Y0 = 3;
            linea2.XF = -4;
            linea2.YF = -3;
            linea2.COLOR0 = Color.Black;

            linea2.encender();

            Segmento linea3 = new Segmento(bits, pbLienzo);
            linea3.X0 = -3;
            linea3.Y0 = 3;
            linea3.XF = -3;
            linea3.YF = -4;
            linea3.COLOR0 = Color.Violet;

            linea3.encender();

            Circulo cir2 = new Circulo(bits, pbLienzo);
            cir2.X0 = -2;
            cir2.Y0 = 0;
            cir2.RADIO = 0.8;
            cir2.COLOR0 = Color.Brown;

            cir2.encender();

            Circulo cir3 = new Circulo(bits, pbLienzo);
            cir3.X0 = -0.4;
            cir3.Y0 = 2;
            cir3.RADIO = 1.2;
            cir3.COLOR0 = Color.Blue;

            cir3.encender();

        }

        private void btnLazos_Click(object sender, EventArgs e)
        {

            Lazo lazo1 = new Lazo(bits, pbLienzo);
            lazo1.RADIO = 1;
            lazo1.X0 = 3;
            lazo1.Y0 = 2;
            lazo1.COLOR0 = Color.Green;

            lazo1.encender();


            Lazo lazo2 = new Lazo(bits, pbLienzo);
            lazo2.RADIO = 1.3;
            lazo2.X0 = 2;
            lazo2.Y0 = -2;
            lazo2.COLOR0 = Color.Black;

            lazo2.encender();


            Margarita margarita = new Margarita(bits, pbLienzo);
            margarita.RADIO = 2;
            margarita.X0 = -4;
            margarita.Y0 = 1.7;
            margarita.COLOR0 = Color.Red;

            margarita.encender();

            Margarita margarita2 = new Margarita(bits, pbLienzo);
            margarita2.RADIO = 0.6;
            margarita2.X0 = -4;
            margarita2.Y0 = -2;
            margarita2.COLOR0 = Color.Brown;

            margarita2.encender();

            circulo.COLOR0 = Color.BlueViolet;
            circulo.encender();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            Segmento ejeX = new Segmento(bits, pbLienzo);
            ejeX.COLOR0 = Color.Black;
            ejeX.X0 = -7;
            ejeX.Y0 = 0;
            ejeX.XF = 7;
            ejeX.YF = 0;

            ejeX.encender();


            Segmento ejeY = new Segmento(bits, pbLienzo);
            ejeY.COLOR0 = Color.Black;
            ejeY.X0 = 0;
            ejeY.Y0 = 5;
            ejeY.XF = 0;
            ejeY.YF = -5;

            ejeY.encender();
        }

        private void dibujarEjes(Bitmap bits)
        {
            Segmento ejeX = new Segmento(bits, pbLienzo);
            ejeX.COLOR0 = Color.Black;
            ejeX.X0 = -7;
            ejeX.Y0 = 0;
            ejeX.XF = 7;
            ejeX.YF = 0;

            ejeX.encender();


            Segmento ejeY = new Segmento(bits, pbLienzo);
            ejeY.COLOR0 = Color.Black;
            ejeY.X0 = 0;
            ejeY.Y0 = 5;
            ejeY.XF = 0;
            ejeY.YF = -5;

            ejeY.encender();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            circulo.apagar();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Lazo lazo = new Lazo(bits, pbLienzo);

            double x = -5;
            lazo.RADIO = 0.8;
            do
            {
                lazo.X0 = x;
                lazo.Y0 = Math.Sin(x);
                lazo.COLOR0 = Color.Red;
                lazo.encender();

                await Task.Delay(120);

                lazo.apagar();

                x +=  0.5;
            }
            while (x <= 5);


        }

        private void btnParcialUno_Click(object sender, EventArgs e)
        {
            /*Epicicloide epi = new Epicicloide(bits, pbLienzo);
            epi.RADIO = 2.3;
            epi.RADIO2 = 1;
            epi.X0 = 0;
            epi.Y0 = 0;
            epi.encender();*/
            Color izquierda = Color.FromArgb(233, 123, 90); // derecha
            Bitmap bits = new Bitmap(width, height);

            /*for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    int r = (int)Utils.interpolar2Puntos(i, 0, 233, 350, 255);
                    int g = (int)Utils.interpolar2Puntos(i, 0, 123, 350, 255);
                    int b = (int)Utils.interpolar2Puntos(i, 0, 90, 350, 255);
                    int r1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 233);
                    int g1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 123);
                    int b1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 90);
                    if (r < 0 || g < 0 || b < 0 || r > 255 || g > 255 || b > 255)
                    {
                        r = 10;
                        g = 20;
                        b = 30;
                    }
                    if(i <= 350)
                        bits.SetPixel(i, j, Color.FromArgb(r, g, b));
                    else
                        bits.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }*/

            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    int r = (int)Utils.interpolar3Puntos(i, 0,233,350,255,700,233);
                    int g = (int)Utils.interpolar3Puntos(i, 0, 123, 350, 255, 700, 123);
                    int b = (int)Utils.interpolar3Puntos(i, 0, 90, 350, 255, 700, 90);
                    int r1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 233);
                    int g1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 123);
                    int b1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 90);
                    if (r < 0 || g < 0 || b < 0 || r > 255 || g > 255 || b > 255)
                    {
                        r = 10;
                        g = 20;
                        b = 30;
                    }
                    bits.SetPixel(i, j, Color.FromArgb(r, g, b));
                }

            pbLienzo.Image = bits;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bits = new Bitmap(width, height);

            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    int r = (int)Utils.interpolar3Puntos(i, 0, 100, 350, 255, 700, 100);
                    int g = (int)Utils.interpolar3Puntos(i, 0, 100, 350, 255, 700, 100);
                    int b = (int)Utils.interpolar3Puntos(i, 0, 150, 350, 255, 700, 150);
                    int r1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 233);
                    int g1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 123);
                    int b1 = (int)Utils.interpolar2Puntos(i, 350, 255, 700, 90);
                    if (r < 0 || g < 0 || b < 0 || r > 255 || g > 255 || b > 255)
                    {
                        r = 10;
                        g = 20;
                        b = 30;
                    }
                    bits.SetPixel(i, j, Color.FromArgb(r, g, b));
                }

            pbLienzo.Image = bits;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void segmento3D_Click(object sender, EventArgs e)
        {
            
        }

        private void pintarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color amarillo = Color.FromArgb(255, 255, 0); //amarillo
            Color verde = Color.FromArgb(0, 255, 0); //verde
            pintarLienzoMitad(pbLienzo, amarillo, verde);
        }

        private void vector3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double t = 0;
            double dt = 0.002;
            Vector3D vector = new Vector3D(bits, pbLienzo);
            vector.COLOR0 = Color.Black;
            do
            {
                vector.X0 = 1 + (1 * Math.Cos(t));
                vector.Y0 = -3 + (1 * Math.Sin(t));
                vector.Z0 = t / 15;
                vector.encender();
                t += dt;
            }
            while (t <= 55);

            t = 0;
            Vector3D vector2 = new Vector3D(bits, pbLienzo);
            vector2.COLOR0 = Color.Red;
            do
            {
                vector2.X0 = 2 + (2 * Math.Cos(t));
                vector2.Y0 = t / 3;
                vector2.Z0 = 2 + (3 * Math.Sin(t));
                vector2.encender();
                t += dt;
            }
            while (t <= 16);

            t = 0;
            Vector3D vector3 = new Vector3D(bits, pbLienzo);
            vector3.COLOR0 = Color.Green;
            do
            {
                vector3.X0 = 8 + (1 * Math.Cos(t));
                vector3.Y0 = -3 + (1 * Math.Sin(t));
                vector3.Z0 = t / 8;
                vector3.encender();
                t += dt;
            }
            while (t <= 15);
        }

        private void segmento3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Segmento3D seg3D = new Segmento3D(bits, pbLienzo, Color.Violet);

             seg3D.X0 = 0;
             seg3D.Y0 = 0;
             seg3D.Z0 = 0;
             seg3D.XF = 4;
             seg3D.YF = 5;
             seg3D.ZF = 2;

             seg3D.encender();*/

            /*double t = 0;
            double dt = 0.002;
            Vector3D vector = new Vector3D(bits, pbLienzo);
            vector.COLOR0 = Color.Black;
            do
            {
                vector.X0 = vector.X0 + 3 * Math.Cos(t);
                vector.Y0 = vector.Y0 + 3 * Math.Sin(t);
                vector.Z0 = Math.Cos(3);
                vector.encender();
                t += dt;
            }
            while (t <= 6.3);*/

            Segmento3D ejeZ = new Segmento3D(bits, pbLienzo, Color.Black);

            ejeZ.X0 = 0;
            ejeZ.Y0 = 0;
            ejeZ.Z0 = 0;

            ejeZ.XF = 0;
            ejeZ.YF = 0;
            ejeZ.ZF = 4;

            ejeZ.encender();

            Segmento3D ejeX = new Segmento3D(bits, pbLienzo, Color.Black);

            ejeX.X0 = 0;
            ejeX.Y0 = 0;
            ejeX.Z0 = 0;

            ejeX.XF = 8;
            ejeX.YF = 0;
            ejeX.ZF = 0;

            ejeX.encender();


            Segmento3D ejeY = new Segmento3D(bits, pbLienzo, Color.Black);

            ejeY.X0 = 0;
            ejeY.Y0 = 0;
            ejeY.Z0 = 0;

            ejeY.XF = 0;
            ejeY.YF = 5;
            ejeY.ZF = 0;

            ejeY.encender();


            Segmento3D cuatro = new Segmento3D(bits, pbLienzo, Color.Black);
            cuatro.X0 = 0;
            cuatro.Y0 = 0;
            cuatro.Z0 = 4;

            cuatro.XF = 0;
            cuatro.YF = 5;
            cuatro.ZF = 4;

            cuatro.encender();

            Segmento3D cinco = new Segmento3D(bits, pbLienzo, Color.Black);
            cinco.X0 = 0;
            cinco.Y0 = 5;
            cinco.Z0 = 4;

            cinco.XF = 0;
            cinco.YF = 5;
            cinco.ZF = 0;

            cinco.encender();


            Segmento3D seis = new Segmento3D(bits, pbLienzo, Color.Black);
            seis.X0 = 0;
            seis.Y0 = 5;
            seis.Z0 = 0;

            seis.XF = 8;
            seis.YF = 5;
            seis.ZF = 0;

            seis.encender();


            Segmento3D siete = new Segmento3D(bits, pbLienzo, Color.Black);
            siete.X0 = 8;
            siete.Y0 = 5;
            siete.Z0 = 0;

            siete.XF = 8;
            siete.YF = 0;
            siete.ZF = 0;

            siete.encender();


            Segmento3D ocho = new Segmento3D(bits, pbLienzo, Color.Black);
            ocho.X0 = 8;
            ocho.Y0 = 0;
            ocho.Z0 = 0;

            ocho.XF = 8;
            ocho.YF = 0;
            ocho.ZF = 4;

            ocho.encender();


            Segmento3D nueve = new Segmento3D(bits, pbLienzo, Color.Black);
            nueve.X0 = 8;
            nueve.Y0 = 0;
            nueve.Z0 = 4;

            nueve.XF = 0;
            nueve.YF = 0;
            nueve.ZF = 4;

            nueve.encender();

            /*Segmento3D diez = new Segmento3D(bits, pbLienzo, Color.Red);
            diez.X0 = 8;
            diez.Y0 = 0;
            diez.Z0 = 4;

            diez.XF = 8;
            diez.YF = 5;
            diez.ZF = 4;

            diez.encender();

            Segmento3D once = new Segmento3D(bits, pbLienzo, Color.Red);
            once.X0 = 8;
            once.Y0 = 5;
            once.Z0 = 4;

            once.XF = 0;
            once.YF = 5;
            once.ZF = 4;

            once.encender();

            Segmento3D doce = new Segmento3D(bits, pbLienzo, Color.Red);
            doce.X0 = 8;
            doce.Y0 = 5;
            doce.Z0 = 4;

            doce.XF = 8;
            doce.YF = 5;
            doce.ZF = 0;

            doce.encender();*/





        }

        private void superficieTIPO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieV sup = new SuperficieV(bits, pbLienzo, Color.Red);
            sup.X0 = 1;
            sup.Y0 = 1;
            sup.Z0 = -2;
            sup.TIPO = 1;
            sup.RD = 2;
            sup.encender();


        }

        private void superficieTIPO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieV sup = new SuperficieV(bits, pbLienzo, Color.Red);
            sup.X0 = 1;
            sup.Y0 = 1;
            sup.Z0 = -2;
            sup.TIPO = 2;
            sup.RD = 2;
            sup.encender();
        }

        private void superficieTIPO3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieV sup = new SuperficieV(bits, pbLienzo, Color.Red);
            sup.X0 = 0;
            sup.Y0 = 0;
            sup.Z0 = 0;
            sup.TIPO = 3;
            sup.RD = 1;
            sup.encender();
        }

        private void cilindroYEsferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieV cilindro = new SuperficieV(bits, pbLienzo, Color.Red);
            cilindro.X0 = 1;
            cilindro.Y0 = -1;
            cilindro.Z0 = -2;
            cilindro.TIPO = 1;
            cilindro.RD = 1;
            cilindro.encender();

            SuperficieV esfera = new SuperficieV(bits, pbLienzo, Color.Blue);
            esfera.X0 = 0;
            esfera.Y0 = 2.5;
            esfera.Z0 = 1;
            esfera.TIPO = 2;
            esfera.RD = 2;
            esfera.encender();
        }

        private void supVTIPO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieR s = new SuperficieR(bits,pbLienzo,Color.DarkGreen);
            s.TIPO = 1;
            s.FV = 0.1;
            s.encender();
        }

        private void paraboloideHiperbolicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieR s = new SuperficieR(bits, pbLienzo, Color.DarkGreen);
            s.TIPO = 2;
            s.FV = 0.6;
            s.encender();
        }

        private void hiperboloideDeUnaHojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieV hiperboloide = new SuperficieV(bits,pbLienzo, Color.DarkGreen);
            hiperboloide.TIPO = 4;
            hiperboloide.RD = 2;
            hiperboloide.X0 = 1;
            hiperboloide.Y0 = 1;
            hiperboloide.Z0 = 1;

            hiperboloide.encender();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            Graphics myGraphic = Graphics.FromImage(bits);

            myGraphic.Clear(Color.White);

            pbLienzo.Image = bits;
        }

       

        private void alfombraGRISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void alfombraGRISToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ColorT;
            Color c;
            int width = pbLienzo.Width;
            int height = pbLienzo.Height;

            Bitmap bits = new Bitmap(width, height);
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    ColorT = (i * i + j * j) % 15;
                    c = Utils.Paleta()[ColorT];
                    bits.SetPixel(i, j, c);
                }
            }

            pbLienzo.Image = bits;
        }

        private void miAlfombraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ColorT;
            Color c;
            int width = pbLienzo.Width;
            int height = pbLienzo.Height;
            int tipo;

            Bitmap bits = new Bitmap(width, height);
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                   
                        ColorT = (i * i / 2 + j * j / 2) % 15;
                    
                    // 1 -> i*i/2 + j*j/2
                    // 2 -> (int)(i/2 * Math.PI * Math.Sqrt(j)) % 15
                    // 3 ->  (int)(i*i * Math.PI + j*j) % 15
                    // 4 -> (int)((i*i + j*j)/2) % 15
                    // 5 -> (int)((i*i + j*j)/3) % 15
                    // 6 -> (int)((i*i + j*j)/4) % 15
                    // 7 -> ColorT = (int)(Math.PI * Math.Cos(i+j)) % 15;
                    //      ColorT = ColorT < 0 ? ColorT * -1 : ColorT;
                    // 8 -> (int)(Math.Sqrt(i*i + j*j)) % 15
                    //      (int)(Math.Sqrt((i*i + j*j)/6)) % 15;
                    // 9 -> (int)(i*i*j*j) % 15
                    // 10 -> (int)((i+j/2)*Math.PI) % 15
                    // 11 -> (int)((i/4 + Math.Sqrt(j)) * Math.PI) % 15
                    // 12 -> (int)((Math.Sqrt(i) + Math.Sqrt(j)) * Math.PI) % 15
                    // 13 -> (int)(Math.Cos(Math.Sqrt(i))+ Math.Sin(Math.Sqrt(j))) % 15
                    // 14 -> (int)(Math.Sqrt(Math.Pow(i,Math.PI) + Math.Pow(j, Math.PI)))) % 15;
                    // 14 -> (int)(Math.Sqrt(Math.Pow(i,Math.PI)) + Math.Sqrt(Math.Pow(j, Math.PI))) % 15;
                    // 15 -> ColorT = (int)(Math.Sqrt(Math.Sin(i) + Math.Cos(j))) % 15;
                    // 16 -> ColorT = (int)(Math.Sqrt(Math.Cos(i*j))) % 13;
                    // 17 -> ColorT = (int)(Math.Sqrt(Math.Cos(i*j/Math.PI))) % 13;
                    //ColorT = (int)(Math.Sqrt((i*j/Math.PI) + Math.Pow(i+j,2))) % 13;
                    ColorT = ColorT < 0 ? ColorT * -1 : ColorT;
                    c = Utils.Paleta()[ColorT];
                    bits.SetPixel(i, j, c);
                }
            }

            pbLienzo.Image = bits;
        }

        private void degradarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            degradarBanderaAmarilloVerde(pbLienzo);
        }

        private void masAlfombrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbAlfombras.Visible = true;
        }

        private void cmbAlfombras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ColorT = 1;
            Color c;
            int width = pbLienzo.Width;
            int height = pbLienzo.Height;
            int tipo = cmbAlfombras.SelectedIndex;

            Bitmap bits = new Bitmap(width, height);
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    switch (cmbAlfombras.SelectedIndex)
                    {
                        case 0: 
                            ColorT = (i * i / 2 + j * j / 2) % 15;
                            break;
                        case 1: 
                            ColorT = (int)(i / 2 * Math.PI * Math.Sqrt(j)) % 15;
                            break;
                        case 2:
                            ColorT = (int)(i * i * Math.PI + j * j) % 15;
                            break;
                        case 3:
                            ColorT = ((i * i + j * j) / 2) % 15;
                            break;
                        case 4:
                            ColorT = ((i * i + j * j) / 3) % 15;
                            break;
                        case 5:
                            ColorT = ((i * i + j * j) / 4) % 15;
                            break;
                        case 6:
                            ColorT = (int)(Math.PI * Math.Cos(i + j)) % 15;
                            break;
                        case 7:
                            ColorT = (int)(Math.Sqrt(i * i + j * j)) % 15;
                            break;
                        case 8:
                            ColorT = (i * i * j * j) % 15;
                            break;
                        case 9:
                            ColorT = (int)((i + j / 2) * Math.PI) % 15;
                            break;
                        case 10:
                            ColorT = (int)((i / 4 + Math.Sqrt(j)) * Math.PI) % 15;
                            break;
                        case 11:
                            ColorT = (int)((Math.Sqrt(i) + Math.Sqrt(j)) * Math.PI) % 15;
                            break;
                        case 12:
                            ColorT = (int)(Math.Cos(Math.Sqrt(i)) + Math.Sin(Math.Sqrt(j))) % 15;
                            break;
                        case 13:
                            ColorT = (int)(Math.Sqrt(Math.Pow(i, Math.PI)) + Math.Sqrt(Math.Pow(j, Math.PI))) % 15;
                            break;
                        case 14:
                            ColorT = (int)(Math.Sqrt(Math.Sin(i) + Math.Cos(j))) % 15;
                            break;
                        case 15:
                            ColorT = (int)(Math.Sqrt(Math.Cos(i * j))) % 13;
                            break;
                        case 16:
                            ColorT = (int)(Math.Sqrt(Math.Cos(i * j / Math.PI))) % 13;
                            break;
                        case 17:
                            ColorT = ((i * i + j * j) / 5) % 13;
                            break;
                        case 18:
                            ColorT = ((i * i + j * j) / 6) % 13;
                            break;
                        case 19:
                            ColorT = (i * i + j * j) / 7 % 13;
                            break;
                        case 20:
                            ColorT = (int)(Math.Sqrt(i) * j / 100) % 15;
                            break;
                        case 21:
                            ColorT = (int)(Math.E * (i/ 2) * Math.PI * (Math.Pow(Math.Sin(j), 3)) + j * i) % 6;
                            break;
                        case 22: //tela jean
                            //ColorT = (int)(Math.E * (j / 2) * Math.PI * (Math.Pow(Math.Cos(i), 3))) % 15;
                            //ColorT = (int)(Math.Pow((i/Math.Cos(j)),2)) % 15;
                            ColorT = (int)((Math.Pow(Math.Cos(i), 2) * Math.PI *j+ Math.Sin(i) + Math.Cos(j) + Math.Tan(i*j)) * Math.E) % 16;
                            break;
                        case 23:
                            ColorT = (int)(i / 2 * j/Math.E + Math.PI + Math.Cos(i*i*i) * Math.Sqrt(Math.Cos(j))) % 16;
                            break;
                    }
                    
                    
                    // 1 -> i*i/2 + j*j/2
                    // 2 -> (int)(i/2 * Math.PI * Math.Sqrt(j)) % 15
                    // 3 ->  (int)(i*i * Math.PI + j*j) % 15
                    // 4 -> (int)((i*i + j*j)/2) % 15
                    // 5 -> (int)((i*i + j*j)/3) % 15
                    // 6 -> (int)((i*i + j*j)/4) % 15
                    // 7 -> ColorT = (int)(Math.PI * Math.Cos(i+j)) % 15;
                    //      ColorT = ColorT < 0 ? ColorT * -1 : ColorT;
                    // 8 -> (int)(Math.Sqrt(i*i + j*j)) % 15
                    //      (int)(Math.Sqrt((i*i + j*j)/6)) % 15;
                    // 9 -> (int)(i*i*j*j) % 15
                    // 10 -> (int)((i+j/2)*Math.PI) % 15
                    // 11 -> (int)((i/4 + Math.Sqrt(j)) * Math.PI) % 15
                    // 12 -> (int)((Math.Sqrt(i) + Math.Sqrt(j)) * Math.PI) % 15
                    // 13 -> (int)(Math.Cos(Math.Sqrt(i))+ Math.Sin(Math.Sqrt(j))) % 15
                    // 14 -> (int)(Math.Sqrt(Math.Pow(i,Math.PI) + Math.Pow(j, Math.PI)))) % 15;
                    // 14 -> (int)(Math.Sqrt(Math.Pow(i,Math.PI)) + Math.Sqrt(Math.Pow(j, Math.PI))) % 15;
                    // 15 -> ColorT = (int)(Math.Sqrt(Math.Sin(i) + Math.Cos(j))) % 15;
                    // 16 -> ColorT = (int)(Math.Sqrt(Math.Cos(i*j))) % 13;
                    // 17 -> ColorT = (int)(Math.Sqrt(Math.Cos(i*j/Math.PI))) % 13;
                    //ColorT = (int)(Math.Sqrt((i*j/Math.PI) + Math.Pow(i+j,2))) % 13;
                    ColorT = ColorT < 0 ? ColorT * -1 : ColorT;
                    //c = Utils.Paleta()[ColorT];
                    //c = Texturas.Madera()[ColorT];
                    //c = Texturas.Nieve()[ColorT];
                    c = Texturas.TelaJean()[ColorT];
                    c = Texturas.Agua()[ColorT];
                    bits.SetPixel(i, j, c);
                }
            }

            pbLienzo.Image = bits;
        }

        private async void tiroParabólicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Lazo lazo = new Lazo(bits, pbLienzo);

            double x = -5;
            lazo.RADIO = 0.8;
            do
            {
                lazo.X0 = x;
                lazo.Y0 = Math.Sin(x);
                lazo.COLOR0 = Color.Red;
                lazo.encender();

                await Task.Delay(120);

                lazo.apagar();

                x += 0.5;
            }
            while (x <= 5);*/

            Vector v = new Vector(bits, pbLienzo, Color.DarkGreen);
            double x = -6;
            do
            {
                v.X0 = x;
                v.Y0 = (36 - x * x) / 9;

                v.encender();
                x += 0.1;
            }
            while (x <= 6);

            Circulo c = new Circulo(bits, pbLienzo);
            c.RADIO = 0.3;
            x = -6;
            do
            {
                c.X0 = x;
                c.Y0 = (36 - x * x) / 9;
                c.COLOR0 = Color.DarkGoldenrod;
                c.encender();

                await Task.Delay(1);

                c.apagar();

                x += 0.1;
            }
            while (x <= 6);

        }

        private async void rebotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector v = new Vector(bits, pbLienzo, Color.DarkGreen);
            double x = -7;
            do
            {
                v.X0 = x;
                //v.Y0 = -(Math.Pow(x, 2) + (12 * x) + 32);
                //v.Y0 = -(Math.Pow(x, 2) + (10 * x) + 21);
                v.Y0 = Utils.interpolar3Puntos(x,-7, 0, -5, 4, -3,0);
                v.encender();
                x += 0.01;
            }
            while (x <= -3);
            x = -3;
            do
            {
                v.X0 = x;
                v.Y0 = (-Math.Pow(x, 2) - (2 * x) + 3 )/ 1.2;

                v.encender();
                x += 0.01;
            }
            while (x <=1);

            x = 1;

            do
            {
                v.X0 = x;
                v.Y0 = (-Math.Pow(x, 2) + (5 * x) - 4) / 1.1;

                v.encender();
                x += 0.01;
            }
            while (x <= 4);
            x = 4;
            do
            {
                v.X0 = x;
                v.Y0 = (-Math.Pow(x, 2) + (10.5 * x) - 26) / 1.3;

                v.encender();
                x += 0.01;
            }
            while (x <= 6.5);

            Circulo c = new Circulo(bits, pbLienzo);
            c.RADIO = 0.3;
            x= -7;
            do
            {
                c.X0 = x;
                c.Y0 = Utils.interpolar3Puntos(x, -7, 0, -5, 4, -3, 0);
                //c.Y0 = -(Math.Pow(x, 2) + (10 * x) + 21);
                c.COLOR0 = Color.DarkGoldenrod;
                c.encender();
                await Task.Delay(1);

                c.apagar();
                x += 0.1;
            }
            while (x <= -3);
            x = -3;
            do
            {
                c.X0 = x;
                c.Y0 = (-Math.Pow(x, 2) - (2 * x) + 3) / 1.2;
                c.COLOR0 = Color.DarkGoldenrod;
                c.encender();
                await Task.Delay(1);

                c.apagar();
                x += 0.1;
            }
            while (x <=1);

            x = 1;

            do
            {
                c.X0 = x;
                c.Y0 = (-Math.Pow(x, 2) + (5 * x) - 4) / 1.1;
                c.COLOR0 = Color.DarkGoldenrod;
                c.encender();
                await Task.Delay(1);

                c.apagar();
                x += 0.1;
            }
            while (x <= 4);
            x = 4;
            do
            {
                c.X0 = x;
                c.Y0 = (-Math.Pow(x, 2) + (10.5 * x) - 26) / 1.3;
                c.COLOR0 = Color.DarkGoldenrod;
                c.encender();
                await Task.Delay(1);

                c.apagar();
                x += 0.1;
            }
            while (x <= 6.5);
        }

        private void proyeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector v = new Vector(bits, pbLienzo, Color.Blue);
            double x = -7;
            do
            {
                v.X0 = x;
                //v.Y0 = (49 - x * x) / 18;
                v.Y0 = Utils.interpolar3Puntos(x, -7, 0, 0, 2.72, 7, 0);

                v.encender();
                x += 0.01;
            }
            while (x <= 7);
           
        }

        // para la proyección
        private void pbLienzo_Click(object sender, EventArgs e)
        {
            Circulo c = new Circulo(bits, pbLienzo);
            c.RADIO = 0.3;
            c.COLOR0 = Color.DarkGoldenrod;

            MouseEventArgs eM = (MouseEventArgs)e;
            double[] coor = Vector.Vreal(eM.X, eM.Y);
            c.X0 = coor[0];
            c.Y0 = coor[1];
            c.encender();


            // rayo que se proyecta
            Segmento v = new Segmento(bits, pbLienzo);
            v.X0 = coor[0];
            v.Y0 = coor[1];
            v.XF = coor[0];
            v.YF = (49 - coor[0] * coor[0]) / 18;
            v.COLOR0 = Color.Yellow;


            v.encender();

            // rayo que se refleja
            Segmento p = new Segmento(bits, pbLienzo);
            p.X0 = coor[0];
            p.Y0 = (49 - coor[0] * coor[0]) / 18;
            if (p.X0 < 0)
            {
                p.XF = 7;
                p.YF = (9 / p.X0) * (7 - p.X0) + p.Y0;
            }
            else
            {
                p.XF = -7;
                p.YF = (9 / p.X0) * (-7 - p.X0) + p.Y0;
            }
            p.COLOR0 = Color.Red;

            p.encender();
        }

        private void pbLienzo_MouseClick(object sender, MouseEventArgs e)
        {
            /*Circulo c = new Circulo(bits, pbLienzo);
            c.RADIO = 0.3;
            c.COLOR0 = Color.DarkGoldenrod;

            base.OnMouseClick(e);
            MessageBox.Show("", "" + e.X.ToString() + e.Y.ToString());
            c.X0 = e.X;
            c.Y0 = e.Y;
            c.encender();*/
        }

        private void superficieEpsilonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieR epsilon = new SuperficieR(bits, pbLienzo, Color.DarkGreen);
            epsilon.TIPO = 3;
            epsilon.FV = 1.6;
            epsilon.encender();
        }

        private void ondaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda o = new Onda(bits, pbLienzo, Color.DarkGreen);
            o.t = 1.5;
            o.interferencia3fuentes();
        }

        private async void pARCIALIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double posX = 2;
            double posY = 1;
            double rad = 2;
            Segmento segundero = new Segmento(bits, pbLienzo);
            segundero.X0 = posX;
            segundero.Y0 = posY;
            
            Circulo c = new Circulo(bits, pbLienzo);
            c.X0 = posX;
            c.Y0 = posY;
            c.RADIO = rad;
            c.COLOR0 = Color.Blue;
            c.encender();
            double t = Math.PI/2;
            double dt = 0.05;
            do
            {
                segundero.XF = posX+((rad-0.3) * (Math.Cos(t)));
                segundero.YF = posY+((rad-0.3) * (Math.Sin(t)));
                segundero.COLOR0 = Color.DarkGreen;
                segundero.encender();
                
                await Task.Delay(60);
                segundero.apagar();
                t -= dt;

            }
            while (t>=-3*Math.PI/2);
        }

        private async void ondaAnimadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Onda o = new Onda(bits, pbLienzo, Color.DarkGreen);
            double tiempo = 0;
            do {
                o.t = tiempo;
                o.GrafO();
                await Task.Delay(20);
                tiempo += 0.05;
            } while (tiempo <= 6 * Math.PI );*/
            Onda o = new Onda(bits, pbLienzo, Color.DarkGreen);
            double tiempo = 0;
            do
            {
                o.t = tiempo;
                o.interferencia3fuentes();
                await Task.Delay(1);
                tiempo += 0.05;
            } while (tiempo <= 6 * Math.PI);
        }

        private void onda3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda3D = new Onda(bits, pbLienzo, Color.DarkGreen);
            onda3D.m = 0.7;
            onda3D.t = 0;
            onda3D.v = 9.3;
            onda3D.w = 1.5;
            onda3D.Onda3D();

        }

        private void onda3D2FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda3D = new Onda(bits, pbLienzo, Color.DarkGreen);
            onda3D.m = 0.7;
            onda3D.t = 0;
            onda3D.v = 9.3;
            onda3D.w = 1.5;
            onda3D.Interferencia3D_2f();
        }

        private void onda3D3FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda3D = new Onda(bits, pbLienzo, Color.DarkGreen);
            onda3D.m = 0.7;
            onda3D.t = 0;
            onda3D.v = 9.3;
            onda3D.w = 1.5;
            onda3D.Interferencia3D_3f();
        }

        private async void onda3DAnimacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda3D = new Onda(bits, pbLienzo, Color.DarkGreen);
            onda3D.m = 0.7;
            onda3D.t = 0;
            onda3D.v = 9.3;
            onda3D.w = 1.5;
            double t = 0.08, dt = 0, tf = 10;
            do
            {
                onda3D.COLOR0 = Color.DarkGreen;
                onda3D.Onda3D();
                await Task.Delay(40);
                onda3D.COLOR0 = Color.White;
                onda3D.Onda3D();
                onda3D.t = dt;
                dt += t;
            }
            while (dt <= tf);
        }

        private async void onda3D2FAnimacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda3D = new Onda(bits, pbLienzo, Color.DarkGreen);
            onda3D.m = 0.7;
            onda3D.t = 0;
            onda3D.v = 9.3;
            onda3D.w = 1.5;
            double t = 0.08, dt = 0, tf = 10;
            do
            {
                onda3D.COLOR0 = Color.DarkGreen;
                onda3D.Interferencia3D_2f();
                await Task.Delay(40);
                onda3D.COLOR0 = Color.White;
                onda3D.Interferencia3D_2f();
                onda3D.t = dt;
                dt += t;
            }
            while (dt <= tf);
        }

        private async void onda3D3FAnimacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda3D = new Onda(bits, pbLienzo, Color.DarkGreen);
            onda3D.m = 0.7;
            onda3D.t = 0;
            onda3D.v = 9.3;
            onda3D.w = 1.5;
            double t = 0.08, dt = 0, tf = 10;
            do
            {
                onda3D.COLOR0 = Color.DarkGreen;
                onda3D.Interferencia3D_3f();
                await Task.Delay(40);
                onda3D.COLOR0 = Color.White;
                onda3D.Interferencia3D_3f();
                onda3D.t = dt;
                dt += t;
            }
            while (dt <= tf);
        }

        private void cuerdaVibranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuerda cue = new Cuerda(bits, pbLienzo, Color.DarkGreen);
            cue.T = 0.3;
            cue.graficarCuerda();
        }

        private async void animarCuerdaVibranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuerda cue = new Cuerda(bits, pbLienzo, Color.DarkGreen);

            double t = 0;
            do
            {
                cue.T = t;

                cue.COLOR0 = Color.DarkGreen;
                cue.graficarCuerda();
                await Task.Delay(5);
                cue.COLOR0 = Color.White;
                cue.graficarCuerda();
                t += 0.04;
            } while (t < 20);
        }

        private void examParcial3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda o = new Onda(bits, pbLienzo, Color.DarkGreen);
            o.t = 1.5;
            o.ExamenP3();
        }

        private async void laminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda3D = new Onda(bits, pbLienzo, Color.DarkGreen);
            onda3D.m = 0.15;
            onda3D.t = 0;
            onda3D.v = 9.5;
            onda3D.w = 0.7;
            double t = 0.1, dt = 0, tf = 10;
            do
            {
                onda3D.COLOR0 = Color.DarkGreen;
                onda3D.Lamina3D();
                await Task.Delay(20);
                onda3D.COLOR0 = Color.White;
                onda3D.Lamina3D();
                onda3D.t = dt;
                dt += t;
            }
            while (dt <= tf);
        }
    }
}