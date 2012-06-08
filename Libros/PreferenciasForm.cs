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
    public partial class PreferenciasForm : Form
    {
        public bool Conectado { get; private set; }
        public string Usuario { get; private set; }
        public string Password { get; private set; }

        private readonly Configuration _config;

        public PreferenciasForm()
        {
            InitializeComponent();
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.ConnectionStrings.Count != 0)
            {
                ConnectionStringSettingsCollection conStrings = ConfigurationManager.ConnectionStrings;
                foreach (ConnectionStringSettings conString in conStrings)
                {
                    string[] conParts = conString.ConnectionString.Split(';');
                    foreach (var conPart in conParts)
                    {
                        if (conPart.StartsWith("User Id"))
                        {
                            txtUsuario.Text = conPart.Replace("User Id=", string.Empty);
                        }
                        else if (conPart.StartsWith("password"))
                        {
                            txtPassword.Text = conPart.Replace("password=", string.Empty);
                        }
                    }
                }
            }

            if (_config.AppSettings.Settings.Count != 0)
            {
                if (bool.Parse(_config.AppSettings.Settings["Conectado"].Value))
                {
                    rbConectado.Checked = true;
                }
                else
                {
                    rbDesconectado.Checked = true;
                }
            }
            else
            {
                rbConectado.Checked = true;
                _config.AppSettings.Settings.Add("Conectado", rbConectado.Checked.ToString());
            }
        }

        private void PreferenciasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _config.AppSettings.Settings["Conectado"].Value = rbConectado.Checked.ToString();

            _config.ConnectionStrings.ConnectionStrings["Libros.Properties.Settings.librosConnectionString"].
                ConnectionString = string.Format(
                    "server=localhost;User Id={0};database=libros;password={1};Persist Security Info=True",
                    txtUsuario.Text, txtPassword.Text);


            _config.Save(ConfigurationSaveMode.Modified);
            MessageBox.Show(this, "Para que los cambios surtan efectos, la aplicación se reiniciará.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();

            Close();
        }
    }
}
