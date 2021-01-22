using API_DESAFIO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DESAFIO.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public AppDbContext()
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Cobranca> Cobrancas { get; set; }
    }
}
 