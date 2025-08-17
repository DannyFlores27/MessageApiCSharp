using Microsoft.EntityFrameworkCore;
using WebFileApi1.Models;

namespace WebFileApi1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Message> Messages => Set<Message>();
}