using BCrypt.Net;
using Modelos.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Usuario
    {

        private String nombre_usuario;
        private String contraseña;
        private String rol;

        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Rol { get => rol; set => rol = value; }


        public bool Ingresar()
        {
            try
            {
                SqlConnection connection = conexion_bd.conectar();

                connection.Open();


                string consulta = @"select clave from vw_Login where nombre_usuario = @user";

                SqlCommand comando = new SqlCommand(consulta, connection);

                comando.Parameters.Add("@user", SqlDbType.VarChar, 100).Value = Nombre_usuario;

                object resultado = comando.ExecuteScalar();

                ////////////Aqui verificamos i el usuario existe
                if (resultado == null || resultado == DBNull.Value)
                {
                    MessageBox.Show("El usuario no existe.");
                    return false;
                }

                string hashEnBaseDatos = resultado.ToString();

                ////////Aqui el programa verifica si la contraseña existe sino muestra el mensaje 
                if (!BCrypt.Net.BCrypt.Verify(Contraseña, hashEnBaseDatos))
                {
                    MessageBox.Show("Contraseña incorrecta.");
                    return false;
                }


                string consulta2 = @"select nombre_usuario, nombre_rol  FROM vw_Login  where nombre_usuario = @user";

                SqlCommand command = new SqlCommand(consulta2, connection);

                command.Parameters.Add("@user", SqlDbType.VarChar, 100).Value = Nombre_usuario;
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        Usuario_Verify.Nombre_usuario = rd.GetString(0);
                        Usuario_Verify.Rol = rd.GetString(1);
                        return true; // Login correcto
                    }
                }




                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el inicio de sesión: " + ex.Message);
                return false;
            }
        }

        public bool actualizar_contraseña(string nuevaContraseña, string nombreUsuario)
        {
            try
            {
                SqlConnection connection = conexion_bd.conectar();
                connection.Open();
                string consulta = @"UPDATE Usuario SET clave = @nuevaContraseña WHERE nombre_usuario = @user";
                SqlCommand comando = new SqlCommand(consulta, connection);
                comando.Parameters.Add("@nuevaContraseña", SqlDbType.VarChar, 100).Value = BCrypt.Net.BCrypt.HashPassword(nuevaContraseña);
                comando.Parameters.Add("@user", SqlDbType.VarChar, 100).Value = Nombre_usuario;
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Contraseña actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la contraseña. Verifique el nombre de usuario.");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
                return false;
            }
        }



    }
}
