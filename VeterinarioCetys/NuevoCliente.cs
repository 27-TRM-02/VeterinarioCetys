using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarioCetys
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void newClienteBoton_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            Boolean resultado = conexion.altaCliente(dniText.Text, nombreText.Text, apellidosText.Text, emailText.Text, movilText.Text);

            if (resultado)
            {
                this.Hide();
                MessageBox.Show("TODO BIEN PAPI");
            }
            else
            {
                MessageBox.Show("ALGO MALO HA PASADOOOO");
            }
        }
    }
}
