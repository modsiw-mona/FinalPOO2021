using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOO.Clases
{
    abstract class Bonus : Carta
    {
        private string descripcion;

        public Bonus(string id_carta, string descripcion)
            : base(id_carta)

        {
            Descripcion = descripcion;
        }

        public string Descripcion
        {
            get => descripcion;

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 10)
                    throw new Exception("La descripcion no puede estar vacia, ser nula, ni menor a diez");
                else
                    descripcion = value;
            }
        }
    }
}
