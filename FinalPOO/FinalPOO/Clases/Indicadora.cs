using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOO.Clases
{
    class Indicadora : cJuego
    {
        #region Atributos
        private char color_o_numero;
        #endregion

        #region Constructor
        public Indicadora(string id_carta, char color_o_numero) : base(id_carta)
        {
            Color_o_numero = color_o_numero;
        }
        #endregion

        #region Accesores
        public char Color_o_numero
        {
            get => color_o_numero;
            set
            {
                if (char.IsWhiteSpace(value))
                    throw new Exception("La carta indicadora debe tener un color o numero, no puede estar en blanco");
                else
                    color_o_numero = value;
            }
        }
        #endregion
    }
}
