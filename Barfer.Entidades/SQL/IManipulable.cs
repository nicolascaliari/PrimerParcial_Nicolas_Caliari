﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public interface IManipulable<T>
    {
        Task<List<T>> TraerAsync();
        Task<T> TraerAsync(int id);

        Task AgregarAsync(T objeto);
        Task ModificarAsync(T objeto);
        Task EliminarAsync(int id);
    }
}
