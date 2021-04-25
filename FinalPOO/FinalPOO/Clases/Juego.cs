using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace FinalPOO.Clases
{
    class Juego
    {
        #region Atributos
        private List<Jugador> l_jugadores;
        private List<Carta> l_cartas;
        private Resto resto;
        private byte cartas_repartir;

        private List<cJuego> l_cjuego; 
        private List<Bonus> l_bonus;
        private List<cJuego> l_cartas_jugadas;
        #endregion

        #region Constructor
        public Juego(List<Jugador> l_jugadores, string ruta_l_cartas, byte cartas_repartir)
        {
            L_jugadores = l_jugadores;
            l_cartas = Cargar_cartas(ruta_l_cartas);
            Cartas_repartir = cartas_repartir;

            l_cjuego = new List<cJuego>();
            l_bonus = new List<Bonus>();
            Barajar_cartas();
            Separar_cartas();
            l_cartas_jugadas = new List<cJuego>();
            Repartir_cartas();

            resto = Crear_resto();
        }
        #endregion

        #region Accesores
        public List<Jugador> L_jugadores
        {
            get => l_jugadores;
            set
            {
                if (value.Count < 2)
                    throw new Exception("La lista de jugadores no puede ser menor a dos");
                else
                    l_jugadores = value;
            }
        }
        public List<Carta> L_cartas { get => l_cartas; set => l_cartas = value; }
        public Resto Resto {get => resto;}
        public List<cJuego> L_cjuego { get => l_cjuego; /*set => l_cjuego = value; */}  
        public List<Bonus> L_bonus { get => l_bonus; /*set => l_bonus = value;*/ }
        public List<cJuego> L_cartas_jugadas { get => l_cartas_jugadas; /*set => l_cartas_jugadas = value; */}
        public byte Cartas_repartir 
        { 
            get => cartas_repartir; 
            set
            {
                if (value < 2 && value > 10)
                    throw new Exception("No se pueden repartir menos de dos cartas o más de 10 cartas");
                else
                    cartas_repartir = value;
            }
        }
        #endregion

        #region Metodos iniciales (Para preparar el juego, van en el constructor)

        private List<Carta> Cargar_cartas(string ruta)
        {
            try
            {
                List<Carta> l_cartas_temp = new List<Carta>();
                string linea;
                StreamReader archivo = new StreamReader(ruta);
                string[] info_archivo;
                
                Estandar e_temp;
                Indicadora i_temp;
                byte contador = 0;

                linea = archivo.ReadLine();
                while(linea != null)
                {
                    info_archivo = linea.Split('|');
                    if(contador < 80)
                    {
                        e_temp = new Estandar(info_archivo[0], char.Parse(info_archivo[1]), char.Parse(info_archivo[2]));
                        l_cartas_temp.Add(e_temp);
                    }
                    else
                    {
                        i_temp = new Indicadora(info_archivo[0], char.Parse(info_archivo[1]));
                        l_cartas_temp.Add(i_temp);
                    }
                    contador++;
                    linea = archivo.ReadLine();
                }
                return l_cartas_temp;
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Cargar_cartas de la clase Juego " + e);
            }
        }

        private void Barajar_cartas()
        {
            try
            {
                if (l_cartas.Count > 0)
                {
                    Random r = new Random();
                    for (int i = 0; i < l_cartas.Count; i++)
                    {
                        int j = r.Next(0, i);
                        Carta temp = l_cartas[j];
                        l_cartas[j] = l_cartas[i];
                        l_cartas[i] = temp;
                    }
                }
                else
                    throw new Exception("\nLa lista de cartas se encuentra vacía, no se pueden barajar las cartas\n");
            }
            catch(Exception e)
            {
                throw new Exception("\nOcurrió un error en el metodo Barajar_cartas de la clase Juego " + e);
            }
        }
        private void Separar_cartas()
        {
            try
            {
                if (l_cartas.Count > 0)
                {
                    for (int i = 0; i < l_cartas.Count; i++)
                    {
                        if (l_cartas[i] is cJuego)
                        {
                            l_cjuego.Add(l_cartas.ElementAt(i) as cJuego);
                        }
                        else
                        {
                            l_bonus.Add(l_cartas.ElementAt(i) as Bonus);
                        }
                    }
                    l_cartas.RemoveRange(0, l_cartas.Count);
                }
                else
                    throw new Exception("\nLa lista de cartas se encuentra vacía, no se pueden separar las cartas\n");
            }
            catch(Exception e)
            {
                throw new Exception("\nOcurrió un error en el metodo Separar_cartas de la clase Juego " + e);
            }                 
        }
        private void Repartir_cartas()
        {
            try
            {
                if (l_cjuego.Count > 0 && l_jugadores.Count > 1 &&(l_cjuego.Count / l_jugadores.Count) >= cartas_repartir)
                {
                    for(int i=0; i<l_jugadores.Count; i++)
                    {
                        for(int j=0; j< cartas_repartir; j++)
                        {
                            l_jugadores.ElementAt(i).Baraja.Add(l_cjuego.ElementAt(j));
                            l_cjuego.RemoveAt(j);
                        }
                    }
                }
                else
                    throw new Exception("\nLa lista de cartas cJuego se encuentra vacía, no se pueden repartir las cartas a los jugadores\n");
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Repartir_cartas de la clase Juego " + e);
            }
        }
        private Resto Crear_resto()
        {
            try
            {
                if (l_cjuego.Count > 0)
                {
                    Resto resto = new Resto();
                    for (int i = 0; i < l_cjuego.Count; i++)
                    {
                        resto.L_cartas_sobrantes.Add(l_cjuego.ElementAt(i));                        
                    }
                    l_cjuego.RemoveRange(0, l_cjuego.Count);
                    return resto;
                }
                else 
                {
                    throw new Exception("\nLa lista de cartas principal se encuentra vacía actualmente");
                }
            }
            catch(Exception e)
            {
                throw new Exception("\nOcurrió un error en el metodo Crear_resto de la clase Juego " + e);
            }         
        }
        #endregion

        #region Metodos para jugar el juego
        
        public List<string> Iniciar_juego()
        {
            try
            {
                bool jugador_gano = false;
                List<string> jugadas = new List<string>();
                l_cartas_jugadas.Add(resto.L_cartas_sobrantes.ElementAt(0));
                resto.L_cartas_sobrantes.RemoveAt(0);
                jugadas.Add("INICIO EL JUEGO");

                for (int i = 0; i < l_jugadores.Count; i++)
                {
                    jugadas.Add(Mostrar_ultima_carta());

                    jugadas.Add("Es el turno de " + l_jugadores.ElementAt(i).Nickname);

                    jugadas.Add(Mostrar_baraja_jugador(i));

                    bool puede_jugar_carta = false;
                    //Ciclo que recorre la baraja del respectivo jugador
                    for (int j = 0; j < l_jugadores.ElementAt(i).Baraja.Count; j++)
                    {
                        //Si esta carta es estandar y la ultima carta jugada tambien es estandar
                        if (l_jugadores.ElementAt(i).Baraja.ElementAt(j) is Estandar && l_cartas_jugadas.Last() is Estandar)
                        {
                            //Si el color o el numero de la carta coinciden con el color o el número de la ultima carta jugada
                            if ((l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Estandar).Color.Equals((l_cartas_jugadas.Last() as Estandar).Color) ||
                                (l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Estandar).Numero.Equals((l_cartas_jugadas.Last() as Estandar).Numero))
                            {
                                jugadas.Add(l_jugadores.ElementAt(i).Entregar_carta(l_cartas_jugadas, j));
                                puede_jugar_carta = true;
                                break;
                            }
                        }
                        //----------------------------------------------------------------------

                        //Si la carta es indicadora y la ultima carta es Estandar
                        else if (l_jugadores.ElementAt(i).Baraja.ElementAt(j) is Indicadora && l_cartas_jugadas.Last() is Estandar)
                        {
                            if ((l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Indicadora).Color_o_numero.Equals((l_cartas_jugadas.Last() as Estandar).Color) ||
                                (l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Indicadora).Color_o_numero.Equals((l_cartas_jugadas.Last() as Estandar).Numero))
                            {
                                //Tira la carta a l_cartas_jugadas y pasa a la siguiente iteración
                                jugadas.Add(l_jugadores.ElementAt(i).Entregar_carta(l_cartas_jugadas, j));
                                puede_jugar_carta = true;
                                break;
                            }
                        }
                        //----------------------------------------------------------------------

                        //Hacer si es Estandar y la otra Indicadora
                        else if ((l_jugadores.ElementAt(i).Baraja.ElementAt(j) is Estandar && l_cartas_jugadas.Last() is Indicadora))
                        {
                            if ((l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Estandar).Color.Equals((l_cartas_jugadas.Last() as Indicadora).Color_o_numero) ||
                                (l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Estandar).Numero.Equals((l_cartas_jugadas.Last() as Indicadora).Color_o_numero))
                            {
                                //Tira la carta a l_cartas_jugadas y pasa a la siguiente iteración
                                jugadas.Add(l_jugadores.ElementAt(i).Entregar_carta(l_cartas_jugadas, j));
                                puede_jugar_carta = true;
                                break;
                            }
                        }
                        //----------------------------------------------------------------------

                        //Hacer si es indicadora y la otra tambien es indicadora
                        else if ((l_jugadores.ElementAt(i).Baraja.ElementAt(j) is Indicadora && l_cartas_jugadas.Last() is Indicadora))
                        {
                            if ((l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Indicadora).Color_o_numero.Equals((l_cartas_jugadas.Last() as Indicadora).Color_o_numero))
                            {
                                //Tira la carta a l_cartas_jugadas y pasa a la siguiente iteración
                                jugadas.Add(l_jugadores.ElementAt(i).Entregar_carta(l_cartas_jugadas, j));
                                puede_jugar_carta = true;
                                break;
                            }
                        }
                        //----------------------------------------------------------------------
                    }

                    if (puede_jugar_carta == false)
                        jugadas.Add(resto.Entregar_carta(l_jugadores.ElementAt(i).Baraja, 1));

                    jugadas.Add(Mostrar_baraja_jugador(i));                   
                }
                jugadas.Add(Mostrar_ultima_carta());


                //---------------------------------------------------------------------

                /*
                //Cada iteración del Do es como una ronda (1 jugada por cada jugador)
                //Habrán rondas hasta que uno de los jugadores se quede sin cartas
                do
                {
                    int iter = 0;
                    //Cada iteración del for es una jugada (primera iteración = jugada J1 y segunda iteración = jugada J2)
                    for(int i=0; i<l_jugadores.Count; i++)
                    {
                        //Verifica si la ultima carta jugada es Estandar o Indicadora y muestra cual es
                        if (l_cartas_jugadas.Last() is Estandar)
                        {
                            jugadas.Add("Carta de más arriba en la pila: " + (l_cartas_jugadas.Last() as Estandar).Color + "" + (l_cartas_jugadas.Last() as Estandar).Numero);
                        }
                        else if (l_cartas_jugadas.Last() is Indicadora)
                        {
                            jugadas.Add("Carta de más arriba en la pila: " + (l_cartas_jugadas.Last() as Indicadora).Color_o_numero);
                        }
                        //---------------------------------------------------------------------
                        
                        /*
                        string s_temp = "";
                        foreach(cJuego c in l_jugadores.ElementAt(i).Baraja)
                        {
                            s_temp += c.Id_carta + "  ";
                        }
                        jugadas.Add(s_temp);

                        bool puede_jugar_carta = false;
                        //Ciclo que recorre la baraja del respectivo jugador
                        for(int j=0; j<l_jugadores.ElementAt(i).Baraja.Count; j++)
                        {
                            //Si esta carta es estandar y la ultima carta jugada tambien es estandar
                            if(l_jugadores.ElementAt(i).Baraja.ElementAt(j) is Estandar && l_cartas_jugadas.Last() is Estandar)
                            {
                                //Si el color o el numero de la carta coinciden con el color o el número de la ultima carta jugada
                                if((l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Estandar).Color.Equals((l_cartas_jugadas.Last() as Estandar).Color) ||
                                    (l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Estandar).Numero.Equals((l_cartas_jugadas.Last() as Estandar).Numero))
                                {
                                    jugadas.Add(l_jugadores.ElementAt(i).Entregar_carta(l_cartas_jugadas, j));
                                    puede_jugar_carta = true;
                                    break;
                                }                               
                            }
                            //----------------------------------------------------------------------

                            //Si la carta es indicadora y la ultima carta es Estandar
                            else if(l_jugadores.ElementAt(i).Baraja.ElementAt(j) is Indicadora && l_cartas_jugadas.Last() is Estandar)
                            {
                                if ((l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Indicadora).Color_o_numero.Equals((l_cartas_jugadas.Last() as Estandar).Color) ||
                                    (l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Indicadora).Color_o_numero.Equals((l_cartas_jugadas.Last() as Estandar).Numero))
                                {
                                    //Tira la carta a l_cartas_jugadas y pasa a la siguiente iteración
                                    jugadas.Add(l_jugadores.ElementAt(i).Entregar_carta(l_cartas_jugadas, j));
                                    puede_jugar_carta = true;
                                    break;
                                }
                            }
                            //----------------------------------------------------------------------

                            //Hacer si es Estandar y la otra Indicadora
                            else if((l_jugadores.ElementAt(i).Baraja.ElementAt(j) is Estandar && l_cartas_jugadas.Last() is Indicadora))
                            {
                                if((l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Estandar).Color.Equals((l_cartas_jugadas.Last() as Indicadora).Color_o_numero) ||
                                    (l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Estandar).Numero.Equals((l_cartas_jugadas.Last() as Indicadora).Color_o_numero))
                                {
                                    //Tira la carta a l_cartas_jugadas y pasa a la siguiente iteración
                                    jugadas.Add(l_jugadores.ElementAt(i).Entregar_carta(l_cartas_jugadas, j));
                                    puede_jugar_carta = true;
                                    break;
                                }
                            }
                            //----------------------------------------------------------------------

                            //Hacer si es indicadora y la otra tambien es indicadora
                            else if((l_jugadores.ElementAt(i).Baraja.ElementAt(j) is Indicadora && l_cartas_jugadas.Last() is Indicadora))
                            {
                                if((l_jugadores.ElementAt(i).Baraja.ElementAt(j) as Indicadora).Color_o_numero.Equals((l_cartas_jugadas.Last() as Indicadora).Color_o_numero))
                                {
                                    //Tira la carta a l_cartas_jugadas y pasa a la siguiente iteración
                                    jugadas.Add(l_jugadores.ElementAt(i).Entregar_carta(l_cartas_jugadas, j));
                                    puede_jugar_carta = true;
                                    break;
                                }
                            }
                            //----------------------------------------------------------------------
                          
                        }
                        if(puede_jugar_carta == false)
                            jugadas.Add(resto.Entregar_carta(l_jugadores.ElementAt(i).Baraja, 5));
                                      
                    }
                    iter++;
                    if (iter == 2 || l_jugadores.ElementAt(0).Baraja.Count == 0 || l_jugadores.ElementAt(1).Baraja.Count == 0)
                        jugador_gano = true;


                } while (jugador_gano == false);
                */
                return jugadas;
            }
            catch(Exception e)
            {
                throw new Exception("\nHa ocurrido un error en el metodo Iniciar_juego de la clase Juego " + e);
            }        
        }

        public string Mostrar_ultima_carta()
        {
            try
            {
                if (l_cartas_jugadas.Count > 0)
                {
                    string s = " ";
                    if (l_cartas_jugadas.Last() is Estandar)
                    {
                        s = "Carta de más arriba en la pila: " + (l_cartas_jugadas.Last() as Estandar).Color + "" + (l_cartas_jugadas.Last() as Estandar).Numero;
                    }
                    else if (l_cartas_jugadas.Last() is Indicadora)
                    {
                        s = "Carta de más arriba en la pila: " + (l_cartas_jugadas.Last() as Indicadora).Color_o_numero;
                    }
                    return s;
                }
                else
                    throw new Exception("La lista de cartas jugadas está vacía");
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Mostrar_ultima_carta " + e);
            }         
        }
        public string Mostrar_baraja_jugador(int ind)
        {
            try
            {
                if (l_jugadores.ElementAt(ind).Baraja.Count > 0)
                {
                    string s_temp = "";
                    foreach (cJuego c in l_jugadores.ElementAt(ind).Baraja)
                    {
                        s_temp += c.Id_carta + "  ";
                    }
                    return s_temp;
                }
                else
                    return "El jugador " + l_jugadores.ElementAt(ind).Nickname + " ya no tiene cartas para jugar";
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Mostrar_baraja_jugador " + e);
            }         
        }    
        #endregion  
    }
}
