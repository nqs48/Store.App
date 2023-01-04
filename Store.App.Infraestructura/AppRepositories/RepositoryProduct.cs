using Store.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App.Infraestructura.AppRepositories
{
    public class RepositoryProduct : IRepositoryProduct
    {

        private readonly AppContext _appContext;
        

        public RepositoryProduct(AppContext appContext)
        {
            _appContext = appContext;
        }


        public IEnumerable<Product> GetAllProducts()
        {
            return _appContext.Products;
        }


        public Product AddProduct(Product product)
        {
            var productAdds= _appContext.Products.Add(product);
            _appContext.SaveChanges();
            return productAdds.Entity;
        }


        public Product? DeleteProduct(int idProduct)
        {
            var productFind= _appContext.Products.SingleOrDefault(p => p.Id == idProduct);
            if (productFind != null)
            {
                _appContext.Products.Remove(productFind);
                _appContext.SaveChanges();  
            }
            return productFind;
        }

        

        public Product GetProduct(int idProduct)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
