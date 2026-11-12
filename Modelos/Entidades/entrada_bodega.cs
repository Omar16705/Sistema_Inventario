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
        private String unidad_medida;
        private String nombre_producto;
        private DateTime fecha_vencimiento;
        private String bodega;
        private String estante_refri;

        public int Id_entrada { get => id_entrada; set => id_entrada = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Unidad_medida { get => unidad_medida; set => unidad_medida = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public string Bodega { get => bodega; set => bodega = value; }
        public string Estante_refri { get => estante_refri; set => estante_refri = value; }



        public static DataTable ObtenerDatos()
        {
            try
            {

                SqlConnection conexion = conexion_bd.conectar();
                string consultaQuery = "SELECT * FROM ENTRADAS_BODEGA";
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

    }
}
