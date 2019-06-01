using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaDatos
{
    class multiMovimiento
    {

        public void crearMovimiento(String ptipoMovimiento, String pfinanzaAfectada, Double pmontoMovimento, String prazonMovimiento, String pusuarioMovimiento, String pfechaMovimiento)
        {
            String SP = "crear_movimiento";
            AccesoDB.conector obj = new AccesoDB.conector();

            MySqlConnection conector = obj.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@ptipoMovimiento", ptipoMovimiento);
            commandDatabase.Parameters.AddWithValue("@pfinanzaAfectada", pfinanzaAfectada);
            commandDatabase.Parameters.AddWithValue("@pmontoMovimiento", pmontoMovimento);
            commandDatabase.Parameters.AddWithValue("@prazonMovimiento", prazonMovimiento);
            commandDatabase.Parameters.AddWithValue("@pusuarioMovimiento", pusuarioMovimiento);
            commandDatabase.Parameters.AddWithValue("@pfechaMovimiento", pfechaMovimiento);
            commandDatabase.CommandTimeout = 60;

            try
            {
                conector.Open();
               int v =  commandDatabase.ExecuteNonQuery();

                if (v ==1)
                {
                    MessageBox.Show("Movimiento Agregado");
                }
                conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public List<CapaLogica.movimiento> cargarMovimientos(String pmovimientoFinanza)
        {
            List<CapaLogica.movimiento> Lmovimiento = new List<CapaLogica.movimiento>();
            String SP = "cargar_movimiento_tipo_finanza";
            AccesoDB.conector objC = new AccesoDB.conector();

            MySqlConnection conector = objC.Getconector();
            MySqlCommand commandDatabase = new MySqlCommand(SP, conector);
            commandDatabase.CommandType = System.Data.CommandType.StoredProcedure;
            commandDatabase.Parameters.AddWithValue("@pmovimientofinanza", pmovimientoFinanza);
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
                        Lmovimiento.Add(new CapaLogica.movimiento(reader.GetString(1),reader.GetString(2),reader.GetDouble(3),
                                                               reader.GetString(4), reader.GetString(5), reader.GetString(6)));
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Lmovimiento;

        } 
    }
}
