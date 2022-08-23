using System;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroIngresado;
            float numeroAlCuadrado;
            float numeroAlCubo;


            bool comprovacion;

            Console.WriteLine("Ingrese un numero:");
            comprovacion = float.TryParse(Console.ReadLine(), out numeroIngresado);

            while ( comprovacion == false || numeroIngresado < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                comprovacion = float.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            numeroAlCuadrado = (float)Math.Pow(numeroIngresado, 2);
            numeroAlCubo = (float)Math.Pow(numeroIngresado, 3);

            Console.WriteLine($"El numero ingresado es {numeroIngresado}, el cuadrado es: {numeroAlCuadrado}, el cubo es: {numeroAlCubo}");



        }
    }
}
