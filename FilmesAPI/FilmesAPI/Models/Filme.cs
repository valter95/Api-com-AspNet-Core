using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required (ErrorMessage = "O campo título é obrigatorio")] //Criando uma validação para não vir o titulo vazio 
        public string Titulo { get; set; }
        [Required (ErrorMessage = "O campo diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        public int Duracao { get; set; }
        public int Id { get; internal set; }
    }
}
