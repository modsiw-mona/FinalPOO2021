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

            Juego juego1 = new Juego(prueba1, "C:\\Users\\gabri\\Downloads\\CartasPrueba.txt", 7);

            Console.WriteLine(juego1.Resto.L_cartas_sobrantes.Count);
                
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
        }   
    }
}
