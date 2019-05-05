using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Polymorphism
{
    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;
        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new NullReferenceException("Connection can't be null;");
            if(string.IsNullOrEmpty(instruction))
                throw new NullReferenceException("Instruction can't be empty or null.");
            _connection = connection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine("Running instruction: '{0}'",_instruction);
            _connection.CloseConnection();
        }
    }
}
