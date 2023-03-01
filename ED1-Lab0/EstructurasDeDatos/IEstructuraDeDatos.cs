using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    public interface IEstructuraDeDatos<T>
    {
        void Insertar(T obj);
        void Actualizar(int pos);

        void Eliminar(int pos); 

        T Obtener(int pos);
    }
}
