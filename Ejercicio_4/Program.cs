using System;
using System.Reflection;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultadoAuxiliar;
            int productoNumero;
            float numeroPerfecto;
            bool esPrimo;
            int contadorDeNumeros;

            int contadorDivision;

            contadorDeNumeros = 0;


         
            for (int i = 0; contadorDeNumeros != 4; i++)
            {
                resultadoAuxiliar = (int)Math.Pow(2, i - 1);
                productoNumero = (int)(Math.Pow(2, i) - 1);

                contadorDivision = 0;
                esPrimo = false;

                for (int y = 1; y <= productoNumero; y++)
                {
                    if (productoNumero != 0)
                    {
                        if (productoNumero % y == 0)
                        {
                            contadorDivision++;
                        };
                    }
                };

                if (contadorDivision == 2)
                {
                    esPrimo = true; 
                };

                if (esPrimo == true)
                {
                    numeroPerfecto = resultadoAuxiliar * productoNumero;
                    contadorDeNumeros++;
                    Console.WriteLine($"El numero perfecto {contadorDeNumeros} es el {numeroPerfecto}"); 
                }
            }
        }
    }
}
