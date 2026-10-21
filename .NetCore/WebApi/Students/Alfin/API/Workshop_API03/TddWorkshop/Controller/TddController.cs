//using Microsoft.AspNetCore.Identity.Data;
//using Microsoft.AspNetCore.Identity.Data;
using Workshop_API03.API.User.RequestObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using TddWorkshop.Fixtures;
using Xunit;

namespace TddWorkshop.Controller
{
    public class TddController : IClassFixture<ApiWebApplicationFactory>
    {
        private readonly HttpClient _httpClient;

        public TddController(ApiWebApplicationFactory factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task Post_Login_ReturnsOkResult()
        {
            // Arrange
            var data = new LoginRequest
            {
                UserName = "sanjay1",
                Password = "123"
            };

            //HttpContent httpContent = new StringContent(
            //    JsonConvert.SerializeObject(data),
            //    Encoding.UTF8);

            //httpContent.Headers.ContentType =
            //    new MediaTypeHeaderValue("application/json");
            var httpContent = new StringContent(
         JsonConvert.SerializeObject(data),
         Encoding.UTF8,
         "application/json"
    );

            // Act
            var response = await _httpClient.PostAsync("/api/User/login", httpContent);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public async Task Post_Register_ReturnsOkResult()
        {
            // Arrange
            var data = new AddUserRequest
            {
                FirstName = "Sanjay",
                LastName = "Kumar",
                Gender = "Male",
                DateOfBirth = new DateOnly(2000, 1, 1),
                UserName = "sanjay1",
                Email = "sanjay1@gmail.com",
                TelephoneNo = "9876543210",
                Password = "123"
            };

            var httpContent = new StringContent(
                JsonConvert.SerializeObject(data),
                Encoding.UTF8,
                "application/json");

            // Act
            var response = await _httpClient.PostAsync("/api/User/adduser", httpContent);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Post_Register_ReturnsBadRequest()
        {
            // Arrange
            var data = new AddUserRequest
            {
                FirstName = "Sanjay",
                LastName = "Kumar",
                Gender = "Male",
                DateOfBirth = new DateOnly(2000, 1, 1),
                UserName = "sanjay1",
                Email = "sanjay1@gmail.com",
                TelephoneNo = "9876543210",
                Password = "123"
            };

            var httpContent = new StringContent(
                JsonConvert.SerializeObject(data),
                Encoding.UTF8,
                "application/json");

            // Register once
            await _httpClient.PostAsync("/api/User/adduser", httpContent);

            // Register again
            var response = await _httpClient.PostAsync("/api/User/adduser", httpContent);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
    

