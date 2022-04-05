using Microsoft.EntityFrameworkCore;
using Spotidie.DAL.Entities;


namespace Spotidie.DAL.EF
{
    public class SpotidieContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }


        public SpotidieContext(DbContextOptions<SpotidieContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //<-----Заполнение таблицы закомменчено----->
        //static SpotidieContext()
        //{
        //    Database.SetInitializer<SpotidieContext>(new StoreDbInitializer());
        //}
    }

    //public class StoreDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SpotidieContext>
    //{
    //    protected override void Seed(SpotidieContext db)
    //    {
    //        db.Users.Add(new User { UserName = "Admin", UserIsAdmin = true });
    //        db.SaveChanges();
    //    }
    //}
}
