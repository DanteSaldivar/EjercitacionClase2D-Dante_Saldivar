using System;
using System.Text;
using MiBiblioteca;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int productoAuxiliar;
            bool auxComprovacion;
           
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero entero y se mostrara su tabla de multiplicar: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);

                while (!auxComprovacion)
                {
                    Console.WriteLine("Ingrese un numero entero y se mostrara su tabla de multiplicar: ");
                    auxComprovacion = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                StringBuilder resultadoMultiplicacion = new StringBuilder();

                for (int i = 0; i < 11; i++)
                {
                    if (i != 0)
                    {
                        productoAuxiliar = numeroIngresado * i;

                        resultadoMultiplicacion.AppendFormat($"{numeroIngresado} x {i} = {productoAuxiliar}\n");
                    }
                }
                Console.WriteLine($"Tabla de multiplicar del numero {numeroIngresado}: ");
                Console.WriteLine(resultadoMultiplicacion.ToString());
                
            } while (Validador.ValidarRespuesta("Desea volver a ingresar otro numero? S/n"));


        }
    }
}
