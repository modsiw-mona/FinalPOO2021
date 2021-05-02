using System;
using System.Collections.Generic;
using System.IO;

namespace cartas
{
    public class Class1
    {

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("/Users/sof/Documents/GitHub/FinalPOO2021/Cartas2.txt");

            for (int i = 0; i < 4; i++) //4 colores
            {
                for (int j = 0; j < 10; j++) //10 numeros
                {
                    for (int k = 0; k < 2; k++) //2 de c/u
                    {
                        if (i == 0) //rojo red
                        {
                            sw.WriteLine("R" + j + "" + "-" + (k + 1) + "|" + 'R' + "|" + char.GetNumericValue(char.Parse(j + "")));
                        }
                        else if (i == 1) //verde green 
                        {
                            sw.WriteLine("G" + j + "" + "-" + (k + 1) + "|" + 'G' + "|" + char.GetNumericValue(char.Parse(j + "")));
                        }
                        else if (i == 2) //amarillo yellow
                        {
                            sw.WriteLine("Y" + j + "" + "-" + (k + 1) + "|" + 'Y' + "|" + char.GetNumericValue(char.Parse(j + "")));
                        }
                        else if (i == 3) //azul //blue
                        {
                            sw.WriteLine("B" + j + "" + "-" + (k + 1) + "|" + 'B' + "|" + char.GetNumericValue(char.Parse(j + "")));
                        }

                    }
                }
            }

            for (int i = 0; i < 4; i++) //4 colores
            {
                for (int j = 0; j < 5; j++) //3 veces/ tandas
                {
                    if (i == 0) //rojo red
                    {
                        sw.WriteLine("R" + "-" + (j + 1) + "|" + 'R');
                    }
                    else if (i == 1) //verde green 
                    {
                        sw.WriteLine("G" + "-" + (j + 1) + "|" + 'G');
                    }
                    else if (i == 2) //amarillo yellow
                    {
                        sw.WriteLine("Y" + "-" + (j + 1) + "|" + 'Y');
                    }
                    else if (i == 3) //azul //blue
                    {
                        sw.WriteLine("B" + "-" + (j + 1) + "|" + 'B');
                    }
                }
            }

            for (int i = 0; i < 2; i++) //2 tipos de cartas premio
            {
                for (int j = 0; j < 6; j++) //se repiten 6 veces
                {
                    if (i == 0) //premio 1 (bota una carta)
                    {
                        sw.WriteLine("Pre" + (i + 1) + "-" + (j + 1) + "|" + 1);

                    }
                    else if (i == 1) //premio 2 (bota dos cartas)
                    {
                        sw.WriteLine("Pre" + (i + 1) + "-" + (j + 1) + "|" + 2);
                    }
                }
            }

            for (int i = 0; i < 4; i++) //4 tipos de carta castigo
            {
                for (int j = 0; j < 3; j++) //3 veces
                {
                    if (i == 0) //castigo 1
                    {
                        sw.WriteLine("Cast" + (i + 1) + "-" + (j + 1) + "|" + 1);
                    }
                    else if (i == 1) //verde green 
                    {
                        sw.WriteLine("Cast" + (i + 1) + "-" + (j + 1) + "|" + 2);
                    }
                    else if (i == 2) //amarillo yellow
                    {
                        sw.WriteLine("Cast" + (i + 1) + "-" + (j + 1) + "|" + 3);
                    }
                    else if (i == 3) //azul //blue
                    {
                        sw.WriteLine("Cast" + (i + 1) + "-" + (j + 1) + "|" + 4);
                    }
                }
            }
            sw.Close();
        }
    }
}
