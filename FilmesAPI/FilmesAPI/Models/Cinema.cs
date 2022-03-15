using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        
        public virtual Gerente Gerente { get; set; } // Mapeamento para gerar o relacionamento 
        
        public int GerenteId { get; set; } // Mapeamento para gerar o relacionamento 

        public virtual List<Sessao> Sessoes { get; set; }
    }
}
