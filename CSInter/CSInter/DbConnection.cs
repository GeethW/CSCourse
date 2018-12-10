using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInter
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string newConnectionString)
        {
            ConnectionString = newConnectionString;
        }

        public abstract void openConnection();

        public abstract void closeConnection();
    }

    public class SQLConnection : DbConnection
    {
        public SQLConnection() : base("connecStrSQL")
        {
            //
        }
        public override void closeConnection()
        {
            Console.WriteLine("Closed SQL database connection.");
        }

        public override void openConnection()
        {
            Console.WriteLine("Opened SQL database connection.");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection() : base("ConnecStrOracle")
        {
            //
        }

        public override void openConnection()
        {
            Console.WriteLine("Opened Oracle connection.");
        }

        public override void closeConnection()
        {
            Console.WriteLine("Closed Oracle connection.");
        }
    }


}
