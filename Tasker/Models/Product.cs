using System;
using System.Collections.Generic;
using System.Text;

namespace Tasker.Models
{
    public  class Product
    {
        public String  Name { get; set; }
        public string  Size { get; set; }
        public decimal Price { get; set; } = 2.6M;
        public string  ImageUrl { get; set; }

    }
}
