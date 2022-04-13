using System;
using LogicaDeNegocios;

namespace Presentacion
{
    class Program
    {
        public static SingletonLogica logica = SingletonLogica.Instancia;
        static void Main(string[] args)
        {
            Console.WriteLine("Carga de una nueva atencion");
            logica.CargarDatosIniciales();
            CargarAtencion();

            Console.ReadKey();
        }

        static public void CargarAtencion()
        {
            Console.WriteLine("Nueva atencion");
            
            Console.Write("Ingrese codigo de la enfermedad: ");
            int CodigoEnfermedad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese DNI del paciente: ");
            int DNI = int.Parse(Console.ReadLine());

            Console.Write("Ingrese fecha con el formato(dd/mm/yyyy): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            logica.CargarAtencion(fecha, logica.BuscarEnfermedad(CodigoEnfermedad), logica.BuscarPersona(DNI));
        }
    }
}
