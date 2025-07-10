using gestor_cdch.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace gestor_cdch.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }

}
