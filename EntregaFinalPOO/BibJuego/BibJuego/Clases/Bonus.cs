using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJuego.Clases
{
    public abstract class Bonus : Carta
    {
        #region Atributos
        protected byte cant_cartas;
        #endregion

        #region Constructor
        public Bonus(string id_carta, byte cant_cartas) : base(id_carta)
        {
            Cant_cartas = cant_cartas;
        }
        #endregion

        #region Accesores     
        public byte Cant_cartas
        {
            get => cant_cartas;
            set
            {
                if (value <= 0)
                    throw new Exception("La cantidad de cartas a recoger/tirar de las cartas Bonus no puede ser menor o igual a 0");
                else
                    cant_cartas = value;
            }
        }
        #endregion
    }
}
