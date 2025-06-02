using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    public class ProductOrder
    {
        public string _UserName { get; set; }
        public string _ProdName { get; set; }
        public string _ProductDescription { get; set; }
        public decimal _Price { get; set; }
        public decimal _Quantity { get; set; }
        public decimal _FinalPrice { get; set; }
        public int _ProductId { get; set; }
        public int _SecurityId { get; set; }
        public int _OrderId { get; set; }
    }
}
