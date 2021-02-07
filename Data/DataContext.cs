using Microsoft.EntityFrameworkCore;
using testeef.Models;

namespace testeef.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)

        {

        }
        //coleçoes que eu quero utilizar e salvar localmente no pc
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }   
}