using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiCoding_Model.Models
{
    [Table("tb_genres")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(name:"Display Order")]
        public int DisplayOrder { get; set; }
    }
}
