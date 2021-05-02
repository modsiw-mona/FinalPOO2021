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

                Jugador jugador1 = new Jugador("sof", 0);
                Jugador jugador2 = new Jugador("cornejo", 0);
                Jugador jugador3 = new Jugador("jorgito", 0);
                prueba1.Add(jugador1);
                prueba1.Add(jugador2);
                prueba1.Add(jugador3);

                Juego juego1 = new Juego(prueba1, "C:\\Users\\gabri\\Downloads\\Cartas2.txt", 7);

                /*
                foreach(Bonus b in juego1.L_bonus)
                {
                    Console.WriteLine(b.Id_carta);
                }*/
              
                foreach(string s in juego1.Iniciar_juego())
                {
                    Console.WriteLine(s);
                    //Console.ReadKey();
                }          
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
