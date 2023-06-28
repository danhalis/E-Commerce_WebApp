using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_WebApp.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")] // -> Store 18 digits + 2 decimal places
        public decimal Price { get; set; }

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
