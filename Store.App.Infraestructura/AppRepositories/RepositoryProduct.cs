using Store.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App.Infraestructura.AppRepositories
{
    internal class RepositoryProduct : IRepositoryProduct
    {

        private readonly AppContext _appContext;
        

        public RepositoryProduct(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Product AddProduct(Product product)
        {
            var productAdd= _appContext.Products.Add(product);
            _appContext.SaveChanges();
            return productAdd.Entity;
        }


        public void DeleteProduct(int idProduct)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
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
