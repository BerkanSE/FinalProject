using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity //Bu classa diğer katmanlarda ulaşabilsin diye başına public yazıyoruz.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //short int'in bir küçüğüdür. Veri tipi
        public decimal UnitPrice { get; set; } 
    }
}
