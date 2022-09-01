using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public static class Calculadora
    {
        public static int Calcular(int primerOperador, int segundoOperador, string operacionMatematica)
        {
            int auxOperacion = 0;
            if (operacionMatematica is not null)
            {
                switch (operacionMatematica)
                {
                    case "+":
                        auxOperacion = primerOperador + segundoOperador;
                        break;
                    case "-":
                        auxOperacion = primerOperador - segundoOperador;
                        break;
                    case "*":
                        auxOperacion = primerOperador * segundoOperador;   
                        break;
                    case "/":
                        if (Validar(segundoOperador))
                        {
                            auxOperacion = primerOperador / segundoOperador;
                        }
                        else 
                        {
                            Console.WriteLine("No se puede dividir por 0!!!!");
                        }
                        break;
                }

            }
            return auxOperacion;
        }

        //EJERCICIO N17 "PITAGORAS ESTARIA ORGULLOSO"
        public static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            double resultado = Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2);

            return Math.Sqrt(resultado);
        }

        //EJERCICIO N18 EL "EL TIEMPO PASA"

        public static double CalcularDiasVividos(int dia, int mes, int anio)
        {
            DateTime tiempoIngresado = new DateTime(anio,mes,dia);
            return (DateTime.Now - tiempoIngresado).TotalDays;
        
        }

        //EJERCICIO N19 A1 "CALCULAR UN FACTORIAL"

        public static int CalcularFactorial(int numero)
        {
            int auxRetorno = 1;

            for (int i = 1; i <= numero; i++)
            {
                auxRetorno *= i;
            }
            return auxRetorno;
        }

        private static bool Validar(int operador)
        {
            return operador != 0;
        }
    }
}
