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
    public partial class ResenhasInfoForm : Form
    {
        public Resenha Resenha { get; set; }

        public ResenhasInfoForm(Resenha resenha = null)
        {
            InitializeComponent();
            Resenha = resenha ?? new Resenha();
        }

        private void ResenhasInfoForm_Load(object sender, EventArgs e)
        {
            this.librosTableAdapter.Fill(this.librosDataSet.libros);
            txtResenha.Text = Resenha.Descripcion;
            cbxLibro.SelectedValue = Resenha.IdLibro;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResenhasInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Resenha.Descripcion = txtResenha.Text;
                Resenha.IdLibro = Convert.ToInt32(cbxLibro.SelectedValue);
            }
        }
    }
}
