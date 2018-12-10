using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInter
{
    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;

        public DbCommand(DbConnection newConnec, string instruction)
        {
            if(newConnec==null || String.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException();
            }
            _connection = newConnec;
            _instruction = instruction;
        }

        public void Execute()
        {
            if(_connection == null || String.IsNullOrWhiteSpace(_instruction))
            {
                throw new NullReferenceException();
            }

            _connection.openConnection();
            Console.WriteLine("Running " + _instruction + "...");
            _connection.closeConnection();
        }
    }
}
