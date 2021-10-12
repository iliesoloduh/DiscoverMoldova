using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.Dtos.User
{
    public class LoginUserResponseDto
    {
        public string Token { get; set; }
        public DateTime TokenExpireDate { get; set; }
        public UserDto UserDto { get; set; }
    }
}
