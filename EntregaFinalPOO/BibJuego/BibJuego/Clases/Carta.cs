using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJuego.Clases
{
    public abstract class Carta
    {
        #region Atributos
        protected string id_carta;
        #endregion

        #region Constructor
        public Carta(string id_carta)
        {
            Id_carta = id_carta;
        }
        #endregion

        #region Accesores
        public string Id_carta
        {
            get => id_carta;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("\nEl ID de la carta no puede estar vacío o ser nulo");
                else
                    id_carta = value;
            }
        }
        #endregion
    }
}
