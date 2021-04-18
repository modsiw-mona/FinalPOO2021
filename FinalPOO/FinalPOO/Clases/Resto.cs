using System;
using System.Collections.Generic;
using System.Text;
using FinalPOO.Interfaces;

namespace FinalPOO.Clases
{
    class Resto : IEntregarCarta
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
        public List<cJuego> L_cartas_sobrantes { get => l_cartas_sobrantes; }
        #endregion

        #region Metodos 
        public cJuego Entregar_carta()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
