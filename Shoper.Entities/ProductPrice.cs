using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoper.Entities
{
    public class ProductPrice
    {
        public int PriceId { get; set; }
        public UnitPrice UnitPrice { get; set; }
        public int ProductId { get; set; } //Foreign Key
        public decimal Price { get; set; }
        public bool isValidFlag { get; set; }
        public Product Product { get; set; }        
    }

    public enum UnitPrice
    {
        Dolar,
        Euro,
        Lira
    }
}
