using System;
using MiBiblioteca;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool auxComprovacion;
            int primerNumeroIngresado;
            int segundoNumeroIngresado;
            float resultadoOperacion;
            string operadorMatematico;
            bool auxRespuesta;

            do
            {

                Console.WriteLine("Ingrese el primer numero para operar: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out primerNumeroIngresado);

                while (!auxComprovacion)
                {
                    Console.WriteLine("Numero no valido reingrese el numero: ");
                    auxComprovacion = int.TryParse(Console.ReadLine(), out primerNumeroIngresado);
                }

                Console.WriteLine("Ingrese un segundo numero para operar: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out segundoNumeroIngresado);

                while (!auxComprovacion)
                {
                    Console.WriteLine("Numero no valido reingrese el numero: ");
                    auxComprovacion = int.TryParse(Console.ReadLine(), out segundoNumeroIngresado);
                }

                Console.WriteLine("Ingrese la operacion que desea realizar ('+'; '-'; '*'; '/') : ");

                operadorMatematico = Console.ReadLine();

           
                while (operadorMatematico != "+" && operadorMatematico != "-" && operadorMatematico != "*" && operadorMatematico != "/") 
                {
                    Console.WriteLine("La operacion Ingresada no es valida reingrese la operacion que desea realizar: ");
                    operadorMatematico = Console.ReadLine();
                }

                resultadoOperacion = Calculadora.Calcular(primerNumeroIngresado,segundoNumeroIngresado,operadorMatematico);

                Console.WriteLine($"El resultado es {resultadoOperacion}");

                auxRespuesta = Validador.ValidarRespuesta("Desea volver a operar? S/N");

            } while (auxRespuesta);



        }
    }
}
