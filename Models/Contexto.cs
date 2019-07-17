using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace FaceAlbum.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
        }
        public DbSet<Album> Albuns { get; set; }

        public DbSet<Imagem> Imagens { get; set; }
    }
}
