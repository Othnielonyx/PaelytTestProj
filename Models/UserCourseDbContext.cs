using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PaelytTest
{

public class UserCourseDbContext : DbContext
{
    public UserCourseDbContext(DbContextOptions<UserCourseDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
}

public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<UserCourseDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
}
}
