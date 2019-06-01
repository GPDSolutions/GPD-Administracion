using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ace_Super_Market.AccesoDB
{
    class conector
    {
        public MySqlConnection Getconector()
        {
            string connectionString = "host=" + Environment.MachineName + ";port=3306;username=ace;password=toor;database=acedb;SslMode=none";

            MySqlConnection databaseConnection = null;

            try
            {
                databaseConnection = new MySqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return databaseConnection;
        }
    }
}
 