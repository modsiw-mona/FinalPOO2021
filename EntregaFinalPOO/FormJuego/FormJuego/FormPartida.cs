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
using System.IO;

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
                if (num  <= l_rondas.Count)
                {
                    lbl_ronda.Text = "Ronda " + num;
                    l_reales.Add(l_rondas[num - 1]);
                    string s = Environment.NewLine + "--------RONDA: " + num.ToString() + "--------" + Environment.NewLine;                  

                    foreach (Jugada j in l_reales[num - 1].L_jugadas)
                    {
                        s += Environment.NewLine + j + Environment.NewLine;
                        tb_ultimaCarta.Text = j.Ultima_carta.ToString();

                        lbl_baraja1.Text = l_reales[num - 1].Barajas[0];
                        lbl_baraja2.Text = l_reales[num - 1].Barajas[1];
                        lbl_baraja3.Text = l_reales[num - 1].Barajas[2];
                        lbl_baraja4.Text = l_reales[num - 1].Barajas[3];
                    }
                    tb_jugadas.AppendText(s);
                    
                    if(num == l_rondas.Count)
                    {                     
                        for(int i = 0; i < l_reales[l_reales.Count - 1].L_jugadas.Count; i++)
                        {
                            if (l_reales[l_reales.Count - 1].L_jugadas.Count == i+1)
                            {
                                Editar_archivo(Form1.l_elegidos.ElementAt(i).Nickname, Form1.l_elegidos.ElementAt(i).Puntos, Form1.l_elegidos.ElementAt(i).Avatar);
                                MessageBox.Show("El jugador " + Form1.l_elegidos.ElementAt(i).Nickname + " fue el ganador");
                                break;
                            }
                        }                     
                        this.Close();
                        Form1 f1 = new Form1();
                        f1.Show();
                        Form1.l_elegidos.RemoveRange(0,4);
                        
                    }
                    num++;
                }
                else
                {
                    throw new Exception("Ya hubo un ganador");
                }                   
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un error en el boton para pasar de jugada " + err);
            }
        }

        #region Otros metodos
        
        private void Editar_archivo(string nickname, ushort puntos,ushort id_avatar)
        {
            try
            {
                string[] lineas = File.ReadAllLines("C:\\Users\\gabri\\Downloads\\players.txt");
                string[] split;
                File.Delete("C:\\Users\\gabri\\Downloads\\players.txt");
                using (StreamWriter sw = File.AppendText("C:\\Users\\gabri\\Downloads\\players.txt"))
                {
                    foreach (string linea in lineas)
                    {
                        split = linea.Split('|');
                        if (split[0].ToLower().Equals(nickname.ToLower()) && ushort.Parse(split[1]) == puntos && ushort.Parse(split[2]) == id_avatar)
                        {
                            continue;
                        }
                        else
                        {
                            sw.WriteLine(linea);
                        }
                    }
                }
                string nuevos = nickname + "|" + (puntos+100) + "|" + id_avatar;
                File.AppendAllText("C:\\Users\\gabri\\Downloads\\players.txt", nuevos);
                
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error al editar el archivo de jugadores " + e);
            }
                      
        }

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
