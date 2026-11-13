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
    public class entrada_bodega
    {
        private int id_entrada;
        private int cantidad;
        private DateTime fecha_vencimiento;
        private DateTime fecha_entrada;
        private String bodega;
        private String estante_refri;
        private int id_producto;
        private int id_usuario;


        public int Id_entrada { get => id_entrada; set => id_entrada = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public string Bodega { get => bodega; set => bodega = value; }
        public string Estante_refri { get => estante_refri; set => estante_refri = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public DateTime Fecha_entrada { get => fecha_entrada; set => fecha_entrada = value; }

        public static DataTable ObtenerDatos()
        {
            try
            {

                SqlConnection conexion = conexion_bd.conectar();
                string consultaQuery = "SELECT * FROM VW_ENTRADAS_BODEGA_PRODUCTO";
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

        public static DataTable ObtenerDatosPorId(int id)
        {
            try
            {
                SqlConnection conexion = conexion_bd.conectar();
                string consultaQuery = "SELECT * FROM VW_ENTRADAS_BODEGA_PRODUCTO WHERE id_entrada = @id";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                add.SelectCommand.Parameters.AddWithValue("@id", id);
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

        public bool insertarEntrada(entrada_bodega entrada)
        {
            try
            {
                using (SqlConnection conexion = conexion_bd.conectar())
                {
                    conexion.Open();
                    string query = @"INSERT INTO entradas_bodega 
                                    (cantidad, fecha_entrada, fecha_vencimiento, bodega, estante_refri, id_producto, id_usuario) 
                                    VALUES 
                                    (@cantidad, @fecha_entrada, @fecha_vencimiento, @bodega, @estante_refri, @id_producto, @id_usuario)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", entrada.Cantidad);
                        cmd.Parameters.AddWithValue("@fecha_entrada", entrada.Fecha_entrada); // Corregido: ya no dice @nombre_producto
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", entrada.Fecha_vencimiento);
                        cmd.Parameters.AddWithValue("@bodega", entrada.Bodega);
                        cmd.Parameters.AddWithValue("@estante_refri", entrada.Estante_refri);
                        cmd.Parameters.AddWithValue("@id_producto", entrada.Id_producto);
                        cmd.Parameters.AddWithValue("@id_usuario", entrada.Id_usuario);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la entrada: " + ex.Message);
                return false;
            }
        }

        public bool eliminarEntrada(int id)
        {
            try
            {
                using (SqlConnection conexion = conexion_bd.conectar())
                {
                    conexion.Open();
                    string query = "DELETE FROM entradas_bodega WHERE id_entrada = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la entrada: " + ex.Message);
                return false;
            }
        } 

        public bool actualizarEntrada(int entrada)
        {
            try
            {
                using (SqlConnection conexion = conexion_bd.conectar())
                {
                    conexion.Open();
                    string query = @"UPDATE entradas_bodega 
                                    SET cantidad = @cantidad, 
                                        fecha_entrada = @fecha_entrada, 
                                        fecha_vencimiento = @fecha_vencimiento, 
                                        bodega = @bodega, 
                                        estante_refri = @estante_refri, 
                                        id_producto = @id_producto, 
                                        id_usuario = @id_usuario 
                                    WHERE id_entrada = @id_entrada";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                        cmd.Parameters.AddWithValue("@fecha_entrada", Fecha_entrada);
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", Fecha_vencimiento);
                        cmd.Parameters.AddWithValue("@bodega", Bodega);
                        cmd.Parameters.AddWithValue("@estante_refri", Estante_refri);
                        cmd.Parameters.AddWithValue("@id_producto", Id_producto);
                        cmd.Parameters.AddWithValue("@id_usuario", Id_usuario);
                        cmd.Parameters.AddWithValue("@id_entrada", Id_entrada);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la entrada: " + ex.Message);
                return false;
            }
        }
    }
}
