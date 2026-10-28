namespace Asp.netpractice;
using Asp.netpractice.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> obj) : base(obj)
    {

    }
    public DbSet<Students> UnPaidStudents { get; set; }
}
