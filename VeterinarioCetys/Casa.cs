using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VeterinarioCetys
{
    public partial class Casa : Form
    {
        Conexion conexion = new Conexion();
        DataTable mascotas = new DataTable();
        DataTable mascotaBusqueda = new DataTable();
        public Casa()
        {
            InitializeComponent();
            // mascotas = conexion.getDB();
            // mascotaBusqueda = conexion.getMascota(chipBusquedaText.Text);
            // mascotaBusquedaData.DataSource = mascotaBusqueda;

        }

        private void botonNewVeteri_Click(object sender, EventArgs e)
        {
            NuevoVeterinario c = new NuevoVeterinario();
            c.Show();
        }

        private void newMascotaBoton_Click(object sender, EventArgs e)
        {
            NuevaMascota c = new NuevaMascota();
            c.Show();
        }

        private void newClienteBoton_Click(object sender, EventArgs e)
        {
            NuevoCliente c = new NuevoCliente();
            c.Show();
        }

        private void botonNewCita_Click(object sender, EventArgs e)
        {
            NuevaCita c = new NuevaCita();
            c.Show();
        }

        private void tabAddVete_Click(object sender, EventArgs e)
        {
          
        }

        private void buscarMascotaBoton_Click(object sender, EventArgs e)
        {
            mascotaBusqueda = conexion.getMascota(chipBusquedaText.Text);
            mascotaBusquedaData.DataSource = mascotaBusqueda;
        }
    }
}
