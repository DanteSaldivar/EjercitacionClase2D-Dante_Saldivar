using System;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumuladorSuma;
            bool auxComprovacion;
            bool auxRespuesta;

            acumuladorSuma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entero para sumar: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
                while (!auxComprovacion)
                {
                    Console.WriteLine("Error~~ Re~Ingrese un numero entero: ");
                    auxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                acumuladorSuma += numeroIngresado;

                Console.WriteLine($"El total acumulado es de: {acumuladorSuma}");

                auxRespuesta = Validador.ValidarRespuesta("Desea continuar? S/N");

            } while (auxRespuesta);
        }
    }
}
