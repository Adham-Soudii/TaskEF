using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Second.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public List<Sale> Sales { get; set; } = new List<Sale>();
    }
}
