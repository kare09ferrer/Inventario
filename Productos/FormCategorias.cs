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
    public partial class FormCategorias : Form {
        public FormCategorias() {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventariosDataSet);

        }

        private void FormCategorias_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'inventariosDataSet.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.inventariosDataSet.categorias);

        }
    }
}
