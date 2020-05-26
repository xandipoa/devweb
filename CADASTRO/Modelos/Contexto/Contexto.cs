using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CADASTRO.Modelos.Entidades;


namespace CADASTRO.Modelos.Contexto
{
    public class Contexto : DbContext        
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Cidade> Cidade { get; set; }
    }
    
}
