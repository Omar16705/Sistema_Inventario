using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public static class Usuario_Verify
    {

        private static String nombre_usuario;
        private static String rol;

        public static string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public static string Rol { get => rol; set => rol = value; }
    }
}
