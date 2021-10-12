using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Exceptions;
using DiscoverMoldova.Core.Interfaces;
using DiscoverMoldova.Core.MappingProfiles;
using DiscoverMoldova.Core.Services;
using DiscoverMoldova.Domain;
using DiscoverMoldova.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscoverMoldova_UnitTests
{
    public class UserServiceTests
    {
        private readonly IUserService _userService;

        public UserServiceTests()
        {
            var mockUserRepository = new Mock<IRepository<User>>();
            

            mockUserRepository.Setup(x => x.GetByIdAsync(It.Is<int>(x => x ==1)))
            .ReturnsAsync(new User()
            {
                Id = 1,
                FirstName = "Soloduh",
                LastName = "Ilie",
                Email = "soloduh@gmail.com",
                UserName = "ilie1234",
                Password = "12345678"
            });

            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new UserProfile()); }); 
            IMapper mapper = mappingConfig.CreateMapper();

            _userService = new UserService(mockUserRepository.Object, mapper);
        }

        [Fact]
        public async Task Get_UserById_Returns_User()
        {
            //Arange
            var id = 1;
            //Act
            var result = await _userService.GetUserByIdAsync(id);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.Id, id);
        }

        [Fact]
        public async Task Get_UserWithIdZero_Returns_NotFound()
        {
            //Arange
            var id = 0;
            //Act

            //Assert
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _userService.GetUserByIdAsync(id));
            Assert.Contains("User with such id does not exist", exception.Message);
        }
    }
}
