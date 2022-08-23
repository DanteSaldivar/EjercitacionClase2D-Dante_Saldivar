using System;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroIngresado;

            float maxIngresado = 0;
            float minimoIngreado = 0;

            float acumulador = 0;
            float promedioDatos;


            bool comprovacion;

            Console.WriteLine("Ingrese 5 numeros:");

            for (int i = 0; i != 5; i++)
            {
                comprovacion = float.TryParse(Console.ReadLine(), out numeroIngresado);

                if (comprovacion == true)
                {
                    acumulador += numeroIngresado;

                    if (i == 0)
                    {
                        maxIngresado = numeroIngresado;
                        minimoIngreado = numeroIngresado;
                    }
                    else
                    {
                        if (maxIngresado < numeroIngresado)
                        {
                            maxIngresado = numeroIngresado;
                        }
                        if (minimoIngreado > numeroIngresado)
                        {
                            minimoIngreado = numeroIngresado;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Eso no es un numero!");
                    i--;
                }
            };

            promedioDatos = acumulador / 5;

            Console.WriteLine("El numero maximo es  {0}, el numero minimo  {1}, " +
                "el promedio es  {2}", maxIngresado, minimoIngreado, promedioDatos);

        }
    }
}
