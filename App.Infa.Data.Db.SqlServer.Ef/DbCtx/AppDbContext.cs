
using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Units.Entities;
using App.Domain.Core.Users.Entitis;
using Microsoft.EntityFrameworkCore;

namespace App.Infa.Data.Db.SqlServer.Ef.DbCtx
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Messege> Messeges { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitPart> Parts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

