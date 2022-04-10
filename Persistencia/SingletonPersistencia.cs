using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public sealed class SingletonPersistencia
    {
        private static SingletonPersistencia instancia = null;
        private SingletonPersistencia() { }
        public static SingletonPersistencia Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new SingletonPersistencia();
                }

                return instancia;
            }
        }

    }
}
