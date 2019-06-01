using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaDatos
{
    class multiFinanza
    {

        public List<CapaLogica.finanza> optenerFinanzas()
        {
            List<CapaLogica.finanza> Lfinanza = new List<CapaLogica.finanza>();

            String SP = "cargar_finanza";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
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
                        Lfinanza.Add(new CapaLogica.finanza(reader.GetString(1),reader.GetDouble(2),reader.GetString(3)));
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return Lfinanza;
        }

        public void crearRetiro(String pnombre, Double psaldo, String pfechaUltMovimiento)
        {

            String SP = "modificar_finanza_retiro";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@ptipoFinanza", pnombre);
            commandDatabase.Parameters.AddWithValue("@psaldo", psaldo);
            commandDatabase.Parameters.AddWithValue("@pfechaUltMovimiento", pfechaUltMovimiento);
            commandDatabase.CommandTimeout = 60;

            try
            {
                conector.Open();
                int v = commandDatabase.ExecuteNonQuery();

                if (v == 1)
                {
                    MessageBox.Show("Finanza Modificada");
                }
                conector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void crearDeposito(String pnombre, Double psaldo, String pfechaUltMovimiento)
        {

            String SP = "modificar_finanza_deposito";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@ptipoFinanza", pnombre);
            commandDatabase.Parameters.AddWithValue("@psaldo",psaldo);
            commandDatabase.Parameters.AddWithValue("@pfechaUltMovimiento",pfechaUltMovimiento);
            commandDatabase.CommandTimeout = 60;

            try
            {
                conector.Open();
                int v = commandDatabase.ExecuteNonQuery();

                if (v == 1)
                {
                    MessageBox.Show("Finanza Modificada");
                }
                conector.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
