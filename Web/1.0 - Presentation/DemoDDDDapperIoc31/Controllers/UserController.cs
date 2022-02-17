using Application.DTO.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DemoDDDDapperIoc31.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IApplicationServiceUser _applicationServiceUser;

        public UserController(IApplicationServiceUser ApplicationServiceUser)
        {
            _applicationServiceUser = ApplicationServiceUser;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                Response.StatusCode = 200;
                return Ok(_applicationServiceUser.GetAll());
            }
            catch (Exception ex)
            {
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                Response.StatusCode = 200;
                return Ok(_applicationServiceUser.GetById(id));
            }
            catch (Exception ex)
            {
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] UserDTO UserDTO)
        {
            try
            {
                if (UserDTO == null)
                    return NotFound();

                _applicationServiceUser.Add(UserDTO);
                Response.StatusCode = 200;
                return Ok("User Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] UserDTO UserDTO)
        {
            try
            {
                if (UserDTO == null)
                    return NotFound();

                _applicationServiceUser.Update(UserDTO);
                Response.StatusCode = 200;
                return Ok("User Atualizado com sucesso!");
            }
            catch (Exception)
            {
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] UserDTO UserDTO)
        {
            try
            {
                if (UserDTO == null)
                    return NotFound();

                _applicationServiceUser.Remove(UserDTO);
                Response.StatusCode = 200;
                return Ok("User Removido com sucesso!");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 404;
                return new ObjectResult("");
            }

        }
    }
}
