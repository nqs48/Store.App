﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.App.Dominio;
using Store.App.Infraestructura.AppRepositories;

namespace Store.App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyController : ControllerBase
    {
        private static IRepositoryBuy _repoBuy = new RepositoryBuy(new Infraestructura.AppContext());
        //private static IRepositoryProduct _repoProduct = new RepositoryProduct(new Infraestructura.AppContext());

        [HttpPost]
        [Route("add")]
        public IActionResult AddProduct([FromBody] Buy buy)
        {
            try
            {
                Buy buyAdded = _repoBuy.AddBuy(buy);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response = buyAdded });
            }
            catch (Exception error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error.Message });
            }

        }

        [HttpGet]
        [Route("all")]
        public IActionResult BuyList()
        {
            try
            {
                IEnumerable<Buy> buyList = _repoBuy.GetAllBuys();
                return StatusCode(StatusCodes.Status200OK, buyList );
            }
            catch (Exception error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error.Message });
            }

        }


        [HttpGet]
        [Route("get/{idBuy:int}")]
        public IActionResult getBuy(int idBuy)
        {
            try
            {
                Buy buy = _repoBuy.GetBuy(idBuy);
                return StatusCode(StatusCodes.Status200OK, buy);
            }
            catch (Exception error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error.Message });
            }

        }



    }
}
