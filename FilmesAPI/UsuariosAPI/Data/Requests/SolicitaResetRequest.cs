﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosAPI.Data.Requests
{
    public class SolicitaResetRequest
    {
        [Required]
        public string Email { get; set; }

    }
}
