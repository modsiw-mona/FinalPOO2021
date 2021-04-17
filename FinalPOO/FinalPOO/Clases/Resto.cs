using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOO.Clases
{
    class Resto
    {
        private List<cJuego> l_cartas_sobrantes;

        public Resto()
        {
            l_cartas_sobrantes = new List<cJuego>();
        }

        public List<cJuego> L_cartas_sobrantes
        {
            get => l_cartas_sobrantes;

        }
    }
}
