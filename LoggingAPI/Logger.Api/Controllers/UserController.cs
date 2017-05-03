using Logger.Data.Service.User.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Logger.Api.Controllers
{
    public class UserController : BaseApiController
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public IHttpActionResult GetUserById(string id)
        {
            var user = this.userService.GetUserById(id);
            return this.GetResult(user);
        }

        public IHttpActionResult GetUserByUserName(string userName)
        {
            var user = this.userService.GetUserByUserName(userName);
            return this.GetResult(user);
        } 

        public IHttpActionResult GetUserByEmail(string email)
        {
            var users = this.userService.GetUserByEmail(email);
            return this.GetResult(users);
        }

        public IHttpActionResult GetUsersByCompany(string company)
        {
            var users = this.userService.GetUsersByCompany(company);
            return this.GetResult(users);
        }

        public IHttpActionResult GetUsersByCompanyAndDepartment(string company, string department)
        {
            var users = this.userService.GetUsersByCompanyAndDepartment(company, department);
            return this.GetResult(users);
        }

        public IHttpActionResult GetUsersByCreatedDate(DateTime date)
        {
            var users = this.userService.GetUsersByCreatedDate(date);
            return this.GetResult(users);
        }

    }
}