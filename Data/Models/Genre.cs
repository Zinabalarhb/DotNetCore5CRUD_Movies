using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore5CRUD.Data.Models
{
	public class Genre //not Genres becuse Ef do that in database
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]//becuse its byte not int but i want it Auto Encremnt
		public byte Id { get; set; }

		[Required,MaxLength(100)]//maxlength for any string that best
		public string Name { get; set; }

		
	}
}

