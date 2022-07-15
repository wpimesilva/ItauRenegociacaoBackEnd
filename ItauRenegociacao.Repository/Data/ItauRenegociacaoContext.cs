using Microsoft.EntityFrameworkCore;
using ItauRenegociacao.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Repository.Data
{
    public class ItauRenegociacaoContext : DbContext
    {
        public ItauRenegociacaoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ClientesContatos> clientesContatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientesContatos>()
                .HasKey(i => i.idContato);
        }
    }
}
