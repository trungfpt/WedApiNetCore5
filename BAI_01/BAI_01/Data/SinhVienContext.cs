using BAI_01.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BAI_01.Data
{
    public class SinhVienContext : DbContext
    {
        public SinhVienContext()
        {
            
        }
        public SinhVienContext(DbContextOptions<SinhVienContext> options) : base (options) 
        {

        }
        public DbSet<SinhVien> SinhVien { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=LAPTOP-NUP1I8BE\\SQLEXPRESS;Initial Catalog=BAI_1_C#5;Integrated Security=True"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}