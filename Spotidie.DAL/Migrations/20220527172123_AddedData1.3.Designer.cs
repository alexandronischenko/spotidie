﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Spotidie.DAL.EF;

#nullable disable

namespace Spotidie.DAL.Migrations
{
    [DbContext(typeof(SpotidieContext))]
    [Migration("20220527172123_AddedData1.3")]
    partial class AddedData13
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Spotidie.DAL.EF.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AuthorAvatar")
                        .HasColumnType("text");

                    b.Property<int>("AuthorForeignKey")
                        .HasColumnType("integer");

                    b.Property<string>("AuthorName")
                        .HasColumnType("text");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("3ed42979-541b-4862-a3f2-66363827f225"),
                            AuthorAvatar = "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg",
                            AuthorForeignKey = 0,
                            AuthorName = "Awolnation"
                        },
                        new
                        {
                            AuthorId = new Guid("acb49cc1-a4bb-4795-844e-bdd7cfed8ba4"),
                            AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album",
                            AuthorForeignKey = 1,
                            AuthorName = "Morgenstern"
                        },
                        new
                        {
                            AuthorId = new Guid("e9fe734e-7674-4f15-bce2-d0241b14a77d"),
                            AuthorAvatar = "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232",
                            AuthorForeignKey = 0,
                            AuthorName = "Баста"
                        },
                        new
                        {
                            AuthorId = new Guid("63ee7ecd-8ec5-4b6a-8cde-b9918ced00e1"),
                            AuthorAvatar = "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg",
                            AuthorForeignKey = 0,
                            AuthorName = "Michael Jackson"
                        },
                        new
                        {
                            AuthorId = new Guid("d7c58ab7-585d-4b81-ab03-ecf339da59f4"),
                            AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg",
                            AuthorForeignKey = 2,
                            AuthorName = "Billie Eilish"
                        });
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.MainUser", b =>
                {
                    b.Property<Guid>("MainUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("MainUserAvatar")
                        .HasColumnType("text");

                    b.Property<string>("MainUserEmail")
                        .HasColumnType("text");

                    b.Property<int>("MainUserForeignKey")
                        .HasColumnType("integer");

                    b.Property<bool>("MainUserIsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("MainUserIsPremium")
                        .HasColumnType("boolean");

                    b.Property<string>("MainUserName")
                        .HasColumnType("text");

                    b.Property<string>("MainUserPassword")
                        .HasColumnType("text");

                    b.HasKey("MainUserId");

                    b.ToTable("MainUsers");

                    b.HasData(
                        new
                        {
                            MainUserId = new Guid("393a5f57-39aa-4e86-a369-2b8169f909b0"),
                            MainUserAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",
                            MainUserEmail = "test5@mail.ru",
                            MainUserForeignKey = 1,
                            MainUserIsAdmin = true,
                            MainUserIsPremium = true,
                            MainUserName = "test1",
                            MainUserPassword = "Qwerty123?"
                        });
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.Playlist", b =>
                {
                    b.Property<Guid>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("MainUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("PlaylistAvatar")
                        .HasColumnType("text");

                    b.Property<int>("PlaylistForeignKey")
                        .HasColumnType("integer");

                    b.Property<string>("PlaylistName")
                        .HasColumnType("text");

                    b.HasKey("PlaylistId");

                    b.HasIndex("MainUserId");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            PlaylistId = new Guid("d74cf760-f840-4cf3-aefd-1d425965f93c"),
                            PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg",
                            PlaylistForeignKey = 1,
                            PlaylistName = "This is MORGENSTERN"
                        },
                        new
                        {
                            PlaylistId = new Guid("ff8cbdca-f685-4ad1-aa90-66fa4308573c"),
                            PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg",
                            PlaylistForeignKey = 0,
                            PlaylistName = "Angel Miners & the Lightning Riders"
                        },
                        new
                        {
                            PlaylistId = new Guid("b2428626-f5a8-4447-9ef9-73e7a5975f96"),
                            PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg",
                            PlaylistForeignKey = 0,
                            PlaylistName = "This is Basta"
                        },
                        new
                        {
                            PlaylistId = new Guid("180377a1-561b-4f29-9b4b-7c63ea571919"),
                            PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320",
                            PlaylistForeignKey = 0,
                            PlaylistName = "This Is Michael Jackson"
                        },
                        new
                        {
                            PlaylistId = new Guid("65c0ac78-f11a-441c-b87b-c15cfe663ab6"),
                            PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e",
                            PlaylistForeignKey = 2,
                            PlaylistName = "This Is Billie Eilish"
                        });
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.Track", b =>
                {
                    b.Property<Guid>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PlaylistId")
                        .HasColumnType("uuid");

                    b.Property<string>("TrackAvatar")
                        .HasColumnType("text");

                    b.Property<string>("TrackData")
                        .HasColumnType("text");

                    b.Property<int>("TrackDuration")
                        .HasColumnType("integer");

                    b.Property<int>("TrackForeignKey")
                        .HasColumnType("integer");

                    b.Property<string>("TrackName")
                        .HasColumnType("text");

                    b.HasKey("TrackId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            TrackId = new Guid("1536301d-5ceb-4a7b-ba9a-1d1016ab52fc"),
                            TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",
                            TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",
                            TrackDuration = 177,
                            TrackForeignKey = 1,
                            TrackName = "Cadillac"
                        },
                        new
                        {
                            TrackId = new Guid("11277b16-c604-4198-bfe7-41d7fa37d86b"),
                            TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",
                            TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",
                            TrackDuration = 160,
                            TrackForeignKey = 1,
                            TrackName = "Селяви"
                        },
                        new
                        {
                            TrackId = new Guid("7750d141-afba-469d-a3fd-b819356af204"),
                            TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
                            TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",
                            TrackDuration = 210,
                            TrackForeignKey = 2,
                            TrackName = "Oxytocin"
                        },
                        new
                        {
                            TrackId = new Guid("78075bc4-670a-496b-9d11-1405f0bef8bf"),
                            TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
                            TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",
                            TrackDuration = 298,
                            TrackForeignKey = 2,
                            TrackName = "Happier Than Ever"
                        },
                        new
                        {
                            TrackId = new Guid("ffb6dc14-d784-4b89-8fce-988400c2d442"),
                            TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",
                            TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",
                            TrackDuration = 180,
                            TrackForeignKey = 2,
                            TrackName = "Bored"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Spotidie.DAL.EF.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Spotidie.DAL.EF.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotidie.DAL.EF.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Spotidie.DAL.EF.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.Playlist", b =>
                {
                    b.HasOne("Spotidie.DAL.Entities.MainUser", null)
                        .WithMany("Playlists")
                        .HasForeignKey("MainUserId");
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.Track", b =>
                {
                    b.HasOne("Spotidie.DAL.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Spotidie.DAL.Entities.Playlist", "Playlist")
                        .WithMany("Track")
                        .HasForeignKey("PlaylistId");

                    b.Navigation("Author");

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.MainUser", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.Playlist", b =>
                {
                    b.Navigation("Track");
                });
#pragma warning restore 612, 618
        }
    }
}
