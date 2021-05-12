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
    public partial class NuevaMascota : Form
    {
        public NuevaMascota()
        {
            InitializeComponent();
        }

        private void newMascotaBoton_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            Boolean resultado = conexion.altaMascota(chipText.Text, nombreText.Text, razaText.Text, edadText.Text, generoText.Text, amoText.Text, veterinarioText.Text);

            if (resultado)
            {
                this.Hide();
                MessageBox.Show("SE AGREGÓ CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("ALGO MALO HA PASADO");
            }
        }
    }
}
