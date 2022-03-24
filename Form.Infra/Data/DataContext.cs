using Form.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Form.Infra.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
          : base(options)
    {
    }
    public DbSet<FormTemplate> FormTemplates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlite("DataSource=app.db;Cache=Shared");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}