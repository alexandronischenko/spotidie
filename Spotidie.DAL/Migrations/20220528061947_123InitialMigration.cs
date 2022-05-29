using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotidie.DAL.Migrations
{
    public partial class _123InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("31c5ebbb-890c-4d5e-905b-ad8c31f016db"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("7b0b2e29-71d5-41b8-bdb5-24ac5436722b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("93bbb433-81a7-4bd3-a6ef-62cc37c5e757"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("9f6ec3e5-978f-4a04-bac6-33a886e3dffb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("ce6dd03a-2aad-4276-9875-931d7103e949"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("fa9c6b17-d5ee-4752-a01e-3715206bc8a5"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("8d499bda-547f-4045-845f-0eb9867d5507"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("2c1309ca-991a-4a2b-808f-236f9be2df80"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("2fd4d44d-6a1a-4fd9-8895-5ab0ecec7db8"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("34120a5e-f4f5-4e77-ac91-660fe79bdb20"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("358f8792-2ca3-4884-86e6-5f4f73d4e600"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("55566b8b-2a4e-4fc0-a73d-bb11efea0655"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("6087e803-a6c6-4cef-9796-46aa0859cb1e"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("692d6809-6a00-46f3-a638-fd097bce83d3"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("7120380e-2f45-4db8-9938-adee7f392fe3"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("a7f15785-b716-42f1-b2f9-a1a3bb713bc8"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("c3aa89af-a2dc-472d-84f4-2c21d318d494"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("dd56e402-d2ad-461b-8ba0-dd381e1ff906"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("f540c136-0f14-426b-949d-d20a9e0c42c2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("07dde7af-5d1a-4805-bf51-44a23a1a5a61"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("0d5f26a9-ecee-450b-a78a-c082ccaaa2cd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("101bed5e-5bf5-4a0b-bc94-ebb8a13892d9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("15451b57-ff52-4765-8b41-34495df26e98"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("155e91a8-db88-4255-8609-4668bec7b7a0"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("191485fd-8c7e-47e1-9c76-b234fcaff41f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("197d58f1-1542-4919-9c86-d9b2dfb190da"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("1e0997d7-b993-407b-8307-6607bc166809"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("22b47b99-222a-4c9c-b1a1-637d63d93024"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("25079ffe-7d1e-442f-981d-dbded77d9080"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("2e0d5721-fd75-4eaa-83e6-ce4c5ec41c62"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("2fd0227f-4d6b-451a-bba6-bc21d1d78aac"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("33c5b9af-01fa-4f7f-ad09-01c25d320002"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("397a6676-0e1a-486d-baad-0a8f6efdd86b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("4e6f3d2c-0709-4fc3-8114-b5a47664d12a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("5e8322d0-c2c8-4d0d-9516-76230023521c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("6622505d-e126-4ce3-a240-ff6e2e607b8b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("704c495b-4055-4c07-9d88-46e97a8f3c26"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("84f4e973-aed2-461a-8468-65f5a2db91eb"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("901fce18-e9c0-4600-979c-e44f9573481e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("b0da1979-4219-47e9-b49a-847b56603ec9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("b5d94723-ee3a-4079-b1cc-522e686e9c21"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("b641fb5a-fa99-4be4-94ed-609f20edffde"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("cf9b69dc-c5a7-436b-a8fb-f6fb54a2b29c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("d18c817b-68f4-4940-873e-16172b49ad7e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("d474ba32-670a-45bc-ba41-3a12b3eee943"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("d65f0704-cd93-47f5-87df-c19d3956003f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("d80645c7-2c66-4735-9203-574c3698c924"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("d80e1c19-f5e5-45a4-8c3c-da0c48239d37"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("de03f59d-984c-42e1-9293-58df422481b1"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("f75ccc54-9225-4b57-899c-78d45d4ce601"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("fcd1ec0b-ab6c-457a-ab4a-4a34a1bc50d7"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorAvatar", "AuthorForeignKey", "AuthorName" },
                values: new object[,]
                {
                    { new Guid("113a93d1-38df-4763-b548-f0521bbc998c"), "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg", 5, "Michael Jackson" },
                    { new Guid("4191b441-1ff5-468c-a094-b15ad9fc7b5d"), "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg", 2, "Billie Eilish" },
                    { new Guid("62955e1e-51ee-4d60-928b-0f73d103b3f9"), "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232", 4, "Баста" },
                    { new Guid("74b0dc3b-8079-4846-ba5c-8ace7459ed0a"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", 6, "Your Favourite Music" },
                    { new Guid("9c2c7354-8740-4e2c-9ff9-fa560d1d4a5e"), "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album", 1, "Morgenstern" },
                    { new Guid("e68ac013-5ce5-47d6-8afa-0c7b59a69abc"), "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg", 3, "Awolnation" }
                });

            migrationBuilder.InsertData(
                table: "MainUsers",
                columns: new[] { "MainUserId", "MainUserAvatar", "MainUserEmail", "MainUserForeignKey", "MainUserIsAdmin", "MainUserIsPremium", "MainUserName", "MainUserPassword" },
                values: new object[] { new Guid("03324ff7-f23d-43c0-8c51-366b4bda6957"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", "test5@mail.ru", 6, true, true, "test1", "Qwerty123?" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "PlaylistId", "MainUserId", "PlaylistAvatar", "PlaylistForeignKey", "PlaylistName" },
                values: new object[,]
                {
                    { new Guid("08fc300f-c02c-4bdf-8597-d915d8b2e4f7"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 6, "This is MORGENSTERN" },
                    { new Guid("0914a7d1-c705-4c3d-a77f-b9f70d9566c2"), null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", 2, "dont smile at me" },
                    { new Guid("0a457a5a-e935-4d39-8784-434fb7bb4ff4"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 6, "Angel Miners & the Lightning Riders" },
                    { new Guid("159fc675-c72d-4564-a5eb-25c80aac4348"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 6, "This is Basta" },
                    { new Guid("1c1a2f2c-546f-4501-8204-41bef39e9f13"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 1, "This is MORGENSTERN" },
                    { new Guid("363dd9c1-0448-40fe-97cc-262a166140e9"), null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", 6, "dont smile at me" },
                    { new Guid("47a43edf-7867-4472-8138-50ad06d7bf5d"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 6, "This Is Michael Jackson" },
                    { new Guid("482c931c-51db-4b0e-b318-eec5876e4e6c"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 5, "This Is Michael Jackson" },
                    { new Guid("5173e421-27c7-4d82-a16e-27df14c7933b"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 4, "This is Basta" },
                    { new Guid("89d94f53-01a3-40f1-ba87-6c9b8a23752e"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 3, "Angel Miners & the Lightning Riders" },
                    { new Guid("bf966b0a-2b07-4df6-b09f-449772882931"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 6, "This Is Billie Eilish" },
                    { new Guid("ff4d5cd8-2f8f-4904-aeda-2f54d10ca03d"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 2, "This Is Billie Eilish" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "AuthorId", "PlaylistId", "TrackAvatar", "TrackData", "TrackDuration", "TrackForeignKey", "TrackName" },
                values: new object[,]
                {
                    { new Guid("11b62786-545b-4e8b-9530-578d4d5357a4"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643", 223, 3, "The Best" },
                    { new Guid("199cae62-1986-4bb8-a55e-d1e511adf2b4"), null, null, "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg", "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66", 118, 4, "Ты была права" },
                    { new Guid("1d622d9a-b4cd-4ba3-b10c-c1aa9b33ca09"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 6, "Happier Than Ever" },
                    { new Guid("26b5bb77-4181-4188-a180-510f3f5a65f4"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 1, "Селяви" },
                    { new Guid("3e15dadb-adf2-4605-8f5a-23dff6134bac"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1", 288, 3, "Slam" },
                    { new Guid("4ed4a318-930d-40cc-a859-ab4244e376ce"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 1, "Timerhan" },
                    { new Guid("549933d2-6da4-4fef-af91-3808c2b0fef3"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 6, "Bored" },
                    { new Guid("56faa806-5e46-4e66-bc34-4daf1489c0cd"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8", 179, 2, "bellyache" },
                    { new Guid("58b4a821-ccfd-4ee4-9dd8-b840127f422d"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4", 203, 2, "idontwannabeyouanymore" },
                    { new Guid("5d87cf24-ea65-4717-bc03-16c3a81b9486"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c", 258, 6, "Beat It" },
                    { new Guid("5e6ba477-61d3-40c5-b712-d76891b505be"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8", 179, 6, "bellyache" },
                    { new Guid("619f70f4-cd88-468d-9d14-4d4841f11126"), null, null, "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg", "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334", 252, 4, "Урбан" },
                    { new Guid("62c28ba3-474d-4120-ab65-41a3c0da3e40"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 6, "Cadillac" },
                    { new Guid("6f894abe-9127-42fb-9e1d-59d8029e9566"), null, null, "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg", "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447", 334, 6, "неболей" },
                    { new Guid("74bbbe09-a81a-41eb-b18b-0076d4acf6dd"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 1, "Cadillac" },
                    { new Guid("774f842e-c398-4876-811c-826f7fad62b5"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 6, "Oxytocin" },
                    { new Guid("7db76519-bd85-4a43-8f58-8b4db80f9df5"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 2, "Oxytocin" },
                    { new Guid("7e5fb039-7deb-49a2-991f-11ec9bba53a7"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 2, "Bored" },
                    { new Guid("89308b58-c5f7-4089-84fa-6b9cff871185"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 2, "Happier Than Ever" },
                    { new Guid("8e7a0044-2575-435d-b617-3b75fac88e31"), null, null, "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg", "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334", 252, 4, "Урбан" },
                    { new Guid("91430730-419b-4fdd-bd3a-d0597c3b5de3"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2", 170, 2, "my boy" },
                    { new Guid("a2b60993-16bf-4abd-8b4a-4f2a703b1879"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 6, "Селяви" },
                    { new Guid("a7a7c376-4232-4e6a-bf3c-8dab5d50acff"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0", 233, 6, "Billie Jean" },
                    { new Guid("abdb2d10-2894-4b52-a9cf-9f43274cc703"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c", 258, 5, "Beat It" },
                    { new Guid("b46db2c6-d4df-409e-ae9a-46b4fa7f2c39"), null, null, "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg", "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66", 118, 6, "Ты была права" },
                    { new Guid("ba0040eb-3ae1-4393-8650-fad25d29bd70"), null, null, "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg", "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447", 334, 4, "неболей" },
                    { new Guid("c0828151-8ac1-441b-bfd7-c79b2912cb41"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643", 223, 6, "The Best" },
                    { new Guid("cef46fbb-071d-4129-85df-b2a242f4057e"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496", 194, 2, "COPYCAT" },
                    { new Guid("df2ef618-dfe0-40a8-9a53-81719518a9d5"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0", 233, 5, "Billie Jean" },
                    { new Guid("e9bd6db1-ab89-4e91-b7f8-36163d6b978f"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2", 170, 6, "my boy" },
                    { new Guid("f804abad-a8eb-459e-9725-07f80f93c3f6"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1", 288, 6, "Slam" },
                    { new Guid("fb92f7b5-5de4-4c73-aed8-52175b850027"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4", 203, 6, "idontwannabeyouanymore" },
                    { new Guid("ffff9dad-a2ab-4729-a090-a1461fdfaa16"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496", 194, 6, "COPYCAT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("113a93d1-38df-4763-b548-f0521bbc998c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("4191b441-1ff5-468c-a094-b15ad9fc7b5d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("62955e1e-51ee-4d60-928b-0f73d103b3f9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("74b0dc3b-8079-4846-ba5c-8ace7459ed0a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("9c2c7354-8740-4e2c-9ff9-fa560d1d4a5e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("e68ac013-5ce5-47d6-8afa-0c7b59a69abc"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("03324ff7-f23d-43c0-8c51-366b4bda6957"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("08fc300f-c02c-4bdf-8597-d915d8b2e4f7"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("0914a7d1-c705-4c3d-a77f-b9f70d9566c2"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("0a457a5a-e935-4d39-8784-434fb7bb4ff4"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("159fc675-c72d-4564-a5eb-25c80aac4348"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("1c1a2f2c-546f-4501-8204-41bef39e9f13"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("363dd9c1-0448-40fe-97cc-262a166140e9"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("47a43edf-7867-4472-8138-50ad06d7bf5d"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("482c931c-51db-4b0e-b318-eec5876e4e6c"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("5173e421-27c7-4d82-a16e-27df14c7933b"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("89d94f53-01a3-40f1-ba87-6c9b8a23752e"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("bf966b0a-2b07-4df6-b09f-449772882931"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("ff4d5cd8-2f8f-4904-aeda-2f54d10ca03d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("11b62786-545b-4e8b-9530-578d4d5357a4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("199cae62-1986-4bb8-a55e-d1e511adf2b4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("1d622d9a-b4cd-4ba3-b10c-c1aa9b33ca09"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("26b5bb77-4181-4188-a180-510f3f5a65f4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("3e15dadb-adf2-4605-8f5a-23dff6134bac"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("4ed4a318-930d-40cc-a859-ab4244e376ce"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("549933d2-6da4-4fef-af91-3808c2b0fef3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("56faa806-5e46-4e66-bc34-4daf1489c0cd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("58b4a821-ccfd-4ee4-9dd8-b840127f422d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("5d87cf24-ea65-4717-bc03-16c3a81b9486"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("5e6ba477-61d3-40c5-b712-d76891b505be"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("619f70f4-cd88-468d-9d14-4d4841f11126"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("62c28ba3-474d-4120-ab65-41a3c0da3e40"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("6f894abe-9127-42fb-9e1d-59d8029e9566"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("74bbbe09-a81a-41eb-b18b-0076d4acf6dd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("774f842e-c398-4876-811c-826f7fad62b5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("7db76519-bd85-4a43-8f58-8b4db80f9df5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("7e5fb039-7deb-49a2-991f-11ec9bba53a7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("89308b58-c5f7-4089-84fa-6b9cff871185"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("8e7a0044-2575-435d-b617-3b75fac88e31"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("91430730-419b-4fdd-bd3a-d0597c3b5de3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("a2b60993-16bf-4abd-8b4a-4f2a703b1879"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("a7a7c376-4232-4e6a-bf3c-8dab5d50acff"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("abdb2d10-2894-4b52-a9cf-9f43274cc703"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("b46db2c6-d4df-409e-ae9a-46b4fa7f2c39"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("ba0040eb-3ae1-4393-8650-fad25d29bd70"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("c0828151-8ac1-441b-bfd7-c79b2912cb41"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("cef46fbb-071d-4129-85df-b2a242f4057e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("df2ef618-dfe0-40a8-9a53-81719518a9d5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("e9bd6db1-ab89-4e91-b7f8-36163d6b978f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("f804abad-a8eb-459e-9725-07f80f93c3f6"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("fb92f7b5-5de4-4c73-aed8-52175b850027"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("ffff9dad-a2ab-4729-a090-a1461fdfaa16"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorAvatar", "AuthorForeignKey", "AuthorName" },
                values: new object[,]
                {
                    { new Guid("31c5ebbb-890c-4d5e-905b-ad8c31f016db"), "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg", 2, "Billie Eilish" },
                    { new Guid("7b0b2e29-71d5-41b8-bdb5-24ac5436722b"), "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg", 3, "Awolnation" },
                    { new Guid("93bbb433-81a7-4bd3-a6ef-62cc37c5e757"), "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232", 4, "Баста" },
                    { new Guid("9f6ec3e5-978f-4a04-bac6-33a886e3dffb"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", 6, "Your Favourite Music" },
                    { new Guid("ce6dd03a-2aad-4276-9875-931d7103e949"), "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg", 5, "Michael Jackson" },
                    { new Guid("fa9c6b17-d5ee-4752-a01e-3715206bc8a5"), "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album", 1, "Morgenstern" }
                });

            migrationBuilder.InsertData(
                table: "MainUsers",
                columns: new[] { "MainUserId", "MainUserAvatar", "MainUserEmail", "MainUserForeignKey", "MainUserIsAdmin", "MainUserIsPremium", "MainUserName", "MainUserPassword" },
                values: new object[] { new Guid("8d499bda-547f-4045-845f-0eb9867d5507"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", "test5@mail.ru", 6, true, true, "test1", "Qwerty123?" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "PlaylistId", "MainUserId", "PlaylistAvatar", "PlaylistForeignKey", "PlaylistName" },
                values: new object[,]
                {
                    { new Guid("2c1309ca-991a-4a2b-808f-236f9be2df80"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 6, "This Is Michael Jackson" },
                    { new Guid("2fd4d44d-6a1a-4fd9-8895-5ab0ecec7db8"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 3, "Angel Miners & the Lightning Riders" },
                    { new Guid("34120a5e-f4f5-4e77-ac91-660fe79bdb20"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 1, "This is MORGENSTERN" },
                    { new Guid("358f8792-2ca3-4884-86e6-5f4f73d4e600"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 6, "Angel Miners & the Lightning Riders" },
                    { new Guid("55566b8b-2a4e-4fc0-a73d-bb11efea0655"), null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", 2, "dont smile at me" },
                    { new Guid("6087e803-a6c6-4cef-9796-46aa0859cb1e"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 2, "This Is Billie Eilish" },
                    { new Guid("692d6809-6a00-46f3-a638-fd097bce83d3"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 6, "This is MORGENSTERN" },
                    { new Guid("7120380e-2f45-4db8-9938-adee7f392fe3"), null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", 6, "dont smile at me" },
                    { new Guid("a7f15785-b716-42f1-b2f9-a1a3bb713bc8"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 5, "This Is Michael Jackson" },
                    { new Guid("c3aa89af-a2dc-472d-84f4-2c21d318d494"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 6, "This Is Billie Eilish" },
                    { new Guid("dd56e402-d2ad-461b-8ba0-dd381e1ff906"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 6, "This is Basta" },
                    { new Guid("f540c136-0f14-426b-949d-d20a9e0c42c2"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 4, "This is Basta" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "AuthorId", "PlaylistId", "TrackAvatar", "TrackData", "TrackDuration", "TrackForeignKey", "TrackName" },
                values: new object[,]
                {
                    { new Guid("07dde7af-5d1a-4805-bf51-44a23a1a5a61"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0", 233, 5, "Billie Jean" },
                    { new Guid("0d5f26a9-ecee-450b-a78a-c082ccaaa2cd"), null, null, "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg", "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447", 334, 4, "неболей" },
                    { new Guid("101bed5e-5bf5-4a0b-bc94-ebb8a13892d9"), null, null, "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg", "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334", 252, 4, "Урбан" },
                    { new Guid("15451b57-ff52-4765-8b41-34495df26e98"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8", 179, 6, "bellyache" },
                    { new Guid("155e91a8-db88-4255-8609-4668bec7b7a0"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4", 203, 6, "idontwannabeyouanymore" },
                    { new Guid("191485fd-8c7e-47e1-9c76-b234fcaff41f"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4", 203, 2, "idontwannabeyouanymore" },
                    { new Guid("197d58f1-1542-4919-9c86-d9b2dfb190da"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 6, "Happier Than Ever" },
                    { new Guid("1e0997d7-b993-407b-8307-6607bc166809"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 6, "Oxytocin" },
                    { new Guid("22b47b99-222a-4c9c-b1a1-637d63d93024"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c", 258, 5, "Beat It" },
                    { new Guid("25079ffe-7d1e-442f-981d-dbded77d9080"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 6, "Селяви" },
                    { new Guid("2e0d5721-fd75-4eaa-83e6-ce4c5ec41c62"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1", 288, 3, "Slam" },
                    { new Guid("2fd0227f-4d6b-451a-bba6-bc21d1d78aac"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 2, "Oxytocin" },
                    { new Guid("33c5b9af-01fa-4f7f-ad09-01c25d320002"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c", 258, 6, "Beat It" },
                    { new Guid("397a6676-0e1a-486d-baad-0a8f6efdd86b"), null, null, "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg", "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66", 118, 6, "Ты была права" },
                    { new Guid("4e6f3d2c-0709-4fc3-8114-b5a47664d12a"), null, null, "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg", "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447", 334, 6, "неболей" },
                    { new Guid("5e8322d0-c2c8-4d0d-9516-76230023521c"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8", 179, 2, "bellyache" },
                    { new Guid("6622505d-e126-4ce3-a240-ff6e2e607b8b"), null, null, "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg", "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334", 252, 4, "Урбан" },
                    { new Guid("704c495b-4055-4c07-9d88-46e97a8f3c26"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 6, "Bored" },
                    { new Guid("84f4e973-aed2-461a-8468-65f5a2db91eb"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2", 170, 2, "my boy" },
                    { new Guid("901fce18-e9c0-4600-979c-e44f9573481e"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2", 170, 6, "my boy" },
                    { new Guid("b0da1979-4219-47e9-b49a-847b56603ec9"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 2, "Happier Than Ever" },
                    { new Guid("b5d94723-ee3a-4079-b1cc-522e686e9c21"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496", 194, 6, "COPYCAT" },
                    { new Guid("b641fb5a-fa99-4be4-94ed-609f20edffde"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 2, "Bored" },
                    { new Guid("cf9b69dc-c5a7-436b-a8fb-f6fb54a2b29c"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643", 223, 3, "The Best" },
                    { new Guid("d18c817b-68f4-4940-873e-16172b49ad7e"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496", 194, 2, "COPYCAT" },
                    { new Guid("d474ba32-670a-45bc-ba41-3a12b3eee943"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 6, "Cadillac" },
                    { new Guid("d65f0704-cd93-47f5-87df-c19d3956003f"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643", 223, 6, "The Best" },
                    { new Guid("d80645c7-2c66-4735-9203-574c3698c924"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 1, "Селяви" },
                    { new Guid("d80e1c19-f5e5-45a4-8c3c-da0c48239d37"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0", 233, 6, "Billie Jean" },
                    { new Guid("de03f59d-984c-42e1-9293-58df422481b1"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1", 288, 6, "Slam" },
                    { new Guid("f75ccc54-9225-4b57-899c-78d45d4ce601"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 1, "Cadillac" },
                    { new Guid("fcd1ec0b-ab6c-457a-ab4a-4a34a1bc50d7"), null, null, "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg", "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66", 118, 4, "Ты была права" }
                });
        }
    }
}
