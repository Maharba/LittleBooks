using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Libros
{
    public partial class Form1 : Form
    {
        private readonly Configuration _config;

        public Form1()
        {
            InitializeComponent();
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            new LibrosForm(bool.Parse(ConfigurationManager.AppSettings["Conectado"])).ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            new AutoresForm(bool.Parse(ConfigurationManager.AppSettings["Conectado"])).ShowDialog();
        }

        private void btnResenha_Click(object sender, EventArgs e)
        {
            new ResenhasForm(bool.Parse(ConfigurationManager.AppSettings["Conectado"])).ShowDialog();
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var preferenciasForm = new PreferenciasForm();
            preferenciasForm.ShowDialog();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLibros.PerformClick();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAutores.PerformClick();
        }

        private void reseñasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnResenha.PerformClick();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AcercaDe().ShowDialog();
        }
    }
}
