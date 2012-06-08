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
    public partial class ResenhasForm : Form
    {
        public ResenhasForm(bool connected = true)
        {
            InitializeComponent();
            IsConnected = connected;
        }

        public bool IsConnected { get; set; }

        private void ResenhasForm_Load(object sender, EventArgs e)
        {
            this.resenhasTableAdapter.Fill(this.librosDataSet.resenhas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var resenhaInfoForm = new ResenhasInfoForm();
            if (resenhaInfoForm.ShowDialog() != DialogResult.Cancel)
            {
                if (resenhaInfoForm.Resenha != null)
                {
                    if (IsConnected)
                    {
                        resenhasTableAdapter.Insert(resenhaInfoForm.Resenha.IdLibro, resenhaInfoForm.Resenha.Descripcion);
                        resenhasTableAdapter.Fill(librosDataSet.resenhas); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.
                    }
                    else
                    {
                        var resenhaRow = librosDataSet.resenhas.NewresenhasRow();

                        resenhaRow.Resenha = resenhaInfoForm.Resenha.Descripcion;
                        resenhaRow.IdLibro = resenhaInfoForm.Resenha.IdLibro;

                        librosDataSet.libros.Rows.Add(resenhaRow);
                        dgvResenhas.DataSource = librosDataSet.resenhas;
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvResenhas.CurrentRow;
            if (currentRow != null)
            {
                Resenha resenha = new Resenha
                                        {
                                            Descripcion =
                                                dgvResenhas.CurrentRow.Cells["resenhaDataGridViewTextBoxColumn"].Value
                                                .
                                                ToString(),
                                            IdLibro = Convert.ToInt32(
                                                dgvResenhas.CurrentRow.Cells["idLibroDataGridViewTextBoxColumn"].Value)
                                        };

                var resenhaInfoForm = new ResenhasInfoForm(resenha);
                if (resenhaInfoForm.ShowDialog() == DialogResult.OK)
                {
                    if (resenhaInfoForm.Resenha != null)
                    {
                        if (IsConnected)
                        {
                            resenhasTableAdapter.Update(resenhaInfoForm.Resenha.Descripcion,
                                                    resenhaInfoForm.Resenha.IdLibro);
                            resenhasTableAdapter.Fill(librosDataSet.resenhas); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.
                        }
                        else
                        {
                            librosDataSet.resenhas[currentRow.Index].Resenha = resenhaInfoForm.Resenha.Descripcion;
                            librosDataSet.resenhas[currentRow.Index].IdLibro = resenhaInfoForm.Resenha.IdLibro;

                            dgvResenhas.DataSource = librosDataSet.resenhas;
                        }
                    }
                }   
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvResenhas.CurrentRow;
            if (currentRow != null)
            {
                if (IsConnected)
                {
                    if (MessageBox.Show(this, "¿Está seguro que desea eliminar el elemento?\nLos cambios se guardarán inmediatamente en la base de datos", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        resenhasTableAdapter.Delete(
                            Convert.ToInt32(currentRow.Cells["idLibroDataGridViewTextBoxColumn"].Value));
                        resenhasTableAdapter.Fill(librosDataSet.resenhas); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.
                    }
                } else 
                {
                    librosDataSet.libros.Rows[Convert.ToInt32(currentRow.Cells["idLibroDataGridViewTextBoxColumn"].RowIndex)].Delete();
                    dgvResenhas.DataSource = librosDataSet.resenhas;
                }
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AcercaDe().ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAgregar.PerformClick();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnModificar.PerformClick();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEliminar.PerformClick();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                            "¿Está seguro que desea guardar los cambios?, se reemplazará la información actual en la base de datos.",
                            "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SaveChanges();
            }
        }

        private void SaveChanges()
        {
            resenhasTableAdapter.Update(librosDataSet.resenhas);
        }

        private void ResenhasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(this,
                                      "¿Desea guardar los cambios?, se reemplazará la información actual en la base de datos.",
                                      "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                SaveChanges();
            }
            else if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
