using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Cinema;
using FilmesAPI.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Services
{
    public class CinemaServices
    {
        private AppDbContext _context;
        private IMapper _mapper;
        public CinemaServices(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public  ReadCinemaDto AdicionaCinema(CreateCinemaDto cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return _mapper.Map<ReadCinemaDto>(cinema);
        }

        public ReadCinemaDto RecuperaCinemas(string nomeDoFilme)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault();
            ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
            return cinemaDto; 
        }

        public  ReadCinemaDto RecuperaCinemasPorId(int id)
        {
           Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema != null)
            {
                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return (cinemaDto);
            }
            return null;
        }

        public Result AtualizaCinema(int id, UpdateCinemaDto cinemaDto)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return Result.Fail("Não foi encontrado nenhuma cinema");
            }
            _mapper.Map(cinemaDto, cinema);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaCinema(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return Result.Fail("Não foi possível deletar o cinema");
            }
            _context.Remove(cinema);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
