using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClienteAppMinimal.Domain.Entities;

namespace ClienteAppMinimal.Data.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("BDClientes");
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
