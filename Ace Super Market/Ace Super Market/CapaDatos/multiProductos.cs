using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaDatos
{
    class multiProductos
    {

        public void crearProducto(string pcodigoBarra, string pnombreProducto, string pcodigo, double pcantidadProducto, double pprecioCosto, double pprecioVenta, double putilidad, double pmetrosCubicos, double ppeso, string ptipoProducto,string punidadMedida)
        {

            String query = "INSERT INTO productos(codigoBarra,nombreProducto,codigo,cantidad,precioCosto,precioVenta,utilidad,metrosCubicos,peso,tipoProducto,unidadMedida) " +
                           "VALUES('"+ pcodigoBarra + "','"+ pnombreProducto + "',"+int.Parse(pcodigo)+ ","+ pcantidadProducto + ","+ pprecioCosto + ","+ pprecioVenta + ","+ putilidad + ","+ pmetrosCubicos + ","+ppeso+",'"+ ptipoProducto + "','"+punidadMedida+"');";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            try
            {
                conector.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Producto insertado satisfactoriamente");

                conector.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show("Crear : "+ex.Message);
            }
        }

        public void modificarProducto(string pcodigoBarra, string pnombreProducto, string pcodigo, double pcantidadProducto, double pprecioCosto, double pprecioVenta, double putilidad, double pmetrosCubicos, double ppeso, string ptipoProducto,string punidadMedida)
        {

            String query = "update productos "
                 + "set nombreProducto = '" + pnombreProducto + "',codigo = "+int.Parse(pcodigo) +",cantidad = cantidad + " + pcantidadProducto + ",precioCosto = " + pprecioCosto + ",precioVenta = " + pprecioVenta + ",utilidad = " + putilidad + ",metrosCubicos = " + pmetrosCubicos + " ,peso = "+ppeso+" "+",tipoProducto = '"+ ptipoProducto + "'"+ ",unidadMedida = '"+punidadMedida+"'" +
                 "where (codigoBarra = '" + pcodigoBarra + "'); ";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            try
            {
                conector.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Producto modificado satisfactoriamente");

                conector.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }

        }

        public void setCantidad(double pcantidadProducto, string pcodigoBarra, string pcodigo)
        {
            String query = "update productos "
                 + "set cantidad = " + pcantidadProducto+" " +
                 "where (codigoBarra = '" + pcodigoBarra + "') AND (codigo = " + int.Parse(pcodigo) + "); ";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(query, conector);
            commandDatabase.CommandTimeout = 60;
            try
            {
                conector.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                conector.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }
        }

        public String consultarProductoXCodigo(String pcodigoBarra, String pcodigo)
        {
            String result = "";
            string query = "SELECT true FROM productos where codigoBarra = '" + pcodigoBarra + "' ";
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



        public Dictionary<string, string> consultarProductoXCodigoBarra(String pcodigoBarra)
        {
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
              string query = "SELECT * FROM productos where codigoBarra = '" + pcodigoBarra + "' ";
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
                      

                        Dproducto.Add("CodigoBarra", reader.GetString(1));
                        Dproducto.Add("NombreProducto", reader.GetString(2));
                        Dproducto.Add("Codigo", reader.GetString(3));
                        Dproducto.Add("Cantidad", reader.GetString(4));
                        Dproducto.Add("PrecioCosto", reader.GetString(5));
                        Dproducto.Add("PrecioVenta", reader.GetString(6));
                        Dproducto.Add("Utilidad", reader.GetString(7));
                        Dproducto.Add("MetrosCubicos", reader.GetString(8));
                        Dproducto.Add("Peso", reader.GetString(9));
                        Dproducto.Add("tipoProducto",reader.GetString(10));
                        Dproducto.Add("unidadMedida", reader.GetString(11));
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
                MessageBox.Show(ex.Message+"dddd");
            }

            return Dproducto;
        }

        public Dictionary<string, string> consultarProductoXCodigoInterno(String pcodigoInterno)
        {
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
            string query = "SELECT * FROM productos where codigo = '" + pcodigoInterno + "' ";
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


                        Dproducto.Add("CodigoBarra", reader.GetString(1));
                        Dproducto.Add("NombreProducto", reader.GetString(2));
                        Dproducto.Add("Codigo", reader.GetString(3));
                        Dproducto.Add("Cantidad", reader.GetString(4));
                        Dproducto.Add("PrecioCosto", reader.GetString(5));
                        Dproducto.Add("PrecioVenta", reader.GetString(6));
                        Dproducto.Add("Utilidad", reader.GetString(7));
                        Dproducto.Add("MetrosCubicos", reader.GetString(8));
                        Dproducto.Add("Peso", reader.GetString(9));
                        Dproducto.Add("tipoProducto",reader.GetString(10));
                        Dproducto.Add("unidadMedida", reader.GetString(11));
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

            return Dproducto;
        }
        public int ultimoCodigo()
        {
            int maxCodigo = 0;

            string query = "SELECT MAX(codigo) FROM productos";
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
                        maxCodigo = reader.GetInt32(0);
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

            return maxCodigo;
        }

        public List<CapaLogica.producto> listarProductos()
        {
            List<CapaLogica.producto> Lproductos = new List<CapaLogica.producto>();

            string query = "SELECT * FROM productos";
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
                        Lproductos.Add(new CapaLogica.producto(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                                                reader.GetDouble(4), reader.GetDouble(5), reader.GetDouble(6),
                                                                reader.GetDouble(7), reader.GetDouble(8), reader.GetDouble(9),
                                                                reader.GetString(10),reader.GetString(11)));
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



            return Lproductos;
        }


    }
}
