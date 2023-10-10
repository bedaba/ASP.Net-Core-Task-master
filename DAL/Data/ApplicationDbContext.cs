using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {}

    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>().HasData(new Contact[] {
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"},
            new Contact {  Name = "bedaba", Address="Cairo",Phone="+201065239871"}

        });
        base.OnModelCreating(modelBuilder);
    }
}
