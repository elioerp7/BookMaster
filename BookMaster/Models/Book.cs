using System.ComponentModel.DataAnnotations;

namespace BookMaster.Models
{
    public class Book
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }
        
        public string Publisher { get; set; }

        [MaxLength(17)]
        [Key]
        public string ISBN { get; set; }

        [MinLength(0)]
        public int Quantity { get; set; }
    }
}