using System.ComponentModel.DataAnnotations;

namespace CheeseAndThankYou.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int OrderId { get; set; }

        //FK
        [Required]
        public int ProductId { get; set; }

        //parent ref
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
