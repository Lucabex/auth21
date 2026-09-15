using auth21.Models;
using Microsoft.EntityFrameworkCore;

namespace auth21.Context;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<User>User{get;set;}
}