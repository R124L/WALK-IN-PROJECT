using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WALK_IN_PROJECT
{
    class QueryHandler
    {
        public string property { get; set; }
        public string[] GetReaderValue(string connectionString, string query, int indexField)
        {
            List<string> list = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(indexField));
                    }
                }
            }

            return list.ToArray();
        }
    }
}
