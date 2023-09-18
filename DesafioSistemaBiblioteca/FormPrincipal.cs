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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Emprestimos' table. You can move, or remove it, as needed.
            this.emprestimosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Emprestimos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Livros);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sistemaBibliotecaDataSet.Cliente);

        }

        private void emprestimoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEmprestimo form = new FormEmprestimo();
            form.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente form = new FormCadastroCliente();
            form.ShowDialog();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroLivro form = new FormCadastroLivro();
            form.ShowDialog();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAutor form = new FormCadastroAutor();
            form.ShowDialog();
        }
    }
}
