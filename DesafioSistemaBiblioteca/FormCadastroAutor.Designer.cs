﻿namespace DesafioSistemaBiblioteca
{
    partial class FormCadastroAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAutor));
            this.sistemaBibliotecaDataSet = new DesafioSistemaBiblioteca.SistemaBibliotecaDataSet();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresTableAdapter = new DesafioSistemaBiblioteca.SistemaBibliotecaDataSetTableAdapters.AutoresTableAdapter();
            this.tableAdapterManager = new DesafioSistemaBiblioteca.SistemaBibliotecaDataSetTableAdapters.TableAdapterManager();
            this.autoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.autoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.autoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataNascimentoAutor = new System.Windows.Forms.DateTimePicker();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutorID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingNavigator)).BeginInit();
            this.autoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaBibliotecaDataSet
            // 
            this.sistemaBibliotecaDataSet.DataSetName = "SistemaBibliotecaDataSet";
            this.sistemaBibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.sistemaBibliotecaDataSet;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = this.autoresTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EmprestimosTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DesafioSistemaBiblioteca.SistemaBibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autoresBindingNavigator
            // 
            this.autoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.autoresBindingNavigator.BindingSource = this.autoresBindingSource;
            this.autoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.autoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.autoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.autoresBindingNavigatorSaveItem});
            this.autoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.autoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.autoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.autoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.autoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.autoresBindingNavigator.Name = "autoresBindingNavigator";
            this.autoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.autoresBindingNavigator.Size = new System.Drawing.Size(462, 25);
            this.autoresBindingNavigator.TabIndex = 0;
            this.autoresBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // autoresBindingNavigatorSaveItem
            // 
            this.autoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("autoresBindingNavigatorSaveItem.Image")));
            this.autoresBindingNavigatorSaveItem.Name = "autoresBindingNavigatorSaveItem";
            this.autoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.autoresBindingNavigatorSaveItem.Text = "Save Data";
            this.autoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.autoresBindingNavigatorSaveItem_Click);
            // 
            // autoresDataGridView
            // 
            this.autoresDataGridView.AllowUserToAddRows = false;
            this.autoresDataGridView.AutoGenerateColumns = false;
            this.autoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.autoresDataGridView.DataSource = this.autoresBindingSource;
            this.autoresDataGridView.Location = new System.Drawing.Point(12, 218);
            this.autoresDataGridView.Name = "autoresDataGridView";
            this.autoresDataGridView.Size = new System.Drawing.Size(438, 220);
            this.autoresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_Nascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data De Nascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nacionalidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nacionalidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dtpDataNascimentoAutor
            // 
            this.dtpDataNascimentoAutor.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.autoresBindingSource, "Data_Nascimento", true));
            this.dtpDataNascimentoAutor.Location = new System.Drawing.Point(12, 169);
            this.dtpDataNascimentoAutor.Name = "dtpDataNascimentoAutor";
            this.dtpDataNascimentoAutor.Size = new System.Drawing.Size(213, 20);
            this.dtpDataNascimentoAutor.TabIndex = 2;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nacionalidade", true));
            this.txtNacionalidade.Location = new System.Drawing.Point(12, 114);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(213, 20);
            this.txtNacionalidade.TabIndex = 3;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nome", true));
            this.txtNomeAutor.Location = new System.Drawing.Point(12, 57);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(213, 20);
            this.txtNomeAutor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data De Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nacionalidade";
            // 
            // txtAutorID
            // 
            this.txtAutorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "AutorId", true));
            this.txtAutorID.Location = new System.Drawing.Point(399, 12);
            this.txtAutorID.Name = "txtAutorID";
            this.txtAutorID.Size = new System.Drawing.Size(51, 20);
            this.txtAutorID.TabIndex = 8;
            // 
            // FormCadastroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.txtAutorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.dtpDataNascimentoAutor);
            this.Controls.Add(this.autoresDataGridView);
            this.Controls.Add(this.autoresBindingNavigator);
            this.Name = "FormCadastroAutor";
            this.Text = "FormCadastroAutor";
            this.Load += new System.EventHandler(this.FormCadastroAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingNavigator)).EndInit();
            this.autoresBindingNavigator.ResumeLayout(false);
            this.autoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemaBibliotecaDataSet sistemaBibliotecaDataSet;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private SistemaBibliotecaDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
        private SistemaBibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator autoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton autoresBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView autoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker dtpDataNascimentoAutor;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutorID;
    }
}