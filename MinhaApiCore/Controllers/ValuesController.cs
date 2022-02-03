using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet] //verbo
        public ActionResult<IEnumerable<string>> ObterTodos()
        {
           var valores =  new string[] { "value1", "value2", "value3" };
            if (valores.Length < 3)
            {
                return BadRequest(); //erro 400
            } else
            {
                return Ok(valores); //success 200
            }
        }

        // GET api/values/5
        [HttpGet("obter-id/{id:int}")] //verbo
        public ActionResult<string> ObterId(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost] //verbo
        public void Post(Produtos value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")] //verbo com rota
        public void Put(int id, [FromForm] Produtos value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")] //verbo
        public void Delete(int id)
        {
        }
    }

    public class Produtos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public double valor { get; set; }
    }
}
