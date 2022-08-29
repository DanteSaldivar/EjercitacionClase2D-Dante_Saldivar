using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class Validador
    {
        public static bool ValidarRespuesta(string pregunta)
        {
            bool auxRespuesta = false;
            string respuesta;

            if (pregunta != null)
            {
                Console.WriteLine(pregunta);
                respuesta = Console.ReadLine();

                auxRespuesta = respuesta.Equals("S", StringComparison.OrdinalIgnoreCase);
                
            }
            return auxRespuesta;
        }
    }
}
