using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibJuego.Interfaces;

namespace BibJuego.Clases
{
    public class Resto :IEntregarCarta
    {
        #region Atributos 
        private List<cJuego> l_cartas_sobrantes;
        #endregion

        #region Constructor
        public Resto()
        {
            l_cartas_sobrantes = new List<cJuego>();
        }
        #endregion

        #region Accesores
        public List<cJuego> L_cartas_sobrantes { get => l_cartas_sobrantes; set => l_cartas_sobrantes = value; }
        #endregion

        #region Metodos 
        public string Entregar_carta(List<cJuego> destino, int indice)
        {
            try
            {
                if (l_cartas_sobrantes.Count != 0)
                {
                    cJuego s = l_cartas_sobrantes.ElementAt(indice);
                    destino.Add(L_cartas_sobrantes.ElementAt(indice));
                    L_cartas_sobrantes.RemoveAt(indice);
                    return "El resto entregó la carta " + s;
                }               
                else
                    throw new Exception("EL resto se quedó sin cartas");
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error al entregar carta desde la clase Resto " + e);
            }
        }
        #endregion
    }
}
