using System;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreIngresado;
            bool auxComprovacion;
            int valorPorHora;
            int antiguedad;
            int horasTrabajadas;

            int totalCobroBruto;
            int aumentoPorAntiguedad;
            float descuentosVarios;
            float totalCobroNeto;
            
            string respuesta;
            bool auxRespuesta;

            do
            {
                ///PIDO EL NOMBRE
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombreIngresado = Console.ReadLine();

                ///PIDO EL PAGO POR HORA
                Console.WriteLine("Ingrese el valor de las horas de trabajo: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out valorPorHora);
                while (!auxComprovacion)
                {
                    Console.WriteLine("ERROR~~ Re-Ingrese el valor de las horas de trabajo: ");
                    auxComprovacion = int.TryParse(Console.ReadLine(), out valorPorHora);
                }
                ///PIDO LA ANTIGUEDAD
                Console.WriteLine("Ingrese su antiguedad(En anios): ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out antiguedad);
                while (!auxComprovacion)
                {
                    Console.WriteLine("ERROR~~ Re-Ingrese su antiguedad(En anios): ");
                    auxComprovacion = int.TryParse(Console.ReadLine(), out antiguedad);
                }
                ///PIDO LA CANTIDAD DE HORAS TRABAJADAS
                Console.WriteLine("Ingrese la cantidad de horas trabajas en el mes: ");
                auxComprovacion = int.TryParse(Console.ReadLine(), out horasTrabajadas);
                while (!auxComprovacion)
                {
                    Console.WriteLine("ERROR~~ Re-Ingrese la cantidad de horas trabajas en el mes: ");
                    auxComprovacion = int.TryParse(Console.ReadLine(), out horasTrabajadas);
                }

                aumentoPorAntiguedad = antiguedad * 150;
                totalCobroBruto = (valorPorHora * horasTrabajadas) + aumentoPorAntiguedad;
                descuentosVarios = (totalCobroBruto * 13) / 100;
                totalCobroNeto = totalCobroBruto - descuentosVarios;

                Console.WriteLine("********************************************************");
                Console.WriteLine($"Empleado:{nombreIngresado} ; Antiguedad: {antiguedad} anios; Pago por Hora: ${valorPorHora} pesos;");
                Console.WriteLine($"Total a cobrar en bruto: ${totalCobroBruto}.");
                Console.WriteLine($"Total a cobrar en Neto: ${totalCobroNeto}.");
                


                Console.WriteLine("Si desea ingresar otro empleado toque cualquier boton/Ingrese 'salir' terminar el programa: ");
                respuesta = Console.ReadLine();
                auxRespuesta = respuesta.Equals("salir", StringComparison.OrdinalIgnoreCase);
            } while (auxRespuesta == false);
        }
    }
}
