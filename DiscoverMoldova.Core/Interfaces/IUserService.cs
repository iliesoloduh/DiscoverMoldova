using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Dtos.User;
using DiscoverMoldova.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverMoldova.Core.Interfaces
{
    public interface IUserService
    {
        Task RegisterUserAsync(CreateUserDto user);
        Task<UserDto> GetUserByIdAsync(long id);
        List<UserDto> GetAll();
        Task UpdateUserDetailsAsync(UpdateUserDto user, long id);
        Task DeleteUserByIdAsync(long id);
        Task<LoginUserResponseDto> Login(LoginUserDto loginUserDto);
    }
}
