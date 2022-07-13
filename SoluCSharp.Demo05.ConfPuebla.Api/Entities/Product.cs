using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoluCSharp.Demo05.ConfPuebla.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
