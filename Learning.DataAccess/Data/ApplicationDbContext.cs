
using Learning_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Learning_Website.DataAccess;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }

}
