using System;
using System.Data.SqlClient;

namespace IDisposableBestPractices
{
    public class UsingIDisposable1
    {
        //private static void Main(string[] args)
        //{
        //    using (var databaseState = new DatabaseState())
        //    {
        //        var result = databaseState.GetDate();
        //        Console.WriteLine(result);
        //    }
        //    Console.ReadKey();
        //}
    }

    public class DatabaseState : IDisposable
    {
        private SqlConnection _connection;

        public string GetDate()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection("Server=.;Database=master;Integrated Security=true;");
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