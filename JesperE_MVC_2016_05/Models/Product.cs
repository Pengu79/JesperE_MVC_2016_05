using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace JesperE_MVC_2016_05.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,MinLength(4),MaxLength(120)]
        public string ProductText { get; set; }
        
        public int ProductNumber { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int ProductsInStock { get; set; }
         
    }
}