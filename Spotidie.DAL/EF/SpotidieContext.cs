using Microsoft.EntityFrameworkCore;
using Spotidie.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Design;

namespace Spotidie.DAL.EF
{

    //dotnet ef migrations add LastMigration -s Spotidie.WEB -p Spotidie.DAL --verbose
    //dotnet ef database update -s Spotidie.WEB -p Spotidie.DAL --verbose
    public class SpotidieContextFactory : IDesignTimeDbContextFactory<SpotidieContext>
    {
        public SpotidieContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SpotidieContext>();
            optionsBuilder.UseNpgsql(
                "User ID=postgres; Server=localhost; port=5432; Database=SpotidieDB; Password=2002; Pooling=true;");

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
            
            // builder.Entity<MainUser>()
            //     .HasMany(p => p.Playlists)
            //     .WithOne(b => b.MainUser)
            //     .HasForeignKey(p => p.MainUserForeignKey);

            // builder.Entity<Playlist>()
            //     .HasMany(p => p.MainUsers)
            //     .WithMany(t => t.Playlists)
            //     .UsingEntity<Dictionary<string,object>>(
            //         "MainUserPlaylist",
            //         r => r.HasOne<MainUser>().WithMany().HasForeignKey("TagId"),
            //         l => l.HasOne<Playlist>().WithMany().HasForeignKey("PostId"),
            //         je =>
            //         {
            //             je.HasKey("PlaylistId", "MainUserId");
            //             je.HasData(
            //                 new { PostId = mainuserId, TagId = mainuserId });
            //         });

            

            // var track1 = new List<Track>(new Track[]
            // {
            //     new Track
            //     {
            //         TrackId = Guid.NewGuid(), TrackName = "Cadillac", TrackDuration = 177,
            //         TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",
            //         TrackAvatar =
            //             "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",
            //         Author = new Author
            //         {
            //             AuthorId = Guid.NewGuid(), AuthorName = "Morgenstern",
            //             AuthorAvatar =
            //                 "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"
            //         },
            //     },
            //     new Track
            //     {
            //         TrackId = Guid.NewGuid(), TrackName = "Селяви", TrackDuration = 160,
            //         TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",
            //         TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",
            //         Author = new Author
            //         {
            //             AuthorId = Guid.NewGuid(), AuthorName = "Morgenstern",
            //             AuthorAvatar =
            //                 "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"
            //         },
            //     },
            // });
            //
            // var playlist1 = new List<Playlist>(new Playlist[]
            // {
            //     new Playlist
            //     {
            //         PlaylistId = Guid.NewGuid(), PlaylistName = "This is MORGENSTERN",
            //         PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 
            //     },
            //     new Playlist
            //     {
            //         PlaylistId = Guid.NewGuid(), PlaylistName = "Angel Miners & the Lightning Riders",
            //         PlaylistAvatar =
            //             "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg"
            //     },
            //     new Playlist
            //     {
            //         PlaylistId = Guid.NewGuid(), PlaylistName = "This is Basta",
            //         PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg"
            //     },
            //     new Playlist
            //     {
            //         PlaylistId = Guid.NewGuid(), PlaylistName = "This Is Michael Jackson",
            //         PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320"
            //     },
            //     new Playlist
            //     {
            //         PlaylistId = Guid.NewGuid(), PlaylistName = "This Is Billie Eilish",
            //         PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 
            //     },
            // });

            int morgenAuthorId = 1;
            int billieilishAuthorId = 2;
            int awolnationAuthorId = 3;
            int bastaAuthorId = 4;
            int michaeljacksonAuthorId = 5;
            int userAuthorId = 6;
            
            var playlistMorgenshtern = Guid.NewGuid();
            var playlistBillieEilish1 = Guid.NewGuid();
            var playlistBillieEilish2 = Guid.NewGuid();
            var playlistAwolnation1 = Guid.NewGuid();
            var playlistBasta1 = Guid.NewGuid();
            var playlistMichaelJackson = Guid.NewGuid();
            var playlistUser = Guid.NewGuid();

            

            builder.Entity<Author>().HasData(
                new Author[]
                {
                    new Author{AuthorId = Guid.NewGuid(),AuthorName = "Awolnation",AuthorAvatar = "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg",AuthorForeignKey = awolnationAuthorId},
                    new Author{AuthorId = Guid.NewGuid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album",AuthorForeignKey = morgenAuthorId},
                    new Author{AuthorId = Guid.NewGuid(),AuthorName = "Баста",AuthorAvatar = "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232",AuthorForeignKey = bastaAuthorId},
                    new Author{AuthorId = Guid.NewGuid(),AuthorName = "Michael Jackson",AuthorAvatar = "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg",AuthorForeignKey = michaeljacksonAuthorId},
                    new Author{AuthorId = Guid.NewGuid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg",AuthorForeignKey = billieilishAuthorId},
                    new Author{AuthorId = Guid.NewGuid(),AuthorName = "Your Favourite Music",AuthorAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",AuthorForeignKey = userAuthorId},
                });
            
            builder.Entity<Track>().HasData(
                new Track[]
                {
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Timerhan",TrackDuration = 177,TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",TrackForeignKey = morgenAuthorId},
                    //Morgen
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Cadillac",TrackDuration = 177,TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",TrackForeignKey = morgenAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Селяви",TrackDuration = 160,TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",TrackForeignKey = morgenAuthorId},
                    //Billie
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Oxytocin",TrackDuration = 210,TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",TrackForeignKey = billieilishAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Happier Than Ever",TrackDuration = 298,TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",TrackForeignKey = billieilishAuthorId,},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Bored",TrackDuration = 180,TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",TrackForeignKey = billieilishAuthorId},
                    
                    new Track{TrackId = Guid.NewGuid(),TrackName = "bellyache",TrackDuration = 179,TrackData = "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8",TrackAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",TrackForeignKey = billieilishAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "my boy",TrackDuration = 170,TrackData = "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2",TrackAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",TrackForeignKey = billieilishAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "idontwannabeyouanymore",TrackDuration = 203,TrackData = "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4",TrackAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",TrackForeignKey = billieilishAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "COPYCAT",TrackDuration = 194,TrackData = "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496",TrackAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",TrackForeignKey = billieilishAuthorId},
                    
                    //Awolnation
                    new Track{TrackId = Guid.NewGuid(),TrackName = "The Best",TrackDuration = 223,TrackData = "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643",TrackAvatar = "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37",TrackForeignKey = awolnationAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Slam",TrackDuration = 288,TrackData = "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1",TrackAvatar = "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37",TrackForeignKey = awolnationAuthorId},
                    
                    //Basta
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Урбан",TrackDuration = 252,TrackData = "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334",TrackAvatar = "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg",TrackForeignKey = bastaAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Ты была права",TrackDuration = 118,TrackData = "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66",TrackAvatar = "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg",TrackForeignKey = bastaAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "неболей",TrackDuration = 334,TrackData = "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447",TrackAvatar = "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg",TrackForeignKey = bastaAuthorId},

                    //Michael Jackson
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Billie Jean",TrackDuration = 233,TrackData = "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg",TrackForeignKey = michaeljacksonAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Beat It",TrackDuration = 258,TrackData = "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg",TrackForeignKey = michaeljacksonAuthorId},

                    
                    //UserMusic
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Cadillac",TrackDuration = 177,TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",TrackForeignKey = userAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Селяви",TrackDuration = 160,TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",TrackForeignKey = userAuthorId},
                    
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Oxytocin",TrackDuration = 210,TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",TrackForeignKey = userAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Happier Than Ever",TrackDuration = 298,TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",TrackForeignKey = userAuthorId,},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Bored",TrackDuration = 180,TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",TrackForeignKey = userAuthorId},
                    
                    new Track{TrackId = Guid.NewGuid(),TrackName = "bellyache",TrackDuration = 179,TrackData = "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8",TrackAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",TrackForeignKey = userAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "my boy",TrackDuration = 170,TrackData = "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2",TrackAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",TrackForeignKey = userAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "idontwannabeyouanymore",TrackDuration = 203,TrackData = "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4",TrackAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",TrackForeignKey = userAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "COPYCAT",TrackDuration = 194,TrackData = "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496",TrackAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",TrackForeignKey = userAuthorId},
                    
                    
                    new Track{TrackId = Guid.NewGuid(),TrackName = "The Best",TrackDuration = 223,TrackData = "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643",TrackAvatar = "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37",TrackForeignKey = userAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Slam",TrackDuration = 288,TrackData = "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1",TrackAvatar = "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37",TrackForeignKey = userAuthorId},
                    
                    
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Урбан",TrackDuration = 252,TrackData = "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334",TrackAvatar = "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg",TrackForeignKey = bastaAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Ты была права",TrackDuration = 118,TrackData = "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66",TrackAvatar = "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg",TrackForeignKey = userAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "неболей",TrackDuration = 334,TrackData = "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447",TrackAvatar = "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg",TrackForeignKey = userAuthorId},


                    new Track{TrackId = Guid.NewGuid(),TrackName = "Billie Jean",TrackDuration = 233,TrackData = "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg",TrackForeignKey = userAuthorId},
                    new Track{TrackId = Guid.NewGuid(),TrackName = "Beat It",TrackDuration = 258,TrackData = "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg",TrackForeignKey = userAuthorId},

                    
                });
            
            builder.Entity<Playlist>().HasData(
                new Playlist[]
                {
                    new Playlist
                    {
                        PlaylistId = playlistMorgenshtern, PlaylistName = "This is MORGENSTERN",
                        PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg",PlaylistForeignKey = morgenAuthorId,
                    },
                    new Playlist
                    {
                        PlaylistId = playlistAwolnation1, PlaylistName = "Angel Miners & the Lightning Riders",
                        PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg",PlaylistForeignKey = awolnationAuthorId
                    },
                    new Playlist
                    {
                        PlaylistId = playlistBasta1, PlaylistName = "This is Basta",
                        PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg",PlaylistForeignKey = bastaAuthorId
                    },
                    new Playlist
                    {
                        PlaylistId = playlistMichaelJackson, PlaylistName = "This Is Michael Jackson",
                        PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320",PlaylistForeignKey = michaeljacksonAuthorId
                    },
                    new Playlist
                    {
                        PlaylistId = playlistBillieEilish1, PlaylistName = "This Is Billie Eilish",
                        PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e",PlaylistForeignKey = billieilishAuthorId
                    },
                    new Playlist
                    {
                        PlaylistId = playlistBillieEilish2, PlaylistName = "dont smile at me",
                        PlaylistAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",PlaylistForeignKey = billieilishAuthorId
                    },
                    
                    //users playlists
                    new Playlist
                    {
                        PlaylistId = Guid.NewGuid(), PlaylistName = "This is MORGENSTERN",
                        PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg",PlaylistForeignKey = userAuthorId,
                    },
                    new Playlist
                    {
                        PlaylistId = Guid.NewGuid(), PlaylistName = "Angel Miners & the Lightning Riders",
                        PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg",PlaylistForeignKey = userAuthorId
                    },
                    new Playlist
                    {
                        PlaylistId = Guid.NewGuid(), PlaylistName = "This is Basta",
                        PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg",PlaylistForeignKey = userAuthorId
                    },
                    new Playlist
                    {
                        PlaylistId = Guid.NewGuid(), PlaylistName = "This Is Michael Jackson",
                        PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320",PlaylistForeignKey = userAuthorId
                    },
                    new Playlist
                    {
                        PlaylistId = Guid.NewGuid(), PlaylistName = "This Is Billie Eilish",
                        PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e",PlaylistForeignKey = userAuthorId
                    },
                    new Playlist
                    {
                        PlaylistId = Guid.NewGuid(), PlaylistName = "dont smile at me",
                        PlaylistAvatar = "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg",PlaylistForeignKey = userAuthorId
                    },
                });
            builder.Entity<MainUser>().HasData(
                new MainUser[]
                {
                    new MainUser
                    {
                        MainUserId = Guid.NewGuid(), MainUserEmail = "test5@mail.ru", MainUserPassword = "Qwerty123?",
                        MainUserName = "test1", MainUserIsPremium = true, MainUserIsAdmin = true,
                        MainUserAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",MainUserForeignKey = userAuthorId
                    },
                });
            



            //AUTHORS
             // builder.Entity<Author>().HasData(
             //     new Author[]
             //     {
             //         new Author{AuthorId = Guid.NewGuid(),AuthorName = "Awolnation",AuthorAvatar = "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg",},
             //         new Author{AuthorId = Guid.NewGuid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"},
             //         new Author{AuthorId = Guid.NewGuid(),AuthorName = "Баста",AuthorAvatar = "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232"},
             //         new Author{AuthorId = Guid.NewGuid(),AuthorName = "Michael Jackson",AuthorAvatar = "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg"},
             //         new Author{AuthorId = Guid.NewGuid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
             //     });
             //
             //TRACKS
             // builder.Entity<Track>().HasData(
             //     new Track[]
             //     {
             //         new Track{TrackId = Guid.NewGuid(),TrackName = "Cadillac",TrackDuration = 177,TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg"},
             //         new Track{TrackId = Guid.NewGuid(),TrackName = "Селяви",TrackDuration = 160,TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",},
             //         new Track{TrackId = Guid.NewGuid(),TrackName = "Oxytocin",TrackDuration = 210,TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",},
             //         new Track{TrackId = Guid.NewGuid(),TrackName = "Happier Than Ever",TrackDuration = 298,TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",},
             //         new Track{TrackId = Guid.NewGuid(),TrackName = "Bored",TrackDuration = 180,TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",},
             //     });
             //PLAYLISTS
            // builder.Entity<Playlist>().HasData(
            //     new Playlist[]
            //     {
            //         new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This is MORGENSTERN",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg"},
            //         new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "Angel Miners & the Lightning Riders",PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg"},
            //         new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This is Basta",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg"},
            //         new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This Is Michael Jackson",PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320"},
            //         new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This Is Billie Eilish",PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e"},
            //     });
            
            //USERS
            // builder.Entity<MainUser>().HasData(
            //     new MainUser[]
            //     {
            //         new MainUser{MainUserId = Guid.NewGuid(),MainUserEmail = "test1@mail.ru",MainUserPassword = "Qwerty123?",MainUserName = "test1",MainUserIsPremium = true,MainUserIsAdmin = true,MainUserAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",},
            //         new MainUser{MainUserId = Guid.NewGuid(),MainUserEmail = "test2@mail.ru",MainUserPassword = "Qwerty123?",MainUserName = "test2",MainUserIsPremium = false,MainUserIsAdmin = false,MainUserAvatar = "https://i.mycdn.me/i?r=AyH4iRPQ2q0otWIFepML2LxR0MrEgIyhL-Sk3iEO-sagEQ",},
            //         new MainUser{MainUserId = Guid.NewGuid(),MainUserEmail = "test3@mail.ru",MainUserPassword = "Qwerty123?",MainUserName = "test3",MainUserIsPremium = false,MainUserIsAdmin = false,MainUserAvatar = "https://www.meme-arsenal.com/memes/22a1ada0935edc5a844e4aef793bd20f.jpg"},
            //     });


            //         //Mega USER
            //           builder.Entity<MainUser>().HasData(new MainUser[]
            //           {
            //               new MainUser{MainUserId = mainuserId,MainUserEmail = "test4@mail.ru",MainUserPassword = "Qwerty123?",MainUserName = "test1",MainUserIsPremium = true,MainUserIsAdmin = true,MainUserAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",
            //                   Playlists = 
            //                       new List<Playlist>(new Playlist[]
            //                       {
            //                           new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This is MORGENSTERN",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg",
            //                               Tracks = new List<Track>(new Track[]
            //                               {
            //                                   new Track{TrackId = Guid.NewGuid(),TrackName = "Cadillac",TrackDuration = 177,TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",
            //                                       Author = new Author{AuthorId = Guid.NewGuid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"},
            //                                   },
            //                                   new Track{TrackId = Guid.NewGuid(),TrackName = "Селяви",TrackDuration = 160,TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",
            //                                       Author = new Author{AuthorId = Guid.NewGuid(),AuthorName = "Morgenstern",AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album"},
            //                                   },
            //                               })
            //                           },
            //                           new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "Angel Miners & the Lightning Riders",PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg"},
            //                           new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This is Basta",PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg"},
            //                           new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This Is Michael Jackson",PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320"},
            //                           new Playlist{PlaylistId = Guid.NewGuid(),PlaylistName = "This Is Billie Eilish",PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e",Tracks = new List<Track>(new Track[]
            //                           {
            //                               new Track
            //                               {
            //                                   TrackId = Guid.NewGuid(),TrackName = "Oxytocin",TrackDuration = 210,TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
            //                                   Author =new Author{AuthorId = Guid.NewGuid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
            //                               },
            //                               new Track
            //                               {
            //                                   TrackId = Guid.NewGuid(),TrackName = "Happier Than Ever",TrackDuration = 298,TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
            //                                   Author =new Author{AuthorId = Guid.NewGuid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
            //                               },
            //                               new Track{
            //                                   TrackId = Guid.NewGuid(),TrackName = "Bored",TrackDuration = 180,TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",
            //                                   Author =new Author{AuthorId = Guid.NewGuid(),AuthorName = "Billie Eilish",AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg"},
            //                               },
            //                           })}
            //                       })
            //               },
            //           });
            //         
            //         
            //     }
            // }


        }
    }
}