using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiCoding_Model.Models
{
    public class Book
    {
        [Key] //primary-key
        public int Id { get; set; }
        public string Title { get; set; }
        [MaxLength(20)] //the ISBN cannot be more than 20 characters
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped] //table won't be created but will function as a db_table
        public string PriceRange { get; set; }

    }
}
