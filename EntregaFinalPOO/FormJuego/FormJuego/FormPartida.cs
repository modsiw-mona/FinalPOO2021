using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibJuego.Clases;

namespace FormJuego
{
    public partial class FormPartida : Form
    {
        Juego juego = new Juego(Form1.l_elegidos, "C:\\Users\\gabri\\Downloads\\cartas2.txt", 7);
        List<Ronda> l_rondas = new List<Ronda>();
        List<Ronda> l_reales = new List<Ronda>();
        private ushort num = 1;
        public FormPartida()
        {            
            InitializeComponent();                 
        }
        private void FormPartida_Load(object sender, EventArgs e)
        {
            #region Nicknmames jugador
            gb_jugador1.Text = Form1.nick_j1;
            gb_jugador2.Text = Form1.nick_j2;
            gb_jugador3.Text = Form1.nick_j3;
            gb_jugador4.Text = Form1.nick_j4;
            #endregion

            #region Barajas iniciales          
            lbl_baraja1.Text = juego.Mostrar_baraja_jugador(0);
            lbl_baraja2.Text = juego.Mostrar_baraja_jugador(1);
            lbl_baraja3.Text = juego.Mostrar_baraja_jugador(2);
            lbl_baraja4.Text = juego.Mostrar_baraja_jugador(3);
            #endregion

            #region Avatars jugadores
            picAvatar1.Image = imageList1.Images[juego.L_jugadores[0].Avatar];
            picAvatar2.Image = imageList1.Images[juego.L_jugadores[1].Avatar];
            picAvatar3.Image = imageList1.Images[juego.L_jugadores[2].Avatar];
            picAvatar4.Image = imageList1.Images[juego.L_jugadores[3].Avatar];
            #endregion

            lbl_ronda.Text = "";

            l_rondas = juego.Iniciar_juego();
            
        }

        private void btn_proxJugada_Click(object sender, EventArgs e)
        {
            try
            {
                if (num <= l_rondas.Count)
                {
                    lbl_ronda.Text = "Ronda: " + num.ToString();
                    l_reales.Add(l_rondas[num - 1]);
                    string s = "Ronda " + num;

                    foreach(Jugada j in l_reales[num - 1].L_jugadas)
                    {
                        s += Environment.NewLine + j + Environment.NewLine;
                        tb_ultimaCarta.Text = j.Ultima_carta.ToString();                     
                    }
                    tb_jugadas.AppendText(s);

                    lbl_baraja1.Text = l_reales[num - 1].Barajas[0];
                    lbl_baraja2.Text = l_reales[num - 1].Barajas[1];
                    lbl_baraja3.Text = l_reales[num - 1].Barajas[2];
                    lbl_baraja4.Text = l_reales[num - 1].Barajas[3];

                    //if()
                   
                    num++;
                }
                else
                {
                    //MessageBox.Show("Hubo un ganador");
                    throw new Exception("Ya hubo un ganador");
                }                   
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un error en el boton para pasar de jugada " + err);
            }
        }

        #region Otros metodos
        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void lbl_baraja3_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {        
        }
        #endregion
    }
}
