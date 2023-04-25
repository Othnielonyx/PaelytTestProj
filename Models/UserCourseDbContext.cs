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

    public DbSet<UserCourseModel> Users { get; set; }
    public DbSet<UserCourseModel> Courses { get; set; }

}
}
