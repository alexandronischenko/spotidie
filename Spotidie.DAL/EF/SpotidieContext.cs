using Microsoft.EntityFrameworkCore;
using Spotidie.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Design;

namespace Spotidie.DAL.EF
{

    //dotnet ef migrations add InitialMigration -s Spotidie.WEB -p Spotidie.DAL --verbose
    //dotnet ef database update -s Spotidie.WEB -p Spotidie.DAL --verbose
    public class SpotidieContextFactory : IDesignTimeDbContextFactory<SpotidieContext>
    {
        public SpotidieContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SpotidieContext>();
            optionsBuilder.UseNpgsql("User ID=postgres; Server=localhost; port=5432; Database=SpotidieDB; Password=2002; Pooling=true;");

            return new SpotidieContext(optionsBuilder.Options);
        }
    }
    public class SpotidieContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    //public class SpotidieContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<MainUser> MainUsers { get; set; }
        


        public SpotidieContext(DbContextOptions<SpotidieContext> options) : base(options)
        {
        }

        public SpotidieContext() : base()
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            //AUTHORS
             builder.Entity<Author>().HasData(
                 new Author[]
                 {
                     new Author{AuthorId = Guid.NewGuid(),AuthorName = "Awolnation",AuthorAvatar = "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg",},
                     new Author{AuthorId = Guid.NewGuid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"},
                     new Author{AuthorId = Guid.NewGuid(),AuthorName = "Баста",AuthorAvatar = "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232"},
                     new Author{AuthorId = Guid.NewGuid(),AuthorName = "Michael Jackson",AuthorAvatar = "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg"},
                     new Author{AuthorId = Guid.NewGuid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
                 });
            
             //TRACKS
             builder.Entity<Track>().HasData(
                 new Track[]
                 {
                     new Track{TrackId = Guid.NewGuid(),TrackName = "Cadillac",TrackDuration = 177,TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg"},
                     new Track{TrackId = Guid.NewGuid(),TrackName = "Селяви",TrackDuration = 160,TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",},
                     new Track{TrackId = Guid.NewGuid(),TrackName = "Oxytocin",TrackDuration = 210,TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",},
                     new Track{TrackId = Guid.NewGuid(),TrackName = "Happier Than Ever",TrackDuration = 298,TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",},
                     new Track{TrackId = Guid.NewGuid(),TrackName = "Bored",TrackDuration = 180,TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",},
                 });
            
             // var track1 = new List<Track>(new Track[]
             // {
             //     new Track{TrackId = new Guid(),TrackName = "Cadillac",TrackDuration = 177,TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",
             //         Author = new Author{AuthorId = new Guid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"},
             //     },
             //     new Track{TrackId = new Guid(),TrackName = "Селяви",TrackDuration = 160,TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",
             //         Author = new Author{AuthorId = new Guid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"},
             //     },
             // });
             //
             // var track2 = new List<Track>(new Track[]
             // {
             //     new Track
             //     {
             //         TrackId = new Guid(),TrackName = "Oxytocin",TrackDuration = 210,TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
             //         Author =new Author{AuthorId = new Guid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
             //     },
             //     new Track
             //     {
             //         TrackId = new Guid(),TrackName = "Happier Than Ever",TrackDuration = 298,TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
             //         Author =new Author{AuthorId = new Guid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
             //     },
             //     new Track{
             //         TrackId = new Guid(),TrackName = "Bored",TrackDuration = 180,TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",
             //         Author =new Author{AuthorId = new Guid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
             //     },
             // });
            
            
             //PLAYLISTS
             builder.Entity<Playlist>().HasData(
                 new Playlist[]
                 {
                     new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This is MORGENSTERN",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg"},
                     new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "Angel Miners & the Lightning Riders",PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg"},
                     new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This is Basta",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg"},
                     new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This Is Michael Jackson",PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320"},
                     new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This Is Billie Eilish",PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e"},
                 });
            
             // var playlist1 = new List<Playlist>(new Playlist[]
             // {
             //     new Playlist{PlaylistId = new Guid(),PlaylistName = "This is MORGENSTERN",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg",Tracks = track1},
             //     new Playlist{PlaylistId = new Guid(),PlaylistName = "Angel Miners & the Lightning Riders",PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg"},
             //     new Playlist{PlaylistId = new Guid(),PlaylistName = "This is Basta",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg"},
             //     new Playlist{PlaylistId = new Guid(),PlaylistName = "This Is Michael Jackson",PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320"},
             //     new Playlist{PlaylistId = new Guid(),PlaylistName = "This Is Billie Eilish",PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e",Tracks = track2},
             // });
            
             //USERS
             builder.Entity<MainUser>().HasData(
                 new MainUser[]
                 {
                     new MainUser{MainUserId = Guid.NewGuid(),MainUserEmail = "test1@mail.ru",MainUserPassword = "Qwerty123?",MainUserName = "test1",MainUserIsPremium = true,MainUserIsAdmin = true,MainUserAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",},
                     new MainUser{MainUserId = Guid.NewGuid(),MainUserEmail = "test2@mail.ru",MainUserPassword = "Qwerty123?",MainUserName = "test2",MainUserIsPremium = false,MainUserIsAdmin = false,MainUserAvatar = "https://i.mycdn.me/i?r=AyH4iRPQ2q0otWIFepML2LxR0MrEgIyhL-Sk3iEO-sagEQ",},
                     new MainUser{MainUserId = Guid.NewGuid(),MainUserEmail = "test3@mail.ru",MainUserPassword = "Qwerty123?",MainUserName = "test3",MainUserIsPremium = false,MainUserIsAdmin = false,MainUserAvatar = "https://www.meme-arsenal.com/memes/22a1ada0935edc5a844e4aef793bd20f.jpg"},
                 });


            //Mega USER
             // builder.Entity<MainUser>().HasData(new MainUser[]
             // {
             //     new MainUser{MainUserId = Guid.NewGuid(),MainUserEmail = "test4@mail.ru",MainUserPassword = "Qwerty123?",MainUserName = "test1",MainUserIsPremium = true,MainUserIsAdmin = true,MainUserAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",
             //         Playlists = 
             //             new List<Playlist>(new Playlist[]
             //             {
             //                 new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This is MORGENSTERN",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg",
             //                     Tracks = new List<Track>(new Track[]
             //                     {
             //                         new Track{TrackId = new Guid(),TrackName = "Cadillac",TrackDuration = 177,TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",
             //                             Author = new Author{AuthorId = new Guid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"},
             //                         },
             //                         new Track{TrackId = new Guid(),TrackName = "Селяви",TrackDuration = 160,TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",
             //                             Author = new Author{AuthorId = new Guid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"},
             //                         },
             //                     })
             //                 },
             //                 new Playlist{PlaylistId = new Guid(),PlaylistName = "Angel Miners & the Lightning Riders",PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg"},
             //                 new Playlist{PlaylistId = new Guid(),PlaylistName = "This is Basta",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg"},
             //                 new Playlist{PlaylistId = new Guid(),PlaylistName = "This Is Michael Jackson",PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320"},
             //                 new Playlist{PlaylistId = new Guid(),PlaylistName = "This Is Billie Eilish",PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e",Tracks = new List<Track>(new Track[]
             //                 {
             //                     new Track
             //                     {
             //                         TrackId = new Guid(),TrackName = "Oxytocin",TrackDuration = 210,TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
             //                         Author =new Author{AuthorId = new Guid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
             //                     },
             //                     new Track
             //                     {
             //                         TrackId = new Guid(),TrackName = "Happier Than Ever",TrackDuration = 298,TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
             //                         Author =new Author{AuthorId = new Guid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
             //                     },
             //                     new Track{
             //                         TrackId = new Guid(),TrackName = "Bored",TrackDuration = 180,TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",
             //                         Author =new Author{AuthorId = new Guid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
             //                     },
             //                 })}
             //             })
             //     },
             // });
            
            
        }
    }
    
    
}
