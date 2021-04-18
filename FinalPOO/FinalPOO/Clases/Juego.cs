using System;
using System.Collections.Generic;
using System.Text;

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

            l_cjuego = Separar_cartas(true);
            l_bonus = Separar_cartas(false);
            l_cartas_jugadas = new List<cJuego>();

            resto = Crear_resto();
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

        public List<Carta> L_cartas
        {
            get => l_cartas;
            set
            {
                if (value.Count < 0)
                    throw new Exception("La lista de cartas no puede ser menor a cero");
                else
                    l_cartas = value;
            }
        }

        public Resto Resto {get => resto;}
        public List<cJuego> L_cjuego { get => l_cjuego; }
        public List<Bonus> L_bonus { get => l_bonus; }
        public List<cJuego> L_cartas_jugadas { get => l_cartas_jugadas; }
        #endregion

        #region Metodos
        private dynamic Separar_cartas(bool cJuego_o_Bonus)         //Retorna "dynamic" lo cual permite retornar tipos de objetos distintos manteniendo la estructura
        {
            try
            {
                bool b = false;
                List<cJuego> arr1 = new List<cJuego>();
                List<Bonus> arr2 = new List<Bonus>();

                for (int i = 0; i < l_cartas.Count; i++)
                {
                    if (l_cartas[i] is cJuego)
                    {
                        l_cartas.RemoveAt(i);
                        arr1.Add(l_cartas[i] as cJuego);
                    }
                    else if (l_cartas[i] is Bonus)
                    {
                        l_cartas.RemoveAt(i);
                        arr2.Add(l_cartas[i] as Bonus);
                    }
                }
                if (b == true) return arr1;                     //Si al metodo se le dice que el booleano es true, retorna la lista de tipo cJuego 
                else return arr2;                               //Si al metodo se le dice que el booleano es false, retorna la lista de tipo Bonus
            }
            catch(Exception e)
            {
                throw new Exception("\nOcurrió un error en el metodo Separar_cartas de la clase Juego " + e);
            }                 
        }
   
        private Resto Crear_resto()
        {
            try
            {
                Resto resto = new Resto();
                for (int i = 0; i < l_cartas.Count; i++)
                {
                    if (l_cartas[i] is cJuego)
                    {
                        l_cartas.RemoveAt(i);
                        resto.L_cartas_sobrantes.Add(l_cartas[i] as cJuego);
                    }
                }
                return Resto;
            }
            catch(Exception e)
            {
                throw new Exception("\nOcurrió un error en el metodo Crear_resto de la clase Juego " + e);
            }         
        }



        #endregion
    }
}
