using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiCoding_Model.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [Column(name: "Name")]
        public string CategoryName { get; set; }
        //[Column(name:"Display Order")]
        //public int DisplayOrder { get; set; }
    }
}
