using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Chi.Exhibition.Service.Common.User
{
    public class UserService : IUserService
    {
        public UserService() 
        {
        }

        public UserEntity GetUserByAccount(string account)
        {
            // return _userRepository.Find(x => x.UserId == account);

            //假資料
            var TestUserData = new UserEntity() 
            {
                UserId = "807418",
                UserName = "IanFeng",
                Password = "123456",
                CreateDate = DateTime.Now,
                RefreshToken = "",
                Role = "Admin"
            };

            return TestUserData;
        }
    }

    #region UserEntity暫時性MODEL
    /// <summary>
    /// 暫時性MODEL
    /// </summary>
    public class UserEntity
    {
        /// <summary>
        /// 使用者帳號
        /// </summary>
        [Key]
        [StringLength(50)]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// 使用者名稱
        /// </summary>
        [StringLength(88)]
        public string? UserName { get; set; }

        /// <summary>
        /// 使用者密碼
        /// </summary>
        [StringLength(48)]
        public string? Password { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 刷新Token
        /// </summary>
        public string? RefreshToken { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [StringLength(20)]
        public string? Role { get; set; }
    }
    #endregion
}


