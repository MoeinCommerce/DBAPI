// System
using System;
using System.Collections.Generic;


namespace DatabaseApi.Models
{
    public class Product : MappableModel
    {
        public long? Code { get; set; }
        public string Unit { get; set; }   
        public string Description { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal? SellPrice { get; set; }
        public int WarehouseId { get; set; }
        public double StockQuantity { get; set; }
        public int? CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsVariable { get; set; }
        public bool IsVariation { get; set; }
        public List<Price> Prices { get; set; }
        public List<AttributeModel> Attributes { get; set; }
    }
}
