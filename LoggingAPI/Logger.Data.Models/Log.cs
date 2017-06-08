using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Data.Models
{
    public class Log
    {
        public int Id { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public string Action { get; set; }

        public string LogText { get; set; }

        public string Ip { get; set; }

        public string UserId { get; set; }
    }
}
