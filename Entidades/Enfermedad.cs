using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermedad
    {
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public Enfermedad(int codigo, string tipo, string nombre, double costo)
        {
            this.Codigo = codigo;
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Costo = costo;
        }
    }
}
