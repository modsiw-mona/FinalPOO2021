using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJuego.Clases
{
    public class Castigo : Bonus
    {
        #region Constructor
        public Castigo(string id_carta, byte cant_cartas) : base(id_carta, cant_cartas)
        {

        }
        #endregion

        #region Metodos
        public string Recoger_cartas(Jugador j, Resto r)
        {
            try
            {
                string s = "";
                if (j.Baraja.Count == 0)
                    s = "CARTA CASTIGO: El jugador " + j.Nickname + " se había quedado sin cartas, pero como acabó con una indicadora tiene que recoger " + cant_cartas + " carta(s)";
                else
                    s = "CARTA CASTIGO: El jugador " + j.Nickname + " recogió " + cant_cartas + " carta(s)";

                for (int i = 0; i < cant_cartas; i++)
                {
                    r.Entregar_carta(j.Baraja, 0);
                }
                return s;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Entregar_cartas de la clase Castigo " + e);
            }
        }
        #endregion
    }
}
