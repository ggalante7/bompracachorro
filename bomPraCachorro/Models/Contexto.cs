using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bomPraCachorro.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Animais> Animais { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Pontos> Pontos { get; set; }
    }
}
