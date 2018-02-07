using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//primary key
using System.ComponentModel.DataAnnotations;

namespace HenryConnect.Models
{//one record in the book table
    public class ABook
    {
        [Key]
        [Required(ErrorMessage="Must enter a book code")]
        public string BookCode { get; set; }

        [Required(ErrorMessage = "Must enter a book title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Must enter a publisher code")]
        [StringLength(2, ErrorMessage ="Publisher Code is 2 letters", MinimumLength =2)]
        public string PublisherCode { get; set; }

        [Required(ErrorMessage = "Must enter a book type")]
        [StringLength(3, ErrorMessage = "Book Type is 3 letters", MinimumLength = 3)]
        public string Type { get; set; }

        [Required(ErrorMessage = "Must enter Y or N")]
        [RegularExpression("[YyNn]", ErrorMessage = "Must enter Y or N")]
        public string Paperback { get; set; }

    }
}
