using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;  //la libreria del DataTable

namespace VeterinarioCetys
{
    class Conexion
    {
        //variable que se encarga de conectarnos al servidor MySql
        public MySqlConnection bbdd;
        public static String DNI = "";
        public Conexion()
        {
            // Conexión con la base de datos MySql
            bbdd = new MySqlConnection("Server = 127.0.0.1; Database = veterinario_cetys; Uid = root; Pwd =; Port = 3306");
        }

        public Boolean loginVeterinario(String _DNI, String _password)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_veterinarios WHERE DNI = @_DNI ", bbdd);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);

                //guardo el resultado de la query
                MySqlDataReader result = consulta.ExecuteReader();

                if (result.Read())
                {
                    String passConHash = result.GetString("password");
                    if (BCrypt.Net.BCrypt.Verify(_password, passConHash))
                    {
                        bbdd.Close();
                        return true;
                    }
                }

                bbdd.Close();
                return false;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                return false;
            }
        }

        public Boolean altaUsuario(String _DNI, String _password, String _Nombre, String _Apellidos, String _Sexo, String _Edad, String _email, String _Especialidad, String _ID)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO t_veterinarios (DNI, password, Nombre, Apellidos, Sexo, Edad, email, Especialidad, ID) VALUES (@_DNI, @_password, @_Nombre, @_Apellidos, @_Sexo, @_Edad, @_email, @_Especialidad, @_ID) ", bbdd);

                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_password", _password);
                consulta.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta.Parameters.AddWithValue("@_Apellidos", _Apellidos);
                consulta.Parameters.AddWithValue("@_Sexo", _Sexo);
                consulta.Parameters.AddWithValue("@_Edad", _Edad);
                consulta.Parameters.AddWithValue("@_email", _email);
                consulta.Parameters.AddWithValue("@_Especialidad", _Especialidad);
                consulta.Parameters.AddWithValue("@_ID", _ID);

                // Devuelve el numero de filas que se han añadido
                int resultado = consulta.ExecuteNonQuery();

                if (resultado > 0)
                {
                    // se ha realizado bien el alta
                    bbdd.Close();
                    return true;
                }

                bbdd.Close();
                return false;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                return false;
                throw e;
            }
        }
        public Boolean altaMascota(String _Chip, String _Nombre, String _Raza, String _Edad, String _Genero, String _Amo, String _Veterinario)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO t_mascotas (Chip, Nombre, Raza, Edad, Genero, Amo, VeterinarioPersonal) VALUES (@_Chip, @_Nombre, @_Raza, @_Edad, @_Genero, @_Amo, @_VeterinarioD) ", bbdd);

                consulta.Parameters.AddWithValue("@_Chip", _Chip);
                consulta.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta.Parameters.AddWithValue("@_Raza", _Raza);
                consulta.Parameters.AddWithValue("@_Edad", _Edad);
                consulta.Parameters.AddWithValue("@_Genero", _Genero);
                consulta.Parameters.AddWithValue("@_Amo", _Amo);
                consulta.Parameters.AddWithValue("@_VeterinarioD", _Veterinario);

                // Devuelve el numero de filas que se han añadido
                int resultado = consulta.ExecuteNonQuery();

                if (resultado > 0)
                {
                    // se ha realizado bien el alta
                    bbdd.Close();
                    return true;
                }

                bbdd.Close();
                return false;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                return false;
                throw e;
            }
        }
        public Boolean altaCliente(String _DNI, String _Nombre, String _Apellidos, String _email, String _Movil)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO t_clientes (DNI, Nombre, Apellidos, email, Movil) VALUES (@_DNI, @_Nombre, @_Apellidos, @_email, @_Movil) ", bbdd);

                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta.Parameters.AddWithValue("@_Apellidos", _Apellidos);
                consulta.Parameters.AddWithValue("@_email", _email);
                consulta.Parameters.AddWithValue("@_Movil", _Movil);

                // Devuelve el numero de filas que se han añadido
                int resultado = consulta.ExecuteNonQuery();

                if (resultado > 0)
                {
                    // se ha realizado bien el alta
                    bbdd.Close();
                    return true;
                }

                bbdd.Close();
                return false;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                return false;
                throw e;
            }
        }
        public Boolean altaCita(String _ID_Citas, String _Veterinario_Cita, String _Mascota_Cita, String _Fecha, String _Hora, String _Concepto)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO t_citas (ID_Citas, Veterinario_Cita, Mascota_Cita, Fecha, Hora, Concepto) VALUES (@_ID_Citas, @_Veterinario_Cita, @_Mascota_Cita, @_Fecha, @_Hora, @_Concepto) ", bbdd);

                consulta.Parameters.AddWithValue("@_ID_Citas", _ID_Citas);
                consulta.Parameters.AddWithValue("@_Veterinario_Cita", _Veterinario_Cita);
                consulta.Parameters.AddWithValue("@_Mascota_Cita", _Mascota_Cita);
                consulta.Parameters.AddWithValue("@_Fecha", _Fecha);
                consulta.Parameters.AddWithValue("@_Hora", _Hora);
                consulta.Parameters.AddWithValue("@_Concepto", _Concepto);

                // Devuelve el numero de filas que se han añadido
                int resultado = consulta.ExecuteNonQuery();

                if (resultado > 0)
                {
                    // se ha realizado bien el alta
                    bbdd.Close();
                    return true;
                }

                bbdd.Close();
                return false;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                return false;
                throw e;
            }
        }

        public int getIdActivo()
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_veterinarios WHERE DNI='" + DNI + "'", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                resultado.Read();
                int idUser = Int32.Parse(resultado.GetString("ID"));
                bbdd.Close();
                return idUser;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }

        public DataTable getMascota(String _Chip)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_mascotas WHERE Chip='" + _Chip + "'", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable mascota = new DataTable(); //formato que espera el datagridview
                mascota.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return mascota;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }
        public DataTable getMascotas()
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_mascotas", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable mascotas = new DataTable(); //formato que espera el datagridview
                mascotas.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return mascotas;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }

        public DataTable getCliente(String _DNI)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_clientes WHERE DNI='" + _DNI + "'", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable cliente = new DataTable(); //formato que espera el datagridview
                cliente.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return cliente;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }


        public DataTable getClientes()
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_clientes", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable clientes = new DataTable(); //formato que espera el datagridview
                clientes.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return clientes;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }

        public DataTable getVeterinarios()
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_veterinarios", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable veterinarios = new DataTable(); //formato que espera el datagridview
                veterinarios.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return veterinarios;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }
        public DataTable getVeterinario(String _DNI)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_veterinarios WHERE DNI='" + _DNI + "'", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable veterinario = new DataTable(); //formato que espera el datagridview
                veterinario.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return veterinario;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }
        public DataTable getVeterinariosEsp(String _Especialidad)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_veterinarios WHERE Especialidad='" + _Especialidad + "'", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable citasVeteri = new DataTable(); //formato que espera el datagridview
                citasVeteri.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return citasVeteri;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }




        public DataTable getCitas()
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_citas", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable citas = new DataTable(); //formato que espera el datagridview
                citas.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return citas;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }
        public DataTable getCitasVeteri(String _DNI)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_citas WHERE Veterinario_Cita='" + _DNI + "'", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable citasVeteri = new DataTable(); //formato que espera el datagridview
                citasVeteri.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return citasVeteri;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }
        public DataTable getCitasMascota(String _Chip)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM t_citas WHERE Mascota_Cita='" + _Chip + "'", bbdd);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable citasMascotas = new DataTable(); //formato que espera el datagridview
                citasMascotas.Load(resultado);  //convierte MysqlDataReader en DataTable
                bbdd.Close();
                return citasMascotas;
            }
            catch (MySqlException e)
            {
                bbdd.Close();
                throw e;
            }
        }
    }
}
