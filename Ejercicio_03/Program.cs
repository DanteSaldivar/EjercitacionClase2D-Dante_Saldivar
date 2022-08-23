using System;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroIngresado;

            bool retornoComprovacion;
            bool auxRespuesta;

            do
            {
                int auxPrimo = 1;
                int contadorDivision = 0;

                Console.WriteLine("Ingrese un numero:");
                retornoComprovacion = float.TryParse(Console.ReadLine(), out numeroIngresado);

                while (retornoComprovacion == false || numeroIngresado < 0)
                {
                    Console.WriteLine("Numero no valido. Reingrese un numero!");
                    retornoComprovacion = float.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                Console.WriteLine("Los numeros primos previos al numero son: ");

                do
                {
                    for (int i = 1; i <= auxPrimo; i++)
                    {
                        if (auxPrimo % i == 0)
                        {
                            contadorDivision++;
                        };
                    };

                    if (contadorDivision == 2)
                    {
                        Console.WriteLine(auxPrimo);
                    };

                    contadorDivision = 0;
                    auxPrimo++;

                } while (auxPrimo != numeroIngresado);

                Console.WriteLine("Desea ingresar otro numero? 'continuar', 'salir'");

                string respuesta = Console.ReadLine();

                auxRespuesta = respuesta.Equals("salir", StringComparison.OrdinalIgnoreCase);

            } while (auxRespuesta == false);


        }
    }
}
