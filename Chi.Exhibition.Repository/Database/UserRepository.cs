using Chi.Exhibition.Repository.Attributes.Autofac;
using Chi.Exhibition.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chi.Exhibition.Repository.Database
{
    //public class UserRepository : DbBase<UserEntity, _ChiExhDbContext>, IUserRepository
    //{
    //    public UserRepository(IServiceProvider serviceProvider) : base(serviceProvider)
    //    {
    //    }

    //    public int UpdateRefreshToken(UserEntity user)
    //    {
    //        const string sql = @" UPDATE dbo.Users
    //                                 SET RefreshToken = @refreshToken
    //                               WHERE UserId = @userId ";
    //        return ExecuteSqlCommand(sql, new { userId = user.UserId, refreshToken = user.RefreshToken });
    //    }
    //}
}
