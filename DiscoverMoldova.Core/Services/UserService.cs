using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Interfaces;
using DiscoverMoldova.Domain;
using DiscoverMoldova.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DiscoverMoldova.Core.Exceptions;
using DiscoverMoldova.Core.Dtos.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace DiscoverMoldova.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;
        public UserService(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task RegisterUserAsync(CreateUserDto userDto)
        {
            if (CheckIfEmailExists(userDto.Email))
            {
                throw new EntryAlreadyExistsException("Another user with such Email already exists in the system!");
            }

            if (CheckIfUsernameExists(userDto.UserName))
            {
                throw new EntryAlreadyExistsException("Another user with such Username already exists in the system!");
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);

            var user = _mapper.Map<User>(userDto);
            user.Password = passwordHash;

            await _userRepository.AddAsync(user);
        }

        public async Task<UserDto> GetUserByIdAsync(long id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                throw new NotFoundException("User with such id does not exist");
            }

            return _mapper.Map<UserDto>(user);
        }

        public List<UserDto> GetAll()
        {
            IQueryable<User> users = _userRepository.GetAll();

            var usersDto = _mapper.Map<List<UserDto>>(users);
            return usersDto;
        }

        public async Task UpdateUserDetailsAsync(UpdateUserDto updateUserDto, long id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                throw new NotFoundException("User with such id does not exist");
            }

            if (!string.IsNullOrWhiteSpace(updateUserDto.FirstName))
                user.FirstName = updateUserDto.FirstName;

            if (!string.IsNullOrWhiteSpace(updateUserDto.LastName))
                user.LastName = updateUserDto.LastName;

            if (!string.IsNullOrWhiteSpace(updateUserDto.Email) && user.Email != updateUserDto.Email)
            {
                if (CheckIfEmailExists(updateUserDto.Email))
                {
                    throw new EntryAlreadyExistsException("Another user with such Email already exists in the system!");
                }
                user.Email = updateUserDto.Email;
            }

            if (!string.IsNullOrWhiteSpace(updateUserDto.UserName) && user.UserName != updateUserDto.UserName)
            {
                if (CheckIfUsernameExists(updateUserDto.UserName))
                {
                    throw new EntryAlreadyExistsException("Another user with such Username already exists in the system!");
                }
                user.UserName = updateUserDto.UserName;
            }

            if (!string.IsNullOrWhiteSpace(updateUserDto.Password))
                user.Password = updateUserDto.Password;

            await _userRepository.SaveAsync();
        }

        public async Task DeleteUserByIdAsync(long id)
        {
            await _userRepository.DeleteAsync(id);
        }

        private bool CheckIfEmailExists(string email)
        {
            return _userRepository.GetAll().FirstOrDefault(x => x.Email == email) != null;
        }

        private bool CheckIfUsernameExists(string username)
        {
            return _userRepository.GetAll().FirstOrDefault(x => x.UserName == username) != null;
        }

        public async Task<LoginUserResponseDto> Login(LoginUserDto loginUserDto)
        {
            var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.UserName == loginUserDto.Username);
            bool rightPassword;
            try
            {
                rightPassword = BCrypt.Net.BCrypt.Verify(loginUserDto.Password, user?.Password);
            }
            catch (Exception)
            {
                throw new NotFoundException("Incorrect username or password!");
            }

            if (user == null || !rightPassword)
            {
                throw new NotFoundException("Incorrect username or password!");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("secretKeasdas234234asaday"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                    issuer: "https://localhost:44376/",
                    audience: "http://localhost:4200/",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(2),
                    signingCredentials: credentials
                );

            var tokenHandler = new JwtSecurityTokenHandler();
            var encodedToken = tokenHandler.WriteToken(token);

            var userDto = _mapper.Map<UserDto>(user);
            var response = new LoginUserResponseDto()
            {
                Token = encodedToken,
                UserDto = userDto
            };

            return response;
        }
    }
}
