using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using FinalPOO.Interfaces;

namespace FinalPOO.Clases
{
    class Jugador : IEntregarCarta
    {
        #region Atributos
        private string nickname;
        private List<cJuego> baraja;
        private byte apuesta_inicial;
        private byte puntos;
        #endregion

        #region Constructor
        public Jugador(string nickname, byte apuesta_inicial, byte puntos)
        {
            Nickname = nickname;
            baraja = new List<cJuego>();
            Apuesta_inicial = apuesta_inicial;
            Puntos = puntos;
        }
        #endregion

        #region Accesores
        public string Nickname
        {
            get => nickname;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new Exception("El nickname no puede estar vacio, ser nulo, ni menor a tres");
                else
                    nickname = value;
            }
        }
        public byte Apuesta_inicial
        {
            get => apuesta_inicial;
            set
            {
                if (value <= 0)
                    throw new Exception("La apuesta inicial debe ser mayor a cero");
                else
                    apuesta_inicial = value;
            }
        }
        public byte Puntos
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
        /*      
        public cJuego Recoger_carta(Resto resto)
        {

        }*/

        public string Entregar_carta(List<cJuego> destino, int indice)
        {
            try
            {
                cJuego c_temp = baraja.ElementAt(indice);
                destino.Add(c_temp);
                baraja.RemoveAt(indice);          
                return "El jugador " + nickname + " tiró la carta " + c_temp.Id_carta;
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error al entregar carta en la clase Jugador " + e);
            }
        }
        #endregion
    }
}
