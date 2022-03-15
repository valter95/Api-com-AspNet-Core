using AutoMapper;
using FilmesAPI.Data.Dtos.Gerente;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles
{
    public class GerenteProfile : Profile
    {
        //Construtor criando um map 
        public GerenteProfile()
        {
            //faz a conversão(Mapeamento) do gerente para o respectivo dto
            CreateMap<CreateGerenteDto, Gerente>();
            //faz a conversão(Mapeamento) de gerente para um readGerenteDto
            CreateMap<Gerente, ReadGerenteDto>()
                .ForMember(gerente => gerente.Cinema, opts => opts
                .MapFrom(gerente => gerente.Cinemas.Select
                (c => new { c.Id, c.Nome, c.Endereco, c.EnderecoId })));
        }
    }
}
