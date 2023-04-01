using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coffe2go.Datastore;
using coffe2go.Entities;
using coffe2go.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coffe2go.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly CoffeeRepository _repository;

        private readonly CoffeeDatastore _context;
        // GET: api/Coffee
        public CoffeeController(CoffeeRepository repository, CoffeeDatastore context)
        {
            _repository = repository;
        }

        public CoffeeController(CoffeeDatastore context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var res = _repository.GetCoffeeCatalog();
            return Ok(res);
        }

        // GET: api/Coffee/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var res = _repository.GetCoffee(id);
            return Ok(res);
        }

        // POST: api/Coffee
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Coffee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Coffee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
