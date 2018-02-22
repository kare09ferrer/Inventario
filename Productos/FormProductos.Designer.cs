namespace Productos {
    partial class FormProductos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nu_categoriaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.inventariosDataSet = new Productos.inventariosDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Productos.inventariosDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Productos.inventariosDataSetTableAdapters.TableAdapterManager();
            this.categoriasTableAdapter = new Productos.inventariosDataSetTableAdapters.categoriasTableAdapter();
            this.productosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nu_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionRichTextBox = new System.Windows.Forms.RichTextBox();
            nombreLabel = new System.Windows.Forms.Label();
            nu_categoriaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingNavigator)).BeginInit();
            this.productosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(51, 69);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nu_categoriaLabel
            // 
            nu_categoriaLabel.AutoSize = true;
            nu_categoriaLabel.Location = new System.Drawing.Point(43, 42);
            nu_categoriaLabel.Name = "nu_categoriaLabel";
            nu_categoriaLabel.Size = new System.Drawing.Size(55, 13);
            nu_categoriaLabel.TabIndex = 6;
            nu_categoriaLabel.Text = "Categoria:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(32, 95);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "Descripción:";
            // 
            // inventariosDataSet
            // 
            this.inventariosDataSet.DataSetName = "inventariosDataSet";
            this.inventariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.inventariosDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.entradasTableAdapter = null;
            this.tableAdapterManager.inventariosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ubicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Productos.inventariosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // productosBindingNavigator
            // 
            this.productosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productosBindingNavigator.BindingSource = this.productosBindingSource;
            this.productosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productosBindingNavigatorSaveItem});
            this.productosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productosBindingNavigator.Name = "productosBindingNavigator";
            this.productosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productosBindingNavigator.Size = new System.Drawing.Size(369, 25);
            this.productosBindingNavigator.TabIndex = 0;
            this.productosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productosBindingNavigatorSaveItem
            // 
            this.productosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productosBindingNavigatorSaveItem.Image")));
            this.productosBindingNavigatorSaveItem.Name = "productosBindingNavigatorSaveItem";
            this.productosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productosBindingNavigatorSaveItem.Click += new System.EventHandler(this.productosBindingNavigatorSaveItem_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(104, 66);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(253, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.inventariosDataSet;
            // 
            // nu_categoriaComboBox
            // 
            this.nu_categoriaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nu_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "nu_categoria", true));
            this.nu_categoriaComboBox.DataSource = this.categoriasBindingSource;
            this.nu_categoriaComboBox.DisplayMember = "nombre";
            this.nu_categoriaComboBox.FormattingEnabled = true;
            this.nu_categoriaComboBox.Location = new System.Drawing.Point(104, 39);
            this.nu_categoriaComboBox.Name = "nu_categoriaComboBox";
            this.nu_categoriaComboBox.Size = new System.Drawing.Size(253, 21);
            this.nu_categoriaComboBox.TabIndex = 7;
            this.nu_categoriaComboBox.ValueMember = "id";
            // 
            // descripcionRichTextBox
            // 
            this.descripcionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "descripcion", true));
            this.descripcionRichTextBox.Location = new System.Drawing.Point(104, 92);
            this.descripcionRichTextBox.Name = "descripcionRichTextBox";
            this.descripcionRichTextBox.Size = new System.Drawing.Size(253, 204);
            this.descripcionRichTextBox.TabIndex = 8;
            this.descripcionRichTextBox.Text = "";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 308);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionRichTextBox);
            this.Controls.Add(nu_categoriaLabel);
            this.Controls.Add(this.nu_categoriaComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.productosBindingNavigator);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventariosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingNavigator)).EndInit();
            this.productosBindingNavigator.ResumeLayout(false);
            this.productosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private inventariosDataSet inventariosDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private inventariosDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private inventariosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombreTextBox;
        private inventariosDataSetTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.ComboBox nu_categoriaComboBox;
        private System.Windows.Forms.RichTextBox descripcionRichTextBox;
    }
}