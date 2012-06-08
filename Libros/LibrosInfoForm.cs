using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Libros
{
    public partial class LibrosInfoForm : Form
    {
        public Libro Libro { get; set; }

        public LibrosInfoForm(Libro libro = null)
        {
            InitializeComponent();
            Libro = libro ?? new Libro();
        }

        private void LibrosInfoForm_Load(object sender, EventArgs e)
        {
            this.autoresTableAdapter.Fill(this.librosDataSet.autores);
            txtTitulo.Text = Libro.Titulo;
            cbxAutor.SelectedValue = Libro.AutorId;
            txtTituloOriginal.Text = Libro.TituloOriginal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LibrosInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                    Libro.Titulo = txtTitulo.Text;
                    Libro.AutorId = Convert.ToInt32(cbxAutor.SelectedValue);
                    Libro.TituloOriginal = txtTituloOriginal.Text;
            }
        }
    }
}
