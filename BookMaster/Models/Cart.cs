using System.ComponentModel.DataAnnotations;

namespace BookMaster.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }

        public string CartId { get; set; }

        public string BookId { get; set; }

        public int Count { get; set; }

        public System.DateTime DateCreated { get; set; }

        public virtual Book Book { get; set; }
    }
}