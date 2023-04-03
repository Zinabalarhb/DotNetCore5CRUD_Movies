using System;
using System.ComponentModel.DataAnnotations;
using DotNetCore5CRUD.Data.Models;

namespace DotNetCore5CRUD.ViewModels
{
	public class MovieFormViewModel
	{
        public int Id { get; set; }

        [Required, StringLength(250)]
        public string Title { get; set; }

        public int Year { get; set; }

        [Range(1,10,ErrorMessage ="ارجو ادخال رقم صحيح من ١ الـي ١٠")]
        public double Rate { get; set; }

        [Required, StringLength(2500)]

        public string StoreLine { get; set; }


        //[Required]
        public byte[]? Poster { get; set; }//type is byteArray

        [Display(Name ="Genre")]//تغيير اسم الخاصية امام المستخدم
        public byte GenreId { get; set; }


        public IEnumerable<Genre>? Genres { get; set; }



        //public MovieFormViewModel()
        //{
        //}
    }
}

