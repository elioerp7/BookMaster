using System.ComponentModel.DataAnnotations;
namespace BookMaster.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public string BookId { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public virtual Book Book { get; set; }

        public virtual Order Order { get; set; }
    }
}