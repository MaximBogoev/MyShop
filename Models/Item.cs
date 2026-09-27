using System;
namespace MyShop.Models
{
    public class Item
    {
        public int ItemId { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty; // gjør at Name starter som "" og ikke Null
        public decimal Price { get; set; }
        public string? Description { get; set; } // spørsmålstegn gjør at det er optional,
        public string? ImageUrl { get; set; } // ? kan holde både string value eller null
    }
}