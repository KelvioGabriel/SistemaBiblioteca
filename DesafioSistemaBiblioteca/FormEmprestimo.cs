using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioSistemaBiblioteca
{
    public partial class FormEmprestimo : Form
    {
        public FormEmprestimo()
        {
            InitializeComponent();
        }

        private void emprestimosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emprestimosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaBibliotecaDataSet);

            if(dtpDataEmprestimo.Value = )
            {

            }
        }

        private void FormEmprestimo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Livros);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sistemaBibliotecaDataSet.Cliente);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Emprestimos' table. You can move, or remove it, as needed.
            this.emprestimosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Emprestimos);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int id = clienteBindingSource.Count;
            txtEmprestimoID.Text = id.ToString();
        }
    }
}
