using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route ("[controller]")] // Chama a classe FilmeController 
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;


        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme) 
        {
            filme.Id = id++;
            filmes.Add(filme);
            
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes() 
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme RecuperaFilmesPorId(int id) 
        {
           return filmes.FirstOrDefault(filme => filme.Id == id);
        }
    }
}
