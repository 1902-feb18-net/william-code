using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDisconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter condition: ");
            var condition = Console.ReadLine();

            // disconnected architecture
            // rather than maximizing the speed of getting the results
            // we want to minimize the time the connection spends open

            // still need nuget package system.data.sqlclient (for sql server)
            // and using directive "using system.data"

            // system.data.dataset can store data that datareader gets
            // with the help of dataadapter

            var dataSet = new DataSet();

            var connectionString = SecretConfiguration.connString;

            using (var connection = new SqlConnection(connectionString))
            {
                // disconnected architecture with ado.net

                // step 1: open the connection
                connection.Open();
                var commandString = $"select * from Movie.Movie where {condition}";
                using (var command = new SqlCommand(commandString, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    // step 2 execute the query, filling the dataset
                    adapter.Fill(dataSet);

                }
                // step 3 close the connection
                connection.Close();
            }

            // setp 4 process the results
            // (not while connection is open; to get it closed asap

            // inside dataset is some datatables
            // inside datatable is datacolumn, datarow
            // inside datarow is object{}
            // this is non-generic

            //old-fashioned non-generic foreach (based on nongeneric IEnumerable)
            // does implicit downcasting
            foreach(DataRow row in dataSet.Tables[0].Rows)
            {
                DataColumn idCol = dataSet.Tables[0].Columns["GenreId"];
                Console.WriteLine($"Genre #{row[idCol]}; {row[1]}");
            }
            Console.ReadLine();
        }
    }
}
