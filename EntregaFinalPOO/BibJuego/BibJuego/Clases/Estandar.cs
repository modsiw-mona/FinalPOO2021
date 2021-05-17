using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJuego.Clases
{
    public class Estandar : cJuego
    {
        #region Atributos
        private char color;
        private char numero;
        #endregion

        #region Constructor
        public Estandar(string id_carta, char color, char numero) : base(id_carta)
        {
            Color = color;
            Numero = numero;
        }
        #endregion

        #region Accesores
        public char Color
        {
            get => color;
            set
            {
                if (char.IsWhiteSpace(value))
                    throw new Exception("El color de la carta estandar no puede estar en blanco");
                else
                    color = value;
            }
        }
        public char Numero
        {
            get => numero;
            set
            {
                if (char.IsWhiteSpace(value))
                    throw new Exception("El numero de la carta estandar no puede estar en blanco");
                else
                    numero = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return "[" + color + numero + "]";
        }
    }
}
