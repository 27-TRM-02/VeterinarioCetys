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
using BCrypt.Net;

namespace VeterinarioCetys
{
    public partial class IniciarSesion : Form
    {
        Conexion conexion = new Conexion();
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void loginBoton_Click(object sender, EventArgs e)
        {
            String dniLogin = dniText.Text;
            if (conexion.loginVeterinario(dniLogin, passwordText.Text))
            {
                Conexion.DNI = dniLogin;
                this.Hide();
                Casa c = new Casa();
                c.Show();
            }
            else
            {
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS");
            }
        }

        private void botonHaseo_Click(object sender, EventArgs e)
        {
            conexion.bbdd.Open();
            MySqlCommand consulta = new MySqlCommand("SELECT DNI, password FROM t_veterinarios", conexion.bbdd);
            MySqlDataReader resultado = consulta.ExecuteReader();
            Dictionary<string, string> passwords = new Dictionary<string, string>();
            while (resultado.Read())
            {
                passwords.Add(resultado.GetString("DNI"), resultado.GetString("password"));
            }
            conexion.bbdd.Close();
            conexion.bbdd.Open();
            foreach(var element in passwords)
            {
                MySqlCommand consultaHash = new MySqlCommand("UPDATE t_veterinarios SET password=@_PASSWORD WHERE DNI=@_DNI", conexion.bbdd);
                consultaHash.Parameters.AddWithValue("@_DNI", element.Key);
                consultaHash.Parameters.AddWithValue("_PASSWORD", BCrypt.Net.BCrypt.HashPassword(element.Value, BCrypt.Net.BCrypt.GenerateSalt()));
                consultaHash.ExecuteNonQuery();
            }
            conexion.bbdd.Close();
            botonHaseo.Enabled = false;
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
        }
    }
}
