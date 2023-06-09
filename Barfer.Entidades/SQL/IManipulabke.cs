using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public interface IManipulable<T>
    {
        public List<T> Traer();
        public T Traer(int id);

        public void Agregar(T objeto);
        public void Modificar(T objeto);
        public void Eliminar(int id);
    }
}
