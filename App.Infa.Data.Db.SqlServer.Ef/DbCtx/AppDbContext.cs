
using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Units.Entities;
using App.Domain.Core.Users.Entitis;
using Microsoft.EntityFrameworkCore;

namespace App.Infa.Data.Db.SqlServer.Ef.DbCtx
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitPart> Parts { get; set; }
        public DbSet<Messege> Messeges { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}

