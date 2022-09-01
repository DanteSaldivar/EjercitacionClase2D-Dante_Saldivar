using System;

namespace Ejercicio_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se crea la cuenta: ");
            Cuenta cuentaUsuario = new Cuenta("Dante S", 5000);
            Console.WriteLine(cuentaUsuario.Mostrar());

            Console.WriteLine("Pago el netflix(-200)");

            cuentaUsuario.Retirar(200);
            Console.WriteLine(cuentaUsuario.Mostrar());

            Console.WriteLine("Recibo un pago de algo: ");
            cuentaUsuario.Ingresar(1740);
            Console.WriteLine(cuentaUsuario.Mostrar());

            Console.ReadKey();

            Console.WriteLine("Me robaron");
            cuentaUsuario.Retirar(7000);
            Console.WriteLine(cuentaUsuario.Mostrar());

            Console.WriteLine("me endeude, fin");
        }
    }
}
