namespace Proyecto_articulación.Forms.Inventario
{
    partial class Forminventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbuscar1 = new System.Windows.Forms.Label();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.dgvInventario1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbuscar1
            // 
            this.lblbuscar1.AutoSize = true;
            this.lblbuscar1.Location = new System.Drawing.Point(30, 54);
            this.lblbuscar1.Name = "lblbuscar1";
            this.lblbuscar1.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar1.TabIndex = 0;
            this.lblbuscar1.Text = "Buscar";
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar1.TabIndex = 1;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // dgvInventario1
            // 
            this.dgvInventario1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario1.Location = new System.Drawing.Point(12, 93);
            this.dgvInventario1.Name = "dgvInventario1";
            this.dgvInventario1.Size = new System.Drawing.Size(554, 177);
            this.dgvInventario1.TabIndex = 2;
            this.dgvInventario1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario1_CellDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Forminventario
            // 
            this.ClientSize = new System.Drawing.Size(602, 293);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvInventario1);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.lblbuscar1);
            this.Name = "Forminventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblbuscar1;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.DataGridView dgvInventario1;
        private System.Windows.Forms.TextBox textBox2;
    }
}