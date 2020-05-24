using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using System.Text;

namespace Model
{
    public class BookStoreModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int BookID { get; set; }

       [Required]
        public string BookTittle { get; set; }

       [Required]
        public string AuthorName { get; set; }

       [Required]
        public double Price { get; set; }

       [Required]
        public string Summary { get; set; }

      [Required]
        public string BookImage { get; set; }

        [Required]
        public int BookCount { get; set; }

    }
}