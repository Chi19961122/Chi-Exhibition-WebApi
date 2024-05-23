using Chi.Exhibition.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chi.Exhibition.Service.Common.User
{
    public interface IUserService
    {
        UserEntity GetUserByAccount(string account);
    }
}
