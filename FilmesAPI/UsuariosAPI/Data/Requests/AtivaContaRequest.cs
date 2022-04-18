using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosAPI.Data.Requests
{
    public class AtivaContaRequest
    {
        [Required]
        public string codigoDeAtivacao { get; set; }
        [Required]
        public int usuarioId { get; set; }
    }
}
