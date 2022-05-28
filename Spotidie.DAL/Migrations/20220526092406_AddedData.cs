using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotidie.DAL.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorAvatar", "AuthorName" },
                values: new object[,]
                {
                    { new Guid("100b3e8c-b4c1-4f15-867a-3268a3d790ab"), "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232", "Баста" },
                    { new Guid("2942afd6-178b-406d-944d-b4854567ed5a"), "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg", "Michael Jackson" },
                    { new Guid("ba6c4427-c564-4bea-bcd4-51277bbeda77"), "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg", "Awolnation" },
                    { new Guid("d0d1aebf-5698-4966-bf0e-66c8ec2bc987"), "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg", "Billie Eilish" },
                    { new Guid("e6319693-806f-463c-8cfd-0247ae73573d"), "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album", "Morgenstern" }
                });

            migrationBuilder.InsertData(
                table: "MainUsers",
                columns: new[] { "MainUserId", "MainUserAvatar", "MainUserEmail", "MainUserIsAdmin", "MainUserIsPremium", "MainUserName", "MainUserPassword" },
                values: new object[,]
                {
                    { new Guid("509f0a15-ff8a-4a32-91d2-a186cc835c3c"), "https://i.mycdn.me/i?r=AyH4iRPQ2q0otWIFepML2LxR0MrEgIyhL-Sk3iEO-sagEQ", "test2@mail.ru", false, false, "test2", "Qwerty123?" },
                    { new Guid("74f03f9f-f679-45e0-8734-7074f37416c1"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", "test1@mail.ru", true, true, "test1", "Qwerty123?" },
                    { new Guid("fe7e9696-2fcc-4470-b6a5-022d9413ba2d"), "https://www.meme-arsenal.com/memes/22a1ada0935edc5a844e4aef793bd20f.jpg", "test3@mail.ru", false, false, "test3", "Qwerty123?" }
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "PlaylistId", "MainUserId", "PlaylistAvatar", "PlaylistName" },
                values: new object[,]
                {
                    { new Guid("87140120-fdea-410d-9233-d2d6308797b6"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", "This Is Michael Jackson" },
                    { new Guid("91a1a36d-6799-4ea3-8643-e7e387980e67"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", "This Is Billie Eilish" },
                    { new Guid("943be00d-249d-439f-83c2-e0e6db583b27"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", "Angel Miners & the Lightning Riders" },
                    { new Guid("ea2306d2-9001-4006-a7f5-24f1580bfe54"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", "This is MORGENSTERN" },
                    { new Guid("fef92f41-7bc3-4729-9c5e-5b07d7f5e415"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", "This is Basta" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "AuthorId", "PlaylistId", "TrackAvatar", "TrackData", "TrackDuration", "TrackName" },
                values: new object[,]
                {
                    { new Guid("42f83cac-51c6-4f71-9339-4466b2559ec8"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, "Oxytocin" },
                    { new Guid("80865784-ec73-404f-9088-b79a58ca04d7"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, "Cadillac" },
                    { new Guid("85529d4a-a225-481f-b93f-605c04f6cc1d"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, "Bored" },
                    { new Guid("a73ea897-67a7-4606-ad02-8e209dacff07"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, "Селяви" },
                    { new Guid("aa51147a-556e-435c-ba54-a06cb67c0c01"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, "Happier Than Ever" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("100b3e8c-b4c1-4f15-867a-3268a3d790ab"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("2942afd6-178b-406d-944d-b4854567ed5a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("ba6c4427-c564-4bea-bcd4-51277bbeda77"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("d0d1aebf-5698-4966-bf0e-66c8ec2bc987"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("e6319693-806f-463c-8cfd-0247ae73573d"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("509f0a15-ff8a-4a32-91d2-a186cc835c3c"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("74f03f9f-f679-45e0-8734-7074f37416c1"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("fe7e9696-2fcc-4470-b6a5-022d9413ba2d"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("87140120-fdea-410d-9233-d2d6308797b6"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("91a1a36d-6799-4ea3-8643-e7e387980e67"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("943be00d-249d-439f-83c2-e0e6db583b27"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("ea2306d2-9001-4006-a7f5-24f1580bfe54"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("fef92f41-7bc3-4729-9c5e-5b07d7f5e415"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("42f83cac-51c6-4f71-9339-4466b2559ec8"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("80865784-ec73-404f-9088-b79a58ca04d7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("85529d4a-a225-481f-b93f-605c04f6cc1d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("a73ea897-67a7-4606-ad02-8e209dacff07"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("aa51147a-556e-435c-ba54-a06cb67c0c01"));
        }
    }
}
