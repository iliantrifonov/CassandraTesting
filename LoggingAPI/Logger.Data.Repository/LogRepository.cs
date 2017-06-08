using Cassandra;
using Logger.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Data.Repository
{
    public class LogRepository : BaseRepository
    {
        public LogRepository()
        {
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            ISession session = cluster.Connect(CassandraConstants.Keyspace);
        }
    }
}
