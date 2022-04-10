using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public double IngresosNetosAnuales { get; set; }
        public Cobertura CoberturaAsociada { get; set; }
        public bool PuedeAccederCobertura(Cobertura cobertura)
        {
            return IngresosNetosAnuales > cobertura.CalcularCosto();
        }
        public Persona(string nombre,string apellido,int dni,DateTime fechaNacimiento, string ciudad,double ingresosNetosAnuales,Cobertura cobertura)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.FechaNacimiento = fechaNacimiento;
            this.Ciudad = ciudad;
            this.IngresosNetosAnuales = ingresosNetosAnuales;
            this.CoberturaAsociada = cobertura;
        }

    }
}
