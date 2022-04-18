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

    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    //            => options.UseSqlite("DataSource=app.db;Cache=Shared");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FormTemplate>().ToTable("FormTemplate");
        modelBuilder.Entity<FormTemplate>().Property(x => x.Id);
        modelBuilder.Entity<FormTemplate>().Property(x => x.Title).HasMaxLength(120).HasColumnType("varchar(120)");
        modelBuilder.Entity<FormTemplate>().Property(x => x.Author).HasMaxLength(160).HasColumnType("varchar(160)");
        modelBuilder.Entity<FormTemplate>().Property(x => x.Edition).HasMaxLength(160).HasColumnType("varchar(160)");
        modelBuilder.Entity<FormTemplate>().HasIndex(b => b.Author);



    }
}