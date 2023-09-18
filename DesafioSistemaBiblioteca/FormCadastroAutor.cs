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
    public partial class FormCadastroAutor : Form
    {
        public FormCadastroAutor()
        {
            InitializeComponent();
        }

        private void autoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaBibliotecaDataSet);

        }

        private void FormCadastroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDataSet.Autores);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int id = autoresBindingSource.Count;
            txtAutorID.Text = id.ToString();
        }
    }
}
