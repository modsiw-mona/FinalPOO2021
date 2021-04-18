using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FinalPOO.Clases
{
    class Juego
    {
        #region Atributos
        private List<Jugador> l_jugadores;
        private List<Carta> l_cartas;
        private Resto resto;

        private List<cJuego> l_cjuego; 
        private List<Bonus> l_bonus;
        private List<cJuego> l_cartas_jugadas;
        #endregion

        #region Constructor
        public Juego(List<Jugador> l_jugadores, List<Carta> l_cartas)
        {
            L_jugadores = l_jugadores;
            L_cartas = l_cartas;

            l_cjuego = new List<cJuego>();
            l_bonus = new List<Bonus>();
            Barajar_cartas();
            Separar_cartas();
            l_cartas_jugadas = new List<cJuego>();

            resto = new Resto();
        }
        #endregion

        #region Accesores
        public List<Jugador> L_jugadores
        {
            get => l_jugadores;
            set
            {
                if (value.Count < 2)
                    throw new Exception("La lista de jugadores no puede ser menor a dos");
                else
                    l_jugadores = value;
            }
        }

        public List<Carta> L_cartas { get => l_cartas; set => l_cartas = value; }
        public Resto Resto {get => resto;}
        public List<cJuego> L_cjuego { get => l_cjuego; set => l_cjuego = value; }  
        public List<Bonus> L_bonus { get => l_bonus; set => l_bonus = value; }
        public List<cJuego> L_cartas_jugadas { get => l_cartas_jugadas; set => l_cartas_jugadas = value; }
        #endregion

        #region Metodos
        private void Barajar_cartas()
        {
            try
            {
                if (l_cartas.Count > 0)
                {
                    Random r = new Random();
                    for (int i = 0; i < l_cartas.Count; i++)
                    {
                        int j = r.Next(0, i);
                        Carta temp = l_cartas[j];
                        l_cartas[j] = l_cartas[i];
                        l_cartas[i] = temp;
                    }
                }
                else
                    throw new Exception("\nLa lista de cartas se encuentra vacía, no se pueden barajar las cartas\n");
            }
            catch(Exception e)
            {
                throw new Exception("\nOcurrió un error en el metodo Barajar_cartas de la clase Juego " + e);
            }
        }
        private void Separar_cartas()        
        {
            try
            {
                if (l_cartas.Count > 0)
                {
                    for (int i = 0; i < l_cartas.Count; i++)
                    {
                        if (l_cartas[i] is cJuego)
                        {
                            l_cjuego.Add(l_cartas.ElementAt(i) as cJuego);
                        }
                        else
                        {
                            l_bonus.Add(l_cartas.ElementAt(i) as Bonus);
                        }
                    }
                    l_cartas.RemoveRange(0, l_cartas.Count);
                }
                else
                    throw new Exception("\nLa lista de cartas se encuentra vacía, no se pueden separar las cartas\n");
            }
            catch(Exception e)
            {
                throw new Exception("\nOcurrió un error en el metodo Separar_cartas de la clase Juego " + e);
            }                 
        }
        private void Repartir_cartas(byte cartas_por_jugador)
        {
            try
            {
                if (l_cjuego.Count > 0 && (l_cjuego.Count / l_jugadores.Count) >= cartas_por_jugador)
                {
                    //l_cjuego.
                }
                else
                    throw new Exception("\nLa lista de cartas cJuego se encuentra vacía, no se pueden repartir las cartas a los jugadores\n");
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Repartir_cartas de la clase Juego " + e);
            }
        }
   
        private Resto Crear_resto()
        {
            try
            {
                if (l_cartas.Count > 0)
                {
                    Resto resto = new Resto();
                    for (int i = 0; i < l_cartas.Count; i++)
                    {
                        if (l_cartas[i] is cJuego)
                        {                     
                            resto.L_cartas_sobrantes.Add(l_cartas[i] as cJuego);
                            l_cartas.RemoveAt(i);
                        }
                    }
                    return resto;
                }
                else 
                {
                    //Resto resto2 = new Resto();
                    //return resto2;  
                    throw new Exception("\nLa lista de cartas principal se encuentra vacía actualmente");
                }
            }
            catch(Exception e)
            {
                throw new Exception("\nOcurrió un error en el metodo Crear_resto de la clase Juego " + e);
            }         
        }



        #endregion
    }
}
