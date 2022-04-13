using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace LogicaDeNegocios
{
    public sealed class SingletonLogica
    {
        public Listas listas = new Listas();
        public SingletonPersistencia persistencia =  SingletonPersistencia.Instancia;

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
        //Metodo para probar el codigo
        public void CargarDatosIniciales()
        {
            Persona persona = new Persona("Mateo", "Sotelo", 43494564, DateTime.Now, "Rafaela", 1000000, null);
            listas.Personas.Add(persona);
            persistencia.GuardarListado(listas.Personas);

            Enfermedad enfermedad = new Enfermedad(1, "Alergica", "Polen", 4000);
            listas.Enfermedades.Add(enfermedad);
            persistencia.GuardarListado(listas.Enfermedades);
        }
        public Enfermedad BuscarEnfermedad(int codigoEnfermedad)
        {
            Enfermedad enfermedad = listas.Enfermedades.Find(x => x.Codigo == codigoEnfermedad);
            return enfermedad;
        }
        public Persona BuscarPersona(int dniPersona)
        {
            Persona persona = listas.Personas.Find(x => x.DNI == dniPersona);
            return persona;
        }
        public bool CargarAtencion(DateTime fechaAtencion, Enfermedad enfermedad,Persona persona)
        {
            Atencion nuevaAtencion = new Atencion(listas.Atenciones.Count(),fechaAtencion, enfermedad, persona);
            listas.Atenciones.Add(nuevaAtencion);
            persistencia.GuardarListado(listas.Atenciones);
            return true;
        }
        public double ValidarEnfermedad(Persona persona, Cobertura cobertura, int codigoEnfermedad, DateTime fecha)
        {
            if (persona.CoberturaAsociada.EnfermedadesIncluidadas.Contains(BuscarEnfermedad(codigoEnfermedad)))
            {
                Atencion atencion = new Atencion(listas.Atenciones.Count(), fecha, BuscarEnfermedad(codigoEnfermedad), persona);
                return BuscarEnfermedad(codigoEnfermedad).Costo;
            }
            return 0;
        }
    }

}
