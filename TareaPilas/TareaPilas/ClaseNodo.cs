using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPilas
{
    class ClaseNodo<Tipo>
    {
        private ClaseNodo<Tipo> _siguiente;

        public ClaseNodo<Tipo> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        private Tipo _objetoConDatos;

        public Tipo ObjetoConDatos

        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        ~ClaseNodo()
        {

        }

        public ClaseNodo()
        {

        }
    }
}
