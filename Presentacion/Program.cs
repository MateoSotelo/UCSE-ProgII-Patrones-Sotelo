using System;
using LogicaDeNegocios;

namespace Presentacion
{
    class Program
    {
        SingletonLogica logica = SingletonLogica.Instancia;
        static void Main(string[] args)
        {
            Console.WriteLine("Carga de una nueva atencion");
            
        }

        public void CargarAtencion()
        {
            Console.WriteLine("Nueva atencion");
            int CodigoEnfermedad = 0;
            
            Console.WriteLine("Ingrese codigo de la enfermedad");
            CodigoEnfermedad = int.Parse(Console.ReadLine());
            

        }
    }
}
