using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksApi.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string NumberOfPages { get; set; }
        [Required]
        public DateTime? PublishedAt { get; set; }
    }
}
