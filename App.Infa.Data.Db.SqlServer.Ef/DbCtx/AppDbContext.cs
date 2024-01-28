
using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Units.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infa.Data.Db.SqlServer.Ef.DbCtx
{
    public class AppDbContext : IdentityDbContext<User,Role,int>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitPart> Parts { get; set; }
        public DbSet<Messege> Messeges { get; set; }
    }
}

public class User :IdentityUser<int>
{
    public string FristName { get; set; }
    public string LastName { get; set; }
}
public class Role : IdentityRole<int>
{
    public string RoleFa { get; set; }
}
