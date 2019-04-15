using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MyMusic.Models
{
	public class Music
	{
		public int ID { get; set; }

		[Required, StringLength(60, MinimumLength = 2)]
		public string Song { get; set; }

		[Required, StringLength(60, MinimumLength = 2)]
		
		public string Artist { get; set; }

		[StringLength(60, MinimumLength = 2)]
		public string Album { get; set; }

		[StringLength(60, MinimumLength = 3)]
		public string Genre { get; set; }

		[Display(Name = "Release Year")]
		public int ReleaseYear { get; set; }
	}

	public class MusicDBContext : DbContext
	{
		public DbSet<Music> Musics { get; set; }
	}
}