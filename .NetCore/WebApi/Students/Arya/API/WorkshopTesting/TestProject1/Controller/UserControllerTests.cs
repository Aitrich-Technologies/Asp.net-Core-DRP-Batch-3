using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Workshop.API.User.RequestObjects;
using TestProject1.Fixtures;


namespace TestProject1.Controller
{
    public class UserControllerTests: IClassFixture<ApiWebApplicationFactory>
    {
        private readonly HttpClient _httpClient;

        public UserControllerTests(ApiWebApplicationFactory factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task Post_Login_ReturnsOkResult()
        {
            //Arrange
            LoginRequest data = new LoginRequest
            {
                UserName = "aparna",
                Password = "123456",
            };
            //HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8);
            //var httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var httpContent = new StringContent(
            JsonConvert.SerializeObject(data),
            Encoding.UTF8,
            "application/json"
       );
            //Act
            var response = await _httpClient.PostAsync(
                    "/api/v1/User/Login",
                    httpContent
                );
            //Assert
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);


        }


    }
}
