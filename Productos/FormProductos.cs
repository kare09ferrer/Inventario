using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos {
    public partial class FormProductos : Form {
        public FormProductos() {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventariosDataSet);
            MessageBox.Show("Se guardo bien");
        }

        private void FormProductos_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'inventariosDataSet.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.inventariosDataSet.categorias);
            // TODO: esta línea de código carga datos en la tabla 'inventariosDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.inventariosDataSet.productos);

        }
    }
}
