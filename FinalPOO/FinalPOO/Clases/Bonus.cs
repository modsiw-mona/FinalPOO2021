using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOO.Clases
{
    abstract class Bonus : Carta
    {
        #region Atributos
        private string descripcion;
        #endregion

        #region Constructor
        public Bonus(string id_carta, string descripcion) : base(id_carta)
        {
            Descripcion = descripcion;
        }
        #endregion

        #region Accesores
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
        #endregion
    }
}
