﻿using Store.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App.Infraestructura.AppRepositories
{
    public interface IRepositoryProduct
    {
        IEnumerable<Product> GetAllProducts();
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        void DeleteProduct(int idProduct);
        Product GetProduct(int idProduct);
    }
}
