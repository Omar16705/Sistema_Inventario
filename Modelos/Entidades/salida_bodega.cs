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
    public class salida_bodega
    {

        private int id_salida;
        private int cantidad;
        private int id_usuario;
        private int nombre_producto;
        private DateTime fecha_vencimiento;
        private DateTime fecha_salida;
        private String bodega;
        private String estante_refri;
        private String uso;

        public int Id_salida { get => id_salida; set => id_salida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public string Bodega { get => bodega; set => bodega = value; }
        public string Estante_refri { get => estante_refri; set => estante_refri = value; }
        public string Uso { get => uso; set => uso = value; }
        public DateTime Fecha_salida { get => fecha_salida; set => fecha_salida = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }

        public static DataTable ObtenerDatos()
        {
            try
            {

                SqlConnection conexion = conexion_bd.conectar();
                string consultaQuery = "SELECT * FROM VW_SALIDAS_BODEGA_PRODUCTO";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable data = new DataTable();
                add.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error :(" + ex);
                return null;
            }

        }


        public bool insertarSalida(salida_bodega salida_Bodega)
        {
            try
            {
                using (SqlConnection connection = conexion_bd.conectar()) {
                connection.Open();
                    string query = "INSERT INTO SALIDAS_BODEGA(ID_PRODUCTO, CANTIDAD, FECHA_VENCIMIENTO, FECHA_SALIDA, BODEGA, ESTANTE_REFRI, USO, ID_USUARIO) VALUES (@id_producto, @cant, @fecha_vencimiento, @fecha_Salida, @bodega, @estante_refri,@uso,@id_usuario )";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_producto", salida_Bodega.Nombre_producto);
                    command.Parameters.AddWithValue("@cant", salida_Bodega.Cantidad);
                    command.Parameters.AddWithValue("@fecha_vencimiento", salida_Bodega.Fecha_vencimiento);
                    command.Parameters.AddWithValue("@fecha_Salida", salida_Bodega.Fecha_salida);
                    command.Parameters.AddWithValue("@bodega", salida_Bodega.Bodega);
                    command.Parameters.AddWithValue("@estante_refri", salida_Bodega.Estante_refri);
                    command.Parameters.AddWithValue("@uso", salida_Bodega.Uso);
                    command.Parameters.AddWithValue("@id_usuario", salida_Bodega.Id_usuario);
                    return command.ExecuteNonQuery() > 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar la salida: " + ex.Message);
                return false;
            }
        }

        public bool eliminarSalida(int id_salida)
        {
            try
            {
                using (SqlConnection connection = conexion_bd.conectar())
                {
                    connection.Open();
                    string query = "DELETE FROM SALIDAS_BODEGA WHERE ID_SALIDA = @id_salida";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_salida", id_salida);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al eliminar la salida: " + ex.Message);
                return false;
            }
        }

        public bool actualizarSalida(salida_bodega salida_Bodega)
        {
            try
            {
                using (SqlConnection connection = conexion_bd.conectar())
                {
                    connection.Open();
                    string query = "UPDATE SALIDAS_BODEGA SET ID_PRODUCTO = @id_producto, CANTIDAD = @cant, FECHA_VENCIMIENTO = @fecha_vencimiento, FECHA_SALIDA = @fecha_Salida, BODEGA = @bodega, ESTANTE_REFRI = @estante_refri, USO = @uso, ID_USUARIO = @id_usuario WHERE ID_SALIDA = @id_salida";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_producto", salida_Bodega.Nombre_producto);
                    command.Parameters.AddWithValue("@cant", salida_Bodega.Cantidad);
                    command.Parameters.AddWithValue("@fecha_vencimiento", salida_Bodega.Fecha_vencimiento);
                    command.Parameters.AddWithValue("@fecha_Salida", salida_Bodega.Fecha_salida);
                    command.Parameters.AddWithValue("@bodega", salida_Bodega.Bodega);
                    command.Parameters.AddWithValue("@estante_refri", salida_Bodega.Estante_refri);
                    command.Parameters.AddWithValue("@uso", salida_Bodega.Uso);
                    command.Parameters.AddWithValue("@id_usuario", salida_Bodega.Id_usuario);
                    command.Parameters.AddWithValue("@id_salida", salida_Bodega.Id_salida);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al actualizar la salida: " + ex.Message);
                return false;
            }
        }
    }
}
