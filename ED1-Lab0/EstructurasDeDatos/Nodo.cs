using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    public class Nodo<T>
    {
        public T Valor;
        public Nodo<T> Siguiente;
        public Nodo<T> Anterior;

        public Nodo(T valor)
        {
            Valor= valor;
            Siguiente = null;
        }
    }
}
