using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaDatos
{
    class multiFactura
    {


        public void crearFactura(List<String> pcodigoInterno, List<String> pcodigoProducto, List<String> pprecioProducto, List<String> pcantidad, List<String> ptotal, List<String> pidCliente, List<String> pfechaFactura)
        {

            for (int a = 0;a<pcodigoInterno.Count;a++)
             {
                
                double codugoInterno = double.Parse(pcodigoInterno[a]);
                double codigoProducto = double.Parse(pcodigoProducto[a]);
                double precioProducto = double.Parse(pprecioProducto[a]);
                double cantidad = double.Parse(pcantidad[a]);
                double total = double.Parse(ptotal[a]);
                double iCliente = double.Parse(pidCliente[a]);
                
                string query = "INSERT INTO factura(codigoFacturaInterno,codigoProducto,precioProducto,cantidad,total,idcliente,fechaFactura)" +
                 "Values("+ codugoInterno + ","+ codigoProducto + ","+ precioProducto + ","+ cantidad + ","+ total + ","+ iCliente + ",'"+ pfechaFactura[a] + "')";

                string query2 = "UPDATE productos SET cantidad = cantidad-"+ cantidad + " WHERE codigo = "+ codigoProducto + "";
                 AccesoDB.conector obj = new AccesoDB.conector();

                 MySqlConnection conector = obj.Getconector();

                 MySqlCommand commandDatabase = new MySqlCommand(query, conector);
                MySqlCommand commandDatabase2 = new MySqlCommand(query2, conector);
                commandDatabase.CommandTimeout = 60;
                 try
                 {
                     conector.Open();
                     MySqlDataReader myReader = commandDatabase.ExecuteReader();
                     conector.Close();

                    conector.Open();
                    MySqlDataReader myReader2 = commandDatabase2.ExecuteReader();
                    conector.Close();
                }
                 catch (Exception ex)
                 {
                     // Mostrar cualquier error
                     MessageBox.Show(ex.Message+"e");
                 }


             }
        }


        public string cargarUltNumeroFactura()
        {
            String result = "";
            string query = "SELECT MAX(codigoFacturaInterno)+1 FROM factura";
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
            }

            return result;
        }

        public String consultarProductoXCodigo(List<String> pcodigoFacturaInterno)
        {
            String result = "";
            string query = "SELECT true FROM factura where codigoFacturaInterno = " + pcodigoFacturaInterno[0] + "";
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

        public List<Dictionary<String, String>> cargaFacturasElec(String pfecha)
        {
           
            List<Dictionary<String, String>> Lfactura = new List<Dictionary<String, String>>();

            String SP = "cargar_factura_elecctronica";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@pfecha", pfecha);
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
                        Dictionary<String, String> Dfactura = new Dictionary<String, String>();
                        Dfactura.Add("codigoFacturaInterno", reader.GetString(0));
                        Dfactura.Add("codigoClienteF",reader.GetString(1));
                        Dfactura.Add("nombreCliente", reader.GetString(2));
                        Dfactura.Add("identificacion", reader.GetString(3));
                        Dfactura.Add("tipoIdentificacion", reader.GetString(4));
                        Dfactura.Add("telefono", reader.GetString(5));
                        Dfactura.Add("direcion", reader.GetString(6));
                        Dfactura.Add("email", reader.GetString(7));
                        Dfactura.Add("total", reader.GetString(8));
                        Dfactura.Add("codigoBarra", reader.GetString(9));
                        Dfactura.Add("nombreProducto", reader.GetString(10));
                        Dfactura.Add("tipoProducto", reader.GetString(11));
                        Dfactura.Add("cantidad", reader.GetString(12));
                        Dfactura.Add("precioProducto", reader.GetString(13));
                        Lfactura.Add(Dfactura);
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Lfactura;

        }

    }
}
