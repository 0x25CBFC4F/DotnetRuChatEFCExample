using DotnetRuChatEFCExample.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetRuChatEFCExample.DAL;

public class ExampleDbContext : DbContext
{
    public ExampleDbContext(DbContextOptions options) : base(options) {}
    
    public DbSet<ExampleEntity> ExampleEntities { get; set; }
}