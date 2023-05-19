using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControls
{
    class Datebase
    {
        MySqlConnection connection = new MySqlConnection("server=cfif31.ru;port=3306;username=ISPr23-36_SavelevVA;password=ISPr23-36_SavelevVA;database=ISPr23-36_SavelevVA_dgvr");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Clone();
        } 

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
