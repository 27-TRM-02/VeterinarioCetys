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
    public partial class NuevaCita : Form
    {
        public NuevaCita()
        {
            InitializeComponent();
        }

        private void newVeteriBoton_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            Boolean resultado = conexion.altaCita(idText.Text, veterinarioText.Text, mascotaText.Text, fechaText.Text, horaText.Text, conceptoText.Text);

            if (resultado)
            {
                this.Hide();
                MessageBox.Show("SE HA AÑADIDO CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("ALGO MALO HA PASADO");
            }
        }
    }
}
