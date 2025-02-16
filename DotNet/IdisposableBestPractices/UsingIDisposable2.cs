using System;
using System.Data.SqlClient;

namespace IDisposableBestPractices
{
    public class UsingIDisposable2
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                var databaseState = new DatabaseState2();
                //using (var databaseState = new DatabaseState2())
                {
                    var result = databaseState.GetDate();
                    Console.WriteLine(i + " : " + result);
                }
            }
            Console.ReadKey();
        }
    }

    public class DatabaseState2 : IDisposable
    {
        private SqlConnection _connection;

        public string GetDate()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection("Server=.;Database=master;Integrated Security=true;max pool size = 10");
                _connection.Open();
            }

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT getdate()";
                return command.ExecuteScalar().ToString();
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Disposing SqlConnection " + _connection.GetHashCode());
            _connection.Close();
            _connection.Dispose();

        }
    }
}