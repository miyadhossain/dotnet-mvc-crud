using DOTNET_MVC_CRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_MVC_CRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
