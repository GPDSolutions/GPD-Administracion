using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaDatos
{
    class multiDatos
    {

        public Dictionary<string,string> getDatos()
        {
            Dictionary<string, string> Ddatos = new Dictionary<string, string>();

            string query = "SELECT count(*) FROM productos ";
            string query2 = "SELECT count(*) FROM usuarios ";
            string query3 = "SELECT count(*) FROM clientes ";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, conector);
            MySqlCommand commandDatabase3 = new MySqlCommand(query3, conector);
            commandDatabase.CommandTimeout = 60;
            commandDatabase2.CommandTimeout = 60;
            commandDatabase3.CommandTimeout = 60;
            MySqlDataReader reader;
            MySqlDataReader reader2;
            MySqlDataReader reader3;
            try
            {
                conector.Open();
                reader = commandDatabase.ExecuteReader();
                
                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Ddatos.Add("Productos",reader.GetString(0));
                    }
                }
                conector.Close();
                conector.Open();
                reader2 = commandDatabase2.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        Ddatos.Add("Usuarios", reader2.GetString(0));
                    }
                }
                conector.Close();
                conector.Open();
                reader3 = commandDatabase3.ExecuteReader();
                if (reader3.HasRows)
                {
                    while (reader3.Read())
                    {
                        Ddatos.Add("Clientes", reader3.GetString(0));

                    }
                }

                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return Ddatos;
        }

        public List<Dictionary<String, String>> getCanton(String pprovincia)
        {

            List<Dictionary<String,String>> LCanton = new List<Dictionary<String, String>>();


            String SP = "optener_canton";

            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@pprovincia", pprovincia);

            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                conector.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Dictionary<string,String> Ddatos = new Dictionary<string, String>();
                        Ddatos.Add("nombreCanton", reader.GetString(0));
                        Ddatos.Add("idCanton", reader.GetString(1));
                        LCanton.Add(Ddatos);

                    }
                }

                conector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return LCanton;
        }

        public List<Dictionary<String, String>> getDistrito(String idDistrito)
        {
            
            List<Dictionary<String, String>> Ldistrito = new List<Dictionary<String, String>>();

            string query = "SELECT DISTINCt nombreDistrito,idDistrito FROM codificacion_mh WHERE nombreCanton = '" + idDistrito + "' ";

            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);

            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                conector.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Dictionary<string, string> Ddatos = new Dictionary<string, string>();
                        Ddatos.Add("nombreDistrito", reader.GetString(0));
                        Ddatos.Add("idDistrito", reader.GetString(1));
                        Ldistrito.Add(Ddatos);
                    }
                }

                conector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return Ldistrito;
        }
    }
}
