using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario;
            int auxCuenta;
            char[] arrayNumeros;
            string resultadoFuncion = null;
            int restoDivision;

            restoDivision = numeroEntero;
            do
            {
                auxCuenta = restoDivision % 2;
                resultadoFuncion += auxCuenta.ToString();
                restoDivision /= 2;

            } while (restoDivision >= 2);

            resultadoFuncion += restoDivision.ToString();
            arrayNumeros = resultadoFuncion.ToCharArray();
            Array.Reverse(arrayNumeros);

            numeroBinario = new string (arrayNumeros);

            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numeroBinario;
            char[] arrayNumeros;
            int lengthString;
            int auxNumero;
            int numeroDecimal;

            numeroDecimal = 0;
            numeroBinario = numeroEntero.ToString();
            arrayNumeros = numeroBinario.ToCharArray();
            lengthString = numeroBinario.Length;

            for (int i = 0; i < numeroBinario.Length; i++)
            {
                auxNumero =(int)char.GetNumericValue(arrayNumeros[lengthString - 1]);

                if (auxNumero != 0)
                {
                    numeroDecimal += (int)Math.Pow(i, 2);
                }
                lengthString--;
            }

            return numeroDecimal;
        }


    }
}
