using CRUD_Operation.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Operation.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {    
        }

        public DbSet<Student> Students { get; set; }
    }
}
