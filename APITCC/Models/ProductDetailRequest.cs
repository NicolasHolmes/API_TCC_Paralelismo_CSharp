﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITCC.Models
{
    [Table("DetalhesProdutos")]
    public class ProductDetailRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int BarCode { get; set; }
        public int StockQuantity { get; set; }
    }
}
