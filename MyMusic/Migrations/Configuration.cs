namespace MyMusic.Migrations
{
	using MyMusic.Models;
	using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyMusic.Models.MusicDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyMusic.Models.MusicDBContext";
        }

        protected override void Seed(MyMusic.Models.MusicDBContext context)
        {
			context.Musics.AddOrUpdate(m => m.Song,
				new Music
				{
					Song = "The Mountain",
					Artist = "Dierks Bentley",
					Album = "The Mountain",
					Genre = "Country",
					ReleaseYear = 2018
				},

				new Music
				{
					Song = "Burning Man",
					Artist = "Dierks Bentley Ft. Brothers Osborne",
					Album = "The Mountain",
					Genre = "Country",
					ReleaseYear = 2018
				},

				new Music
				{
					Song = "Take A Little Ride",
					Artist = "Jason Aldean",
					Album = "Night Train",
					Genre = "Country",
					ReleaseYear = 2012
				},

				new Music
				{
					Song = "The Pretender",
					Artist = "Foo Fighters",
					Album = "Echoes, Silence, Patience & Grace",
					Genre = "Alternative",
					ReleaseYear = 2007
				},

				new Music
				{
					Song = "Money",
					Artist = "Pink Floyd",
					Album = "The Dark Side of the Moon",
					Genre = "Rock",
					ReleaseYear = 1973
				},

				new Music
				{
					Song = "Slide",
					Artist = "The Goo Goo Dolls",
					Album = "Dizzy Up The Girl",
					Genre = "Pop",
					ReleaseYear = 1998
				},

				new Music
				{
					Song = "By The Way",
					Artist = "Red Hot Chili Peppers",
					Album = "By The Way",
					Genre = "Alternative",
					ReleaseYear = 2002
				},

				new Music
				{
					Song = "I Go Back",
					Artist = "Kenny Chesney",
					Album = "When the Sun Goes Down",
					Genre = "Country",
					ReleaseYear = 2004
				}
			);
        }
    }
}
