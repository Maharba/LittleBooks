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
    public partial class AutoresForm : Form
    {
        public AutoresForm(bool connected = true)
        {
            InitializeComponent();
            IsConnected = connected;
        }

        public bool IsConnected { get; private set; }

        private void AutoresForm_Load(object sender, EventArgs e)
        {
            autoresTableAdapter.Fill(librosDataSet.autores);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var autorInfoForm = new AutoresInfoForm();
            if (autorInfoForm.ShowDialog() != DialogResult.Cancel)
            {
                if (autorInfoForm.Autor != null)
                {
                    if (IsConnected)
                    {
                        autoresTableAdapter.Insert(autorInfoForm.Autor.Nombre, autorInfoForm.Autor.Nacimiento,
                                               autorInfoForm.Autor.Muerte, autorInfoForm.Autor.Nacionalidad);
                        autoresTableAdapter.Fill(librosDataSet.autores); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.
                    }
                    else
                    {
                        var autorRow = librosDataSet.autores.NewautoresRow();

                        autorRow.Nombre = autorInfoForm.Autor.Nombre;
                        autorRow.Nacionalidad = autorInfoForm.Autor.Nacionalidad;
                        autorRow.Nacimiento = autorInfoForm.Autor.Nacimiento;
                        autorRow.Muerte = autorInfoForm.Autor.Muerte;

                        librosDataSet.libros.Rows.Add(autorRow);
                        dgvAutores.DataSource = librosDataSet.autores;
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvAutores.CurrentRow;
            if (currentRow != null)
            {
                Autor autor = new Autor
                                    {
                                        Nombre = currentRow.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString(),
                                        Nacionalidad =
                                            currentRow.Cells["nacionalidadDataGridViewTextBoxColumn"].Value.ToString(),
                                        Nacimiento =
                                            currentRow.Cells["nacimientoDataGridViewTextBoxColumn"].Value.ToString(),
                                        Muerte = currentRow.Cells["muerteDataGridViewTextBoxColumn"].Value.ToString()
                                    };

                var autorInfoForm = new AutoresInfoForm(autor);
                if (autorInfoForm.ShowDialog() == DialogResult.OK)
                {
                    if (autorInfoForm.Autor != null)
                    {
                        if (IsConnected)
                        {
                            autoresTableAdapter.Update(autorInfoForm.Autor.Nombre, autorInfoForm.Autor.Nacimiento,
                                                    autorInfoForm.Autor.Muerte, autorInfoForm.Autor.Nacionalidad,
                                                    Convert.ToInt32(
                                                        currentRow.Cells["idAutorDataGridViewTextBoxColumn"].Value));
                            autoresTableAdapter.Fill(librosDataSet.autores); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.
                        } 
                        else
                        {
                            librosDataSet.autores[currentRow.Index].Nombre = autorInfoForm.Autor.Nombre;
                            librosDataSet.autores[currentRow.Index].Nacimiento = autorInfoForm.Autor.Nacimiento;
                            librosDataSet.autores[currentRow.Index].Nacimiento = autorInfoForm.Autor.Nacimiento;
                            librosDataSet.autores[currentRow.Index].Muerte = autorInfoForm.Autor.Muerte;

                            dgvAutores.DataSource = librosDataSet.autores;
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvAutores.CurrentRow;
            if (currentRow != null)
            {
                if (IsConnected)
                {
                    if (MessageBox.Show(this, "¿Está seguro que desea eliminar el elemento?\nLos cambios se guardarán inmediatamente en la base de datos", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        autoresTableAdapter.Delete(Convert.ToInt32(
                                                           currentRow.Cells["idAutorDataGridViewTextBoxColumn"].Value));
                        autoresTableAdapter.Fill(librosDataSet.autores); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.
                    }
                }
                else
                {
                    librosDataSet.libros.Rows[Convert.ToInt32(currentRow.Cells["idAutorDataGridViewTextBoxColumn"].RowIndex)].Delete();
                    dgvAutores.DataSource = librosDataSet.autores;
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

        private void AutoresForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SaveChanges()
        {
            autoresTableAdapter.Update(librosDataSet.autores);
        }
    }
}
