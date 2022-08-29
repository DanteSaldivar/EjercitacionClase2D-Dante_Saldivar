using System;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMaximo;
            int numeroMinimo;
            float promedioNumeros;

            bool auxComprovacion;
            bool auxValidacion; 
            bool banderaPrimerIngreso;

            int contadorNumeros;
            int acumuladorNumeros;

            contadorNumeros = 0;
            numeroMaximo = 0;
            numeroMinimo = 0;
            acumuladorNumeros = 0;
            banderaPrimerIngreso = true;


            Console.WriteLine("Ingrese 10 numeros enteros en el rango de -100 y 100 : ");
            do
            {
                auxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
                auxValidacion = Validador.Validar(numeroIngresado, -100, 100);
                while (!auxComprovacion || !auxValidacion)
                {
                    Console.WriteLine("ERROR~~ Re- Ingrese el numero: ");
                    auxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
                    auxValidacion = Validador.Validar(numeroIngresado, -100, 100);
                }
               
                if (banderaPrimerIngreso)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                    banderaPrimerIngreso = false;
                }
                numeroMaximo = Math.Max(numeroIngresado, numeroMaximo);
                numeroMinimo = Math.Min(numeroIngresado, numeroMinimo);

                acumuladorNumeros += numeroIngresado;
                contadorNumeros ++;
            } while (contadorNumeros != 10);

            promedioNumeros = acumuladorNumeros / 10;

            Console.WriteLine($"El valor minimo ingresado es: {numeroMinimo}\nEl Valor maximo ingresado es: {numeroMaximo}\n" +
                $"El Promedio de los numeros es: {promedioNumeros}");

        }
    }
}
