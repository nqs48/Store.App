using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App.Dominio
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int InInventory { get; set; }
        public bool Enabled { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

    }
}
