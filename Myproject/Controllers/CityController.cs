using Microsoft.AspNetCore.Mvc;
using Solid.Core;
using Solid.Core.Servise;
using Solid.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityServise _cityServise;
        private static int id = 0;
      
        public CityController(ICityServise cityServise)
        {
            _cityServise = cityServise;
        }
        
        // GET: api/<CityController>
        [HttpGet]
        public ActionResult<City> Get()
        {
            return Ok(_cityServise.GetCities());
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public ActionResult <City> Get(int id)
        {
            var city = _cityServise.GetId(id);
            if (city == null)
                return NotFound();
            else
                return city;
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] City city1)
        {
             //id++;
            //_cityServise.GetCities().Add(new City { Name = city1.Name,Count=city1.Count,Id=id });
            _cityServise.AddCity(city1);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int id, [FromBody] City city1)
        {

            var city = _cityServise.GetId(id);
            if (city == null)
                return NotFound();
            else
            {

                return Ok(_cityServise.Update(id, city1));
            }
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var course = _cityServise.GetId(id);
            if (course == null)
                return NotFound();
            else
            {
                _cityServise.DeleteCity(id);
                return Ok();
            }
        }
    }
}
