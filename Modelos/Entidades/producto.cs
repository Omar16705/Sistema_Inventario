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
    public class producto
    {

        private int id_producto;
        private string nombre_producto;
        private string descripcion_producto;
        private string unidad_medida;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion_producto { get => descripcion_producto; set => descripcion_producto = value; }
        public string Unidad_medida { get => unidad_medida; set => unidad_medida = value; }


        public DataTable mostrarProductos()
        {
            try
            {
                conexion_bd conexion = new conexion_bd();
                string query = "SELECT * FROM producto";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion_bd.conectar());
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar productos: " + ex.Message);
            }
        }

        public bool insertarProducto(producto producto)
        {
            try
            {
                using (SqlConnection conexion = conexion_bd.conectar())
                {
                    conexion.Open();
                    string query = "INSERT INTO producto (nombre_producto, descripcion, unidad_medida) VALUES (@nombre_producto, @descripcion_producto, @unidad_medida)";

                    using (SqlCommand cmd = new SqlCommand(query, conexion)) // <-- Aquí usamos 'conexion'
                    {
                        cmd.Parameters.AddWithValue("@nombre_producto", producto.Nombre_producto);
                        cmd.Parameters.AddWithValue("@descripcion_producto", producto.Descripcion_producto);
                        cmd.Parameters.AddWithValue("@unidad_medida", producto.Unidad_medida);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
        }



        public static Dictionary<string, DataTable> ObtenerDatosUsuarios()
        {
            try
            {
                Dictionary<string, DataTable> datos = new Dictionary<string, DataTable>();

                SqlConnection conexion = conexion_bd.conectar();
                {
                    conexion.Open();

                    // Usuarios
                    SqlDataAdapter daUsuario = new SqlDataAdapter("SELECT ID_PRODUCTO, NOMBRE_PRODCTO FROM PRODUCTO", conexion);
                    DataTable dtUsuario = new DataTable();
                    daUsuario.Fill(dtUsuario);
                    datos["Usuario"] = dtUsuario;

                }

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex);
                return null;
            }


        }
        
        public bool actualizarProducto(producto producto)
        {
            try
            {
                using (SqlConnection conexion = conexion_bd.conectar())
                {
                    conexion.Open();
                    string query = "UPDATE producto SET nombre_producto = @nombre_producto, descripcion = @descripcion_producto, unidad_medida = @unidad_medida WHERE id_producto = @id_producto";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre_producto", producto.Nombre_producto);
                        cmd.Parameters.AddWithValue("@descripcion_producto", producto.Descripcion_producto);
                        cmd.Parameters.AddWithValue("@unidad_medida", producto.Unidad_medida);
                        cmd.Parameters.AddWithValue("@id_producto", producto.Id_producto);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }

        public bool eliminarProducto(int id_producto)
        {
            try
            {
                using (SqlConnection conexion = conexion_bd.conectar())
                {
                    conexion.Open();
                    string query = "DELETE FROM producto WHERE id_producto = @id_producto";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_producto", id_producto);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }
    }
}
