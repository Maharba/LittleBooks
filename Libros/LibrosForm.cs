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
    public partial class LibrosForm : Form
    {
        public bool IsConnected { get; private set; }

        public LibrosForm(bool conected = true)
        {
            InitializeComponent();
            IsConnected = conected;
        }

        private void LibrosForm_Load(object sender, EventArgs e)
        {            
            this.librosTableAdapter.Fill(this.librosDataSet.libros);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvLibros.CurrentRow;
            if (currentRow != null)
            {
                Libro libro = new Libro
                                    {
                                        Titulo = currentRow.Cells["tituloDataGridViewTextBoxColumn"].Value.ToString(),
                                        AutorId =
                                            Convert.ToInt32(currentRow.Cells["autorDataGridViewTextBoxColumn"].Value),
                                        TituloOriginal =
                                            currentRow.Cells["tituloOriginalDataGridViewTextBoxColumn"].Value.ToString
                                            ()
                                    };

                var libroInfoForm = new LibrosInfoForm(libro);
                if (libroInfoForm.ShowDialog() == DialogResult.OK)
                {
                    if (libroInfoForm.Libro != null)
                    {
                        if (IsConnected)
                        {
                            librosTableAdapter.Update(libroInfoForm.Libro.Titulo, libroInfoForm.Libro.AutorId,
                                                    libroInfoForm.Libro.TituloOriginal,
                                                    Convert.ToInt32(
                                                        currentRow.Cells["idDataGridViewTextBoxColumn"].Value));
                            librosTableAdapter.Fill(librosDataSet.libros); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.

                        }
                        else
                        {
                            librosDataSet.libros[currentRow.Index].Titulo = libroInfoForm.Libro.Titulo;
                            if (libroInfoForm.Libro.AutorId.HasValue)
                                librosDataSet.libros[currentRow.Index].Autor = libroInfoForm.Libro.AutorId.Value;
                            librosDataSet.libros[currentRow.Index].TituloOriginal = libroInfoForm.Libro.TituloOriginal;
                            
                            dgvLibros.DataSource = librosDataSet.libros;
                        }
                    }
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var libroInfoForm = new LibrosInfoForm();
            if (libroInfoForm.ShowDialog() != DialogResult.Cancel)
            {
                if (libroInfoForm.Libro != null)
                {
                    if (IsConnected)
                    {
                        librosTableAdapter.Insert(libroInfoForm.Libro.Titulo, libroInfoForm.Libro.AutorId,
                                              libroInfoForm.Libro.TituloOriginal);
                        librosTableAdapter.Fill(librosDataSet.libros); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.
                    }
                    else
                    {
                        var libroRow = librosDataSet.libros.NewlibrosRow();
                        
                        libroRow.Titulo = libroInfoForm.Libro.Titulo;
                        if (libroInfoForm.Libro.AutorId.HasValue) libroRow.Autor = libroInfoForm.Libro.AutorId.Value;
                        libroRow.TituloOriginal = libroInfoForm.Libro.TituloOriginal;
                        
                        librosDataSet.libros.Rows.Add(libroRow);
                        dgvLibros.DataSource = librosDataSet.libros;
                    }
                }
            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvLibros.CurrentRow;
            if (currentRow != null)
            {
                if (IsConnected)
                {
                    if (MessageBox.Show(this, "¿Está seguro que desea eliminar el elemento?\nLos cambios se guardarán inmediatamente en la base de datos", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        librosTableAdapter.Delete(Convert.ToInt32(currentRow.Cells["idDataGridViewTextBoxColumn"].Value));
                        librosTableAdapter.Fill(librosDataSet.libros); // IMPORTANTE!!! Si se quita esta línea no se actualizará el dataGridView.
                    }
                }
                else
                {
                    librosDataSet.libros.Rows[Convert.ToInt32(currentRow.Cells["idDataGridViewTextBoxColumn"].RowIndex)].Delete();
                    dgvLibros.DataSource = librosDataSet.libros;
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

        private void LibrosForm_FormClosing(object sender, FormClosingEventArgs e)
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
            librosTableAdapter.Update(librosDataSet.libros);
        }
    }
}
