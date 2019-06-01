using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaDatos
{
    class multiCliente
    {

        public void crearCliente(String pidcliente, String pnombre, String pidentificacion, String ptipoIdenficacion, String ptelefono, String pdireccion, String pemail, String pcodigoClienteF)
        {
            String query = "INSERT INTO clientes(idcliente,nombreCliente,identificacion,tipoIdentificacion,telefono,direcion,email,codificaciondireccion)" +
                           "VALUES("+int.Parse(pidcliente)+",'"+pnombre+"','"+pidentificacion+"','"+ptipoIdenficacion+"','"+ptelefono+ "','"+pdireccion+ "','"+pemail+ "','"+pcodigoClienteF+"')";

            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conector.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Se creo el cliente");
                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        public void modificarCliente(String pidcliente, String pnombre, String pidentificacion, String ptipoIdenficacion, String ptelefono, String pdireccion, String pemail, String pcodigoClienteF)
        {

            String query = "update clientes "
                 + "set nombreCliente = '" + pnombre + "',identificacion = '" + pidentificacion + "',tipoIdentificacion = '" + ptipoIdenficacion + "',telefono = '" + ptelefono + "',direcion = '" + pdireccion + "' ,email = '" + pemail +"',codigoClienteF = '" + pcodigoClienteF + "'" +
                 "where (idcliente = '" + pidcliente + "'); ";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            try
            {
                conector.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Cliente Modificado");
                conector.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }

        }

        public String buscarUltimoIdCliente()
        {
            String result ="0";

            String query = "SELECT MAX(idcliente)+1 FROM clientes";
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
                        result = reader.GetString(0);
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return result;
        }

        public List<CapaLogica.cliente> buscarCliente(String pnombre)
        {
            List<CapaLogica.cliente> Lresult = new List<CapaLogica.cliente>();
                  string query = "SELECT * FROM clientes where nombreCliente like '%"+ pnombre + "%'";
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

                        CapaLogica.cliente objC = new CapaLogica.cliente(reader.GetString(0),reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetString(5), reader.GetString(6),reader.GetString(7));


                        Lresult.Add(objC);


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

                MessageBox.Show(ex.Message.ToString());
            }

            return Lresult;
        }


        public List<CapaLogica.cliente> buscarClienteXid(String pid)
        {
            List<CapaLogica.cliente> Lresult = new List<CapaLogica.cliente>();
            string query = "SELECT * FROM clientes where idcliente = '"+pid+"'";
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

                        CapaLogica.cliente objC = new CapaLogica.cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));


                        Lresult.Add(objC);


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

                MessageBox.Show(ex.Message.ToString());
            }

            return Lresult;
        }

        public String consultarCliente(String pidCliente)
        {
            string result = "0";
            String query = "SELECT TRUE FROM clientes WHERE idcliente = '"+ pidCliente + "'";
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
                        result = reader.GetString(0);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return result;
        }

        public List<CapaLogica.cliente> listarClientes()
        {
            List<CapaLogica.cliente> Lclientes = new List<CapaLogica.cliente>();

            string query = "SELECT * FROM clientes";
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
                        Lclientes.Add(new CapaLogica.cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                                                                reader.GetString(3), reader.GetString(4), reader.GetString(5),
                                                                reader.GetString(6), reader.GetString(7)));
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



            return Lclientes;
        }
    }
}
