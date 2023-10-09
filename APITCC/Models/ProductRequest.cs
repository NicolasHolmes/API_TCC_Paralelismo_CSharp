using System.ComponentModel.DataAnnotations.Schema;

namespace APITCC.Models
{
    [Table("Produtos")]
    public class ProductRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
    }
}
