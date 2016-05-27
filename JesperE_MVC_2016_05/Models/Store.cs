using System.Collections.Generic;

namespace JesperE_MVC_2016_05.Models
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }


    }
}