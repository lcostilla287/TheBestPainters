using System.Data.Entity;

namespace TheBestPainters.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Crew> Crews { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<Material> Materials { get; set; }
    }
}