
namespace JsInformatics.Shop.Web.Data
{
    using JsInformatics.Shop.Web.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
    }
}
