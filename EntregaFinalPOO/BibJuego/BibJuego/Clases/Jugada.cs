using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJuego.Clases
{
    public class Jugada
    {
        #region Atributos
        private cJuego ultima_carta;
        private Jugador jugador;
        
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
            return "Ultima carta jugada " + ultima_carta + Environment.NewLine +"Turno de " + jugador.Nickname + Environment.NewLine + movimiento + Environment.NewLine;
        }
    }
}
