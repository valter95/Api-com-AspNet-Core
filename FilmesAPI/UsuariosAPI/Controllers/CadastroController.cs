using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosAPI.Data.Dtos;

namespace UsuariosAPI.Controllers
{
    [Route ("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastaUsuario(CreateUsuarioDto usuarioDto) 
        {
            return Ok();
        }
    }
}
