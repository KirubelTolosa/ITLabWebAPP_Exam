using Employee.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL
{
    public class DataRepository : IDataRepository
    {
        private string dbConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
     
        public List<DaDto> GetEmployees()
        {
            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;
            
            sqlite_conn = new SQLiteConnection(dbConnectionString);                                   
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Records";            
            sqlite_cmd.ExecuteNonQuery();            
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<DaDto> employeesOnRecord = new List<DaDto>();
            while (sqlite_datareader.Read())
            {
                var employee = new DaDto();                
                employee.userName = (string)sqlite_datareader["user"];
                employee.password = (string)sqlite_datareader["password"];
                employeesOnRecord.Add(employee);
            }
            sqlite_conn.Close();
            return employeesOnRecord;
        }
    }
}
