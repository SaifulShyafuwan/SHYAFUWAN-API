using Leo.Models;
using Microsoft.EntityFrameworkCore;

namespace Leo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options) : base (options){

        }

        public DbSet<Value> Values {get; set;}
    }
}