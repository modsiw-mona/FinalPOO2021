using System;
using System.Collections.Generic;
using System.Text;
using FinalPOO.Clases;

namespace FinalPOO.Interfaces
{
    interface IEntregarCarta
    {
        string Entregar_carta(List<cJuego> destino, int indice);
    }
}
