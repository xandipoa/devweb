using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro.Models.Entidades;

namespace Cadastro.Models.Contexto
{
    public class Contexto : DbContext
    {
        public DbSet<Cidade> Cidade { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public Contexto()
        {
        }        
    }
}
