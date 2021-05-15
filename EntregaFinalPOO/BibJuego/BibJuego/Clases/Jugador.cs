using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibJuego.Interfaces;

namespace BibJuego.Clases
{
    class Jugador : IEntregarCarta
    {
        #region Atributos
        private string nickname;
        private List<cJuego> baraja;
        private ushort puntos;
        #endregion

        #region Constructor
        public Jugador(string nickname, ushort puntos)
        {
            Nickname = nickname;
            baraja = new List<cJuego>();
            Puntos = puntos;
        }
        #endregion

        #region Accesores
        public string Nickname
        {
            get => nickname.ToUpper();
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new Exception("El nickname no puede estar vacio, ser nulo, ni menor a tres");
                else
                    nickname = value;
            }
        }
        public ushort Puntos
        {
            get => puntos;
            set
            {
                if (value < 0)
                    throw new Exception("Los puntos no pueden ser menor a cero");
                else
                    puntos = value;
            }
        }
        public List<cJuego> Baraja
        {
            get => baraja;
            set
            {
                if (value.Count < 0)
                    throw new Exception("El resto no puede ser menor a cero");
                else
                    baraja = value;
            }
        }
        #endregion

        #region Metodos     
        public string Entregar_carta(List<cJuego> destino, int indice)
        {
            try
            {
                cJuego c_temp = baraja.ElementAt(indice);
                destino.Add(c_temp);
                baraja.RemoveAt(indice);
                return "El jugador " + Nickname + " tiró la carta " + c_temp.Id_carta;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error al entregar carta en la clase Jugador " + e);
            }
        }
        #endregion
    }
}
