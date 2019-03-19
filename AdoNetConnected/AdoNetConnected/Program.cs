using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetConnected
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.Net
            //originally Active Data Objects, ADO. later ADO.NET
            // ADO.NET is the 'brand name"/"namespace" for all .NET data access stuff
            // but in practice, when we say "ADO.NET", we mean the old fashioned way
            // we're about to see

            //ADO.NET has things in System.Data namespace
            //we need a data provider - use nuget package syste.data.sqlclient
            // for sql server connections

            //the connection string has all we need to connect to the database
            var connString = SecretConfiguration.connString;

            Console.WriteLine("Enter condition: ");
            var condition = Console.ReadLine();
            var commString = $"select * from Movie.Movie where {condition}";

            //SQL injection:
            //user could enter "1 =1; Drop table Movie.Movie;" and i drop table.
            // solution: sanitize and validate all user input
            
            // for connected architecture

            //(we should also be catching exceptions)
            using (var connection = new SqlConnection(connString))
            {
                //1 open the connection
                connection.Open();

                //2 execute  query
                //var commString = "select * from Movie.Movie";
                using (var command = new SqlCommand(commString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //we have command.ExecuteReader which returns a DataReader
                        //      for select queries..
                        // we have command.ExecuteNonQuery which just returns number
                        //      of rows affected, for Delete, insert, etc.

                        //3 process the results
                        if(reader.HasRows)
                        {
                            //"reader.Read" advances the "cursor" through the results
                            // one row at a time
                            // the results are coming in to the computer's network buffer
                            // and datareader is reading them eac as soon as they come in
                            // (networks are slow compared to code)
                            while(reader.Read())
                            {
                                object id = reader["MovieId"];
                                object title = reader["Title"];
                                object fullTitle = reader[5]; //fifth column

                                //i could do downcasting and instantiate some
                                // movie class. or just print results

                                Console.WriteLine($"Movie #{id}: {fullTitle}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Table has no rows");
                        }
                    }
                }
            }
        }
    }
}
