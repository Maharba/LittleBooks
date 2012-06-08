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
    public partial class AutoresInfoForm : Form
    {
        private DateTime _fechaMuerte;
        private string _lugarMuerte;

        /// <summary>
        /// Obtiene o establece el Autor.
        /// </summary>
        public Autor Autor { get; set; }

        public AutoresInfoForm(Autor autor = null)
        {
            InitializeComponent();
            Autor = autor;

            if (autor != null)
            {
                txtNombre.Text = autor.Nombre;
                txtNacionalidad.Text = autor.Nacionalidad;
                string[] blabla = autor.Nacimiento.Split(';');
                txtLugarNacimiento.Text = blabla[0];
                string[] ddd = blabla[1].Split(new string[] { "de" }, StringSplitOptions.None);
                DateTime nacimiento;

                if (ddd[1].Contains("enero"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 1, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("febrero"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 2, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("marzo"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 3, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("abril"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 4, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("mayo"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 5, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("junio"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 6, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("julio"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 7, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("agosto"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 8, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("septiembre"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 9, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("octubre"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 10, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("noviembre"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 11, int.Parse(ddd[0]));
                }
                else if (ddd[1].Contains("diciembre"))
                {
                    nacimiento = new DateTime(int.Parse(ddd[2]), 12, int.Parse(ddd[0]));
                }
                else
                {
                    nacimiento = new DateTime();
                }

                try
                {
                    dtNacimiento.Value = nacimiento;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show(this,
                                    "Error al obtener información de la base de datos.\nVerifique que el mes esté en el formato correcto.\nSe mostrará la fecha de Nacimiento como el día de hoy.\n\nTip: Generalmente es ocasionado por tener el número del mes y no el nombre.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string[] blabla1 = autor.Muerte.Split(';');
                txtLugarMuerte.Text = blabla1[0];

                if (blabla1.Length == 2)
                {
                    string[] strings = blabla1[1].Split(new string[] { "de" }, StringSplitOptions.None);
                    DateTime muerte;

                    if (strings[1].Contains("enero"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 1, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("febrero"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 2, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("marzo"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 3, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("abril"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 4, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("mayo"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 5, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("junio"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 6, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("julio"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 7, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("agosto"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 8, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("septiembre"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 9, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("octubre"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 10, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("noviembre"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 11, int.Parse(strings[0]));
                    }
                    else if (strings[1].Contains("diciembre"))
                    {
                        muerte = new DateTime(int.Parse(strings[2]), 12, int.Parse(strings[0]));
                    }
                    else
                    {
                        muerte = new DateTime();
                    }
                    try
                    {
                        dtMuerte.Value = muerte;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show(this,
                                        "Error al obtener información de la base de datos.\nVerifique que el mes esté en el formato correcto.\nSe mostrará la fecha de Muerte como el día de hoy.\n\nTip: Generalmente es ocasionado por tener el número del mes y no el nombre.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Autor = new Autor();
            }
        }

        private void chkVive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVive.Checked)
            {
                _lugarMuerte = txtLugarMuerte.Text;
                _fechaMuerte = dtMuerte.Value;

                txtLugarMuerte.Text = string.Empty;
                txtLugarMuerte.Enabled = false;
                dtMuerte.Enabled = false;
                dtMuerte.Text = string.Empty;
            }
            else
            {
                txtLugarMuerte.Text = _lugarMuerte;
                txtLugarMuerte.Enabled = true;
                dtMuerte.Enabled = true;
                dtMuerte.Value = _fechaMuerte;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AutoresInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Autor.Nombre = txtNombre.Text;

                string monthName = ConvertMonthNumberToMonthName(dtNacimiento.Value.Month);

                Autor.Nacimiento = string.Format("{0}; {1} de {2} de {3}", txtLugarNacimiento.Text,
                                                    dtNacimiento.Value.Day, monthName,
                                                    dtNacimiento.Value.Year);
                if (chkVive.Checked)
                {
                    Autor.Muerte = string.Empty;
                }
                else
                {
                    monthName = ConvertMonthNumberToMonthName(dtMuerte.Value.Month);
                    Autor.Muerte = string.Format("{0}; {1} de {2} de {3}", txtLugarMuerte.Text,
                                                    dtMuerte.Value.Day, monthName,
                                                    dtMuerte.Value.Year);
                }
                Autor.Nacionalidad = txtNacionalidad.Text;
            }
        }

        private string ConvertMonthNumberToMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "enero";
                case 2:
                    return "febrero";
                case 3:
                    return "marzo";
                case 4:
                    return "abril";
                case 5:
                    return "mayo";
                case 6:
                    return "junio";
                case 7:
                    return "julio";
                case 8:
                    return "agosto";
                case 9:
                    return "septiembre";
                case 10:
                    return "octubre";
                case 11:
                    return "noviembre";
                case 12:
                    return "diciembre";
                default:
                    return string.Empty;
            }
        }
    }
}
