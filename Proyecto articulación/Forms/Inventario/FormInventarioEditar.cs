using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_articulación.Forms.Inventario
{
    public partial class FormInventarioEditar : Form
    {
        private Forminventario _forminventario;
        //private Entities.Inventario _inventario;


        public FormInventarioEditar(Forminventario forminventario, int id)
        {
            InitializeComponent();
            _forminventario = forminventario;

            //_inventario = CacheData.DatosInventario.FirstOrDefault(r => r.ProductId == id);
            LoadData();
        }

        private void LoadData()
        {
            /*
            txtNombre.Text = _inventario.ProductName;
            txtCantidad.Text = _inventario.Quantity.ToString();
            txtPreciodecompra.Text = _inventario.PurchasePrice.ToString();
            txtPreciodeventa.Text = _inventario.SellingPrice.ToString();
            */
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCantidad.Text, out int Cantidad);
            decimal.TryParse(txtPreciodecompra.Text, out decimal precioCompra);
            decimal.TryParse(txtPreciodeventa.Text, out decimal precioVenta);

            /*
            _inventario.ProductName = txtNombre.Text;
            _inventario.Quantity = Cantidad;
            _inventario.PurchasePrice = precioCompra;
            _inventario.SellingPrice = precioVenta;

            CacheData.DatosInventario.Remove(_inventario);
            CacheData.DatosInventario.Add(_inventario);
            CacheData.DatosInventario = CacheData.DatosInventario.OrderBy(x => x.ProductName).ToList();
            */
            _forminventario.LoadData();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtPreciodecompra.Text = string.Empty;
            txtPreciodeventa.Text = string.Empty;
        }
    }
}
