using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaDatos
{
    public class multiUsuario
    {
        

        public void crearUsuario(string pnombre,string pusuario, string prol)
        {
            String query = "INSERT INTO usuarios(nombre,usuario,contrasenna,rol) VALUES('"+pnombre+"','"+pusuario+"','1234','"+prol+"');";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

             MySqlCommand commandDatabase = new MySqlCommand(query, conector);
             commandDatabase.CommandTimeout = 60;
            try
            {
                conector.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuario insertado satisfactoriamente");

                conector.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }



        }

        public Boolean modificarUsuario(string pnombre, string pusuario, string prol,string pcontrasenna)
        {

            Boolean verificacion = false;
            String query = "update usuarios "
             + "set nombre = '" + pnombre + "',contrasenna = '" + pcontrasenna + "',rol = '" + prol + "'" +
                "where usuario = '" + pusuario + "'; ";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            try
            {
                conector.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                verificacion = true;

                conector.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }

            return verificacion;

        }

        public String consultarUsuario(String pusuario, String pcontrasenna)
        {
            String result = "";
            string query;

                 query = "SELECT true FROM usuarios where usuario = '" + pusuario + "' AND contrasenna = '" + pcontrasenna + "';";
                       
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conector.Open();
                reader = commandDatabase.ExecuteReader();


                // Si se encontraron datos
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {                    
                        result = reader.GetString(0);
                    }
                }
                else
                {
                  //  MessageBox.Show("No se encontro nada");
                }

                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }


        public string cargarNombreUsuario(string pusuario)
        {
            String result = "";
            string query = "SELECT nombre FROM usuarios where usuario = '" + pusuario + "';";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conector.Open();
                reader = commandDatabase.ExecuteReader();
                // Si se encontraron datos
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = reader.GetString(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro nada");
                }

                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return result;
        }

        public string cargarContrasenna(string pusuario)
        {
            String result = "";
            string query = "SELECT contrasenna FROM usuarios where usuario = '" + pusuario + "';";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conector.Open();
                reader = commandDatabase.ExecuteReader();
                // Si se encontraron datos
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = reader.GetString(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro nada");
                }

                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return result;
        }

        public string cargarRol(string pusuario)
        {
            String result = "";
            string query = "SELECT rol FROM usuarios where usuario = '" + pusuario + "';";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conector.Open();
                reader = commandDatabase.ExecuteReader();
                // Si se encontraron datos
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = reader.GetString(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro nada");
                }

                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return result;
        }





    }

 
}
