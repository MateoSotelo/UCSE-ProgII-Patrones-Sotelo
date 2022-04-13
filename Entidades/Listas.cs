using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Listas
    {
        public List<Persona> Personas { get; set; }
        public List<Atencion> Atenciones { get; set; }
        public List<Cobertura> Coberturas { get; set; }
        public List<Enfermedad> Enfermedades { get; set; }
        public Listas(List<Persona> personas = null, List<Atencion> atenciones = null, List<Cobertura> coberturas = null, List<Enfermedad> enfermedades = null)
        {
            this.Personas = personas; ;
            this.Atenciones = atenciones;
            this.Coberturas = coberturas;
            this.Enfermedades = enfermedades;
        }
        public Listas()
        {
            this.Personas = new List<Persona>();
            this.Atenciones = new List<Atencion>();
            this.Coberturas = new List<Cobertura>();
            this.Enfermedades = new List<Enfermedad>();
        }
        
    }
}
