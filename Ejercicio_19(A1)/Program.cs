using System;
using MiBiblioteca;

namespace Ejercicio_19_A1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool auxComprovacion;

            Console.WriteLine("Ingrese un numero entero para calcular su factorial: ");
            auxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!auxComprovacion || numeroIngresado < 0)
            {
                Console.WriteLine("Error~ Re~Ingrese un numero entero para calcular su factorial: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            Console.WriteLine($"El factorial de {numeroIngresado} es: {Calculadora.CalcularFactorial(numeroIngresado)}");
        }
    }
}
