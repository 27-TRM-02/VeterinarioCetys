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
        // DataTables que muestran distintas consultas de la base de datos
        DataTable mascotas = new DataTable();
        DataTable mascotaBusqueda = new DataTable();
        DataTable clienteBusqueda = new DataTable();
        DataTable citas = new DataTable();
        DataTable citasMascota = new DataTable();
        DataTable citasVeterinario = new DataTable();
        DataTable veterinarios = new DataTable();
        DataTable veterinario = new DataTable();
        DataTable veterinariosEsp = new DataTable();

        public Casa()
        {
            InitializeComponent();
            int idVeterinario = this.conexion.getIdActivo();
            switch (idVeterinario)
            {
                case 1:
                    this.tabControlCasa.Controls.Remove(this.tabAddVete);
                    break;
                case 2:
                    this.tabControlCasa.Controls.Remove(this.tabNewClients);
                    this.tabControlCasa.Controls.Remove(this.tabAddVete);
                    break;

            }
            citas = conexion.getCitas();
            citasVeteriData.DataSource = citas;
            veterinarios = conexion.getVeterinarios();
            veterinariosData.DataSource = veterinarios;
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

        private void buscarMascotaBoton_Click(object sender, EventArgs e)
        {
            mascotaBusqueda = conexion.getMascota(chipBusquedaText.Text);
            mascotaBusquedaData.DataSource = mascotaBusqueda;
        }

        private void buscarClienteBoton_Click(object sender, EventArgs e)
        {
            clienteBusqueda = conexion.getCliente(dniBusquedaText.Text);
            clienteBusquedaData.DataSource = clienteBusqueda;
        }

        private void buscarCitaMascotaBoton_Click(object sender, EventArgs e)
        {
            citasMascota = conexion.getCitasMascota(chipCitaBusquedaText.Text);
            citasVeteriData.DataSource = citasMascota;
        }

        private void buscarCitaVeteriBoton_Click(object sender, EventArgs e)
        {
            citasVeterinario = conexion.getCitasVeteri(dniCitaBusquedaText.Text);
            citasVeteriData.DataSource = citasVeterinario;
        }

        private void dniVeteriBusquedaBoton_Click(object sender, EventArgs e)
        {
            veterinario = conexion.getVeterinario(vetText.Text);
            veterinariosData.DataSource = veterinario;
        }

        private void espVetBusquedaBoton_Click(object sender, EventArgs e)
        {
            veterinariosEsp = conexion.getVeterinariosEsp(vetText.Text);
            veterinariosData.DataSource = veterinariosEsp;
        }

        private void logOutBoton_Click(object sender, EventArgs e)
        {
            IniciarSesion c = new IniciarSesion();
            this.Hide();
            c.Show();
        }
    }
}
