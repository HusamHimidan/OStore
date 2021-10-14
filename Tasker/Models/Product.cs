using System;

namespace Tasker.Models
{
    public class Product
    {
        public String Name { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; } = 2.6M;
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
  public  class Category

    {
        public int  Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }
}
