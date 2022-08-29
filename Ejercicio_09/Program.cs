using System;

namespace Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumeroIngresado;
            int contadorEspacioBlanco;

            bool auxComprovacion;
           // bool banderaPrimerMensaje;

           // banderaPrimerMensaje = true;

            Console.WriteLine("Ingrese la altura para el triangulo rectangulo: ");
            auxComprovacion = int.TryParse(Console.ReadLine(), out NumeroIngresado);
            while (!auxComprovacion || NumeroIngresado < 0)
            {
                Console.WriteLine("ERROR~~~ Re-Ingrese la altura para el triangulo rectangulo: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out NumeroIngresado);
            }

            contadorEspacioBlanco = NumeroIngresado;

            for (int i = 0; i < NumeroIngresado; i++)
            {

                for (int z = 0; z < contadorEspacioBlanco - 1; z++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    { 
                        Console.Write("**");
                    
                    }
                }
                Console.WriteLine();
                contadorEspacioBlanco--;
            }
        }
    }
}
