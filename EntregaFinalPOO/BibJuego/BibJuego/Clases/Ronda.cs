using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJuego.Clases
{
    public class Ronda
    {
        #region Atributos 
        private ushort n_ronda;
        private List<Jugada> l_jugadas;
        private List<string> barajas;
        #endregion

        #region Constructor
        public Ronda(ushort n_ronda)
        {
            N_ronda = n_ronda;
            l_jugadas = new List<Jugada>();
            barajas = new List<string>();
        }
        #endregion

        #region Accesores
        public ushort N_ronda
        {
            get => n_ronda;
            set
            {
                if (value <= 0)
                    throw new Exception("El número de ronda no puede ser menor o igual a 0");
                else
                    n_ronda = value;
            }
        }
        public List<Jugada> L_jugadas
        {
            get => l_jugadas;
            set
            {
                if (value.Count < 0)
                    throw new Exception("La lista de jugadas no puede ser menor a cero");
                else
                    l_jugadas = value;
            }
        }

        public List<string> Barajas
        {
            get => barajas;
            set
            {
                if (value.Count <= 0)
                    throw new Exception("El número de ronda no puede ser menor o igual a 0");
                else
                    barajas = value;
            }
        }
            


        #endregion

        public override string ToString()
        {
            string jugs = "";
            for (int i = 0; i < l_jugadas.Count; i++)
            {
                jugs += "\n" + l_jugadas[i];
            }
            return "-----RONDA " + n_ronda + "------" + "\n" + jugs;
        }
    }
}
