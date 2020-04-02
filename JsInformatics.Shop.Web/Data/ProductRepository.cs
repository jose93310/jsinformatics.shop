using JsInformatics.Shop.Web.Data.Entities;

namespace JsInformatics.Shop.Web.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
