using System.Data;
using System.Data.SqlClient;
using lista_de_compra;

namespace Negocio
{
    public class ListaService
    {
        private readonly Database _database = new Database();

        public DataTable ObtenerListas()
        {
            return _database.ObtenerListas();
        }

        public DataTable ObtenerProductosPorLista(int idLista)
        {
            return _database.ObtenerProductosPorLista(idLista);
        }
    }
}
