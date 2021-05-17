using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibJuego.Clases;

namespace BibJuego.Interfaces
{
    public interface IEntregarCarta
    {
        string Entregar_carta(List<cJuego> destino, int indice);
    }
}
