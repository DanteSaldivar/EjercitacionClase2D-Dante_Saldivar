using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    internal class Cuenta
    {
        private string titular;
        private int cantidad;


        public Cuenta(string nombreDelTitular, int montoDeCuenta)
        {
            titular = nombreDelTitular;
            cantidad = montoDeCuenta;
        }
        public string Titular
        {
            get
            {
                return titular;
            }
        }
        public int Cantidad
        { 
            get
            {
                return cantidad;
            }
        }

        public string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();
            auxRetorno.AppendFormat($"Titular de la cuenta: {Titular}\nFondos de la cuenta: {Cantidad}");
            return auxRetorno.ToString();
        }

        public void Ingresar(int montoIngresado)
        {
            if (montoIngresado > 0)
            {
                cantidad += montoIngresado;
            }
        }

        public void Retirar(int montoIngresado)
        { 
            cantidad -= montoIngresado;
        }


    }
}
