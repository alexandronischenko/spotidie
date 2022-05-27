using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotidie.DAL.Migrations
{
    public partial class AddedData12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_MainUsers_MainUserId",
                table: "Playlists");

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("4fba6a8c-36c7-4033-9582-214d2f1692e4"));

            migrationBuilder.AddColumn<int>(
                name: "TrackForeignKey",
                table: "Tracks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "MainUserId",
                table: "Playlists",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<int>(
                name: "PlaylistForeignKey",
                table: "Playlists",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MainUserForeignKey",
                table: "MainUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorForeignKey",
                table: "Authors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorAvatar", "AuthorForeignKey", "AuthorName" },
                values: new object[,]
                {
                    { new Guid("139161d6-dcdb-48f5-8a7e-4adcfb5f433c"), "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg", 1, "Michael Jackson" },
                    { new Guid("35666ad7-f14d-4245-acbb-2c6ef68acbbf"), "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg", 0, "Billie Eilish" },
                    { new Guid("3cca7a34-efcb-4ab0-8b0f-9017da103102"), "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg", 0, "Awolnation" },
                    { new Guid("58867631-9389-407c-84c4-6813a4a8d63a"), "https://upload.wikimedia.org/wikipedia/commons/4/40/Michael_Jackson_Dangerous_World_Tour_1993.jpg", 0, "Michael Jackson" },
                    { new Guid("70404774-488e-48ad-ad84-72edb85eace0"), "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album", 1, "Morgenstern" },
                    { new Guid("70b9e528-e76e-4e0a-9fc1-77de6a6edcf0"), "http://sun9-10.userapi.com/s/v1/if1/CSawlnOoYN9CC6IgDfCSUjqvluyGA9KqvJ8ujexQy5KVmJw5mxnsAxKwBY7o8mazS9svVxf_.jpg?size=604x604&quality=96&type=album", 0, "Morgenstern" },
                    { new Guid("a485329b-1912-428f-8f78-7e531cc18b56"), "https://www.buro247.ua/thumb/670x830_0/images/2020/09/billie-eilish-photos-bodyshaming-01.jpg", 2, "Billie Eilish" },
                    { new Guid("a6814305-95a6-4ea0-a30b-b637d26c3736"), "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232", 0, "Баста" },
                    { new Guid("cf47c616-5244-4969-bf1e-e863da3ee30d"), "https://miro.medium.com/max/1400/1*NhL0RhtXr4tYhYExPyHW4g.jpeg", 1, "Awolnation" },
                    { new Guid("e5f3bb31-cb7d-4add-8d6f-2bd06a8ed2de"), "https://i.scdn.co/image/ab6761610000e5ebf5c9cb7c03d1e4e5226fc232", 1, "Баста" }
                });

            migrationBuilder.InsertData(
                table: "MainUsers",
                columns: new[] { "MainUserId", "MainUserAvatar", "MainUserEmail", "MainUserForeignKey", "MainUserIsAdmin", "MainUserIsPremium", "MainUserName", "MainUserPassword" },
                values: new object[,]
                {
                    { new Guid("0cce5564-935c-495d-bfd2-2f26b65a315d"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", "test1@mail.ru", 0, true, true, "test1", "Qwerty123?" },
                    { new Guid("32a8b9b6-391e-4fc5-a9cc-19a0ab6f5c2b"), "https://i.mycdn.me/i?r=AyH4iRPQ2q0otWIFepML2LxR0MrEgIyhL-Sk3iEO-sagEQ", "test2@mail.ru", 0, false, false, "test2", "Qwerty123?" },
                    { new Guid("5dc759e8-751b-4d4b-9ad1-b717b5f6a6a5"), "https://www.meme-arsenal.com/memes/22a1ada0935edc5a844e4aef793bd20f.jpg", "test3@mail.ru", 0, false, false, "test3", "Qwerty123?" },
                    { new Guid("efbf04a5-f312-432d-bb46-36e5fafb8f6a"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", "test5@mail.ru", 1, true, true, "test1", "Qwerty123?" }
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "PlaylistId", "MainUserId", "PlaylistAvatar", "PlaylistForeignKey", "PlaylistName" },
                values: new object[,]
                {
                    { new Guid("00bb2a94-9812-425c-9faf-e45a80803865"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 2, "This Is Billie Eilish" },
                    { new Guid("3a9220fb-a19a-403e-87ce-334f30b6b7a8"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 1, "This is Basta" },
                    { new Guid("65327aca-c40f-47fb-9e4f-bcbe5412cd37"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 1, "This is MORGENSTERN" },
                    { new Guid("7e976092-6db6-45a2-a60b-dc736cb3d168"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 1, "This Is Michael Jackson" },
                    { new Guid("8b1f7393-11fb-4c7c-bcb5-eb436c7098d4"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO4eXcRP-large.jpg", 0, "This is Basta" },
                    { new Guid("93c52d1c-300e-4e3d-9f13-adab73002190"), null, "https://i.scdn.co/image/ab67706f00000003e8e28219724c2423afa4d320", 0, "This Is Michael Jackson" },
                    { new Guid("d3f3df2a-4f2b-47f4-a488-ee0368a14bcb"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 0, "Angel Miners & the Lightning Riders" },
                    { new Guid("d5fd5c5c-d6aa-41fe-992c-ae3f0cda8d9b"), null, "https://thisis-images.scdn.co/37i9dQZF1DZ06evO0vvwas-large.jpg", 0, "This is MORGENSTERN" },
                    { new Guid("e638e1cf-35aa-4712-957e-336ab60dd235"), null, "https://is5-ssl.mzstatic.com/image/thumb/Music124/v4/19/97/5e/19975ec4-e9a5-0e07-0600-8592238a1765/849320046806.png/1200x1200bf-60.jpg", 1, "Angel Miners & the Lightning Riders" },
                    { new Guid("eb443618-0c55-4b6f-a594-20e21340b9dc"), null, "https://i.scdn.co/image/ab67706f000000034d26d431869cabfc53c67d8e", 0, "This Is Billie Eilish" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "AuthorId", "PlaylistId", "TrackAvatar", "TrackData", "TrackDuration", "TrackForeignKey", "TrackName" },
                values: new object[,]
                {
                    { new Guid("70c4d09b-ad6b-44b1-b56d-3cdadbc36674"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 0, "Bored" },
                    { new Guid("79eb6f3d-8d15-4fdc-a283-c9dabe350be9"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 2, "Happier Than Ever" },
                    { new Guid("8c3406c8-2dd7-448f-ac47-70e554a4138a"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 1, "Cadillac" },
                    { new Guid("9d721549-ca34-441f-9f49-ce00f3f26408"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 0, "Селяви" },
                    { new Guid("aa7ee17b-e78f-4745-84fe-703f505c3d2f"), null, null, "https://upload.wikimedia.org/wikipedia/ru/4/49/Cadillac_%28%D0%BF%D0%B5%D1%81%D0%BD%D1%8F%29.jpg", "https://open.spotify.com/track/3aVNCtmLR9BSgFALSySejF?si=c4bac8e332144863", 177, 0, "Cadillac" },
                    { new Guid("ab84cec1-7445-47ee-855c-04f86cd39173"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/4RVwu0g32PAqgUiJoXsdF8?si=62abafa4e4da4f89", 298, 0, "Happier Than Ever" },
                    { new Guid("ad0496bc-195c-4685-9f4d-00335b138dca"), null, null, "https://lastfm.freetls.fastly.net/i/u/ar0/8bccd9c4336ffdbe502671287bc1b85c.jpg", "https://open.spotify.com/track/04sN26COy28wTXYj3dMoiZ?si=bccdf3f86317456c", 180, 2, "Bored" },
                    { new Guid("ad34f2e7-919b-4878-843d-7dade9a5cc22"), null, null, "https://i.ytimg.com/vi/zdUIpi3WC5s/maxresdefault.jpg", "https://open.spotify.com/track/3SOHFsSinxM6flLceYl5BT?si=9a73e3a45760441c", 160, 1, "Селяви" },
                    { new Guid("f2f37a0c-8658-4217-9b43-0e632f73d0e8"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 0, "Oxytocin" },
                    { new Guid("f5d0f84f-d459-4654-84cb-6c302157d445"), null, null, "https://spiritofrock.ru/wp-content/uploads/2021/10/Billie-Eilish-Happier-Than-Ever-Tour-1000x600-1.jpg", "https://open.spotify.com/track/0UJAH9v2PmS7sBcuBquprR?si=2fc802a0d83c4470", 210, 2, "Oxytocin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_MainUsers_MainUserId",
                table: "Playlists",
                column: "MainUserId",
                principalTable: "MainUsers",
                principalColumn: "MainUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_MainUsers_MainUserId",
                table: "Playlists");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("139161d6-dcdb-48f5-8a7e-4adcfb5f433c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("35666ad7-f14d-4245-acbb-2c6ef68acbbf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("3cca7a34-efcb-4ab0-8b0f-9017da103102"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("58867631-9389-407c-84c4-6813a4a8d63a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("70404774-488e-48ad-ad84-72edb85eace0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("70b9e528-e76e-4e0a-9fc1-77de6a6edcf0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("a485329b-1912-428f-8f78-7e531cc18b56"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("a6814305-95a6-4ea0-a30b-b637d26c3736"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("cf47c616-5244-4969-bf1e-e863da3ee30d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("e5f3bb31-cb7d-4add-8d6f-2bd06a8ed2de"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("0cce5564-935c-495d-bfd2-2f26b65a315d"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("32a8b9b6-391e-4fc5-a9cc-19a0ab6f5c2b"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("5dc759e8-751b-4d4b-9ad1-b717b5f6a6a5"));

            migrationBuilder.DeleteData(
                table: "MainUsers",
                keyColumn: "MainUserId",
                keyValue: new Guid("efbf04a5-f312-432d-bb46-36e5fafb8f6a"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("00bb2a94-9812-425c-9faf-e45a80803865"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("3a9220fb-a19a-403e-87ce-334f30b6b7a8"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("65327aca-c40f-47fb-9e4f-bcbe5412cd37"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("7e976092-6db6-45a2-a60b-dc736cb3d168"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("8b1f7393-11fb-4c7c-bcb5-eb436c7098d4"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("93c52d1c-300e-4e3d-9f13-adab73002190"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("d3f3df2a-4f2b-47f4-a488-ee0368a14bcb"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("d5fd5c5c-d6aa-41fe-992c-ae3f0cda8d9b"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("e638e1cf-35aa-4712-957e-336ab60dd235"));

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: new Guid("eb443618-0c55-4b6f-a594-20e21340b9dc"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("70c4d09b-ad6b-44b1-b56d-3cdadbc36674"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("79eb6f3d-8d15-4fdc-a283-c9dabe350be9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("8c3406c8-2dd7-448f-ac47-70e554a4138a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("9d721549-ca34-441f-9f49-ce00f3f26408"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("aa7ee17b-e78f-4745-84fe-703f505c3d2f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("ab84cec1-7445-47ee-855c-04f86cd39173"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("ad0496bc-195c-4685-9f4d-00335b138dca"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("ad34f2e7-919b-4878-843d-7dade9a5cc22"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("f2f37a0c-8658-4217-9b43-0e632f73d0e8"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("f5d0f84f-d459-4654-84cb-6c302157d445"));

            migrationBuilder.DropColumn(
                name: "TrackForeignKey",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "PlaylistForeignKey",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "MainUserForeignKey",
                table: "MainUsers");

            migrationBuilder.DropColumn(
                name: "AuthorForeignKey",
                table: "Authors");

            migrationBuilder.AlterColumn<Guid>(
                name: "MainUserId",
                table: "Playlists",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "MainUsers",
                columns: new[] { "MainUserId", "MainUserAvatar", "MainUserEmail", "MainUserIsAdmin", "MainUserIsPremium", "MainUserName", "MainUserPassword" },
                values: new object[] { new Guid("4fba6a8c-36c7-4033-9582-214d2f1692e4"), "https://i.ytimg.com/vi/3UF96jzrX4o/hqdefault.jpg", "test5@mail.ru", true, true, "test1", "Qwerty123?" });

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_MainUsers_MainUserId",
                table: "Playlists",
                column: "MainUserId",
                principalTable: "MainUsers",
                principalColumn: "MainUserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
