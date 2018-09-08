using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Producer.Controllers
{
    [Route("api/[controller]")]
    public class FilaController : Controller
    {
        public Fila fila;
        public FilaController() => fila = new Fila();

        [HttpGet]
        public IActionResult Get() => Ok("OK");

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            return Ok(fila.Enviar(value));
        }
    }
}
