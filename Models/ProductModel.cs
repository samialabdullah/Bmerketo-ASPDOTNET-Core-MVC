﻿

namespace WebApp.Models
{
    public class ProductModel
    {   
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
        public string? Description { get; set; }

        

    }
}



