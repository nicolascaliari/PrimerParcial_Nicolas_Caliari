﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Usuarios
{
    public class Empleado : Usuario
    {
        public Empleado(string nombreUsuario, string contraseñaUsuario, string apellidoUsuario, decimal edadUsuario, TipoUsuario tipo)
            : base(nombreUsuario, contraseñaUsuario, apellidoUsuario, edadUsuario, tipo)
        {
        }


    }
}
