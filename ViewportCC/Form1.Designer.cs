namespace ViewportCC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLienzo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLazos = new System.Windows.Forms.Button();
            this.btnSegmento = new System.Windows.Forms.Button();
            this.btnParabola = new System.Windows.Forms.Button();
            this.btnPintarMisColores = new System.Windows.Forms.Button();
            this.btnDegragarMyColors = new System.Windows.Forms.Button();
            this.btnDegradar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEjes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnParcialUno = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLienzo
            // 
            this.pbLienzo.BackColor = System.Drawing.Color.White;
            this.pbLienzo.Location = new System.Drawing.Point(0, 0);
            this.pbLienzo.Name = "pbLienzo";
            this.pbLienzo.Size = new System.Drawing.Size(700, 500);
            this.pbLienzo.TabIndex = 0;
            this.pbLienzo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnLazos);
            this.panel1.Controls.Add(this.btnSegmento);
            this.panel1.Controls.Add(this.btnParabola);
            this.panel1.Controls.Add(this.btnPintarMisColores);
            this.panel1.Controls.Add(this.btnDegragarMyColors);
            this.panel1.Controls.Add(this.btnDegradar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(699, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 500);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dibujar Funciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLazos
            // 
            this.btnLazos.Location = new System.Drawing.Point(41, 332);
            this.btnLazos.Name = "btnLazos";
            this.btnLazos.Size = new System.Drawing.Size(115, 31);
            this.btnLazos.TabIndex = 6;
            this.btnLazos.Text = "Dibujar Lazos";
            this.btnLazos.UseVisualStyleBackColor = true;
            this.btnLazos.Click += new System.EventHandler(this.btnLazos_Click);
            // 
            // btnSegmento
            // 
            this.btnSegmento.Location = new System.Drawing.Point(41, 284);
            this.btnSegmento.Name = "btnSegmento";
            this.btnSegmento.Size = new System.Drawing.Size(115, 31);
            this.btnSegmento.TabIndex = 5;
            this.btnSegmento.Text = "Dibujar Figuras";
            this.btnSegmento.UseVisualStyleBackColor = true;
            this.btnSegmento.Click += new System.EventHandler(this.btnSegmento_Click);
            // 
            // btnParabola
            // 
            this.btnParabola.Location = new System.Drawing.Point(41, 237);
            this.btnParabola.Name = "btnParabola";
            this.btnParabola.Size = new System.Drawing.Size(115, 31);
            this.btnParabola.TabIndex = 4;
            this.btnParabola.Text = "Dibujar parábola";
            this.btnParabola.UseVisualStyleBackColor = true;
            this.btnParabola.Click += new System.EventHandler(this.btnParabola_Click);
            // 
            // btnPintarMisColores
            // 
            this.btnPintarMisColores.Location = new System.Drawing.Point(41, 116);
            this.btnPintarMisColores.Name = "btnPintarMisColores";
            this.btnPintarMisColores.Size = new System.Drawing.Size(115, 31);
            this.btnPintarMisColores.TabIndex = 3;
            this.btnPintarMisColores.Text = "pintar mis colores";
            this.btnPintarMisColores.UseVisualStyleBackColor = true;
            this.btnPintarMisColores.Click += new System.EventHandler(this.btnPintarMisColores_Click);
            // 
            // btnDegragarMyColors
            // 
            this.btnDegragarMyColors.Location = new System.Drawing.Point(41, 169);
            this.btnDegragarMyColors.Name = "btnDegragarMyColors";
            this.btnDegragarMyColors.Size = new System.Drawing.Size(115, 50);
            this.btnDegragarMyColors.TabIndex = 2;
            this.btnDegragarMyColors.Text = "degradar mis colores";
            this.btnDegragarMyColors.UseVisualStyleBackColor = true;
            this.btnDegragarMyColors.Click += new System.EventHandler(this.btnDegragarMyColors_Click);
            // 
            // btnDegradar
            // 
            this.btnDegradar.Location = new System.Drawing.Point(41, 73);
            this.btnDegradar.Name = "btnDegradar";
            this.btnDegradar.Size = new System.Drawing.Size(115, 23);
            this.btnDegradar.TabIndex = 1;
            this.btnDegradar.Text = "degradar";
            this.btnDegradar.UseVisualStyleBackColor = true;
            this.btnDegradar.Click += new System.EventHandler(this.btnDegradar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "pintar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPintar);
            // 
            // btnEjes
            // 
            this.btnEjes.Location = new System.Drawing.Point(12, 506);
            this.btnEjes.Name = "btnEjes";
            this.btnEjes.Size = new System.Drawing.Size(115, 31);
            this.btnEjes.TabIndex = 8;
            this.btnEjes.Text = "Mostrar Ejes";
            this.btnEjes.UseVisualStyleBackColor = true;
            this.btnEjes.Click += new System.EventHandler(this.btnEjes_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(740, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "Prueba";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnParcialUno
            // 
            this.btnParcialUno.Location = new System.Drawing.Point(600, 506);
            this.btnParcialUno.Name = "btnParcialUno";
            this.btnParcialUno.Size = new System.Drawing.Size(115, 31);
            this.btnParcialUno.TabIndex = 10;
            this.btnParcialUno.Text = "PARCIAL I";
            this.btnParcialUno.UseVisualStyleBackColor = true;
            this.btnParcialUno.Click += new System.EventHandler(this.btnParcialUno_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(414, 506);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 31);
            this.button5.TabIndex = 11;
            this.button5.Text = "CORRECION PARCIAL I";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 506);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 31);
            this.button6.TabIndex = 12;
            this.button6.Text = "3D";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 546);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnParcialUno);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEjes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbLienzo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbLienzo;
        private Panel panel1;
        private Button button1;
        private Button btnDegradar;
        private Button btnDegragarMyColors;
        private Button btnPintarMisColores;
        private Button btnParabola;
        private Button btnSegmento;
        private Button btnLazos;
        private Button button2;
        private Button btnEjes;
        private Button button3;
        private Button button4;
        private Button btnParcialUno;
        private Button button5;
        private Button button6;
    }
}