using Store.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App.Infraestructura.AppRepositories
{
    public class RepositoryBuy : IRepositoryBuy
    {

        private readonly AppContext _appContext;


        public RepositoryBuy(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Buy AddBuy(Buy buy)
        {
            var buyAdds = _appContext.Buys.Add(buy);
            _appContext.SaveChanges();
            return buyAdds.Entity;
        }

        public IEnumerable<Buy> GetAllBuys()
        {
            return _appContext.Buys;
        }

        public Buy GetBuy(int idBuy)
        {
            var buyFind = _appContext.Buys.FirstOrDefault(b => b.Id == idBuy);
            return buyFind;
        }
    }
}
