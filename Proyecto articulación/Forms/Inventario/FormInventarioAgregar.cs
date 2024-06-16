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
    public partial class FormInventarioAgregar : Form
    {
        private Forminventario _forminventario;
        public FormInventarioAgregar(Forminventario forminventario)
        {
            InitializeComponent();
            _forminventario = forminventario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e )
        {
            using (var db = new ProyectoArticulaciomEntities())
            {
                int.TryParse(txtCantidad.Text, out int Cantidad);
                decimal.TryParse(txtPreciodecompra.Text, out decimal precioCompra);
                decimal.TryParse(txtPreciodeventa.Text, out decimal precioVenta);


                Data.Inventario dato = new Data.Inventario
                {

                    ProductName = txtNombre.Text,
                    Quantity = Cantidad,
                    PurchasePrice = precioCompra,
                    SellingPrice = precioVenta,

                };



                db.Inventario.Add(dato);
                db.SaveChanges();

                _forminventario.LoadData();
                Limpiar();



            }
            
                
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

        private void FormInventarioAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
