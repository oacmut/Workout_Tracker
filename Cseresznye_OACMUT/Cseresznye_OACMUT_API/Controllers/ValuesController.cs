using Cseresznye_OACMUT_API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cseresznye_OACMUT_API.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            FitnessDBContext context = new FitnessDBContext();
            var lista = (from x in context.Nutritions select x).ToList();
            return Ok(lista);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FitnessDBContext context = new FitnessDBContext();
            var keresett = (from x in context.Nutritions where id==x.NutritionId select x).FirstOrDefault();
            return Ok(keresett);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Nutrition value)
        {
            FitnessDBContext context = new FitnessDBContext();
            context.Nutritions.Add(value);
            context.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FitnessDBContext context = new FitnessDBContext();
            var torlendo = (from x in context.Nutritions where id==x.NutritionId select x).FirstOrDefault();
            context.Remove(torlendo);
            context.SaveChanges();
        }
    }
}
