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
    public class EventoController : ControllerBase
    {


        public IEnumerable<Evento> _evento = new Evento[]{
                
            new Evento(){
                EventoId = 1,
                DataEvento = new DateTime().ToString(),
                Local = "São Paulo",
                QtdPessoas = 30,
                Tema = "Halloween",
                Lote = "L12230" ,
                ImagemURL = "Luuioxjij"          
                
            },
             new Evento(){
                EventoId = 2,
                DataEvento = new DateTime().ToString(),
                Local = "São Paulo",
                QtdPessoas = 30,
                Tema = "Halloween",
                Lote = "L12230" ,
                ImagemURL = "Luuioxjij"          
                
            }
        };
       
        public EventoController(ILogger<EventoController> logger)
        {
          
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {

            return _evento;
            
        }

        [HttpGet("{id}")]
         public IEnumerable<Evento> GetById(int id)
        {

            return _evento.Where(evento=> evento.EventoId == id);
            
        }

        
        [HttpPost]
         public string test()
        {
            return "value";
        }

        [HttpPut("{name}")]

        public string put(string name){
            return $"Ola {name}";
        }




    }
}
