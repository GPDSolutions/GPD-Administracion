using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaDatos
{
    class multicalvelectronica
    {

        public void crearClaveElectronica(String pcodigoFacturaInterno, String pcodigopais, String pdia, String pmes, String panno, String pidentificacion, String pconsecutivo, String psituacioncomprobante, String pcodigoseguridad)
        {
            String SP = "crear_clave_electronica";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(SP,conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@pcodigoFacturaInterno", pcodigoFacturaInterno);
            commandDatabase.Parameters.AddWithValue("@pcodigopais", pcodigopais);
            commandDatabase.Parameters.AddWithValue("@pdia",pdia);
            commandDatabase.Parameters.AddWithValue("@pmes",pmes);
            commandDatabase.Parameters.AddWithValue("@panno",panno);
            commandDatabase.Parameters.AddWithValue("@pidentificacion", pidentificacion);
            commandDatabase.Parameters.AddWithValue("@pconsecutivo", pconsecutivo);
            commandDatabase.Parameters.AddWithValue("@psituacioncomprobante", psituacioncomprobante);
            commandDatabase.Parameters.AddWithValue("@pcodigoseguridad", pcodigoseguridad);
            commandDatabase.CommandTimeout = 60;

            try
            {
                conector.Open();
                int v = commandDatabase.ExecuteNonQuery();

                if (v == 1)
                {
                    MessageBox.Show("Clave Agregado");
                }
                conector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void crearClaveElectronicaTiquete(String pcodigoFacturaInterno, String pcodigopais, String pdia, String pmes, String panno, String pidentificacion, String pconsecutivo, String psituacioncomprobante, String pcodigoseguridad)
        {
            String SP = "crear_clave_electronica_tiquete";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@pcodigoFacturaInterno", pcodigoFacturaInterno);
            commandDatabase.Parameters.AddWithValue("@pcodigopais", pcodigopais);
            commandDatabase.Parameters.AddWithValue("@pdia", pdia);
            commandDatabase.Parameters.AddWithValue("@pmes", pmes);
            commandDatabase.Parameters.AddWithValue("@panno", panno);
            commandDatabase.Parameters.AddWithValue("@pidentificacion", pidentificacion);
            commandDatabase.Parameters.AddWithValue("@pconsecutivo", pconsecutivo);
            commandDatabase.Parameters.AddWithValue("@psituacioncomprobante", psituacioncomprobante);
            commandDatabase.Parameters.AddWithValue("@pcodigoseguridad", pcodigoseguridad);
            commandDatabase.CommandTimeout = 60;

            try
            {
                conector.Open();
                int v = commandDatabase.ExecuteNonQuery();

                if (v == 1)
                {
                    MessageBox.Show("Clave Agregado");
                }
                conector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public CapaLogica.clavefacturacionelectronica cargarClaveElectronica()
        {
            CapaLogica.clavefacturacionelectronica clave = null;
            String SP = "optener_clave_electronica";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
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
                        clave = new CapaLogica.clavefacturacionelectronica(reader.GetString(0), reader.GetString(2), reader.GetString(3),
                                                                           reader.GetString(4), reader.GetString(6), reader.GetString(7),
                                                                           reader.GetString(8));
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return clave;
        }

        public CapaLogica.clavefacturacionelectronica cargarClaveElectronicaTiquete()
        {
            CapaLogica.clavefacturacionelectronica clave = null;
            String SP = "optener_clave_electronica_tiquete";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
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
                        clave = new CapaLogica.clavefacturacionelectronica(reader.GetString(0), reader.GetString(2), reader.GetString(3),
                                                                           reader.GetString(4), reader.GetString(6), reader.GetString(7),
                                                                           reader.GetString(8));
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return clave;
        }

        public String optenerToken()
        {
            String SP = "optener_Token";
            String token = "";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
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
                        token = reader.GetString(1);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return token;
        }

        public List<String> cargarConsecutivoReceptor()
        {
            List<String> LconsecutivoReceptor = new List<string>();
            String SP = "optener_consecutivo_receptor";
            AccesoDB.conector objC = new AccesoDB.conector();
            MySqlConnection conector = objC.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
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
                        LconsecutivoReceptor.Add(reader.GetString(2));
                        LconsecutivoReceptor.Add(reader.GetString(3));
                        LconsecutivoReceptor.Add(reader.GetString(4));
                        LconsecutivoReceptor.Add(reader.GetString(5));

                    }

                }
                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return LconsecutivoReceptor;
        }

        public void guardarConsecutivoReceptor(Dictionary<String,String> Drecepcion)
        {
            String SP = "guardar_consecutivo_receptor";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@pclaveFactura", Drecepcion["claveFactura"]);
            commandDatabase.Parameters.AddWithValue("@plocall", Drecepcion["locall"]);
            commandDatabase.Parameters.AddWithValue("@pterminal", Drecepcion["terminal"]);
            commandDatabase.Parameters.AddWithValue("@ptipodocumento", Drecepcion["tipodocumento"]);
            commandDatabase.Parameters.AddWithValue("@pconsecutivo", Drecepcion["consecutivo"]);
            commandDatabase.CommandTimeout = 60;

            try
            {
                conector.Open();
                int v = commandDatabase.ExecuteNonQuery();

                if (v == 1)
                {
                    MessageBox.Show("Datos de Receptor Agregados");
                }
                conector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void crearDatosFactura(Dictionary<String,String> Drecepcion)
        {
            String SP = "crear_datos_factura";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@pestado", Drecepcion["estado"]);
            commandDatabase.Parameters.AddWithValue("@pclave", Drecepcion["clave"]);
            commandDatabase.Parameters.AddWithValue("@ptipoidentificacion", Drecepcion["tipoidentificacion"]);
            commandDatabase.Parameters.AddWithValue("@pnumerocedulaemisor", Drecepcion["numerocedulaemisor"]);
            commandDatabase.Parameters.AddWithValue("@pfechaemisiondoc", Drecepcion["fechaemisiondoc"]);
            commandDatabase.Parameters.AddWithValue("@pmensaje", Drecepcion["mensaje"]);
            commandDatabase.Parameters.AddWithValue("@pdetallemensaje", Drecepcion["detallemensaje"]);
            commandDatabase.Parameters.AddWithValue("@pmontototalimpuesto", Drecepcion["montototalimpuesto"]);
            commandDatabase.Parameters.AddWithValue("@ptotalfactura", Drecepcion["totalfactura"]);
            commandDatabase.Parameters.AddWithValue("@pnumerocedulareceptor", Drecepcion["numerocedulareceptor"]);
            commandDatabase.Parameters.AddWithValue("@pnumeroconsecutivoreceptor", Drecepcion["numeroconsecutivoreceptor"]);
            commandDatabase.Parameters.AddWithValue("@pnombrecliente", Drecepcion["nombrecliente"]);
            commandDatabase.Parameters.AddWithValue("@pcorerocliente", Drecepcion["corerocliente"]);

            commandDatabase.CommandTimeout = 60;

            try
            {
                conector.Open();
                int v = commandDatabase.ExecuteNonQuery();

                if (v == 1)
                {
                    MessageBox.Show("Datos de Factura Agregados");
                }
                conector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void modificarDatosFactura(Dictionary<String, String> Drecepcion)
        {
            String SP = "modificar_datos_factura";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();

            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@pestado", Drecepcion["estado"]);
            commandDatabase.Parameters.AddWithValue("@pclave", Drecepcion["clave"]);
            commandDatabase.Parameters.AddWithValue("@ptipoidentificacion", Drecepcion["tipoidentificacion"]);
            commandDatabase.Parameters.AddWithValue("@pnumerocedulaemisor", Drecepcion["numerocedulaemisor"]);
            commandDatabase.Parameters.AddWithValue("@pfechaemisiondoc", Drecepcion["fechaemisiondoc"]);
            commandDatabase.Parameters.AddWithValue("@pmensaje", Drecepcion["mensaje"]);
            commandDatabase.Parameters.AddWithValue("@pdetallemensaje", Drecepcion["detallemensaje"]);
            commandDatabase.Parameters.AddWithValue("@pmontototalimpuesto", Drecepcion["montototalimpuesto"]);
            commandDatabase.Parameters.AddWithValue("@ptotalfactura", Drecepcion["totalfactura"]);
            commandDatabase.Parameters.AddWithValue("@pnumerocedulareceptor", Drecepcion["numerocedulareceptor"]);
            commandDatabase.Parameters.AddWithValue("@pnumeroconsecutivoreceptor", Drecepcion["numeroconsecutivoreceptor"]);
            commandDatabase.Parameters.AddWithValue("@pnombrecliente", Drecepcion["nombrecliente"]);
            commandDatabase.Parameters.AddWithValue("@pcorerocliente", Drecepcion["corerocliente"]);

            commandDatabase.CommandTimeout = 60;

            try
            {
                conector.Open();
                int v = commandDatabase.ExecuteNonQuery();

                if (v == 1)
                {
                    MessageBox.Show("Datos de Factura Agregados");
                }
                conector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public List<Dictionary<String,String>> optenerDatosFactura()
        {
            List<Dictionary<String, String>> LdatosFactura = new List<Dictionary<String, String>>();

            String SP = "optener_datos_factura";
            AccesoDB.conector objC = new AccesoDB.conector();
            MySqlConnection conector = objC.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
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
                        Dictionary<String, String> DdatosFactura = new Dictionary<string, string>();

                        DdatosFactura.Add("estado", reader.GetString(1));
                        DdatosFactura.Add("clave", reader.GetString(2));
                        DdatosFactura.Add("tipoidentificacion", reader.GetString(3));
                        DdatosFactura.Add("numerocedulaemisor", reader.GetString(4));
                        DdatosFactura.Add("fechaemisiondoc", reader.GetString(5));
                        DdatosFactura.Add("mensaje", reader.GetString(6));
                        DdatosFactura.Add("detallemensaje", reader.GetString(7));
                        DdatosFactura.Add("montototalimpuesto", reader.GetString(8));
                        DdatosFactura.Add("totalfactura", reader.GetString(9));
                        DdatosFactura.Add("numerocedulareceptor", reader.GetString(10));
                        DdatosFactura.Add("numeroconsecutivoreceptor", reader.GetString(11));
                        DdatosFactura.Add("nombrecliente", reader.GetString(12));
                        DdatosFactura.Add("correocliente", reader.GetString(13));

                        LdatosFactura.Add(DdatosFactura);

                    }

                }
                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return LdatosFactura;

        }
    }
}
