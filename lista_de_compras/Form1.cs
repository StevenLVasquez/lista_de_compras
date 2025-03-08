using System;
using System.Windows.Forms;
using Negocio;


namespace lista_de_compras
{
    public partial class Form1 : Form
    {
        private readonly ListaService listaService = new ListaService();
        public Form1()
        {
            InitializeComponent();
            CargarListas();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarListas()
        {
            dgvListas.DataSource = listaService.ObtenerListas();
        }

        private void dgvListas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idLista = Convert.ToInt32(dgvListas.Rows[e.RowIndex].Cells["IdLista"].Value);
                dgvProductos.DataSource = listaService.ObtenerProductosPorLista(idLista);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
