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
    public partial class Form1 : Form
    {
        enum l_avatars { Dinosaurio, Zombie, Dragón, Monstruo, Michi, Calavera}
        List<Jugador> l_jugadores = new List<Jugador>();
        public static List<Jugador> l_elegidos = new List<Jugador>();

        public static string nick_j1;
        public static string nick_j2;
        public static string nick_j3;
        public static string nick_j4;
       
        public Form1()
        {
            InitializeComponent();
            l_jugadores = Cargar_jugadores("C:\\Users\\gabri\\Downloads\\players.txt");
            lb_leaderboard.DataSource = l_jugadores;
            cb_seleccionarAvatar.DataSource = Enum.GetValues(typeof(l_avatars));
        }
    
        #region Metodos de listbox
        public List<Jugador> Cargar_jugadores(string ruta)
        {
            try
            {
                List<Jugador> l_temp = new List<Jugador>();
                
                Jugador j_temp;
                StreamReader archivo;
                string linea;
                string[] info_jugadores;

                archivo = new StreamReader(ruta);

                linea = archivo.ReadLine();

                while(linea != null)
                {
                    info_jugadores = linea.Split('|');
                    j_temp = new Jugador(info_jugadores[0], ushort.Parse(info_jugadores[1]), ushort.Parse(info_jugadores[2]));

                    l_temp.Add(j_temp);
                    linea = archivo.ReadLine();
                }
                return l_temp;
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error al cargar los jugadores " + e);
            }
        }
        #endregion

        #region Metodos de botones
        private void btn_agregarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                Jugador jugador_temp;
                jugador_temp = new Jugador(tb_nickname.Text, 0, (ushort)cb_seleccionarAvatar.SelectedIndex);
                string elementos = tb_nickname.Text.ToUpper() + "|" + 0 + "|" + cb_seleccionarAvatar.SelectedIndex;
                l_jugadores.Add(jugador_temp);

                lb_leaderboard.DataSource = null;
                lb_leaderboard.DataSource = l_jugadores;
                tb_nickname.Clear();

                File.AppendAllText("C:\\Users\\gabri\\Downloads\\players.txt", Environment.NewLine + elementos );
            }
            catch(Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al crear un jugador " + err);
            }
        }
        private void btn_elegirJugador_Click(object sender, EventArgs e)
        {
            try
            {
                if (l_elegidos.Contains((Jugador)lb_leaderboard.SelectedItem))
                    throw new Exception("Ese jugador ya fue seleccionado previamente");
                else if (l_elegidos.Count == 4)
                    throw new Exception("Ya fueron ingresados 4 jugadores");
                else
                {
                    l_elegidos.Add((Jugador)lb_leaderboard.SelectedItem);
                    lb_jugadores.DataSource = null;
                    lb_jugadores.DataSource = l_elegidos;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un error al elegir jugador " + err);
            }
        }
        private void btn_jugar_Click(object sender, EventArgs e)
        {
            try
            {
                if (l_elegidos.Count != 4)
                    throw new Exception("Tienes que elegir 4 jugadores");
                else
                {
                    nick_j1 = l_elegidos[0].Nickname;
                    nick_j2 = l_elegidos[1].Nickname;
                    nick_j3 = l_elegidos[2].Nickname;
                    nick_j4 = l_elegidos[3].Nickname;

                    FormPartida f2 = new FormPartida();
                    f2.Show();
                    this.Hide();
                }
             
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un error en el boton Jugar " + err);
            }
        }
        //Boton cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(1);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un error al cerrar la aplicación " + err);
            }
        }

        //Boton como jugar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("COMO JUGAR?" + Environment.NewLine + Environment.NewLine + "Este proyecto es una simulación del juego 'Uno', para comenzar el juego" +
                    " lo primero que debes hacer es elegir 4 jugadores del leaderboard, despues de esto presiona 'Iniciar partida'." + Environment.NewLine + Environment.NewLine +
                    "Esto te llevara a una nueva pantalla donde está el tablero, a la izquierda hay una consola que explica a detalle cada movimiento de cada ronda, " +
                    "a la derecha hay un boton donde puedes pasar a la siguiente ronda" + Environment.NewLine + Environment.NewLine +
                    "La jugabilidad es practicamente la misma, la unica diferencia es que existen unas cartas especiales que si las tiras " +
                    "te puede tocar tanto un bonus como un castigo.");
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un error al mostrar información de como jugar " + err);
            }
        }

        //Boton info
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("INFORMACION SOBRE LOS CREADORES" + Environment.NewLine + Environment.NewLine + "Esta aplicación fue desarrollada" +
                    "por Sofia Arango Patiño y Gabriel Cornejo Botero estudiantes de ing de sistemas en la UPB sede Medellín, esta es la entrega" +
                    "final del curso Programación y diseño orientado a objetos 2021-01." + Environment.NewLine + Environment.NewLine + "Para el desarrollo" +
                    "de esta aplicación creamos una biblioteca de clases con los conceptos de la orientación a objetos y la conectamos con una " +
                    "aplicación de windows Forms en la que usamos lectura de archivos y mostramos el juego de la biblioteca de clases por medio " +
                    "de una interfaz grafica.");
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un error al mostrar información sobre los creadores " + err);
            }
        }
        #endregion

        private void cb_seleccionarAvatar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox combo = (ComboBox)sender;
                picAvatars.Image = imageListAvatars.Images[combo.SelectedIndex];             
            }
            catch(Exception err)
            {
                MessageBox.Show("Ocurrió un error en el combo para elegir Avatar " + err);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
