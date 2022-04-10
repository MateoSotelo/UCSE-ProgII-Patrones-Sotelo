using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Entidades;

namespace Persistencia
{
    public class Principal
    {
        public const string path = @"C:\Users\msote\OneDrive\Documentos\Repositorios\UCSE-ProgII-Patrones-Sotelo\Jsons";
        public void GuardarListado(List<Persona> personas)
        {
            if (!File.Exists(path + @"\Personas.txt"))
            {
                File.Create(path + @"\Personas.txt");
                using (StreamWriter writer = new StreamWriter(path + @"\Personas.txt", false))
                {
                    string personasJson = JsonConvert.SerializeObject(personas);
                    writer.Write(personasJson);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path + @"\Personas.txt", false))
                {
                    string personasJson = JsonConvert.SerializeObject(personas);
                    writer.Write(personasJson);
                }
            }
        }
        public void GuardarListado(List<Atencion> atenciones)
        {
            if (!File.Exists(path + @"\Atenciones.txt"))
            {
                File.Create(path + @"\Atenciones.txt");
                using (StreamWriter writer = new StreamWriter(path + @"\Atenciones.txt", false))
                {
                    string atencionesJsons = JsonConvert.SerializeObject(atenciones);
                    writer.Write(atencionesJsons);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path + @"\Atenciones.txt", false))
                {
                    string atencionesJsons = JsonConvert.SerializeObject(atenciones);
                    writer.Write(atencionesJsons);
                }
            }
        }
        public void GuardarListado(List<Enfermedad> enfermedades)
        {
            if (!File.Exists(path + @"\Enfermedades.txt"))
            {
                File.Create(path + @"\Enfermedades.txt");
                using (StreamWriter writer = new StreamWriter(path + @"\Enfermedades.txt", false))
                {
                    string enfermedadesJsons = JsonConvert.SerializeObject(enfermedades);
                    writer.Write(enfermedadesJsons);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path + @"\Enfermedades.txt", false))
                {
                    string enfermedadesJsons = JsonConvert.SerializeObject(enfermedades);
                    writer.Write(enfermedadesJsons);
                }
            }
        }
        public void GuardarListado(List<Cobertura> coberturas)
        {
            if (!File.Exists(path + @"\Coberturas.txt"))
            {
                File.Create(path + @"\Coberturas.txt");
                using (StreamWriter writer = new StreamWriter(path + @"\Coberturas.txt", false))
                {
                    string coberturasJsons = JsonConvert.SerializeObject(coberturas);
                    writer.Write(coberturasJsons);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path + @"\Coberturas.txt", false))
                {
                    string coberturasJsons = JsonConvert.SerializeObject(coberturas);
                    writer.Write(coberturasJsons);
                }
            }
        }
        public List<Persona> LeerPersonas(List<Persona> personas)
        {
            if (File.Exists(path + @"\Personas.txt"))
            {
                using (StreamReader reader = new StreamReader(path + @"\Personas.txt"))
                {
                    string persona = reader.ReadToEnd();
                    personas = JsonConvert.DeserializeObject<List<Persona>>(persona);
                }

            }
            return personas;
        }
        public List<Atencion> LeerAtencion(List<Atencion> atenciones)
        {
            if (File.Exists(path + @"\Atenciones.txt"))
            {
                using (StreamReader reader = new StreamReader(path + @"\Atenciones.txt"))
                {
                    string atencion = reader.ReadToEnd();
                    atenciones = JsonConvert.DeserializeObject<List<Atencion>>(atencion);
                }

            }
            return atenciones;
        }
        public List<Enfermedad> LeerEnfermedades(List<Enfermedad> enfermedades)
        {
            if (File.Exists(path + @"\Enfermedades.txt"))
            {
                using (StreamReader reader = new StreamReader(path + @"\Enfermedades.txt"))
                {
                    string enfermedad = reader.ReadToEnd();
                    enfermedades = JsonConvert.DeserializeObject<List<Enfermedad>>(enfermedad);
                }

            }
            return enfermedades;
        }
        public List<Cobertura> LeerCoberturas(List<Cobertura> coberturas)
        {
            if (File.Exists(path + @"\Coberturas.txt"))
            {
                using (StreamReader reader = new StreamReader(path + @"\Coberturas.txt"))
                {
                    string cobertura = reader.ReadToEnd();
                    coberturas = JsonConvert.DeserializeObject<List<Cobertura>>(cobertura);
                }
            }
            return coberturas;
        }

    }
}
