using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore5CRUD.Data.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[Required,MaxLength(250)]
		public string Title { get; set; }

		public int Year { get; set; }

		public double Rate { get; set; }

        [Required, MaxLength(2500)]

        public string StoreLine { get; set; }


		[Display(Name ="Select Poster..")]
        [Required]
        public byte[] Poster { get; set; }//type is byteArray



		[Display(Name ="Genre")]
		public byte GenreId { get; set; }//just one ForgenKey for connected with GenreTable
		public Genre Gener { get; set; }

		public Movie()
		{
		}
	}
}

