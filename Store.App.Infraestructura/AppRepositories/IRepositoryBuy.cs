using Store.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App.Infraestructura.AppRepositories
{
    public interface IRepositoryBuy
    {
        IEnumerable<Buy> GetAllBuys();
        Buy AddBuy(Buy buy);
        Buy GetBuy(int idBuy);
    }
}
