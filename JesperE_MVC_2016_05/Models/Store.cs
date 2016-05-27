using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JesperE_MVC_2016_05.Models
{
    public class Store
    {
        [Key]
        public int StoreID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }


    }
}