using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        List<Persona> personas;
        public PersonasController()
        {
            personas = new List<Persona>
            {
                new Persona { IdPersona = 1, Nombre = "Lucia", Edad = 17}
                , new Persona { IdPersona = 2, Nombre = "Adrian", Edad = 20}
                , new Persona { IdPersona = 3, Nombre = "Sara", Edad = 24}
                , new Persona {IdPersona = 4, Nombre = "Pedro", Edad = 40}
                , new Persona { IdPersona = 5, Nombre = "Carlos", Edad = 40 }
            };
        }

        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return this.personas;
        }

        [HttpGet("{id}")]
        public ActionResult<Persona> GetPersona(int id)
        {
            return this.personas.SingleOrDefault(x => x.IdPersona == id);
        }
    }
}

