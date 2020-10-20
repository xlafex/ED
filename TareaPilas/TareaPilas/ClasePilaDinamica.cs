using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TareaPilas
{
    class ClasePilaDinamica<Tipo> where Tipo: IEquatable<Tipo>
    {
        private ClaseNodo<Tipo> _top;

        public ClaseNodo<Tipo> Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public bool Vacia
        {
            get {
                return (Top == null);   
                }
        }

        public void Push(Tipo objeto)
        {
            if (Vacia)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                Top = nodoNuevo;
                nodoNuevo.Siguiente = null;

            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Top;

                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Datos duplicados.");
                    }
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual!=null);
                {
                    ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                    nodoNuevo.ObjetoConDatos = objeto;
                    nodoNuevo.Siguiente = Top;
                    Top = nodoNuevo;

                }
            }

        }

        public Tipo Pop(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Lista Vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = Top;
                nodoPrevio = null;
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                        nodoEliminado = nodoActual;
                        if (nodoActual.Equals(Top))
                        {
                            Top = Top.Siguiente;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoConDatos);
                        }
                        else if (nodoActual.Equals(Top))
                        {
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoConDatos);
                        }
                        else
                        {
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoConDatos);
                        }
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }

                } while (Top != null);
                throw new Exception("No se encontro el Grupo a a Eliminar");
            }

        }

        public Tipo Pop()
        {
            if (Vacia)
            {
                throw new Exception("Lista vacia.");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;
            Top = Top.Siguiente;
            Tipo objetoRetorno = nodoActual.ObjetoConDatos;
            nodoActual = null;

            return objetoRetorno;


        }


        

        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Lista vacia.");

            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;

            do
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return nodoActual.ObjetoConDatos;
                }

                nodoActual = nodoActual.Siguiente;


            } while (nodoActual!=null);
            {
                throw new Exception("No encontrado.");
            }


        }

        public void Vaciar()
        {
            if (Vacia)
            {
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Top;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;


                } while (nodoActual != null);
                {
                    Top = null;
                    return;
                }
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Top;
                do
                {
                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);
                yield break;
            }
        }

        public ClasePilaDinamica()
        {
            Top = null;
        }

         ~ClasePilaDinamica()
        {
            Vaciar();
        }




    }
}



