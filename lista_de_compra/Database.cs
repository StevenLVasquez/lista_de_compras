using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace lista_de_compra
{
    public class Database
    {
        private readonly string connectionString = @"Server=STEVENV;Database=SpaceX;Trusted_Connection=True;TrustServerCertificate=True;";

        public DataTable ObtenerListas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Lista", conn))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }

        public DataTable ObtenerProductosPorLista(int idLista)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductosLista WHERE IdLista = @IdLista", conn))
                {
                    cmd.Parameters.AddWithValue("@IdLista", idLista);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }
    }//pruebas unitarias
}