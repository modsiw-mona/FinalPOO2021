using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOO.Clases
{
    /*Una jugada está compuesta por: 
        1. Indicar cual fue la ultima carta jugada
        2. Indicar de que jugador es el turno
        3. Indicar que movimiento fue efectuado (si pudo lanzar una carta al morro o si tuvo que agarrar una del resto)
               
    */
    class Jugada
    {
        #region Atributos
        private cJuego ultima_carta;
        private Jugador jugador;
        //Si tengo al jugador tambien tengo la baraja
        private string movimiento;
        #endregion

        #region Constructor
        public Jugada(cJuego ultima_carta, Jugador jugador)
        {
            Ultima_carta = ultima_carta;
            Jugador = jugador;
        }
        #endregion

        #region Accesores
        public string Movimiento 
        {
            get => movimiento; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El movimiento en la jugada no puede ser nulo o estar vacío");
                else
                    movimiento = value;
            }
        }
        public cJuego Ultima_carta { get => ultima_carta; set => ultima_carta = value; }
        public Jugador Jugador { get => jugador; set => jugador = value; }
        #endregion

        public override string ToString()
        {
            return "Ultima carta jugada " + ultima_carta + "\nTurno de " + jugador.Nickname + "\n" + movimiento + "\n";
        }
    }
}
