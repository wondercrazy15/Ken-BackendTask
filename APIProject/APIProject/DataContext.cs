using APIProject.Model;
using Microsoft.EntityFrameworkCore;

namespace APIProject;



public partial class DataContext : DbContext
{
    //public DataContext() { } //this one
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    public DbSet<StoreValues> StoreValues { get; set; }

}

