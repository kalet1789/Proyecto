using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_articulación.Data;

namespace Proyecto_articulación.Forms.Inventario
{
    public partial class Forminventario : Form
    {
        public Forminventario()
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            using(var db = new ProyectoArticulaciomEntities())
            {
                    dgvInventario1.DataSource = null;
                    dgvInventario1.DataSource = db.Inventario.ToList();

                    dgvInventario1.Columns["ProductId"].HeaderText = "ID del Libro";
                    dgvInventario1.Columns["ProductName"].HeaderText = "Nombre del Libro";
                    dgvInventario1.Columns["Quantity"].HeaderText = "Cantidad";
                    dgvInventario1.Columns["PurchasePrice"].HeaderText = "Precio de Compra";
                    dgvInventario1.Columns["SellingPrice"].HeaderText = "Precio de Venta";

            }
        }



        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            FormInventarioAgregar formInventarioAgregar = new FormInventarioAgregar(this);
            formInventarioAgregar.Show();
        }

        private void dgvInventario1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idProducto = dgvInventario1.Rows[e.RowIndex].Cells[0].Value.ToString();
            int.TryParse(idProducto,  out int id);

            FormInventarioEditar formInventarioEditar = new FormInventarioEditar(this, id);
            formInventarioEditar.Show();
                

        }
    }
}
