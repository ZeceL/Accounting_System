using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Accounting_System
{
    public class OracleDB
    {
        private OracleConnection _connection;
        private string _connectionString = "User Id=test;Password=1111;Data Source=mybase;";

        public OracleDB()
        {
            _connection = new OracleConnection(_connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                _connection.Open();
                Console.WriteLine("Connection successful!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            _connection.Close();
            Console.WriteLine("Connection closed.");
        }

        public DataTable GetUserData()
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Создаем команду для выполнения SQL-запроса
                string sql = "SELECT * \r\nFROM STRUCTURE";
                OracleCommand cmd = new OracleCommand(sql, _connection);

                // Выполняем запрос и получаем результат
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dataTable;
        }
    }
}
