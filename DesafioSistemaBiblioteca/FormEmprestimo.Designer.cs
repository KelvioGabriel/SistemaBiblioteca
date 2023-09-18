namespace DesafioSistemaBiblioteca
{
    partial class FormEmprestimo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmprestimo));
            this.cmbClienteEmprestimo = new System.Windows.Forms.ComboBox();
            this.emprestimosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDataSet = new DesafioSistemaBiblioteca.SistemaBibliotecaDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbLivroEmprestimo = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataDevolução = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new DesafioSistemaBiblioteca.SistemaBibliotecaDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new DesafioSistemaBiblioteca.SistemaBibliotecaDataSetTableAdapters.ClienteTableAdapter();
            this.emprestimosTableAdapter = new DesafioSistemaBiblioteca.SistemaBibliotecaDataSetTableAdapters.EmprestimosTableAdapter();
            this.livrosTableAdapter = new DesafioSistemaBiblioteca.SistemaBibliotecaDataSetTableAdapters.LivrosTableAdapter();
            this.emprestimosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.emprestimosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmprestimoID = new System.Windows.Forms.TextBox();
            this.emprestimosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingNavigator)).BeginInit();
            this.emprestimosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClienteEmprestimo
            // 
            this.cmbClienteEmprestimo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emprestimosBindingSource, "ClienteId", true));
            this.cmbClienteEmprestimo.DataSource = this.clienteBindingSource;
            this.cmbClienteEmprestimo.DisplayMember = "Nome";
            this.cmbClienteEmprestimo.FormattingEnabled = true;
            this.cmbClienteEmprestimo.Location = new System.Drawing.Point(12, 51);
            this.cmbClienteEmprestimo.Name = "cmbClienteEmprestimo";
            this.cmbClienteEmprestimo.Size = new System.Drawing.Size(216, 21);
            this.cmbClienteEmprestimo.TabIndex = 0;
            this.cmbClienteEmprestimo.ValueMember = "ClienteId";
            // 
            // emprestimosBindingSource
            // 
            this.emprestimosBindingSource.DataMember = "Emprestimos";
            this.emprestimosBindingSource.DataSource = this.sistemaBibliotecaDataSet;
            // 
            // sistemaBibliotecaDataSet
            // 
            this.sistemaBibliotecaDataSet.DataSetName = "SistemaBibliotecaDataSet";
            this.sistemaBibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sistemaBibliotecaDataSet;
            // 
            // cmbLivroEmprestimo
            // 
            this.cmbLivroEmprestimo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emprestimosBindingSource, "LivroId", true));
            this.cmbLivroEmprestimo.DataSource = this.livrosBindingSource;
            this.cmbLivroEmprestimo.DisplayMember = "Titulo";
            this.cmbLivroEmprestimo.FormattingEnabled = true;
            this.cmbLivroEmprestimo.Location = new System.Drawing.Point(298, 51);
            this.cmbLivroEmprestimo.Name = "cmbLivroEmprestimo";
            this.cmbLivroEmprestimo.Size = new System.Drawing.Size(216, 21);
            this.cmbLivroEmprestimo.TabIndex = 1;
            this.cmbLivroEmprestimo.ValueMember = "LivroId";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDataSet;
            // 
            // dtpDataDevolução
            // 
            this.dtpDataDevolução.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emprestimosBindingSource, "DataDevolução", true));
            this.dtpDataDevolução.Location = new System.Drawing.Point(298, 148);
            this.dtpDataDevolução.Name = "dtpDataDevolução";
            this.dtpDataDevolução.Size = new System.Drawing.Size(216, 20);
            this.dtpDataDevolução.TabIndex = 2;
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emprestimosBindingSource, "DataEmprestimo", true));
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(12, 148);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(216, 20);
            this.dtpDataEmprestimo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.EmprestimosTableAdapter = this.emprestimosTableAdapter;
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.UpdateOrder = DesafioSistemaBiblioteca.SistemaBibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // emprestimosTableAdapter
            // 
            this.emprestimosTableAdapter.ClearBeforeFill = true;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // emprestimosBindingNavigator
            // 
            this.emprestimosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.emprestimosBindingNavigator.BindingSource = this.emprestimosBindingSource;
            this.emprestimosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.emprestimosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.emprestimosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.emprestimosBindingNavigatorSaveItem});
            this.emprestimosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.emprestimosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.emprestimosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.emprestimosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.emprestimosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.emprestimosBindingNavigator.Name = "emprestimosBindingNavigator";
            this.emprestimosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.emprestimosBindingNavigator.Size = new System.Drawing.Size(595, 25);
            this.emprestimosBindingNavigator.TabIndex = 5;
            this.emprestimosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // emprestimosBindingNavigatorSaveItem
            // 
            this.emprestimosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emprestimosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("emprestimosBindingNavigatorSaveItem.Image")));
            this.emprestimosBindingNavigatorSaveItem.Name = "emprestimosBindingNavigatorSaveItem";
            this.emprestimosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.emprestimosBindingNavigatorSaveItem.Text = "Save Data";
            this.emprestimosBindingNavigatorSaveItem.Click += new System.EventHandler(this.emprestimosBindingNavigatorSaveItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Do Emprestimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Da Devolução";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Livro";
            // 
            // txtEmprestimoID
            // 
            this.txtEmprestimoID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimosBindingSource, "EmprestimoId", true));
            this.txtEmprestimoID.Location = new System.Drawing.Point(536, 12);
            this.txtEmprestimoID.Name = "txtEmprestimoID";
            this.txtEmprestimoID.Size = new System.Drawing.Size(47, 20);
            this.txtEmprestimoID.TabIndex = 10;
            // 
            // emprestimosDataGridView
            // 
            this.emprestimosDataGridView.AllowUserToAddRows = false;
            this.emprestimosDataGridView.AutoGenerateColumns = false;
            this.emprestimosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emprestimosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.emprestimosDataGridView.DataSource = this.emprestimosBindingSource;
            this.emprestimosDataGridView.Location = new System.Drawing.Point(12, 257);
            this.emprestimosDataGridView.Name = "emprestimosDataGridView";
            this.emprestimosDataGridView.Size = new System.Drawing.Size(571, 220);
            this.emprestimosDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LivroId";
            this.dataGridViewTextBoxColumn2.DataSource = this.livrosBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Livro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "LivroId";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClienteId";
            this.dataGridViewTextBoxColumn3.DataSource = this.clienteBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ClienteId";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataEmprestimo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Do Emprestimo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataDevolução";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Da Devolução";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 489);
            this.Controls.Add(this.txtEmprestimoID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emprestimosDataGridView);
            this.Controls.Add(this.emprestimosBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.dtpDataDevolução);
            this.Controls.Add(this.cmbLivroEmprestimo);
            this.Controls.Add(this.cmbClienteEmprestimo);
            this.Name = "FormEmprestimo";
            this.Text = "FormEmprestimo";
            this.Load += new System.EventHandler(this.FormEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingNavigator)).EndInit();
            this.emprestimosBindingNavigator.ResumeLayout(false);
            this.emprestimosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClienteEmprestimo;
        private System.Windows.Forms.ComboBox cmbLivroEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDataDevolução;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.Label label1;
        private SistemaBibliotecaDataSet sistemaBibliotecaDataSet;
        private SistemaBibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator emprestimosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton emprestimosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource emprestimosBindingSource;
        private SistemaBibliotecaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private SistemaBibliotecaDataSetTableAdapters.EmprestimosTableAdapter emprestimosTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SistemaBibliotecaDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private System.Windows.Forms.TextBox txtEmprestimoID;
        private System.Windows.Forms.DataGridView emprestimosDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}