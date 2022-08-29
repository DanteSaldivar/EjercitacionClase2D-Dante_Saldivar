using System;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int contadorAux;

            bool comprovacion;
            int acumuladorNumerosA;
            int acumuladorNumerosB;

            bool banderaPrimerCentro;

            banderaPrimerCentro = false;
            contadorAux = 1;
            


            Console.WriteLine("Ingrese un numero:");

            comprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);

            if (comprovacion)
            {
                while (contadorAux < numeroIngresado)
                {
                    contadorAux++;
                    acumuladorNumerosA = 0;
                    acumuladorNumerosB = 0;

                    for (int i = 0; i < contadorAux; i++)
                    {
                        acumuladorNumerosA += i;
                    }

                    for (int j = contadorAux + 1; j <= acumuladorNumerosA; j++)
                    {
                        if (acumuladorNumerosA == acumuladorNumerosB || acumuladorNumerosB > acumuladorNumerosA)
                        {
                            break;
                        }
                        acumuladorNumerosB += j;
                    }

                    if (acumuladorNumerosA == acumuladorNumerosB)
                    {
                        if (!banderaPrimerCentro)
                        {
                            Console.WriteLine("Los numeros centro encontrados son:");
                            banderaPrimerCentro = true;
                        }
                        Console.WriteLine(contadorAux);       
                    }
                }
            
            }
        }
    }
}
