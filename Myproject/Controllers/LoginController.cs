using Microsoft.AspNetCore.Mvc;
using Solid.Core;
using Solid.Core.Servise;
using Solid.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServise _loginServise;
        private static int id = 0;
      
        public LoginController(ILoginServise loginServise)
        {
            _loginServise = loginServise;
        }
        
        // GET: api/<CityController>
        [HttpGet]
        public ActionResult<Login> Get()
        {
            return Ok(_loginServise.GetLogins());
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public ActionResult <Login> Get(int id)
        {
            var login = _loginServise.GetId(id);
            if (login == null)
                return NotFound();
            else
                return login;
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] Login login)
        {
            //id++;
            //_cityServise.GetCities().Add(new City { Name = city1.Name,Count=city1.Count,Id=id });
            _loginServise.AddLogins(login);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int id, [FromBody] Login login)
        {

            var login1 = _loginServise.GetId(id);
            if (login1 == null)
                return NotFound();
            else
            {

                return Ok(_loginServise.Update(id, login));
            }
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var course = _loginServise.GetId(id);
            if (course == null)
                return NotFound();
            else
            {
                _loginServise.DeleteLogins(id);
                return Ok();
            }
        }
    }
}
