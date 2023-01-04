using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.App.Dominio;
using Store.App.Infraestructura.AppRepositories;

namespace Store.App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private static IRepositoryProduct _repoProduct = new RepositoryProduct(new Infraestructura.AppContext());

        [HttpPost]
        [Route("add")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                Product productAdded=_repoProduct.AddProduct(product);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response= productAdded });
            }
            catch (Exception error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error.Message});
            }

        }


        [HttpGet]
        [Route("all")]
        public IActionResult ProductList()
        {
            try
            {
                IEnumerable<Product> productList = _repoProduct.GetAllProducts();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response = productList });
            }
            catch (Exception error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error.Message});
            }

        }

        [HttpDelete]
        [Route("delete/{idProduct:int}")]
        public IActionResult DeleteProduct(int idProduct)
        {
            try
            {
                var productDeleted = _repoProduct.DeleteProduct(idProduct);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK ELIMINADO", response = productDeleted });
            }
            catch (Exception error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error.Message });
            }

        }


    }
}
