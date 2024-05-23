using Chi.Exhibition.Service.Models.Api;
using Chi.Exhibition.Service.Models.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chi.Exhibition.Service.Common.Jwt
{
    public interface IJwtAuthService
    {
        ApiResponseModel Login(JwtLoginDto jwtLoginViewModel);

        JwtTokenDto RefreashToken(JwtTokenDto tokenDto);
    }
}
