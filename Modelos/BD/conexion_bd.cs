using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.BD
{
    public  class conexion_bd
    {
        private static string servidor = "DESKTOP-0FOUEU1\\SQLEXPRESS";

        private static string database = "Sistema_Inventario_Comedor";


        public static SqlConnection conectar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection($"Data Source = {servidor}; Initial Catalog = {database}; Integrated Security = true ;");
                return conexion;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo error con la conexion con la base de datos" + ex);
                return null;
            }

        }
    }
}
