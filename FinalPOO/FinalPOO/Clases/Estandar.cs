using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOO.Clases
{
    class Estandar : cJuego
    {
        private char color;
        private char numero;

        public Estandar(string id_carta, char color, char numero)

            : base(id_carta)

        {
            Color = color;
            Numero = numero;
        }

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
    }
}
