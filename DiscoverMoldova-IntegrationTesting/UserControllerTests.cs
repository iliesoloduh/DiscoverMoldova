using DiscoverMoldova;
using DiscoverMoldova.Domain;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscoverMoldova_IntegrationTesting
{
    public class UserControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public UserControllerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_UserById_Returns_OkStatusCode()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = "/api/users/1";

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Fact]
        public async Task Get_UserById_Returns_User()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = "/api/users/1";

            // Act
            var user = await client.GetFromJsonAsync<User>(url);

            // Assert
            Assert.NotNull(user);
            Assert.Equal(1, user.Id);
        }

        [Fact]
        public async Task Get_UserWithIdZero_Returns_Notfound()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = "/api/users/2";

            // Act
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
            Assert.Equal("User with such id does not exist", content);
        }
    }
}
