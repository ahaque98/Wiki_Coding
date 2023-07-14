using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiCoding_Model.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_Id { get; set; }

        [Required]
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public string weight { get; set; }

        [ForeignKey("Book")]
        public int Book_Id { get; set; } 

        // will navigate to Book if we have navigation property.
        public Book Book { get; set; } 
    }
}
