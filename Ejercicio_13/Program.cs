using System;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroDecimal;
            string numeroBinario;
            bool AuxComprovacion;

            Console.WriteLine("Ingrese un numero entero para convertir en binario: ");
            AuxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);

            while (!AuxComprovacion)
            {
                Console.WriteLine("ERROR~~~ Re~Ingrese un numero entero para convertir en binario: ");
                AuxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            numeroBinario = Conversor.ConvertirDecimalABinario(numeroIngresado);
            Console.WriteLine($"El Binario de {numeroIngresado} es : {numeroBinario}");

            Console.WriteLine("Ingrese un Binario para convertir en Decimal: ");
            AuxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);

            while (!AuxComprovacion)
            {
                Console.WriteLine("ERROR~~~ Re~Ingrese un Binario para convertir en Decimal: ");
                AuxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            numeroDecimal = Conversor.ConvertirBinarioADecimal(numeroIngresado);
            Console.WriteLine($"El Decimal de {numeroIngresado} es : {numeroDecimal}");


        }
    }
}
