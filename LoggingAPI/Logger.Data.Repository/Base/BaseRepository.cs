using Cassandra.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Data.Repository.Base
{
    public class BaseRepository
    {
        public static BaseRepository()
        {
            MappingConfiguration.Global.Define<Mapping.Mapping>();
        }
    }
}
