
namespace FormJuego
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_seleccionarAvatar = new System.Windows.Forms.ComboBox();
            this.btn_agregarJugador = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_leaderboard = new System.Windows.Forms.ListBox();
            this.lb_jugadores = new System.Windows.Forms.ListBox();
            this.btn_elegirJugador = new System.Windows.Forms.Button();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_agregarJugador);
            this.groupBox1.Controls.Add(this.cb_seleccionarAvatar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nickname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el nickname";
            // 
            // tb_nickname
            // 
            this.tb_nickname.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nickname.Location = new System.Drawing.Point(6, 68);
            this.tb_nickname.Name = "tb_nickname";
            this.tb_nickname.Size = new System.Drawing.Size(202, 23);
            this.tb_nickname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione un avatar";
            // 
            // cb_seleccionarAvatar
            // 
            this.cb_seleccionarAvatar.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_seleccionarAvatar.FormattingEnabled = true;
            this.cb_seleccionarAvatar.Location = new System.Drawing.Point(9, 135);
            this.cb_seleccionarAvatar.Name = "cb_seleccionarAvatar";
            this.cb_seleccionarAvatar.Size = new System.Drawing.Size(199, 24);
            this.cb_seleccionarAvatar.TabIndex = 5;
            // 
            // btn_agregarJugador
            // 
            this.btn_agregarJugador.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarJugador.Location = new System.Drawing.Point(33, 367);
            this.btn_agregarJugador.Name = "btn_agregarJugador";
            this.btn_agregarJugador.Size = new System.Drawing.Size(153, 32);
            this.btn_agregarJugador.TabIndex = 6;
            this.btn_agregarJugador.Text = "Agregar jugador";
            this.btn_agregarJugador.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_jugar);
            this.groupBox2.Controls.Add(this.lb_jugadores);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(548, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Iniciar juego";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_elegirJugador);
            this.groupBox3.Controls.Add(this.lb_leaderboard);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(288, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 420);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Leaderboard";
            // 
            // lb_leaderboard
            // 
            this.lb_leaderboard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_leaderboard.FormattingEnabled = true;
            this.lb_leaderboard.ItemHeight = 16;
            this.lb_leaderboard.Location = new System.Drawing.Point(16, 30);
            this.lb_leaderboard.Name = "lb_leaderboard";
            this.lb_leaderboard.Size = new System.Drawing.Size(197, 340);
            this.lb_leaderboard.TabIndex = 1;
            // 
            // lb_jugadores
            // 
            this.lb_jugadores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jugadores.FormattingEnabled = true;
            this.lb_jugadores.ItemHeight = 16;
            this.lb_jugadores.Location = new System.Drawing.Point(6, 30);
            this.lb_jugadores.Name = "lb_jugadores";
            this.lb_jugadores.Size = new System.Drawing.Size(218, 84);
            this.lb_jugadores.TabIndex = 0;
            // 
            // btn_elegirJugador
            // 
            this.btn_elegirJugador.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elegirJugador.Location = new System.Drawing.Point(16, 376);
            this.btn_elegirJugador.Name = "btn_elegirJugador";
            this.btn_elegirJugador.Size = new System.Drawing.Size(197, 32);
            this.btn_elegirJugador.TabIndex = 2;
            this.btn_elegirJugador.Text = "Elegir jugador";
            this.btn_elegirJugador.UseVisualStyleBackColor = true;
            // 
            // btn_jugar
            // 
            this.btn_jugar.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jugar.Location = new System.Drawing.Point(34, 130);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(166, 32);
            this.btn_jugar.TabIndex = 1;
            this.btn_jugar.Text = "Iniciar partida";
            this.btn_jugar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FormJuego.Properties.Resources.Uno;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(548, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 129);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.BackgroundImage = global::FormJuego.Properties.Resources._51372;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.SeaGreen;
            this.button3.Location = new System.Drawing.Point(636, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 53);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.BackgroundImage = global::FormJuego.Properties.Resources.info;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(548, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 53);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.BackgroundImage = global::FormJuego.Properties.Resources._61208;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(725, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Uno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_seleccionarAvatar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nickname;
        private System.Windows.Forms.Button btn_agregarJugador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.ListBox lb_jugadores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_elegirJugador;
        private System.Windows.Forms.ListBox lb_leaderboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

