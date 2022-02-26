using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		[Required]
		public string AuthorName { get; set; }
		[Required]
		public Genre Genre { get; set; }
		[Required]
		public byte GenreId { get; set; }
		[Required]
		public DateTime DateAdded { get; set; }
		[Display(Name="Release Date")]
		[Required]
		public DateTime ReleaseDate { get; set; }
		[Display(Name="Number in Stock")]
		[Required]
		[Range(1, 20, ErrorMessage = "Value must be within 1 to 20")]
		public int NumberInStock { get; set; }
		[Required]
		public int NumberAvailable { get; set; }
	}

}
