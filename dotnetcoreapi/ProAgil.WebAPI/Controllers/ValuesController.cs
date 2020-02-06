using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebAPI.Data;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext Context { get; }
        public ValuesController(DataContext context)
        {
            Context = context;
        }
               

        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[]{
                new Evento(){
                    EventoId = 1,
                    DataEvento = "28/01/2020",
                    Local = "São Paulo",
                    Lote = "1º Lote",
                    QtdPessoas = 500,
                    Tema = "Curso Asp.Net Core 1"
                },

                new Evento(){
                    EventoId = 2,
                    DataEvento = "29/01/2020",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 300,
                    Tema = "Curso Asp.Net WEBApi Core 1"
                }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[]{
                new Evento(){
                    EventoId = 1,
                    DataEvento = "28/01/2020",
                    Local = "São Paulo",
                    Lote = "1º Lote",
                    QtdPessoas = 500,
                    Tema = "Curso Asp.Net Core 1"
                },

                new Evento(){
                    EventoId = 2,
                    DataEvento = "29/01/2020",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 300,
                    Tema = "Curso Asp.Net WEBApi Core 1"
                }
            }.FirstOrDefault(x => x.EventoId == id);
        }
    }
}