﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Author> Authors { get; private set; }
        public DbSet<Playlist> Playlists { get; private set; }
        public DbSet<Track> Tracks { get; private set; }
        public DbSet<MainUser> MainUsers { get; private set; }


        public SpotidieContext(DbContextOptions<SpotidieContext> options) : base(options)
        {
        }

        public SpotidieContext() : base()
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
