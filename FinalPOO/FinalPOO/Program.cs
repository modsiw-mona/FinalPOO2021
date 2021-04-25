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
            try
            {
                List<Jugador> prueba1 = new List<Jugador>();

                Jugador jugador1 = new Jugador("sof", 50, 20);
                Jugador jugador2 = new Jugador("cornejo", 20, 30);
                prueba1.Add(jugador1);
                prueba1.Add(jugador2);

                Juego juego1 = new Juego(prueba1, "C:\\Users\\gabri\\Downloads\\CartasArregladas.txt", 3);

                /* 
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

                List<cJuego> prueba33 = new List<cJuego>();
                jugador1.Entregar_carta(prueba33, 3);
                Console.WriteLine("Cartas j1: ");
                foreach (cJuego c in juego1.L_jugadores.ElementAt(0).Baraja)
                {
                    Console.WriteLine(c.Id_carta);
                }
                Console.WriteLine("Cartas prueba: ");
                foreach (cJuego c in prueba33)
                {
                    Console.WriteLine(c.Id_carta);
                }*/

                Console.WriteLine( juego1.Resto.L_cartas_sobrantes.Count());
                foreach(string s in juego1.Iniciar_juego())
                {
                    Console.WriteLine(s);
                    //Console.ReadKey();
                }
                
                //Console.WriteLine(juego1.Iniciar_juego().Count);

                
                
            }
            catch(Exception err)
            {
                Console.WriteLine("Ha ocurrido un error " + err);
            }
            finally
            {
                Console.WriteLine("Ha terminado la ejecución del programa");
            }

            
        }
    }
}
