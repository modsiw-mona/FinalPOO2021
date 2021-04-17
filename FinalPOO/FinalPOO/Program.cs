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

            Estandar estandar1 = new Estandar("123", 'R', '2');
            Estandar estandar2 = new Estandar("234", 'A', '3');
            Estandar estandar3 = new Estandar("346", 'V', '8');

            Premio premio1 = new Premio("345", "bota dos cartas");
            Premio premio2 = new Premio("359", "bota tres cartas");

            Castigo castigo1 = new Castigo("345", "Recoge dos cartas");
            Castigo castigo2 = new Castigo("345", "Recoge tres cartas");

            cartasprueba1.Add(estandar1);
            cartasprueba1.Add(estandar2);
            cartasprueba1.Add(estandar3);

            cartasprueba1.Add(premio1);
            cartasprueba1.Add(premio2);

            cartasprueba1.Add(castigo1);
            cartasprueba1.Add(castigo2);

            //Resto resto = new Resto();
        }
    }
}
