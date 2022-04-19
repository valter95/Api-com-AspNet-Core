using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")] // Chama a classe FilmeController 
    public class FilmeController : ControllerBase
    {
        private FilmeService _filmeService;

        //Criando o construr do Context
        public FilmeController(FilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            ReadFilmeDto readDto = _filmeService.AdicionaFilme(filmeDto);

            return CreatedAtAction(nameof(RecuperaFilmesPorId), new { id = readDto.Id }, readDto);

        }

        [HttpGet]
        public IActionResult RecuperarFilmes()
        {
            ReadFilmeDto readDto = _filmeService.RecuperarFilmes();
            if (readDto != null)
                return Ok(readDto);
            return NotFound();

        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorId(int id)
        {
            ReadFilmeDto readDto = _filmeService.RecuperaFilmesPorId(id);

            if (readDto != null)
                return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]  //Put serve para atualizar
        public IActionResult AtualizarFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        {
            Result resultado = _filmeService.AtualizarFilme(id, filmeDto);

            if (resultado.IsFailed)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Result resultado = _filmeService.DeletaFilme(id);

            if (resultado.IsFailed)
                return NotFound();
            return NoContent();
        }
    }
}
