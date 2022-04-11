using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace LogicaDeNegocios
{
    public sealed class SingletonLogica
    {
        public List<Persona> Personas = new List<Persona>();
        public List<Cobertura> Coberturas = new List<Cobertura>();
        public List<Enfermedad> Enfermedades = new List<Enfermedad>();
        public List<Atencion> Atenciones = new List<Atencion>();

        private static SingletonLogica instancia = null;
        private SingletonLogica() { }
        public static SingletonLogica Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new SingletonLogica();
                }

                return instancia;
            }
        }
        public Enfermedad BuscarEnfermedad(int codigoEnfermedad)
        {
            Enfermedad enfermedad = (Enfermedad)Enfermedades.Where(x => x.Codigo == codigoEnfermedad);
            return enfermedad;
        }
        public double ValidarEnfermedad(Persona persona, Cobertura cobertura, int codigoEnfermedad, DateTime fecha)
        {
            if (persona.CoberturaAsociada.EnfermedadesIncluidadas.Contains(BuscarEnfermedad(codigoEnfermedad)))
            {
                Atencion atencion = new Atencion(Atenciones.Count(), fecha, BuscarEnfermedad(codigoEnfermedad), persona);
                return BuscarEnfermedad(codigoEnfermedad).Costo;
            }
            return 0;
        }
    }

}
