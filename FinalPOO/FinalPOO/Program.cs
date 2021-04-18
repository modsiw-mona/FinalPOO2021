using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalPOO.Clases;

namespace FinalPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> prueba1 = new List<Jugador>();

            Jugador jugador1 = new Jugador("sof", 50, 20);
            Jugador jugador2 = new Jugador("cornejo", 20, 30);

            prueba1.Add(jugador1);
            prueba1.Add(jugador2);

            List<Carta> cartasprueba1 = new List<Carta>();

            Estandar est;
            est = new Estandar("123", 'R', '2');
            cartasprueba1.Add(est);
            est = new Estandar("234", 'A', '3');
            cartasprueba1.Add(est);
            est = new Estandar("213", 'A', '8');
            cartasprueba1.Add(est);
            est = new Estandar("2566", 'V', '1');
            cartasprueba1.Add(est);
            est = new Estandar("312", 'V', '5');
            cartasprueba1.Add(est);
            est = new Estandar("211", 'B', '7');
            cartasprueba1.Add(est);
            est = new Estandar("212", 'B', '8');
            cartasprueba1.Add(est);
            est = new Estandar("214", 'B', '9');
            cartasprueba1.Add(est);

            Premio pre;
            pre = new Premio("342", "bota dos cartas");
            cartasprueba1.Add(pre);
            pre = new Premio("343", "bota 3 cartas");
            cartasprueba1.Add(pre);
            pre = new Premio("344", "bota 4 cartas");
            cartasprueba1.Add(pre);

            Juego juego1 = new Juego(prueba1, cartasprueba1, 3);

            Console.WriteLine("Cartas j1: ");
            foreach (cJuego c in juego1.L_jugadores.ElementAt(0).Baraja)
            {
                Console.WriteLine(c.Id_carta);
            }
            Console.WriteLine("Cartas j2: ");
            foreach (cJuego c in juego1.L_jugadores.ElementAt(1).Baraja)
            {
                Console.WriteLine(c.Id_carta);
            }
            Console.WriteLine("Cartas Resto: ");
            foreach (cJuego c in juego1.Resto.L_cartas_sobrantes)
            {
                Console.WriteLine(c.Id_carta);
            }
        }   
    }
}
