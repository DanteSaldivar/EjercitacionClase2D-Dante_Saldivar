using System;
using MiBiblioteca;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacionIngresada;
            FigurasGeometricas? operacion = null;
            double numeroIngresado;
            double numeroIngresadoAuxiliar;
            double resultado = 0;
            bool auxComprovacion;

            Console.WriteLine("Que operacion desea realizar? \n1-Calcular area de un cuadrado\n2-Calcular Area de un triangulo\n" +
                "3-Calcular area de un circulo");

            auxComprovacion = int.TryParse(Console.ReadLine(), out operacionIngresada);

            while (!Validador.ValidarRango(operacionIngresada, 0, 4))
            {
                Console.WriteLine("~~~ERROR~~~\nQue operacion desea realizar? \n1-Calcular area de un cuadrado\n2-Calcular Area de un triangulo\n" +
                "3-Calcular area de un circulo");
                auxComprovacion = int.TryParse(Console.ReadLine(), out operacionIngresada);
            }

            switch (operacionIngresada)
            {
                case 1:
                    Console.WriteLine("Ingrese la longitud del Cuadrado: ");
                    double.TryParse(Console.ReadLine(), out numeroIngresado);
                    resultado = CalculadoraDeArea.CalcularAreaCuadrado(numeroIngresado);
                    operacion = FigurasGeometricas.Cuadrado;
                    break;
                case 2:
                    Console.WriteLine("Ingrese la base del triangulo: ");
                    double.TryParse(Console.ReadLine(), out numeroIngresado);
                    Console.WriteLine("Ingresa la altura del triangulo: ");
                    double.TryParse(Console.ReadLine(), out numeroIngresadoAuxiliar);
                    resultado = CalculadoraDeArea.CalcularAreaTriangulo(numeroIngresado, numeroIngresadoAuxiliar);
                    operacion = FigurasGeometricas.Cuadrado;
                    break;
                case 3:
                    Console.WriteLine("Ingrese el radio del cirulo: ");
                    double.TryParse(Console.ReadLine(), out numeroIngresado);
                    resultado = CalculadoraDeArea.CalcularAreaCirculo(numeroIngresado);
                    operacion = FigurasGeometricas.Cuadrado;
                    break;
            }


            Console.WriteLine($"El area del {operacion} es = {resultado} (m,cm,km)");

        }
    }
}
