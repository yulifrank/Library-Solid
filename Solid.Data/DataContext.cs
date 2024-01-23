using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;

namespace Solid.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LibraryDB");
        }

    }
}