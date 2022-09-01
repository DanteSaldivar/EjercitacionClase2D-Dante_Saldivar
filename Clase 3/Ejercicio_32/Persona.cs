using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    internal class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombrePersona,string fechaDeNacimento, int documentoIdentidad)
        {
            nombre = nombrePersona;
            fechaDeNacimiento = Convert.ToDateTime(fechaDeNacimento);
            dni = documentoIdentidad;
        }

        public string Nombre { set { nombre = value; } get { return nombre; } }
        public DateTime FechaDeNacimiento { set { fechaDeNacimiento = value; } get { return fechaDeNacimiento; } }
        public int Dni { set { dni = value; } get { return dni; } }

        
        private double CalcularEdad()
        {
            return (DateTime.Today.Year - FechaDeNacimiento.Year);
        }

        public string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();
            auxRetorno.AppendFormat($"Nombre: {Nombre}; DNI: {Dni}; Edad: {CalcularEdad()} años; ");
            return auxRetorno.ToString();
        }
        public string esMayorDeEdad()
        {
            string auxRetorno = "Es menor de edad.";
            if (this.CalcularEdad() > 17)
            {
                auxRetorno = "Es mayor de edad.";
            }
            return auxRetorno;
        }

    }
}
