using Cassandra.Mapping;
using Logger.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Data.Repository.Mapping
{
    internal class Mapping : Mappings
    {
        public Mapping()
        {
            this.MapLogs();
        }

        private void MapLogs()
        {
            For<Log>()
                .TableName("logs")
                .PartitionKey(c => c.Id)
                .Column(c => c.Id, cm => cm.WithName("id"))
                .Column(c => c.Action, cm => cm.WithName("action"))
                .Column(c => c.CreatedDateTime, cm => cm.WithName("created_datetime"))
                .Column(c => c.Ip, cm => cm.WithName("ip"))
                .Column(c => c.LogText, cm => cm.WithName("log_text"))
                .Column(c => c.UserId, cm => cm.WithName("user_id"));
        }
    }
}
