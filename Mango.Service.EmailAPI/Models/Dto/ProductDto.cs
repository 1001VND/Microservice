﻿using System.ComponentModel.DataAnnotations;

namespace Mango.Service.EmailAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public int Count { get; set; } = 1;
        /*public string? ImageLocalPath { get; set; }
        public IFormFile? Image { get; set; }*/
    }
}
