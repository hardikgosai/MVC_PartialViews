using System.ComponentModel.DataAnnotations;

namespace Getri_PartialViews.Models
{
    public class Products
    {
        public int ProductId { get; set; }
                
        public string ProductName { get; set; }

        public string ProductCategory { get; set; }

        public string Description { get; set; }
                
        public decimal ProductPrice { get; set; }
    }
}
