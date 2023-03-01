using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    public class ListaEnlazada<T> : IEstructuraDeDatos<T>
    {
        public int Contador = 0;
        public Nodo<T> PrimerNodo { get; set; }
        public Nodo<T> UltimoNodo { get; set; }

        public void Actualizar(int pos)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int pos)
        {
            throw new NotImplementedException();
        }

        public void Insertar(T obj)
        {
            var nodoInsertar = new Nodo<T>(obj);
            if(Contador== 0)
            {
                PrimerNodo = nodoInsertar;
                Contador++;
                UltimoNodo= nodoInsertar;
            }
            else
            {
                UltimoNodo.Siguiente = nodoInsertar;
                Contador++;
                UltimoNodo = nodoInsertar;
            }
        }

        public T Obtener(int pos)
        {
            throw new NotImplementedException();
        }
    }
}
