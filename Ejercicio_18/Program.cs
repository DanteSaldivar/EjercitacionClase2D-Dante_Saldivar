using System;
using MiBiblioteca;

namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaIngresado;
            int mesIngresado;
            int anioIngresado;
            double diasVividos;
            bool auxComprovacion;

            Console.WriteLine("Ingrese su fecha de nacimiento, empezando por: \nDia:");
            auxComprovacion = int.TryParse(Console.ReadLine(), out diaIngresado);

            while (!auxComprovacion || !Validador.ValidarRango(diaIngresado, 0, 32))
            {
                Console.WriteLine("Error reingrese el Dia:");
                auxComprovacion = int.TryParse(Console.ReadLine(), out diaIngresado);
            }

            Console.WriteLine("Ingrese el Mes:");
            auxComprovacion = int.TryParse(Console.ReadLine(), out mesIngresado);

            while (!auxComprovacion || !Validador.ValidarRango(mesIngresado, 0, 13))
            {
                Console.WriteLine("Error reingrese el Mes:");
                auxComprovacion = int.TryParse(Console.ReadLine(), out mesIngresado);
            }

            Console.WriteLine("Ingrese el Anio:");
            auxComprovacion = int.TryParse(Console.ReadLine(), out anioIngresado);

            while (!auxComprovacion)
            {
                Console.WriteLine("Error reingrese el Anio:");
                auxComprovacion = int.TryParse(Console.ReadLine(), out anioIngresado);
            }

            diasVividos = Calculadora.CalcularDiasVividos(diaIngresado, mesIngresado, anioIngresado);

            Console.WriteLine($"Usted ha vivido {(int)diasVividos} dias.");

        }
    }
}
