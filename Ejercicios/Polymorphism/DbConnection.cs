using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicios.Polymorphism
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; } = new TimeSpan(0,0,5);
        public DateTime Time;

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new NullReferenceException("The connection string can't be null.");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SqlConnection : DbConnection
    {
        //TODO: I could also throw exceptions if the connection is closed but hasn't been opened first and other exceptions but it's beyond the scope of this exercise
        public override void CloseConnection()
        {
            Console.WriteLine("Connection closed.");
        }

        public override void OpenConnection()
        {
            DateTime openedTime = DateTime.Now;
            Console.WriteLine("Opening connection...");
            if(Time - openedTime > TimeOut)
                throw new Exception("Connection failed.");
            Console.WriteLine("Connection opened.");
        }

        public SqlConnection(string connectionString) : base(connectionString)
        {

        }
    }

    public class OracleConnection : DbConnection
    {
        public override void CloseConnection()
        {
            Console.WriteLine("Connection closed.");
        }

        public override void OpenConnection()
        {
            DateTime openedTime = DateTime.Now;
            Console.WriteLine("Opening connection...");
            if (Time - openedTime> TimeOut)
                throw new Exception("Connection failed.");
            Console.WriteLine("Connection opened.");
        }

        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
    }
}
