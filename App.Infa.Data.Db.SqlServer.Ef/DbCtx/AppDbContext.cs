
using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Units.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Infa.Data.Db.SqlServer.Ef.DbCtx
{
    public class AppDbContext : IdentityDbContext<User, Role, int>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitPart> Parts { get; set; }
        public DbSet<Messege> Messeges { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}



public class User : IdentityUser<int>
{
    public string FirstName { get; set; }

    public string LastName { get; set; }


}

public class Role : IdentityRole<int>
{
    public string NameFa { get; set; }
}