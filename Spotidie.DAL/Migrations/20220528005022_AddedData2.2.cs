using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotidie.DAL.Migrations
{
    public partial class AddedData22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("085b3d32-7462-49c1-aec3-76f66c466dee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("139179a6-ffe0-484a-92d1-d67a939f6f3a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("1a042c70-f725-4142-98e8-7bb3b2c69dc9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("2bd905cb-97e4-43db-8eae-4ff7212d93f6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("5cfaabf2-eb6a-4f06-b5c9-8c2a0f8b49d6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("61abd222-ce59-4575-8fb7-204432bb5d9e"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("cd6f1f54-8ee4-4f22-92ef-cc62de87cb47"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("18bc09c4-88b2-490b-b7e5-df40d8484ac2"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("1bffc002-7263-4c55-93d9-c0ed2b13168d"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("39944eaf-f284-49d1-8188-35d579ef2797"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("49d062cd-a530-42cb-801f-b67e56b3ca8a"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("6db5f9b1-1c33-48c4-8fca-87cda63681e2"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("6dd9deee-b9d8-4fe0-af6a-7d9b88354de6"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("76536318-44f8-4d71-b3cc-f81a9eba4ef0"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("8bab1d58-fc3c-4692-abac-05f5df5f5bb5"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("adc221bf-b735-4f8e-a71f-74defeca6581"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("b1777146-4690-4df5-ba43-2206dd50bd4d"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("cc5d685a-65b6-4a03-834b-fc2379cc04d7"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("f434eb04-8ce4-40d3-af35-600982ce6657"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("0030e945-e3f0-4192-b1e3-fac41c982aee"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("13679f91-c84a-4091-86f9-d66ada36d2ee"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("18b2b0c8-aa43-4004-92dd-4c89f6918308"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("23553c20-3ee9-480a-8027-ca121faa9b65"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("2572ebf2-2f32-421c-8a90-153a4650e7fe"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("27267685-2326-4ffd-bc37-818d30fa3a22"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("3bc007d5-51f3-4236-be30-c6bcbe2f2722"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("4994bb7b-344c-4fa6-8c52-c9250efdd972"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("4e62db82-eb53-4d91-b0fa-b539b7ea7a2d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("4ebe2fc4-5930-4dd1-a3c6-d41324a2fa67"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("53bd0b36-b237-4055-81b0-4c5e754f2d0f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("5b1f3b71-c277-463a-a08c-5832212c095e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("6022e362-fc06-420f-9d47-ae6dd9baa45a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("82ab0ac3-bc59-4a27-b236-0625be526c78"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("869c7300-7f1e-4633-9be5-8e4e7ad1f07b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("8861fd6e-af9b-4bfe-8051-85589e9be573"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("8d04e219-c540-4029-85ae-67057084e103"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("a27e8c6f-b692-4ff0-a78a-0688ef53d24f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("a4acbc76-5128-4bf4-b6ea-07c6da27173e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("a5cd66fb-af2e-490e-8591-9b41254ceb67"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("a5d17575-d97a-470a-967b-b23d8215f413"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("aa1f14b7-0516-4e68-a6df-a344653bbb6e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("b7d2b305-cc03-41f9-86d7-ea25586a1173"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("c7e005aa-965c-4791-b9bc-db8fba241e33"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("d63c8cf4-67d3-49d8-b6a0-7ecb14d24ce8"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("de68f4ad-e4e7-418b-9bf3-a1978313ecaf"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("e573064f-8180-4a72-abda-ac695dd7fd69"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("e5e7469c-9554-456e-9f25-7a147bef6cc4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("e84fffe6-5617-4f48-b77a-8424bb1d7f55"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("ec3ff423-01bb-43b3-9421-71c7f1e5a531"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("fa5b6602-35a9-41c8-8e7d-fbbe2036e69d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("fd56618a-1e4e-46e1-9a38-e9057a2af8ec"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorAvatar", "AuthorForeignKey", "AuthorName" },
                values: new object[,]
                {
                    { new Guid("3bd3cb3e-63fb-44b2-a802-a9ed35a8da43"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", 6, "Your Favourite Music" },
                    { new Guid("8e4db8b7-8d5f-4728-9035-8b72177cc23d"), "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg", 5, "Michael Jackson" },
                    { new Guid("af575421-f64d-47c3-9209-f4e0dbbd4ed7"), "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album", 1, "Morgenstern" },
                    { new Guid("b2464515-8943-435a-9967-7ae2eed876f8"), "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg", 3, "Awolnation" },
                    { new Guid("cf7011f7-67fa-4787-b371-e1d8541577ec"), "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232", 4, "Баста" },
                    { new Guid("eef4f4c6-d366-4a06-894f-061ca2a92240"), "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg", 2, "Billie Eilish" }
                });

            migrationBuilder.InsertData(
                table: "MainUsers",
                columns: new[] { "MainUserId", "MainUserAvatar", "MainUserEmail", "MainUserForeignKey", "MainUserIsAdmin", "MainUserIsPremium", "MainUserName", "MainUserPassword" },
                values: new object[] { new Guid("a60031bf-478b-453f-815e-2aba71d6c2f8"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", "test5@mail.ru", 6, true, true, "test1", "Qwerty123?" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "PlaylistId", "MainUserId", "PlaylistAvatar", "PlaylistForeignKey", "PlaylistName" },
                values: new object[,]
                {
                    { new Guid("2a4434b8-8923-48a1-aac7-29294c18453f"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 5, "This Is Michael Jackson" },
                    { new Guid("3c65e079-302a-4a86-8b26-33d634453c77"), null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", 2, "dont smile at me" },
                    { new Guid("49304080-68c4-4282-971f-21d078d1d84c"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 6, "This is MORGENSTERN" },
                    { new Guid("74313437-c03c-4755-aee8-b561bce50bff"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 4, "This is Basta" },
                    { new Guid("788bc3b8-7688-4722-97b7-a2f426520660"), null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", 6, "dont smile at me" },
                    { new Guid("80a333e4-bbc0-4d90-b3fa-7d60c17858d3"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 6, "This is Basta" },
                    { new Guid("82b5e106-2cff-4fac-b1ef-ed641a0db7d8"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 6, "This Is Michael Jackson" },
                    { new Guid("9b72e5da-9d33-4267-a99e-032d83dd0091"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 3, "Angel Miners & the Lightning Riders" },
                    { new Guid("a7a0253a-8a5a-46ed-8b51-b8aaa55a446a"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 6, "Angel Miners & the Lightning Riders" },
                    { new Guid("d51352ae-e041-4ccf-a9ad-2b226d91a2c1"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 1, "This is MORGENSTERN" },
                    { new Guid("d81af643-549b-4f0c-bb59-feba454e2819"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 2, "This Is Billie Eilish" },
                    { new Guid("fdbf06b4-a041-48bd-a9dc-611d27a17a33"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 6, "This Is Billie Eilish" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "AuthorId", "PlaylistId", "TrackAvatar", "TrackData", "TrackDuration", "TrackForeignKey", "TrackName" },
                values: new object[,]
                {
                    { new Guid("0394c1ce-76e0-418a-81f8-b63cc4a3277a"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 1, "Cadillac" },
                    { new Guid("0b77af65-daa0-46e4-a944-85884407455c"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643", 223, 6, "The Best" },
                    { new Guid("0e3a072e-ebd7-40a0-bc01-1bb59213e9ca"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 6, "Cadillac" },
                    { new Guid("0f375b42-7756-4cff-8509-4a1140e6e6c6"), null, null, "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg", "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334", 252, 4, "Урбан" },
                    { new Guid("1b50e6a1-8890-4490-90b6-a97cd51ba71c"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 6, "Селяви" },
                    { new Guid("37248ac3-b021-40e4-b98e-a39afbafc1e3"), null, null, "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg", "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447", 334, 6, "неболей" },
                    { new Guid("3965d881-25ae-4994-aa4e-86b519c94ce7"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2", 170, 6, "my boy" },
                    { new Guid("3a7e4db3-ba77-4a9a-accc-dd1752a01792"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2", 170, 2, "my boy" },
                    { new Guid("3c1eeedd-7564-49b5-afab-02c137e5319a"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4", 203, 2, "idontwannabeyouanymore" },
                    { new Guid("418f8014-379d-40bc-a752-3725f8e3881e"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 1, "Селяви" },
                    { new Guid("41fe4539-d1db-4425-a5e3-9cd7875d3c5c"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c", 258, 6, "Beat It" },
                    { new Guid("4cfda8c2-d982-4700-af47-4bbc43cc8c17"), null, null, "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg", "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334", 252, 4, "Урбан" },
                    { new Guid("55e0f31f-b127-4193-b976-6aee4ae58c4d"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1", 288, 6, "Slam" },
                    { new Guid("6c0e7b7c-d88f-4e63-bdd1-6ea469dbdfff"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1", 288, 3, "Slam" },
                    { new Guid("71246719-7df5-479e-916a-6ad78c9f6c42"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643", 223, 3, "The Best" },
                    { new Guid("749eb116-2bab-41c6-8a12-ba53f91cf316"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 2, "Oxytocin" },
                    { new Guid("8109dd4b-c011-4d9e-bdbf-bcc3b1192414"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 6, "Oxytocin" },
                    { new Guid("81273d50-66ad-4b7c-aae6-67f9c0e4ccf5"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496", 194, 2, "COPYCAT" },
                    { new Guid("88549002-3213-438b-9029-c9311211d4ba"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0", 233, 6, "Billie Jean" },
                    { new Guid("8d754bca-0f23-4d91-93f3-bf20d57081b4"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c", 258, 5, "Beat It" },
                    { new Guid("8d95607f-e1c4-469a-bc63-63b74bfaab4a"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 6, "Bored" },
                    { new Guid("8e2f328b-c3cd-40de-9cb6-74f1435ea871"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 2, "Bored" },
                    { new Guid("93b686e7-1a84-480e-8a70-757011a04c54"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 2, "Happier Than Ever" },
                    { new Guid("949cacf7-6fa0-4f68-8cf8-630f52e92b1a"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4", 203, 6, "idontwannabeyouanymore" },
                    { new Guid("9aa40b91-7187-4ce7-a2c2-e2be8f541875"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8", 179, 6, "bellyache" },
                    { new Guid("9beed781-3f73-408a-8968-7ab2139146f1"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 6, "Happier Than Ever" },
                    { new Guid("bdf94390-0d47-49fa-b226-6af9b4e4f925"), null, null, "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg", "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447", 334, 4, "неболей" },
                    { new Guid("c2bbe8ee-097d-49f9-91f7-27cadd0e8823"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0", 233, 5, "Billie Jean" },
                    { new Guid("c500b500-0d90-4ee8-9e11-03f0ab7dea56"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496", 194, 6, "COPYCAT" },
                    { new Guid("d1870e6c-cab0-4f1f-b161-545161b07d85"), null, null, "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg", "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66", 118, 4, "Ты была права" },
                    { new Guid("f26c10a1-9c28-4250-b06f-43727b2a8f7f"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8", 179, 2, "bellyache" },
                    { new Guid("f4a9f9e7-7356-40cb-8e40-da73f3a214a4"), null, null, "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg", "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66", 118, 6, "Ты была права" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("3bd3cb3e-63fb-44b2-a802-a9ed35a8da43"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("8e4db8b7-8d5f-4728-9035-8b72177cc23d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("af575421-f64d-47c3-9209-f4e0dbbd4ed7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("b2464515-8943-435a-9967-7ae2eed876f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("cf7011f7-67fa-4787-b371-e1d8541577ec"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("eef4f4c6-d366-4a06-894f-061ca2a92240"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("a60031bf-478b-453f-815e-2aba71d6c2f8"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("2a4434b8-8923-48a1-aac7-29294c18453f"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("3c65e079-302a-4a86-8b26-33d634453c77"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("49304080-68c4-4282-971f-21d078d1d84c"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("74313437-c03c-4755-aee8-b561bce50bff"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("788bc3b8-7688-4722-97b7-a2f426520660"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("80a333e4-bbc0-4d90-b3fa-7d60c17858d3"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("82b5e106-2cff-4fac-b1ef-ed641a0db7d8"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("9b72e5da-9d33-4267-a99e-032d83dd0091"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("a7a0253a-8a5a-46ed-8b51-b8aaa55a446a"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("d51352ae-e041-4ccf-a9ad-2b226d91a2c1"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("d81af643-549b-4f0c-bb59-feba454e2819"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("fdbf06b4-a041-48bd-a9dc-611d27a17a33"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("0394c1ce-76e0-418a-81f8-b63cc4a3277a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("0b77af65-daa0-46e4-a944-85884407455c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("0e3a072e-ebd7-40a0-bc01-1bb59213e9ca"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("0f375b42-7756-4cff-8509-4a1140e6e6c6"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("1b50e6a1-8890-4490-90b6-a97cd51ba71c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("37248ac3-b021-40e4-b98e-a39afbafc1e3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("3965d881-25ae-4994-aa4e-86b519c94ce7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("3a7e4db3-ba77-4a9a-accc-dd1752a01792"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("3c1eeedd-7564-49b5-afab-02c137e5319a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("418f8014-379d-40bc-a752-3725f8e3881e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("41fe4539-d1db-4425-a5e3-9cd7875d3c5c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("4cfda8c2-d982-4700-af47-4bbc43cc8c17"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("55e0f31f-b127-4193-b976-6aee4ae58c4d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("6c0e7b7c-d88f-4e63-bdd1-6ea469dbdfff"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("71246719-7df5-479e-916a-6ad78c9f6c42"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("749eb116-2bab-41c6-8a12-ba53f91cf316"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("8109dd4b-c011-4d9e-bdbf-bcc3b1192414"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("81273d50-66ad-4b7c-aae6-67f9c0e4ccf5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("88549002-3213-438b-9029-c9311211d4ba"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("8d754bca-0f23-4d91-93f3-bf20d57081b4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("8d95607f-e1c4-469a-bc63-63b74bfaab4a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("8e2f328b-c3cd-40de-9cb6-74f1435ea871"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("93b686e7-1a84-480e-8a70-757011a04c54"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("949cacf7-6fa0-4f68-8cf8-630f52e92b1a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("9aa40b91-7187-4ce7-a2c2-e2be8f541875"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("9beed781-3f73-408a-8968-7ab2139146f1"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("bdf94390-0d47-49fa-b226-6af9b4e4f925"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("c2bbe8ee-097d-49f9-91f7-27cadd0e8823"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("c500b500-0d90-4ee8-9e11-03f0ab7dea56"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("d1870e6c-cab0-4f1f-b161-545161b07d85"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("f26c10a1-9c28-4250-b06f-43727b2a8f7f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("f4a9f9e7-7356-40cb-8e40-da73f3a214a4"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorAvatar", "AuthorForeignKey", "AuthorName" },
                values: new object[,]
                {
                    { new Guid("085b3d32-7462-49c1-aec3-76f66c466dee"), "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album", 1, "Morgenstern" },
                    { new Guid("139179a6-ffe0-484a-92d1-d67a939f6f3a"), "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232", 4, "Баста" },
                    { new Guid("1a042c70-f725-4142-98e8-7bb3b2c69dc9"), "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg", 5, "Michael Jackson" },
                    { new Guid("2bd905cb-97e4-43db-8eae-4ff7212d93f6"), "https://sun9-22.userapi.com/s/v1/if1/CSm8zW35urd67tfqeWMkGkJsxa0yobAc4rC3_O6Yh4hRi4PJpzyBeU64yDdrZz6P_KYmAD8v.jpg?size=604x453&quality=96&type=album", 6, "Your Favourite Music" },
                    { new Guid("5cfaabf2-eb6a-4f06-b5c9-8c2a0f8b49d6"), "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg", 3, "Awolnation" },
                    { new Guid("61abd222-ce59-4575-8fb7-204432bb5d9e"), "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg", 2, "Billie Eilish" }
                });

            migrationBuilder.InsertData(
                table: "MainUsers",
                columns: new[] { "MainUserId", "MainUserAvatar", "MainUserEmail", "MainUserForeignKey", "MainUserIsAdmin", "MainUserIsPremium", "MainUserName", "MainUserPassword" },
                values: new object[] { new Guid("cd6f1f54-8ee4-4f22-92ef-cc62de87cb47"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", "test5@mail.ru", 6, true, true, "test1", "Qwerty123?" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "PlaylistId", "MainUserId", "PlaylistAvatar", "PlaylistForeignKey", "PlaylistName" },
                values: new object[,]
                {
                    { new Guid("18bc09c4-88b2-490b-b7e5-df40d8484ac2"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 5, "This Is Michael Jackson" },
                    { new Guid("1bffc002-7263-4c55-93d9-c0ed2b13168d"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 6, "This Is Michael Jackson" },
                    { new Guid("39944eaf-f284-49d1-8188-35d579ef2797"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 6, "This is Basta" },
                    { new Guid("49d062cd-a530-42cb-801f-b67e56b3ca8a"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 2, "This Is Billie Eilish" },
                    { new Guid("6db5f9b1-1c33-48c4-8fca-87cda63681e2"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 4, "This is Basta" },
                    { new Guid("6dd9deee-b9d8-4fe0-af6a-7d9b88354de6"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 6, "This is MORGENSTERN" },
                    { new Guid("76536318-44f8-4d71-b3cc-f81a9eba4ef0"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 1, "This is MORGENSTERN" },
                    { new Guid("8bab1d58-fc3c-4692-abac-05f5df5f5bb5"), null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", 6, "dont smile at me" },
                    { new Guid("adc221bf-b735-4f8e-a71f-74defeca6581"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 6, "Angel Miners & the Lightning Riders" },
                    { new Guid("b1777146-4690-4df5-ba43-2206dd50bd4d"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 6, "This Is Billie Eilish" },
                    { new Guid("cc5d685a-65b6-4a03-834b-fc2379cc04d7"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 3, "Angel Miners & the Lightning Riders" },
                    { new Guid("f434eb04-8ce4-40d3-af35-600982ce6657"), null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", 2, "dont smile at me" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "AuthorId", "PlaylistId", "TrackAvatar", "TrackData", "TrackDuration", "TrackForeignKey", "TrackName" },
                values: new object[,]
                {
                    { new Guid("0030e945-e3f0-4192-b1e3-fac41c982aee"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 6, "Happier Than Ever" },
                    { new Guid("13679f91-c84a-4091-86f9-d66ada36d2ee"), null, null, "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg", "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66", 118, 4, "Ты была права" },
                    { new Guid("18b2b0c8-aa43-4004-92dd-4c89f6918308"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 2, "Happier Than Ever" },
                    { new Guid("23553c20-3ee9-480a-8027-ca121faa9b65"), null, null, "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg", "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447", 334, 4, "неболей" },
                    { new Guid("2572ebf2-2f32-421c-8a90-153a4650e7fe"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0", 233, 6, "Billie Jean" },
                    { new Guid("27267685-2326-4ffd-bc37-818d30fa3a22"), null, null, "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg", "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334", 252, 4, "Урбан" },
                    { new Guid("3bc007d5-51f3-4236-be30-c6bcbe2f2722"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1", 288, 6, "Slam" },
                    { new Guid("4994bb7b-344c-4fa6-8c52-c9250efdd972"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c", 258, 6, "Beat It" },
                    { new Guid("4e62db82-eb53-4d91-b0fa-b539b7ea7a2d"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/7qVsMCptRS8tf4eIsQVHYR?si=4fee5f08375049a1", 288, 3, "Slam" },
                    { new Guid("4ebe2fc4-5930-4dd1-a3c6-d41324a2fa67"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/5ChkMS8OtdzJeqyybCc9R5?si=452685936d3646e0", 233, 5, "Billie Jean" },
                    { new Guid("53bd0b36-b237-4055-81b0-4c5e754f2d0f"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4", 203, 6, "idontwannabeyouanymore" },
                    { new Guid("5b1f3b71-c277-463a-a08c-5832212c095e"), null, null, "https://upload.wikimedia.org/wikipedia/ru/0/0e/Billie_Jean.jpg", "https://open.spotify.com/track/1OOtq8tRnDM8kG2gqUPjAj?si=04a0f63ce0394c8c", 258, 5, "Beat It" },
                    { new Guid("6022e362-fc06-420f-9d47-ae6dd9baa45a"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 6, "Oxytocin" },
                    { new Guid("82ab0ac3-bc59-4a27-b236-0625be526c78"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 2, "Bored" },
                    { new Guid("869c7300-7f1e-4633-9be5-8e4e7ad1f07b"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8", 179, 2, "bellyache" },
                    { new Guid("8861fd6e-af9b-4bfe-8051-85589e9be573"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496", 194, 2, "COPYCAT" },
                    { new Guid("8d04e219-c540-4029-85ae-67057084e103"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/5w7wuzMzsDer96KqxafeRK?si=5c7991a726b34496", 194, 6, "COPYCAT" },
                    { new Guid("a27e8c6f-b692-4ff0-a78a-0688ef53d24f"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 1, "Cadillac" },
                    { new Guid("a4acbc76-5128-4bf4-b6ea-07c6da27173e"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 1, "Селяви" },
                    { new Guid("a5cd66fb-af2e-490e-8591-9b41254ceb67"), null, null, "https://lifemusic.kz/uploads/posts/2020-08/thumbs/1597593257_basta-zivert-ne-bolei.jpg", "https://open.spotify.com/track/6xBifM893zgSssatuI6YAf?si=f3abc4ff03074447", 334, 6, "неболей" },
                    { new Guid("a5d17575-d97a-470a-967b-b23d8215f413"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1ni8ZTAY1GHXEFOGHl7fdg?si=e6e975f1853f4cf8", 179, 6, "bellyache" },
                    { new Guid("aa1f14b7-0516-4e68-a6df-a344653bbb6e"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2", 170, 2, "my boy" },
                    { new Guid("b7d2b305-cc03-41f9-86d7-ea25586a1173"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 6, "Cadillac" },
                    { new Guid("c7e005aa-965c-4791-b9bc-db8fba241e33"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643", 223, 6, "The Best" },
                    { new Guid("d63c8cf4-67d3-49d8-b6a0-7ecb14d24ce8"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/41zXlQxzTi6cGAjpOXyLYH?si=124307b3504340d4", 203, 2, "idontwannabeyouanymore" },
                    { new Guid("de68f4ad-e4e7-418b-9bf3-a1978313ecaf"), null, null, "https://nemcd.com/wp-content/uploads/2015/07/Basta-Urban.jpg", "https://open.spotify.com/track/40FJaSjTBdsIJ0upyx4Vjn?si=4fcc0c1805374334", 252, 4, "Урбан" },
                    { new Guid("e573064f-8180-4a72-abda-ac695dd7fd69"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 2, "Oxytocin" },
                    { new Guid("e5e7469c-9554-456e-9f25-7a147bef6cc4"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 6, "Селяви" },
                    { new Guid("e84fffe6-5617-4f48-b77a-8424bb1d7f55"), null, null, "https://the-flow.ru/uploads/images/resize/830x0/adaptiveResize/12/47/06/27/20/5b906d740cd7.jpg", "https://open.spotify.com/track/5ISgcj2vuSrL3FjHHnDPZU?si=bdf8fba16d764a66", 118, 6, "Ты была права" },
                    { new Guid("ec3ff423-01bb-43b3-9421-71c7f1e5a531"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 6, "Bored" },
                    { new Guid("fa5b6602-35a9-41c8-8e7d-fbbe2036e69d"), null, null, "https://i.scdn.co/image/ab67616d0000b27351cbdc2b8a04d0195dd4ab37", "https://open.spotify.com/track/1t4wa5r7E7oZ2D4G07JFsI?si=da1d6a276fa44643", 223, 3, "The Best" },
                    { new Guid("fd56618a-1e4e-46e1-9a38-e9057a2af8ec"), null, null, "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/02/1d/30/021d3036-5503-3ed3-df00-882f2833a6ae/17UM1IM17026.rgb.jpg/1200x1200bf-60.jpg", "https://open.spotify.com/track/1RGasjWLZ4qMN7wbtkLa3u?si=b955ab8d8f994ad2", 170, 6, "my boy" }
                });
        }
    }
}
