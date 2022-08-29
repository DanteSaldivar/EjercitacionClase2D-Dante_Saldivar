using System;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool comprovacion;
            int fechaInicio;
            int fechaFinal;

            bool esBisiesto;
            bool banderaPrimerMensaje;

            banderaPrimerMensaje = true;

            Console.WriteLine("Ingrese el anio por el que desea comenzar a contar: ");
            comprovacion = int.TryParse(Console.ReadLine(), out fechaInicio);

            while (!comprovacion)
            {
                Console.WriteLine("ERROR~~! Re-Ingrese el anio por el que desea comenzar a contar: ");
                comprovacion = int.TryParse(Console.ReadLine(), out fechaInicio);
            }
            ///PIDO HASTA EL ANIO DONDE DESEA CONTAR
            Console.WriteLine("Ingrese el anio hasta donde desea contar: ");
            comprovacion = int.TryParse(Console.ReadLine(), out fechaFinal);

            while (!comprovacion)
            {
                Console.WriteLine("ERROR~~! Re-Ingrese el anio hasta donde desea contar: ");
                comprovacion = int.TryParse(Console.ReadLine(), out fechaFinal);
            }

            for (int i = fechaInicio; i <= fechaFinal; i++)
            {
                esBisiesto = false;

                if (i % 4 == 0)
                { 
                    esBisiesto = true;

                    if (i % 100 == 0)
                    {
                        esBisiesto = false;

                        if (i % 400 == 0)
                        {
                            esBisiesto = true;
                        }
 
                    }
                }

                if (esBisiesto)
                {
                    if (banderaPrimerMensaje)
                    { 
                        Console.WriteLine("******************************");
                        Console.WriteLine("Los siguientes anios son bisiestos: ");
                        banderaPrimerMensaje = false;
                    }
                    Console.WriteLine(i);
                }
            }


        }
    }
}
