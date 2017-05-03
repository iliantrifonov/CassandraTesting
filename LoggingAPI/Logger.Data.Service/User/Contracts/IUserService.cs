using Logger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Data.Service.User.Contracts
{
    public interface IUserService
    {
        UserModel GetUserById(string id);

        UserModel GetUserByUserName(string userName);

        ICollection<UserModel> GetUsersByCompany(string company);

        ICollection<UserModel> GetUsersByCompanyAndDepartment(string company, string department);

        ICollection<UserModel> GetUserByEmail(string email);

        ICollection<UserModel> GetUsersByCreatedDate(DateTime date);
    }
}
