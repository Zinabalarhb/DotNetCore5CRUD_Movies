using System;
using DotNetCore5CRUD.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore5CRUD.Data
{
	public class AppDb : DbContext
	{
		public DbSet<Genre> Genres { get; set; }

		public DbSet<Movie> Movies { get; set; }

		public AppDb(DbContextOptions<AppDb> op):base(op)
		{
		}

	}
}

