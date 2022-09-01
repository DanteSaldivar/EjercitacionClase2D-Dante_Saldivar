using System;

namespace Ejercicio_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Dante", "30/09/2001", 43726063);
            Persona persona2 = new Persona("Juan", "15/03/1996", 1568481);
            Persona persona3 = new Persona("Rafael", "26/01/2006", 12356189);

            Persona[] personas = new Persona[] { persona1, persona2, persona3 };

            foreach (Persona item in personas)
            {
                Console.Write(item.Mostrar());
                Console.WriteLine(item.esMayorDeEdad());
            }
            
        }
    }
}
