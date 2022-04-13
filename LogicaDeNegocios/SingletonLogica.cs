using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using System.Net;
using System.Net.Mail;

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
            EnviarMail();
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
        public void EnviarMail()
        {
            MailAddress to = new MailAddress("msotelo111201@gmail.com");
            MailAddress from = new MailAddress("msotelo111201@gmail.com");
            MailMessage mail = new MailMessage(from, to);
            mail.Subject = "Nueva Atencion";
            mail.Body = "Se ha cargado una nueva atencion";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.Credentials = new NetworkCredential(
                "msotelo111201@gmail.com", "losceibos4");
            smtp.EnableSsl = true;

            Console.WriteLine("Mail enviado");
            smtp.Send(mail);
        }
    }

}
