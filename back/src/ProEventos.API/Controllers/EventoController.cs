using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProEventos.API.Controllers.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase // herda de ControllerBase
    {


        

        public readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context; // injeção de dependencia
        }

        [HttpGet]
        public IEnumerable<Evento> Get() // metodo get que retorna uma lista de eventos
        {
            return _context.Eventos; // retorna a lista de eventos do banco de dados
        }

        [HttpGet("{id}")]
        public Evento GetById(int id) // metodo get que recebe um id
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id); // retorna o evento que tem o id igual ao id passado

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