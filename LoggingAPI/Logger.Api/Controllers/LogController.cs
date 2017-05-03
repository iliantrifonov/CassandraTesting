using Logger.Data.Service.Log.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Logger.Api.Controllers
{
    public class LogController : BaseApiController
    {
        private ILogService logService;

        public LogController(ILogService logService)
        {
            this.logService = logService;
        }

        public IHttpActionResult GetLogById(int id)
        {
            var log = this.logService.GetLogById(id);
            return this.GetResult(log);
        }

        public IHttpActionResult GetLogsByDate(DateTime date)
        {
            var logs = this.logService.GetLogsByDate(date);
            return this.GetResult(logs);
        }

        public IHttpActionResult GetLogsByWeek(int week)
        {
            var logs = this.logService.GetLogsByWeek(week, DateTime.Now.Year);
            return this.GetResult(logs);
        }

        public IHttpActionResult GetLogsByMonth(int month)
        {
            var logs = this.logService.GetLogsByMonth(month, DateTime.Now.Year);
            return this.GetResult(logs);
        }

        public IHttpActionResult GetLogsByUserIdAndMonth(string id, int month)
        {
            var logs = this.logService.GetLogsByUserIdAndMonth(id, month, DateTime.Now.Year);
            return this.GetResult(logs);
        }

        public IHttpActionResult GetLogsByDateInterval(DateTime start, DateTime end)
        {
            var logs = this.logService.GetLogsByDateInterval(start, end);
            return this.GetResult(logs);
        }

        public IHttpActionResult GetLogsByUserIdAndDateInterval(int id, DateTime start, DateTime end)
        {
            var logs = this.logService.GetLogsByUserIdAndDateInterval(id, start, end);
            return this.GetResult(logs);
        }
    }
}