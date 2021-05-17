
namespace FormJuego
{
    partial class FormPartida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_jugadas = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_jugador1 = new System.Windows.Forms.GroupBox();
            this.lbl_baraja1 = new System.Windows.Forms.Label();
            this.picAvatar1 = new System.Windows.Forms.PictureBox();
            this.gb_jugador2 = new System.Windows.Forms.GroupBox();
            this.lbl_baraja2 = new System.Windows.Forms.Label();
            this.picAvatar2 = new System.Windows.Forms.PictureBox();
            this.gb_jugador3 = new System.Windows.Forms.GroupBox();
            this.lbl_baraja3 = new System.Windows.Forms.Label();
            this.picAvatar3 = new System.Windows.Forms.PictureBox();
            this.gb_jugador4 = new System.Windows.Forms.GroupBox();
            this.lbl_baraja4 = new System.Windows.Forms.Label();
            this.picAvatar4 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tb_ultimaCarta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_proxJugada = new System.Windows.Forms.Button();
            this.lbl_ronda = new System.Windows.Forms.Label();
            this.jugadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rondaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.gb_jugador1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar1)).BeginInit();
            this.gb_jugador2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar2)).BeginInit();
            this.gb_jugador3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar3)).BeginInit();
            this.gb_jugador4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rondaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_jugadas);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugadas";
            // 
            // tb_jugadas
            // 
            this.tb_jugadas.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_jugadas.Location = new System.Drawing.Point(6, 26);
            this.tb_jugadas.Multiline = true;
            this.tb_jugadas.Name = "tb_jugadas";
            this.tb_jugadas.ReadOnly = true;
            this.tb_jugadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_jugadas.Size = new System.Drawing.Size(188, 388);
            this.tb_jugadas.TabIndex = 1;
            // 
            // gb_jugador1
            // 
            this.gb_jugador1.Controls.Add(this.lbl_baraja1);
            this.gb_jugador1.Controls.Add(this.picAvatar1);
            this.gb_jugador1.Location = new System.Drawing.Point(231, 301);
            this.gb_jugador1.Name = "gb_jugador1";
            this.gb_jugador1.Size = new System.Drawing.Size(250, 125);
            this.gb_jugador1.TabIndex = 9;
            this.gb_jugador1.TabStop = false;
            this.gb_jugador1.Text = "Jugador 1";
            // 
            // lbl_baraja1
            // 
            this.lbl_baraja1.AutoSize = true;
            this.lbl_baraja1.Location = new System.Drawing.Point(15, 100);
            this.lbl_baraja1.Name = "lbl_baraja1";
            this.lbl_baraja1.Size = new System.Drawing.Size(13, 13);
            this.lbl_baraja1.TabIndex = 3;
            this.lbl_baraja1.Text = "1";
            this.lbl_baraja1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAvatar1
            // 
            this.picAvatar1.Location = new System.Drawing.Point(85, 15);
            this.picAvatar1.Name = "picAvatar1";
            this.picAvatar1.Size = new System.Drawing.Size(75, 75);
            this.picAvatar1.TabIndex = 2;
            this.picAvatar1.TabStop = false;
            // 
            // gb_jugador2
            // 
            this.gb_jugador2.Controls.Add(this.lbl_baraja2);
            this.gb_jugador2.Controls.Add(this.picAvatar2);
            this.gb_jugador2.Location = new System.Drawing.Point(538, 301);
            this.gb_jugador2.Name = "gb_jugador2";
            this.gb_jugador2.Size = new System.Drawing.Size(250, 125);
            this.gb_jugador2.TabIndex = 10;
            this.gb_jugador2.TabStop = false;
            this.gb_jugador2.Text = "Jugador 2";
            // 
            // lbl_baraja2
            // 
            this.lbl_baraja2.AutoSize = true;
            this.lbl_baraja2.Location = new System.Drawing.Point(15, 100);
            this.lbl_baraja2.Name = "lbl_baraja2";
            this.lbl_baraja2.Size = new System.Drawing.Size(35, 13);
            this.lbl_baraja2.TabIndex = 4;
            this.lbl_baraja2.Text = "label2";
            this.lbl_baraja2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAvatar2
            // 
            this.picAvatar2.Location = new System.Drawing.Point(85, 15);
            this.picAvatar2.Name = "picAvatar2";
            this.picAvatar2.Size = new System.Drawing.Size(75, 75);
            this.picAvatar2.TabIndex = 2;
            this.picAvatar2.TabStop = false;
            // 
            // gb_jugador3
            // 
            this.gb_jugador3.Controls.Add(this.lbl_baraja3);
            this.gb_jugador3.Controls.Add(this.picAvatar3);
            this.gb_jugador3.Location = new System.Drawing.Point(538, 38);
            this.gb_jugador3.Name = "gb_jugador3";
            this.gb_jugador3.Size = new System.Drawing.Size(250, 125);
            this.gb_jugador3.TabIndex = 11;
            this.gb_jugador3.TabStop = false;
            this.gb_jugador3.Text = "Jugador 3";
            // 
            // lbl_baraja3
            // 
            this.lbl_baraja3.AutoSize = true;
            this.lbl_baraja3.Location = new System.Drawing.Point(15, 100);
            this.lbl_baraja3.Name = "lbl_baraja3";
            this.lbl_baraja3.Size = new System.Drawing.Size(35, 13);
            this.lbl_baraja3.TabIndex = 5;
            this.lbl_baraja3.Text = "label3";
            this.lbl_baraja3.Click += new System.EventHandler(this.lbl_baraja3_Click);
            // 
            // picAvatar3
            // 
            this.picAvatar3.Location = new System.Drawing.Point(85, 15);
            this.picAvatar3.Name = "picAvatar3";
            this.picAvatar3.Size = new System.Drawing.Size(75, 75);
            this.picAvatar3.TabIndex = 2;
            this.picAvatar3.TabStop = false;
            // 
            // gb_jugador4
            // 
            this.gb_jugador4.Controls.Add(this.lbl_baraja4);
            this.gb_jugador4.Controls.Add(this.picAvatar4);
            this.gb_jugador4.Location = new System.Drawing.Point(231, 38);
            this.gb_jugador4.Name = "gb_jugador4";
            this.gb_jugador4.Size = new System.Drawing.Size(250, 125);
            this.gb_jugador4.TabIndex = 12;
            this.gb_jugador4.TabStop = false;
            this.gb_jugador4.Text = "Jugador 4";
            // 
            // lbl_baraja4
            // 
            this.lbl_baraja4.AutoSize = true;
            this.lbl_baraja4.Location = new System.Drawing.Point(15, 100);
            this.lbl_baraja4.Name = "lbl_baraja4";
            this.lbl_baraja4.Size = new System.Drawing.Size(35, 13);
            this.lbl_baraja4.TabIndex = 6;
            this.lbl_baraja4.Text = "label4";
            // 
            // picAvatar4
            // 
            this.picAvatar4.Location = new System.Drawing.Point(85, 15);
            this.picAvatar4.Name = "picAvatar4";
            this.picAvatar4.Size = new System.Drawing.Size(75, 75);
            this.picAvatar4.TabIndex = 2;
            this.picAvatar4.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dinosaurio.png");
            this.imageList1.Images.SetKeyName(1, "Zombie.png");
            this.imageList1.Images.SetKeyName(2, "Dragon.png");
            this.imageList1.Images.SetKeyName(3, "Monstruo.png");
            this.imageList1.Images.SetKeyName(4, "Gato.png");
            this.imageList1.Images.SetKeyName(5, "Calavera.png");
            // 
            // tb_ultimaCarta
            // 
            this.tb_ultimaCarta.Enabled = false;
            this.tb_ultimaCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ultimaCarta.Location = new System.Drawing.Point(529, 214);
            this.tb_ultimaCarta.Name = "tb_ultimaCarta";
            this.tb_ultimaCarta.Size = new System.Drawing.Size(41, 26);
            this.tb_ultimaCarta.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ultima carta jugada: ";
            // 
            // btn_proxJugada
            // 
            this.btn_proxJugada.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proxJugada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_proxJugada.Location = new System.Drawing.Point(683, 205);
            this.btn_proxJugada.Name = "btn_proxJugada";
            this.btn_proxJugada.Size = new System.Drawing.Size(105, 46);
            this.btn_proxJugada.TabIndex = 15;
            this.btn_proxJugada.Text = "Siguiente ronda";
            this.btn_proxJugada.UseVisualStyleBackColor = true;
            this.btn_proxJugada.Click += new System.EventHandler(this.btn_proxJugada_Click);
            // 
            // lbl_ronda
            // 
            this.lbl_ronda.AutoSize = true;
            this.lbl_ronda.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ronda.Location = new System.Drawing.Point(707, 12);
            this.lbl_ronda.Name = "lbl_ronda";
            this.lbl_ronda.Size = new System.Drawing.Size(60, 18);
            this.lbl_ronda.TabIndex = 16;
            this.lbl_ronda.Text = "label2";
            // 
            // jugadaBindingSource
            // 
            this.jugadaBindingSource.DataSource = typeof(BibJuego.Clases.Jugada);
            // 
            // rondaBindingSource
            // 
            this.rondaBindingSource.DataSource = typeof(BibJuego.Clases.Ronda);
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(BibJuego.Clases.Jugador);
            // 
            // FormPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ronda);
            this.Controls.Add(this.btn_proxJugada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ultimaCarta);
            this.Controls.Add(this.gb_jugador4);
            this.Controls.Add(this.gb_jugador3);
            this.Controls.Add(this.gb_jugador2);
            this.Controls.Add(this.gb_jugador1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPartida";
            this.Text = "FormPartida";
            this.Load += new System.EventHandler(this.FormPartida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_jugador1.ResumeLayout(false);
            this.gb_jugador1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar1)).EndInit();
            this.gb_jugador2.ResumeLayout(false);
            this.gb_jugador2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar2)).EndInit();
            this.gb_jugador3.ResumeLayout(false);
            this.gb_jugador3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar3)).EndInit();
            this.gb_jugador4.ResumeLayout(false);
            this.gb_jugador4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rondaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb_jugador1;
        private System.Windows.Forms.PictureBox picAvatar1;
        private System.Windows.Forms.GroupBox gb_jugador2;
        private System.Windows.Forms.PictureBox picAvatar2;
        private System.Windows.Forms.GroupBox gb_jugador3;
        private System.Windows.Forms.PictureBox picAvatar3;
        private System.Windows.Forms.GroupBox gb_jugador4;
        private System.Windows.Forms.PictureBox picAvatar4;
        private System.Windows.Forms.Label lbl_baraja1;
        private System.Windows.Forms.Label lbl_baraja2;
        private System.Windows.Forms.Label lbl_baraja3;
        private System.Windows.Forms.Label lbl_baraja4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tb_ultimaCarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource rondaBindingSource;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private System.Windows.Forms.Button btn_proxJugada;
        private System.Windows.Forms.Label lbl_ronda;
        private System.Windows.Forms.BindingSource jugadaBindingSource;
        private System.Windows.Forms.TextBox tb_jugadas;
    }
}