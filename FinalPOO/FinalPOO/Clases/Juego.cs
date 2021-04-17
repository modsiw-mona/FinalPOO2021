using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOO.Clases
{
    class Juego
    {
        private List<Jugador> l_jugadores;
        private List<Carta> l_cartas;
        private Resto resto;

        private List<cJuego> l_cjuego;
        private List<Bonus> l_bonus;
        private List<cJuego> l_cartas_jugadas;

        public Juego(List<Jugador> l_jugadores, List<Carta> l_cartas, Resto resto)
        {
            L_jugadores = l_jugadores;
            L_cartas = l_cartas;
            this.resto = resto;
            Separar_cartas();
            l_cartas_jugadas = new List<cJuego>();
        }

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

        private void Separar_cartas()
        {
            //List<Carta>[] arreglo = new List<Carta>[2];
            //List<cJuego> 

            for(int i=0; i<l_cartas.Count; i++)
            {
                if(l_cartas[i] is cJuego)
                {
                    l_cartas.RemoveAt(i);
                    L_cjuego.Add(l_cartas[i] as cJuego);
                }
                else if(l_cartas[i] is Bonus)
                {
                    l_cartas.RemoveAt(i);
                    L_bonus.Add(l_cartas[i] as Bonus);
                }

            }
        }

        private Resto Crear_resto()
        {
            Resto resto = new Resto();

        }

    }
}
