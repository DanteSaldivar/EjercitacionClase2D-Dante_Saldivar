using System;

namespace MiBiblioteca
{
    public class Validador
    {
        public static bool ValidarRango(int valor, int min, int maximo)
        {
            bool auxRetorno = valor > min && valor < maximo;

            return auxRetorno;
        }
        public static bool ValidarRespuesta(string mensajeDeValidacion)
        {
            string auxRespuesta;
            Console.WriteLine(mensajeDeValidacion);
            auxRespuesta = Console.ReadLine();

            return auxRespuesta == "S";
        }
    }   
}
