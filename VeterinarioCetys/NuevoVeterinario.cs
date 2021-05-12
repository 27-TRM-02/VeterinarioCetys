using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace VeterinarioCetys
{
    public partial class NuevoVeterinario : Form
    {
        public NuevoVeterinario()
        {
            InitializeComponent();
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
        }

        private void newVeteriBoton_Click(object sender, EventArgs e)
        {
            String passHasheada = BCrypt.Net.BCrypt.HashPassword(passwordText.Text, BCrypt.Net.BCrypt.GenerateSalt());

            Conexion conexion = new Conexion();
            Boolean resultado = conexion.altaUsuario(DNItext.Text, passHasheada, nombreText.Text, apellidosText.Text, sexoText.Text, edadText.Text, emailText.Text, especialidadText.Text, perfilText.Text);

            if (resultado)
            {
                this.Hide();
                MessageBox.Show("CREACIÓN COMPLETADA");
            }
            else
            {
                MessageBox.Show("ALGO MALO HA PASADO");
            }
        }
    }
}
