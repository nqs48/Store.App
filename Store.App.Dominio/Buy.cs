using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App.Dominio
{
    public class Buy
    { 
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string IdType { get; set; }
        public string IdClient { get; set; }
        public string ClientName { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
   
}
