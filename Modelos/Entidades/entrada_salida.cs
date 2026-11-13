using Modelos.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class entrada_salida
    {
        public List<EntidadMovimientoBodega> ListarMovimientos(string filtro = "")
        {
            var lista = new List<EntidadMovimientoBodega>();
            filtro = (filtro ?? "").Trim().ToUpper();
            bool esNumero = int.TryParse(filtro, out int numeroId);

            string query = @"
            SELECT 
                TIPO_MOVIMIENTO,
                CODIGO_MOVIMIENTO,
                ID_MOVIMIENTO,
                ID_ENTRADA,
                ID_SALIDA,
                FECHA_MOVIMIENTO,
                ID_PRODUCTO,
                NOMBRE_PRODUCTO,
                UNIDAD_MEDIDA,
                CANTIDAD,
                FECHA_VENCIMIENTO,
                BODEGA,
                ESTANTE_REFRI,
                USO
            FROM VW_MOVIMIENTOS_BODEGA
            WHERE (@Filtro = '' OR CODIGO_MOVIMIENTO = @Filtro 
                   OR (@EsNumero = 1 AND (ID_ENTRADA = @NumeroId OR ID_SALIDA = @NumeroId OR ID_PRODUCTO = @NumeroId)))
            ORDER BY FECHA_MOVIMIENTO DESC;";

            using (SqlConnection connection = conexion_bd.conectar())
            using (var comando = new SqlCommand(query, connection))
            {
                comando.Parameters.Add("@Filtro", SqlDbType.VarChar, 50).Value = filtro;
                comando.Parameters.Add("@EsNumero", SqlDbType.Bit).Value = esNumero ? 1 : 0;
                comando.Parameters.Add("@NumeroId", SqlDbType.Int).Value = esNumero ? numeroId : (object)DBNull.Value;

                connection.Open();
                using (var dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new EntidadMovimientoBodega
                        {
                            TipoMovimiento = dr["TIPO_MOVIMIENTO"].ToString() ?? "",
                            CodigoMovimiento = dr["CODIGO_MOVIMIENTO"].ToString() ?? "",
                            IdMovimiento = Convert.ToInt32(dr["ID_MOVIMIENTO"]),
                            IdEntrada = dr["ID_ENTRADA"] != DBNull.Value ? (int?)Convert.ToInt32(dr["ID_ENTRADA"]) : null,
                            IdSalida = dr["ID_SALIDA"] != DBNull.Value ? (int?)Convert.ToInt32(dr["ID_SALIDA"]) : null,
                            FechaMovimiento = Convert.ToDateTime(dr["FECHA_MOVIMIENTO"]),
                            IdProducto = Convert.ToInt32(dr["ID_PRODUCTO"]),
                            NombreProducto = dr["NOMBRE_PRODUCTO"].ToString() ?? "",
                            UnidadMedida = dr["UNIDAD_MEDIDA"].ToString() ?? "",
                            Cantidad = Convert.ToInt32(dr["CANTIDAD"]),
                            FechaVencimiento = Convert.ToDateTime(dr["FECHA_VENCIMIENTO"]),
                            Bodega = dr["BODEGA"] != DBNull.Value ? dr["BODEGA"].ToString() : "",
                            EstanteRefri = dr["ESTANTE_REFRI"] != DBNull.Value ? dr["ESTANTE_REFRI"].ToString() : "",
                            Uso = dr["USO"] != DBNull.Value ? dr["USO"].ToString() : ""
                        });
                    }
                }
            }
            return lista;
        }
    }

    public class EntidadMovimientoBodega
    {
        public string TipoMovimiento { get; set; } = string.Empty;
        public string CodigoMovimiento { get; set; } = string.Empty;
        public int IdMovimiento { get; set; }
        public int? IdEntrada { get; set; }
        public int? IdSalida { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = string.Empty;
        public string UnidadMedida { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Bodega { get; set; }
        public string EstanteRefri { get; set; }
        public string Uso { get; set; }
    }
}