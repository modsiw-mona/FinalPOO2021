using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOO.Clases
{
    class Premio : Bonus
    {
        public Premio(string id_carta, byte cant_cartas) : base(id_carta, cant_cartas)
        {

        }

        public string Tirar_cartas(Jugador j, Resto r)
        {
            try
            {
                if((j.Baraja.Count - cant_cartas) < 0)
                {
                    for(int i = 0; i < j.Baraja.Count; i++)
                    {
                        j.Entregar_carta(r.L_cartas_sobrantes, 0);
                    }
                    return "El jugador " + j.Nickname + " tiró todas las cartas";
                }
                else
                {
                    for(int i = 0; i < cant_cartas; i++)
                    {
                        j.Entregar_carta(r.L_cartas_sobrantes, 0);
                    }
                    return "El jugador " + j.Nickname + " tiró " + cant_cartas + " cartas";
                }               
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Tirar_cartas de la clase Premio " + e);
            }
        }
    }
}
