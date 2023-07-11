using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiCoding_Model.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } 
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
}
