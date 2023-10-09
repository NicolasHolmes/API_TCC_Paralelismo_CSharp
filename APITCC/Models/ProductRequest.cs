using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITCC.Models
{
    [Table("Produtos")]
    public class ProductRequest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
    }
}
