using System;
using MiBiblioteca;
namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseIngresada;
            double alturaIngresada;
            bool auxComprovacion;

            Console.WriteLine("Ingrese la base del triangulo: ");
            auxComprovacion = double.TryParse(Console.ReadLine(), out baseIngresada);
            while (!auxComprovacion)
            {
                Console.WriteLine("~~ERROR~~Ingrese la base del triangulo: ");
                auxComprovacion = double.TryParse(Console.ReadLine(), out baseIngresada);
            }

            Console.WriteLine("Ingrese la altura del triangulo: ");
            auxComprovacion = double.TryParse(Console.ReadLine(), out alturaIngresada);
            while (!auxComprovacion)
            {
                Console.WriteLine("~~ERROR~~Ingrese la altura del triangulo: ");
                auxComprovacion = double.TryParse(Console.ReadLine(), out alturaIngresada);
            }

            Console.WriteLine($"La hipotenusa del triangulo mide {Calculadora.CalcularHipotenusa(baseIngresada,alturaIngresada)} cm.");
        }
    }
}
