using Microsoft.EntityFrameworkCore;
using BACKTESTIMMO.Models;

namespace BACKTESTIMMO.Context
{
   public class UserContext : DbContext
   {

      public UserContext(DbContextOptions<UserContext> options) : base(options)
      {
      }

      public DbSet<User> users { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
      if (!optionsBuilder.IsConfigured)
      {
         optionsBuilder.UseSqlServer("Server=tcp:wiwiserver.database.windows.net,1433;Initial Catalog=Immo;Persist Security Info=False;User ID=Wiwi;Password=Superwi86;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
      }
      }
   }
}
