using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase // herda de ControllerBase
    {


        public IEnumerable<Evento> _evento = new Evento[] // foi criado um evento erdado de evento
        {
            new Evento() {
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.png"
                },
            new Evento() { 
                    EventoId = 2,
                    Tema = "Angular e Suas novidades",
                    Local = "Curitiba",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
              },
        };

        public EventoController()
        {
        }



        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id) // metodo get que recebe um id
        {
            return _evento.Where(evento => evento.EventoId == id); // retorna o evento que tem o id igual ao id passado

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