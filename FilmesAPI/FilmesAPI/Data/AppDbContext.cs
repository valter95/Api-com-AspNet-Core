using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(Cinema => Cinema.Endereco)
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId);

            //Realiza o relacionamento entre gerente e cinema pois 1 gerente pode ser gerente de muitos cinemas
            builder.Entity<Cinema>()
                .HasOne(cinema => cinema.Gerente)
                .WithMany(Gerente => Gerente.Cinemas)
                .HasForeignKey(cinema => cinema.GerenteId);
            //.OnDelete(DeleteBehavior.Restrict) Para Evitar Cascade deve se utilizar o OnDelete restrict 

            builder.Entity<Sessao>()
                .HasOne(sessao => sessao.Filme)
                .WithMany(Filme => Filme.Sessoes)
                .HasForeignKey(Sessao => Sessao.FilmeId);

            builder.Entity<Sessao>()
                .HasOne(sessao => sessao.Cinema)
                .WithMany(cinema => cinema.Sessoes)
                .HasForeignKey(sessao => sessao.CinemaId);

        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }


    }
}
