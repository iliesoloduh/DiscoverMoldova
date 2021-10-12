using DiscoverMoldova.API.Controllers;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscoverMoldova_UnitTests
{
    public class UserControllerTests
    {
        private readonly UserController _userController;

        public UserControllerTests()
        {
            var mockUserService = new Mock<IUserService>();

            mockUserService.Setup(x => x.GetUserByIdAsync(It.Is<int>(x => x == 1)))
                .ReturnsAsync(new UserDto()
                {
                    Id = 1,
                    FirstName = "Soloduh",
                    LastName = "Ilie",
                    Email = "soloduh@gmail.com",
                    UserName = "ilie1234",
                    Password = "12345678"
                });

            _userController = new UserController(mockUserService.Object);
        }

        [Fact]
        public async Task Get_UserById_Returns_User()
        {
            //Arange
            var id = 1;
            //Act
            var result = await _userController.GetUserById(id) as ObjectResult;
            var user = result.Value as UserDto;
            //Assert
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
            Assert.Equal(user.Id, id);
        }

        [Fact]
        public async Task Get_UserWithIdZero_Returns_NotFound()
        {
            //Arange
            var id = 0;
            //Act
            var result = await _userController.GetUserById(id) as ObjectResult;
            var user = result.Value as UserDto;
            //Assert
            Assert.Equal((int)HttpStatusCode.NotFound, result.StatusCode);
            Assert.Equal("User with such id does not exist", result.Value);
        }

        [Fact]
        public async Task DeleteUser_Returns_NoContent()
        {
            //Arange
            var id = 1;
            //Act
            var result = await _userController.DeleteUser(id) as StatusCodeResult;
            //Assert
            Assert.Equal((int)HttpStatusCode.NoContent, result.StatusCode);
        }

        [Fact]
        public async Task AddUser_Returns_OkResult()
        {
            //Arange
            var user = new CreateUserDto() { FirstName = "Soloduh", LastName = "Ilie", Email = "soloduh@gmail.com", UserName = "ilie1234", Password = "password112233" };
            //Act
            var result = await _userController.RegisterUser(user) as StatusCodeResult;
            //Assert
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        public async Task UpdateUserDetails_Returns_OkResult()
        {
            //Arange
            var id = 1;
            var updateUserDto = new UpdateUserDto() { Email = "soloduh.ilie@gmail.com" };

            //Act
            var result = await _userController.UpdateUserDetails(updateUserDto, id) as StatusCodeResult;

            //Assert
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

    }
}
