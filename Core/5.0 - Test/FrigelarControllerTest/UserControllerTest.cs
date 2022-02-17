using System;
using Xunit;
using FrigelarAPI.Controllers;
using Application.DTO.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FrigelarControllerTest
{
    public class UserControllerTest
    {
        UserController _controller;
        IApplicationServiceUser _applicationServiceUser;

        public UserControllerTest()
        {
            _controller = new UserController(_applicationServiceUser);
        }

        [Fact]
        public void Get_All()
        {
            //Arrange  
            var controller = new UserController(_applicationServiceUser);

            //Act  
            var data = controller.Get();

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void Get()
        {
            //Arrange  
            var controller = new UserController(_applicationServiceUser);
            var id = 2;

            //Act  
            var data = controller.Get(id);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void Add()
        {
            //Arrange  
            var controller = new UserController(_applicationServiceUser);
            var u = new UserDTO() { 
                Name = "fulano", 
                Email = "fulano@blablabla.com", 
                Gender = "Admin"
            };

            //Act  
            var data = controller.Post(u);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void Update()
        {
            //Arrange  
            var controller = new UserController(_applicationServiceUser);
            var u = new UserDTO()
            {
                Id = 2,
                Name = "fulano",
                Email = "fulano@blablabla.com",
                Gender = "Admin"
            };

            //Act  
            var data = controller.Put(u);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void Delete()
        {
            //Arrange  
            var controller = new UserController(_applicationServiceUser);
            var u = new UserDTO()
            {
                Id = 2
            };

            //Act  
            var data = controller.Delete(u);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }
    }
}
