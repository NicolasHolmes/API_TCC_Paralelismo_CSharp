using System;

namespace APITCC.Models
{
    public class ProductRequest
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime? MaturityDate { get; set; }
    }
}
