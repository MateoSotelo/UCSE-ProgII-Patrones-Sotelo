using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public sealed class SingletonLogica
    {
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
    }
}
