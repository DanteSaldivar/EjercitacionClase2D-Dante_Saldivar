using System;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumeroIngresado;

            bool auxComprovacion;

            Console.WriteLine("Ingrese la altura para el triangulo rectangulo: ");
            auxComprovacion = int.TryParse(Console.ReadLine(), out NumeroIngresado);
            while (!auxComprovacion || NumeroIngresado < 0)
            {
                Console.WriteLine("ERROR~~~ Re-Ingrese la altura para el triangulo rectangulo: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out NumeroIngresado);
            }

            for (int i = 0; i < NumeroIngresado; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

        }
    }
}
