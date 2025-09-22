using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Exemplo de Get com id = {id}";
        }

        [HttpPost("{id}")]

        public string Post(int id)
        {
            return $"Exemplo de Post com id = {id}";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }
        
        [HttpDelete("{id}")]
        public string HttpDelete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}