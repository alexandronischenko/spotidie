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
    [Migration("20220527171550_AddedData1.2")]
    partial class AddedData12
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
                            AuthorId = new Guid("cf47c616-5244-4969-bf1e-e863da3ee30d"),
                            AuthorAvatar = "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg",
                            AuthorForeignKey = 1,
                            AuthorName = "Awolnation"
                        },
                        new
                        {
                            AuthorId = new Guid("70404774-488e-48ad-ad84-72edb85eace0"),
                            AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album",
                            AuthorForeignKey = 1,
                            AuthorName = "Morgenstern"
                        },
                        new
                        {
                            AuthorId = new Guid("e5f3bb31-cb7d-4add-8d6f-2bd06a8ed2de"),
                            AuthorAvatar = "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232",
                            AuthorForeignKey = 1,
                            AuthorName = "Баста"
                        },
                        new
                        {
                            AuthorId = new Guid("139161d6-dcdb-48f5-8a7e-4adcfb5f433c"),
                            AuthorAvatar = "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg",
                            AuthorForeignKey = 1,
                            AuthorName = "Michael Jackson"
                        },
                        new
                        {
                            AuthorId = new Guid("a485329b-1912-428f-8f78-7e531cc18b56"),
                            AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg",
                            AuthorForeignKey = 2,
                            AuthorName = "Billie Eilish"
                        },
                        new
                        {
                            AuthorId = new Guid("3cca7a34-efcb-4ab0-8b0f-9017da103102"),
                            AuthorAvatar = "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg",
                            AuthorForeignKey = 0,
                            AuthorName = "Awolnation"
                        },
                        new
                        {
                            AuthorId = new Guid("70b9e528-e76e-4e0a-9fc1-77de6a6edcf0"),
                            AuthorAvatar = "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album",
                            AuthorForeignKey = 0,
                            AuthorName = "Morgenstern"
                        },
                        new
                        {
                            AuthorId = new Guid("a6814305-95a6-4ea0-a30b-b637d26c3736"),
                            AuthorAvatar = "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232",
                            AuthorForeignKey = 0,
                            AuthorName = "Баста"
                        },
                        new
                        {
                            AuthorId = new Guid("58867631-9389-407c-84c4-6813a4a8d63a"),
                            AuthorAvatar = "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg",
                            AuthorForeignKey = 0,
                            AuthorName = "Michael Jackson"
                        },
                        new
                        {
                            AuthorId = new Guid("35666ad7-f14d-4245-acbb-2c6ef68acbbf"),
                            AuthorAvatar = "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg",
                            AuthorForeignKey = 0,
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
                            MainUserId = new Guid("efbf04a5-f312-432d-bb46-36e5fafb8f6a"),
                            MainUserAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",
                            MainUserEmail = "test5@mail.ru",
                            MainUserForeignKey = 1,
                            MainUserIsAdmin = true,
                            MainUserIsPremium = true,
                            MainUserName = "test1",
                            MainUserPassword = "Qwerty123?"
                        },
                        new
                        {
                            MainUserId = new Guid("0cce5564-935c-495d-bfd2-2f26b65a315d"),
                            MainUserAvatar = "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg",
                            MainUserEmail = "test1@mail.ru",
                            MainUserForeignKey = 0,
                            MainUserIsAdmin = true,
                            MainUserIsPremium = true,
                            MainUserName = "test1",
                            MainUserPassword = "Qwerty123?"
                        },
                        new
                        {
                            MainUserId = new Guid("32a8b9b6-391e-4fc5-a9cc-19a0ab6f5c2b"),
                            MainUserAvatar = "https://i.mycdn.me/i?r=AyH4iRPQ2q0otWIFepML2LxR0MrEgIyhL-Sk3iEO-sagEQ",
                            MainUserEmail = "test2@mail.ru",
                            MainUserForeignKey = 0,
                            MainUserIsAdmin = false,
                            MainUserIsPremium = false,
                            MainUserName = "test2",
                            MainUserPassword = "Qwerty123?"
                        },
                        new
                        {
                            MainUserId = new Guid("5dc759e8-751b-4d4b-9ad1-b717b5f6a6a5"),
                            MainUserAvatar = "https://www.meme-arsenal.com/memes/22a1ada0935edc5a844e4aef793bd20f.jpg",
                            MainUserEmail = "test3@mail.ru",
                            MainUserForeignKey = 0,
                            MainUserIsAdmin = false,
                            MainUserIsPremium = false,
                            MainUserName = "test3",
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
                            PlaylistId = new Guid("65327aca-c40f-47fb-9e4f-bcbe5412cd37"),
                            PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg",
                            PlaylistForeignKey = 1,
                            PlaylistName = "This is MORGENSTERN"
                        },
                        new
                        {
                            PlaylistId = new Guid("e638e1cf-35aa-4712-957e-336ab60dd235"),
                            PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg",
                            PlaylistForeignKey = 1,
                            PlaylistName = "Angel Miners & the Lightning Riders"
                        },
                        new
                        {
                            PlaylistId = new Guid("3a9220fb-a19a-403e-87ce-334f30b6b7a8"),
                            PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg",
                            PlaylistForeignKey = 1,
                            PlaylistName = "This is Basta"
                        },
                        new
                        {
                            PlaylistId = new Guid("7e976092-6db6-45a2-a60b-dc736cb3d168"),
                            PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320",
                            PlaylistForeignKey = 1,
                            PlaylistName = "This Is Michael Jackson"
                        },
                        new
                        {
                            PlaylistId = new Guid("00bb2a94-9812-425c-9faf-e45a80803865"),
                            PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e",
                            PlaylistForeignKey = 2,
                            PlaylistName = "This Is Billie Eilish"
                        },
                        new
                        {
                            PlaylistId = new Guid("d5fd5c5c-d6aa-41fe-992c-ae3f0cda8d9b"),
                            PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg",
                            PlaylistForeignKey = 0,
                            PlaylistName = "This is MORGENSTERN"
                        },
                        new
                        {
                            PlaylistId = new Guid("d3f3df2a-4f2b-47f4-a488-ee0368a14bcb"),
                            PlaylistAvatar = "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg",
                            PlaylistForeignKey = 0,
                            PlaylistName = "Angel Miners & the Lightning Riders"
                        },
                        new
                        {
                            PlaylistId = new Guid("8b1f7393-11fb-4c7c-bcb5-eb436c7098d4"),
                            PlaylistAvatar = "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg",
                            PlaylistForeignKey = 0,
                            PlaylistName = "This is Basta"
                        },
                        new
                        {
                            PlaylistId = new Guid("93c52d1c-300e-4e3d-9f13-adab73002190"),
                            PlaylistAvatar = "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320",
                            PlaylistForeignKey = 0,
                            PlaylistName = "This Is Michael Jackson"
                        },
                        new
                        {
                            PlaylistId = new Guid("eb443618-0c55-4b6f-a594-20e21340b9dc"),
                            PlaylistAvatar = "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e",
                            PlaylistForeignKey = 0,
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
                            TrackId = new Guid("8c3406c8-2dd7-448f-ac47-70e554a4138a"),
                            TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",
                            TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",
                            TrackDuration = 177,
                            TrackForeignKey = 1,
                            TrackName = "Cadillac"
                        },
                        new
                        {
                            TrackId = new Guid("ad34f2e7-919b-4878-843d-7dade9a5cc22"),
                            TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",
                            TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",
                            TrackDuration = 160,
                            TrackForeignKey = 1,
                            TrackName = "Селяви"
                        },
                        new
                        {
                            TrackId = new Guid("f5d0f84f-d459-4654-84cb-6c302157d445"),
                            TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
                            TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",
                            TrackDuration = 210,
                            TrackForeignKey = 2,
                            TrackName = "Oxytocin"
                        },
                        new
                        {
                            TrackId = new Guid("79eb6f3d-8d15-4fdc-a283-c9dabe350be9"),
                            TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
                            TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",
                            TrackDuration = 298,
                            TrackForeignKey = 2,
                            TrackName = "Happier Than Ever"
                        },
                        new
                        {
                            TrackId = new Guid("ad0496bc-195c-4685-9f4d-00335b138dca"),
                            TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",
                            TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",
                            TrackDuration = 180,
                            TrackForeignKey = 2,
                            TrackName = "Bored"
                        },
                        new
                        {
                            TrackId = new Guid("aa7ee17b-e78f-4745-84fe-703f505c3d2f"),
                            TrackAvatar = "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg",
                            TrackData = "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863",
                            TrackDuration = 177,
                            TrackForeignKey = 0,
                            TrackName = "Cadillac"
                        },
                        new
                        {
                            TrackId = new Guid("9d721549-ca34-441f-9f49-ce00f3f26408"),
                            TrackAvatar = "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg",
                            TrackData = "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c",
                            TrackDuration = 160,
                            TrackForeignKey = 0,
                            TrackName = "Селяви"
                        },
                        new
                        {
                            TrackId = new Guid("f2f37a0c-8658-4217-9b43-0e632f73d0e8"),
                            TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
                            TrackData = "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470",
                            TrackDuration = 210,
                            TrackForeignKey = 0,
                            TrackName = "Oxytocin"
                        },
                        new
                        {
                            TrackId = new Guid("ab84cec1-7445-47ee-855c-04f86cd39173"),
                            TrackAvatar = "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg",
                            TrackData = "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89",
                            TrackDuration = 298,
                            TrackForeignKey = 0,
                            TrackName = "Happier Than Ever"
                        },
                        new
                        {
                            TrackId = new Guid("70c4d09b-ad6b-44b1-b56d-3cdadbc36674"),
                            TrackAvatar = "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg",
                            TrackData = "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c",
                            TrackDuration = 180,
                            TrackForeignKey = 0,
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

                    b.HasOne("Spotidie.DAL.Entities.Playlist", null)
                        .WithMany("Tracks")
                        .HasForeignKey("PlaylistId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.MainUser", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("Spotidie.DAL.Entities.Playlist", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}