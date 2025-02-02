// Abstract Product
using System;

public interface IDatabaseConnection
{
    void Connect();
    void Disconnect();
}

public class SqlServerConnection : IDatabaseConnection
{
    public void Connect() { Console.WriteLine("Connecting to SQL Server..."); }
    public void Disconnect() { Console.WriteLine("Disconnecting from SQL Server..."); }
}

public class MySqlConnection : IDatabaseConnection
{
    public void Connect() { Console.WriteLine("Connecting to MySQL..."); }
    public void Disconnect() { Console.WriteLine("Disconnecting from MySQL..."); }
}

// Abstract Factory
public interface IDatabaseConnectionFactory
{
    IDatabaseConnection CreateConnection();
}

// Concrete Factories
public class SqlServerConnectionFactory : IDatabaseConnectionFactory
{
    public IDatabaseConnection CreateConnection() { return new SqlServerConnection(); }
}

public class MySqlConnectionFactory : IDatabaseConnectionFactory
{
    public IDatabaseConnection CreateConnection() { return new MySqlConnection(); }
}

// Client Code
public class DatabaseManager
{
    private readonly IDatabaseConnection _connection;

    public DatabaseManager(IDatabaseConnectionFactory factory)
    {
        _connection = factory.CreateConnection();
    }

    public DatabaseManager(IDatabaseConnection databaseConnection)
    {
        _connection = databaseConnection;
    }

    public void PerformDatabaseOperations()
    {
        _connection.Connect();
        // Perform database operations
        _connection.Disconnect();
    }
}

public class Application
{
    public static void Main1(string[] args)
    {
        string dbType = "SQLServer";

        IDatabaseConnection factory;

        if (dbType == "SQLServer")
            factory = new SqlServerConnection();
        else if (dbType == "MySQL")
            factory = new MySqlConnection();
        else
            throw new Exception("Unknown database type");

        var dbManager = new DatabaseManager(factory);
        dbManager.PerformDatabaseOperations();
    }

    public static void Main(string[] args)
    {
        string dbType = "SQLServer"; 

        IDatabaseConnectionFactory factory;

        if (dbType == "SQLServer")
            factory = new SqlServerConnectionFactory();
        else if (dbType == "MySQL")
            factory = new MySqlConnectionFactory();
        else
            throw new Exception("Unknown database type");

        var dbManager = new DatabaseManager(factory);
        dbManager.PerformDatabaseOperations();
    }
}
