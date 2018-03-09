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
    public partial class FormInventarios : Form {
        public FormInventarios() {
            InitializeComponent();
        }

        private void inventariosBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.inventariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventariosDataSet);

        }

        private void FormInventarios_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'inventariosDataSet.inventarios' Puede moverla o quitarla según sea necesario.
            this.inventariosTableAdapter.Fill(this.inventariosDataSet.inventarios);

        }
    }
}
