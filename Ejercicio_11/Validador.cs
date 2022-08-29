using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Validador
    {
       public static bool Validar(int valor, int min, int maximo)
        {
            bool auxRetorno = false;
           
            if (valor > min && valor < maximo)
            { 
                auxRetorno = true;
            }

            return auxRetorno;
        }
    }
}
