using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JERP.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLicensingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_FASBSubtopics_FASBSubtopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_FASBTopics_FASBTopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("006afc48-bb4d-4daa-a06a-efc1ffd52b42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("01cfd371-a7ee-4281-87ff-3f68b2f9c41d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("02139fe6-c949-435f-b886-0398600b0a9d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("03eab407-68a7-4c8e-a284-e8e66465f662"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("054ae04e-ceba-450f-99fb-b2937f57e2de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("05788d35-4286-4ba7-9586-7e073aadbd94"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("073443b6-057f-4489-982d-fa192dfea3f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("095098b6-518d-4733-bd56-28ec782dfd0b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0a7381aa-fa67-4e11-b8c4-950489d9205e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0b5b1bde-8b0b-4f2c-891c-54bbc352796c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0e17efe9-19e0-4f3d-82b3-0df30f51e40c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0ef65bdf-5466-452d-9f5e-3ed5f531aed4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0f2e5e09-ff1f-4f8e-b108-b1e168732700"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0f494812-e424-4013-b8c1-7790d1cdd34e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0fded2d2-1a3e-489a-b041-b1d5dda46182"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("11007b8c-cb60-4a1b-8d23-c0a5ca690c75"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("115ddac9-69f8-4710-a1fd-54771966f318"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("11bad2ea-7e97-4501-8147-87757ce97323"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("120bc7f6-99ef-4f4c-8369-c686f04183b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("12fd3a8b-f9a2-4c38-aef9-36525d6c1818"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("13d6e2c2-e47c-4cfb-8d97-603330444378"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("162e4908-3ce5-4692-a83f-0100e2746ba6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("17737085-54a3-4723-ba28-8c73ddf89d56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("17998002-0fd1-434f-a563-e705879f01bf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1a557148-aec7-4599-af80-011a77374262"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1b504b7e-34e5-49fc-a658-a3254ef26813"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1c25fed3-f860-4631-b523-c65531ef3762"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1c9e0bd7-2251-46a1-a782-b5a5e401c1df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1cce5572-46c2-48f8-881f-84958cff2b83"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1d771ad0-8a13-4323-b349-c5bf5070aef7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1f30ec5d-24b8-4de3-bad0-5c85ed843671"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1f901080-169e-468f-ab51-691fe0cf079c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("206e39fa-6af9-4b51-b4f4-56b894ede286"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("20ea0702-61f0-4e8f-bd78-1bf0d211e45c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("20f1812a-588a-415d-a557-2f2864eab331"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("212f0997-9dca-41fb-9bf5-dea6148790fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("23b43bd5-78a1-451c-beb6-4463ed9429fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("24477952-a987-4136-96a2-819f7b2f385e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("264aa248-93d7-4bf0-a253-7d9077825257"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2684bf37-4bbf-4b17-8467-ce36d5327a09"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2733e275-1701-40fd-bc55-7ca2dd486c15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("27ca4619-4681-4593-b53e-f5ba4598469a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("28abb56a-30df-41eb-afac-9bc9626d99bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("290fb12c-254b-4352-8f33-06457e38aaf3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2a3e0cab-fea8-46bd-b9f2-8d99c999ebb1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2a9678c7-df12-4219-9254-093dc52d7647"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2ae640b8-2791-4dec-85c1-df98d3870fac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2b2d8202-313b-405f-8a2f-37c741c550ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2b6f4abe-d73c-4c43-a806-e7fb6fee2c89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2df53f2a-ad80-4378-b4e3-e25d2f20b53d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2e5e3bd9-3192-4128-962b-b96e109bc3cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2e6790d4-b06b-4577-9efa-a5ca7d524174"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2f5347ce-dd0d-4641-9faf-6cc055f9e173"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2f77e28a-83aa-456a-a91b-e28b7cb5d575"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2fa706e3-2d98-486f-b560-1288bda2612d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2fe77f84-b13e-40ce-a392-08bf3fb00c45"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("302d8abb-399f-4e82-ab7f-676c2aef6203"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("308a0402-c861-49c4-a448-4d21279aa0f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("30e3a467-2aa6-4e6c-99aa-5a49939b401a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("31276716-b39c-41c7-8443-78093775e925"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3196b28c-e891-4b72-a880-031656f1c7d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("32375f76-0d00-43f0-98c9-a6bec042dd25"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("32bd5ec6-b19b-478c-9d55-da2f437809b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("32ee97a9-19d5-411a-8573-e0d096392270"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("332d3abc-d550-4e12-bf6d-88641c8c7826"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3342e8b8-8f68-4822-a373-11d85bddbe0c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("34771f76-5428-4f7a-8e3b-cd48c020aec4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("34e236c1-c0fd-40e5-8379-cfe7a78abc26"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3510bc13-9338-45d4-b7ce-93f092eed3cf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("351c82e6-0517-4439-a401-b58b18b1a3c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("36255ee6-4a70-4668-8424-17be68541544"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("36d79ca7-9c8c-46b5-a9e1-c8d2f65ef4ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("383eba15-e13f-4fe6-a49a-0d1b85f84e91"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("38806a68-6d44-4f84-b37d-7e1fc73c89b6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("38de07f4-7f1b-42fa-adc6-7e38a96ba562"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3a324e3c-fb84-4ae7-9dda-44e18cfbf233"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3a775203-cac8-4279-8b42-c07635408d64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3a883878-074f-4b94-9856-d74fda640d8e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3ae23533-2c0b-4ca7-8e58-4ec845a3454c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3af0a415-b4c8-412e-b1bf-b2f06a3f8052"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3b1c3de5-6c81-4d6b-af3f-e305d5508d1f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3b394308-5485-4f63-9fb3-3a3380886123"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3cc95d57-9d67-45bc-bf7d-901616caff30"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3d1ff7eb-a1c9-4dc1-9370-a8f4ade878a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3d511cc6-f98b-422e-810b-80c21a900546"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3ea2d7c2-306c-416c-a700-9701ea3d66db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3ed6b758-e77c-46ef-8b3b-8ed0851a2473"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("40cdb484-e0f9-4cf5-a569-3e3cf4228d00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4113021a-f8db-4705-b3a2-02a72a18666e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("42a27edd-5352-4700-b6d2-2cd5a5e75a66"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("43dee448-6ea4-4496-a02d-d384ac892ff5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("443f8888-9cb4-4c90-a1d3-c506fb7df591"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("468f6232-8eb2-4e21-94a7-ba6550719192"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("46fc0bf4-2a93-4bf6-ae71-d9a2bb4c3cbd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("48766df4-6970-4faa-b995-b26b5890c413"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("49c2ae54-f237-4030-83ae-a08899459468"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4ac3fdf2-2320-4c5e-aed3-f8ee9c42f52d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4b656b6d-0ba2-4fe6-b93f-69cda18bc20f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4c7d8cf2-5296-4c67-ab1e-4b4440a164f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4d60abfa-b25c-4eef-9d78-a0e57d93146f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4e0da4c1-2ffe-4d68-852e-ebce5b4cfbe5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4e204740-02db-440d-8d38-cc628eba2e00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4eb34567-dc5b-4d5d-afd7-5d25ef509e34"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4f5a5c28-0583-4ba7-8433-54e9886ca585"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4fdf5b58-25df-433e-be2d-4941ad548df3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("50c96d93-22eb-4068-857b-6f3e24e1f75a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("511482f3-e79a-44ad-b169-598b1d749902"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("51dda8a2-150e-410a-81c1-8f8ed77d1c89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("526e70a2-0679-4cb4-bf68-bf930bf019b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("52aed62b-f590-49ee-b4b8-8a42c9515806"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("53872a41-c248-4e6d-b278-e57c3866afcd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("53b31ede-1d1f-4b9d-80ee-42cdf44c0ca1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("542783dc-bc49-4240-b934-8a981fe6f3f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5492dc15-2dfd-4d1b-aafd-138c16e81da9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("55ed87eb-fc6c-4c78-a2c9-221c86646092"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5695e75b-560c-4135-be53-4ab2fcf52a6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5725ca32-f32e-4506-ac2a-afe55645f12d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("59c90420-f536-4ab0-a092-b0f9e6f1d3c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("59ef7798-e41f-40ad-be65-8bcc507f55a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5a864278-51fc-45bc-bdbd-0c879c429154"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5af7a7c3-110c-47d4-aa52-5b7510a26aeb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5b035f34-fe03-49d5-a0e5-8fa9b3910df3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5bf0029e-7355-45f6-aae1-00811ae40ff8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5c4ff64e-d71d-4965-a438-667142ff63e6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5c542d87-4436-4d6a-97a1-e39bd145376f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5e70a924-bbd6-4350-8aa2-ca33993f9af5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5fbb0ee2-bdeb-40af-b8aa-2b10dfedd82d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6034bfdd-b3f9-49fe-88fb-56341290e3f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("60cd9973-a01f-4997-bc46-4a0d281fd7e2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("612fd488-13ef-417a-9ac7-c53eb761d372"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("61b03f62-5e8c-4526-b05b-9a6ddec97583"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("61e82f04-c0f1-4c0b-92dd-8377a12b2c18"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("61ee0edf-8d5e-4e9a-a7ca-51ed9aa09166"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6212fc8c-f53e-4615-95e2-7f5f4beba0ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("62b628e2-f706-4949-a3e1-5a08941cfa88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6334ea8e-5322-42bb-8d26-e35b49d38ce9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("63ba1212-d384-4ff6-bbbb-54c5c49efb4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("63c30b3f-0928-41ce-8391-037655384e7b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6466bbfb-381b-45f1-a951-65d4aff05b77"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("649e4ce9-75c9-4a50-8567-931cf701da76"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("653e60d6-ea67-4ba1-b3ff-fcba0fe60afe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("657f3216-e42a-4b10-be0b-9c4399bd94c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("65e1ade8-d72f-45d8-997f-696080765893"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("677763d1-d1f2-459d-9364-e7158cf40eae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("69184902-221e-443b-bcde-469e3d2d6bcc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("69c7fcc5-e58d-4922-89a0-3571de2223f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("69ef82b6-98b4-42d7-a275-2e45e081d87a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6b02abd2-4886-4f98-ac62-c2ea001a55bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6b7a8dc7-ae1a-4a8a-a23f-67f10c034f8a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6c10f3e7-e5e5-42d4-9b4e-5929f0f2b85c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6cff6635-e8e2-4343-b7fb-8f9156326122"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6e66146b-197f-49ff-9639-a2f4d0d9fa31"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("707e726a-52ac-4f4f-92cc-0b5ce8c379d4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("70cbc79e-accb-4ecd-b4a6-e7a4ba5a5a17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("70d5641f-1125-4d0f-b28b-eaae857ba773"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("712b089f-5b12-405d-8638-3ad0db533738"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("72053b56-31fe-4481-a1a6-96cc5b9a95f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("72187175-99d6-4ab5-9cca-0dba084fb95b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7248046a-a071-4546-9662-fe3d82bab4d0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("75065260-728d-4db4-b420-4f6e0b5b048c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("75c63d98-7311-4640-89d6-7c1c4b47918d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("763b7b4c-51b5-4174-910e-06bf67dfc224"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("768b2224-fd7c-468d-bf47-f5bde7893ddc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("785fa3c1-5720-4152-bbd7-8558cd275065"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("79d65b23-5657-4d8c-8fe9-05e70e224ebf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7bb515ab-0f6e-4019-a952-2a91fd8f0805"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7c6c9ddf-80d4-4784-b1fd-c17bf18e583c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7ca07817-c869-46ec-8d21-555cf7897638"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7d94e11c-f1fa-4ef4-ae63-6b95745732c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("80c1c487-4f5a-4082-8685-7283b7481fe6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("82de3b3b-dd17-4607-85e6-c4fdfd79b39f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("82fa8157-35c5-4577-8be1-21305753fb36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("832560d5-e0f3-480c-9df1-f11656600232"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("83392d6c-10a4-4a3f-a096-82631a1b6db3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8400f141-07b4-4182-9e36-d051465d2a89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8432cd01-b516-4d73-8efc-b0f9ecf74223"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("84c3f9e6-b037-4611-ab0e-397d6860fab6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8552d153-5e88-46e6-80bd-d65f84cc516c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("859d56dc-90c0-4df3-8b14-d69fd2a8a507"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("85dacc06-3fcd-46a7-844c-b9bcefe01f1b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("862e2ba2-3f1b-4168-9cf3-08254ff8c84f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("86551bae-a9ae-4eba-8240-e0d2e76f48d0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("86e83ceb-b598-46b5-90a4-958f367b4886"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("87842a1e-1daf-4ef0-8fe0-0cca273e076d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("884abe49-ecf4-4d33-9832-ff7552291759"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8987e20a-c2e1-4d30-9f73-12f8f76e8e23"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8a80be9f-3b80-4e8f-80f0-c2ae554cba87"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8a9dfaa7-2824-45d6-9536-dfc59551488a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8cac6ec4-d53b-44a5-a776-b15c5dcd7860"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8cbb5133-56b8-4fd7-ad2d-bb2311892a24"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8d40353a-0572-4f63-983f-f9963c2371b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8f26b1ac-7a55-45fa-96ee-edd7b4235d93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8f4bfc63-b48e-417d-b2f3-54c6d5f8900a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8f4ec71e-167f-4dd5-a56d-c8ef4e731f7f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8f7d015f-97bb-48ae-b051-f21d34037e44"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8ffa20d7-e8b2-4329-bb57-f89eaaf288d3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("90983952-8dce-4f74-927c-833da5667353"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("913622d4-5e5b-4562-8733-34d72d4e9e74"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("918a9afd-e20d-4c66-93e8-4c3288aeab3a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("91b157a7-0de4-46c0-b2d0-e490acbad717"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("91b5fc8d-3913-401b-a876-076b7200994c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("92c24558-c8ae-447d-91e9-ca28c2a5e0ba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("933785d6-1089-4d01-b85c-b70363dd751f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("945ea77b-ca50-4467-92b2-b8d3a010c29e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("94bec5cd-e754-4042-a990-69aeeb365c03"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("95b2a906-1ed8-490b-8d12-09cd2cd16f58"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("96320718-7b96-4187-888f-a4bfd77fdae8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("966c6a84-72b4-4441-92d6-5259aff9d743"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("96bdd269-61f8-4f4a-85af-93f729e8ddd3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("977f3665-55bb-462e-b895-87ed6db6f69b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9784b037-d171-4bcf-9a50-293ea7fb31d2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("978f97df-a81b-495e-9c14-253a3f8227af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("97c2ff6d-676d-4344-966e-a048a35d3ddb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9879f86e-c5e6-4020-a5a9-37f2a7ba8c73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9b9bebd3-f38f-43a7-b2a9-731364a212ba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9cacb247-661e-4308-b759-388c3ced129a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9d18d787-15db-41f2-bdd8-5a4829f9aa26"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9d85e686-8d27-4502-9eab-93d3fc9afd31"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9ddb2cc4-1f0e-456c-b266-965a1579c98b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9df2291a-4475-460e-be1a-0bc8fe0778f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a159e660-bb27-499d-b458-cfc4cb9770a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a1ef57a6-2bba-4ccd-8e89-27658a0aa17b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a20f8ef1-fd78-4ead-918a-ed29373887ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a2801c3a-a7db-409f-b2db-ed0eb2cb4676"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a2d5161c-4138-4378-ae85-c47f5794dc06"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a5c91a1d-d46e-4827-85b0-1c290ea27a1e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a5ee9ff7-a9a6-4e60-b686-d84a837b0e29"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a5f5445b-cb53-4377-8545-84fd0d39882a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a6da4411-39e2-46e7-8cd2-5b8772fa96c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a6e26866-727f-4703-83fb-7dea1e5fd600"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a7471542-51b0-4b2d-ba4b-5e11e1ff1cb9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a7a5a21a-b407-4e09-9d4b-d394dea84252"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a7fa6116-6864-4021-b583-bb47dd165f30"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a82e25cb-c9d5-4a84-9dc5-8e5165dd139d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a9382478-5890-4c1e-9be5-3fd1daca0d73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("aa5fbe22-f69c-4036-9127-dd8529167c87"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("aa97997e-4137-4acf-bd51-352d63ea28b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ab240088-4a18-4e41-9292-2087c019b15f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ad7c10f6-8523-498d-b04c-bceb509d3974"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ae7ffcf3-7b0e-4e0f-bcdb-d86b5811ea2e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b01090ed-771e-4111-8ec1-63ff7e9935bf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b0118891-a710-4615-a804-ee2516d0f3e4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b088a41b-c7a8-47a8-89dd-58cdc7876105"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b0d50f0f-e3d6-40ff-94de-8b7c6fc9695b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b10de13b-014c-49ff-96c2-93e52c7bbc61"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b170bc18-ac47-4c86-9330-59e8f452aba0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b268f77c-4f5f-4e09-bda3-7fe1f1d1696b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b2d5a544-9350-4290-a292-353601feae2b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b34531a0-8cc4-4641-b5df-2d05c0e502f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b5f97618-779e-4a83-939b-3072a6c6422c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b7048920-c5aa-4762-9f0d-346cb0e7cd66"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b83079ac-9248-4103-a191-e54b12cee5e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b891cb1c-852c-42b9-9d59-e576d1653a20"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b89528ec-1fab-4294-b9c8-8e8f9eb40d22"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b8d72613-5678-4999-b5f5-c74455eb7ae0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b9232506-d812-4e57-99d2-d1c58fbb0034"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b930ef8e-9a68-4edd-bcd4-c3df358d6c27"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b937dc32-669d-44b3-a563-3e4409872e95"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b991847d-8de3-4fe1-a8f5-c6af145746f5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b9f1c190-7d6f-46cf-91e5-84036f071d48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b9fcc2b6-e91f-4385-8fc7-43cf14859d16"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ba43060c-b207-4019-a33a-c97cf2933024"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ba7a5223-7c9d-4531-a801-2fdf3b6e7858"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb1b3f59-7e17-49dc-acbe-5d65741edd24"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb282b37-5f9e-4636-a0e7-f3951f848466"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb72f98b-d392-4400-ac8e-b8c2d4b0229a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bc3aff30-cb44-4e8b-8e19-cfa739afc31c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bd77d122-ad67-4873-9032-0107b4f9a371"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("be6fa73b-a62c-46c9-a272-c916e922a653"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c0856748-76dd-4196-9967-7ddb96ac28a3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c11d530a-ed89-4045-97c7-d6e1bc673285"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c1b613c6-7508-4441-bf7f-9dd749c221e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c264bc8f-372d-41bc-a305-641a7acf4f4e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c4462925-b821-4e10-981b-9062597e4e67"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c4ae74bc-839f-4f89-ab6e-6ae9610b6129"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c7a33ad7-e706-4213-a1cc-959023f4fcc9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c9774100-3146-4d99-865e-37d26be54f17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ca1370aa-2daa-451c-8db1-86a89e1335e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ca2ccd56-ce08-4c71-b4ef-b38de616ff28"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ca36d2b1-317d-49cd-a72f-ae4cbbc783f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cb3bb55c-364a-45a1-bb5a-8c23a86ff846"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ccb4c09c-f3b0-41f7-8dce-62984a765c61"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ccbbed03-0896-41ec-ab9e-62336018c1b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cce28a7d-4034-4cfe-97c0-bf57f46c69a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cdb826b3-c308-4890-8740-1ae607ce5192"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ced9b602-82be-4c4c-bec1-ce1006ef7fa5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ceef44e8-d813-4c45-ad63-f11f4ec6da68"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cf188434-114f-475a-8eb5-1a07b63db612"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cf7bc84c-d954-46e8-9bd7-92d197fc4ae1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cfb89a0d-033e-4d4c-a1df-e547dab25fa6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d114abf2-a0d6-4ca8-99e4-6a8ce6fee0a7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d3952621-60d4-4533-b418-c09324304328"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d4029560-12ee-42d8-a268-4cfab2eb42d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d4785396-d91a-42c0-a818-2ec0a97a6b88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d482491d-8c10-494f-91ae-cccd7ea4febd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d584e1f4-3ca0-48be-9722-1566e1b0daeb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d5884d3c-080c-4c3c-a92f-27567a1e112c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d5bf2853-a771-431b-a727-d84b34d70b51"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d5bfe6d3-d35c-4aa9-9b6a-63452720b555"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d6188a7b-5df4-4178-9cce-eab5aa681190"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d65639bc-dbac-4a67-a8bc-d59c0af3e374"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d7132967-f2e9-4c5b-b17f-70d72ab03c89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d7e5deee-9187-4531-a53e-cbf0cdbfe17b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d9a1f9d0-03ba-4551-a0fb-80e976568d40"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d9c2fd7f-57eb-4ad7-9dee-75e8bb299a42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d9e09e52-e687-4b68-af58-c6f609f3ba3f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("db6c6268-5ac9-4a18-a797-3085957d9ae8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("db893652-241b-41dd-a079-70ccfc519a09"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("dd15cabb-0247-4f76-a499-39726c0f3c3c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("dd8133de-2045-423f-9888-9ff07c5d8a15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ddfd5513-dc96-490e-a912-a8b64f9c62c1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("deccbb30-9212-44cd-b83d-229f9450a82c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e1623c5e-f5f2-40ae-a515-94db29591907"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e2020cc6-1032-4e84-8b2d-b41dddb48bf0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e4494f16-295d-4de7-9934-da31e1647154"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e493ee8f-dd0a-43bc-a1c8-3b29ea72cffd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e64da626-b5ed-4c29-94e5-edd0d3f6066a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e6c6debb-b9a8-4f0d-b137-c479c0db4941"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e6ef7e1d-935e-4c0a-bbc0-5e1b95c62755"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e7780a84-1dfb-41ab-a7fd-52eabd072a8d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e7baf798-5770-4f14-a82a-f40164bb059d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e9d94689-2b1c-4250-aa64-c8dbe386270e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ed3b7131-e1d9-4c61-9d9b-83327e46ae0d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ee93ce2a-0b2e-4421-a362-e49340e5fc91"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ef42e821-e09a-4405-8f25-a0782b53364d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f0611c17-8940-4311-a477-3fd0efc87721"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f07b192c-5096-45a9-87ce-9786039afd2a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f1435e20-a012-408a-8f1a-83abb5f386ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f144a4de-f67f-48fe-9862-78da8682a85b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f3ec4be7-60d2-490d-89d0-02cb6e6d1e93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f5a65d80-7c89-4e7a-a280-d0cb47ec61fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f5afb076-246b-47c4-ae4b-a8f296682634"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f5c6f7a3-13ea-47db-bb50-981d36bd3a77"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f664b54f-0cb1-4b38-b0fc-1ab737a6bb61"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f6c96070-f5ab-40e0-8d65-f31c6d9e77f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f6eee19a-3c6d-47a0-838f-cd033b7c4c03"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f74b15a6-2ccc-4f00-94c2-21e9e0735b65"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f7703242-8697-4eff-bf15-2fbbd1779837"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f7b9e500-dc45-4aae-952f-5d95442a28ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f877d306-873f-4add-9b07-b65a8ad5d5c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f89975ce-be91-4330-b01d-8b01a3bc29f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f8d3b8b9-d448-4527-8cca-d01b5bc06005"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f92c72f2-cc66-4b1b-b583-b303881aca15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f96041bd-7ff0-4764-bf89-897e00bcf86f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f96aac50-f697-44b4-b8da-21c69eba1b3c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f9964295-7507-4b2e-ac53-7d8698e35996"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fab2efcc-2dc5-4acf-a10b-a32c07aef997"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fbd89cd0-1cb9-4eba-8709-8c82f09ae56d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fc846537-8634-47a4-8084-60dd52d20c0a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ff622bb8-b1a8-4236-9cee-d4320c52cbbe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ffd91a95-f58f-48cf-bae9-2b4b935686bd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0a80cf3c-126b-499b-adfc-90365ec76731"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0bab2718-4916-4468-9993-8572a6882f7f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0f82980a-1dfc-419a-b99a-fa081c7d7589"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0fb93137-ae54-4758-9933-881c13b20809"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("11ddc8e2-1154-458b-9b7d-15f1def71110"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("13f1aa2d-9cab-4e47-b016-ebee1899826d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("140669f0-9543-45bd-ae29-765473abcfe7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1e7905d2-5e14-4190-b0e3-44584949a981"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("2051ef90-2112-4e62-bbd7-fed074247313"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("20b16cc7-30b3-4e6b-b7bf-bb551e2b0b35"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("20c94d8d-3a64-4858-a19b-a0834e5eda87"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("26b0bc87-ba06-42b1-95ef-b47413d5f0ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("26e07710-3918-4bf0-b327-c6466e635576"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("311082fb-cca2-4507-a64e-64b7998debd9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("331a667b-c7c5-45cc-8c5c-04a93807034d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("33603828-3d97-4630-aa08-30182a3116b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("37cd1131-3500-4c1a-90ce-b9dbfcb806e9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("3995e9be-88fa-4f50-9702-6c0cb0e44636"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("3ebaa5cb-e6b5-41cb-bb33-a715ea5d086f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("3f5b3a32-9bd0-4245-8c92-88410cc3b83a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("40843736-5c8d-44d0-8a81-b7304b276609"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("48ded176-92fe-45d5-a422-0ad570370a88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4a7b9ce7-07a8-469c-b63e-51acb7ca8e4c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4e7dfdfe-0ba5-4a5b-9902-1e26a45abe1b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4ff63ca9-8e4f-454a-9df9-0d6ca1a213f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("508a714a-ca3b-4acc-9e44-97857ef949fa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("508cf940-b141-4f77-9bdf-aaf0dfa15075"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("54dd4c12-c037-4169-84c8-78da96e26e1f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5a5dfcd8-d1a2-40f1-9edb-03c01e459145"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5bdae584-cd61-4471-9481-2200f1daa86a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5c7a4384-70cf-4959-ae78-252f029a08e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5d6fd464-38a4-47db-a2b0-d43c3f2fa319"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5dd91913-6cc1-4134-abb9-6034604f53e7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5e6cb7d9-0cb6-4f3b-a165-e56a8923337d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("6084f16f-0cae-4b5e-91cf-a8a2602581b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("612110f5-28e0-4b9a-9661-d4921d84e22c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("6c5bd89e-91bb-4057-bef0-5f6589b0a629"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("6e6d7609-fffc-45ca-b9f6-0ec66d3316a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("72b48ffd-3ca1-4a63-93d9-5082f902a89e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("73bdd1e8-dcf8-482a-8ae4-ef2b1673c8a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("73c3f842-71ac-449b-91b5-14e7999c2226"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("7a99ca57-ff36-4cd5-9458-58729748dea4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("7fcec6a5-68e6-4e7c-94f6-1c7f4f4189d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("80388014-bf69-4c8d-a6df-0e7f963073e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("8556d81f-1d65-4f82-b254-b098d88a460e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("868579dc-b374-4864-8380-f7fe6d73f438"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("8c233cfd-d89c-47b3-a08c-c123fe2f674c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("8c8da832-9a43-429a-93f4-865a3f5c3a8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("8c8f4c68-7004-49e7-80f2-1efde75c55fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("8ff41b56-db70-4785-9b6a-72731c7aabab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("90855ac4-9f5c-4d4a-a187-5efaf9f29c35"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("92d6440c-f5b0-4d5a-b349-e050ce561315"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("968d2799-9a5e-459d-a781-762af032cba2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("98203b8f-8f43-4c82-a0e1-f78acb36db24"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a565b1ee-acff-4236-96de-b7bb96620f4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a57dec8c-ae88-4d01-bfd8-7d01660da54b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a7a4e2cd-9c72-4531-a004-bc716420cbc4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a980c07a-27d2-42fb-a3a9-853b8e2858dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("af448d74-6f8f-4f1f-b189-05b63f7d3806"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b4b4b69b-223b-41f2-b296-517c26c1c1bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("bd35979f-8bc1-4b02-83c2-006fe0ef8a2e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("bdd61938-8803-475a-9a09-7a9fbfd0f5e8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("bebfc796-5a16-4902-8d02-39a3152984d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c0811370-c923-4771-a419-9e06a60afeaf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("d0657f37-3d70-4f1f-b88a-4b3ba2e74c38"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("d43d4832-2dcb-4cac-b837-a9dad2ba16eb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("dac30188-680e-46e5-97ff-efb3a0de4801"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("dda2660b-f000-48a8-b02d-d31029e07cff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("de8c2abc-63d9-4ced-aa81-8ae605379d73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e11e1e10-fa8f-43b9-be78-a91c68791130"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e4fe5587-f9ba-45d4-aae6-18b4f098ae04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e931f435-ae90-40c4-b044-c3f2c58646e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("ec7225f8-c8c6-4530-a1db-a51d385facf7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("eea6366a-82a7-4672-8f59-fcbcf64abdfd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("efa8e7f4-0a44-4537-a0cc-1ab0480a6627"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f73eee2c-ae4e-4ef5-a720-2d56e5399c09"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("fd700a75-fef2-4700-8dc6-4215819155dd"));

            migrationBuilder.CreateTable(
                name: "Licenses",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Plan = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxEmployees = table.Column<int>(type: "int", nullable: false),
                    CurrentEmployees = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MaxCompanies = table.Column<int>(type: "int", nullable: false),
                    CurrentCompanies = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MachineId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StripeCustomerId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StripeSubscriptionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsAnnualBilling = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastValidatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SONumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedShipDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PromisedShipDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShippingMethod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShippingTerms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaymentTerms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShipToAddressLine1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShipToAddressLine2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShipToCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShipToState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShipToPostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ShipToCountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalShipped = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalInvoiced = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFullyShipped = table.Column<bool>(type: "bit", nullable: false),
                    IsFullyInvoiced = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalesRepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SalesQuoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SalesQuoteNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerPONumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    InternalNotes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    RequiresMetrcTracking = table.Column<bool>(type: "bit", nullable: false),
                    MetrcManifestNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrders_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalSchema: "dbo",
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCountTracking",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeCount = table.Column<int>(type: "int", nullable: false),
                    RecordedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCountTracking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeCountTracking_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalSchema: "dbo",
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanFeatures",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatureCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FeatureName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanFeatures_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalSchema: "dbo",
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionHistory",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Plan = table.Column<int>(type: "int", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OccurredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionHistory_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalSchema: "dbo",
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderLines",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    InventoryItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxPercent = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityShipped = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityInvoiced = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RevenueAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderLines_Accounts_RevenueAccountId",
                        column: x => x.RevenueAccountId,
                        principalSchema: "dbo",
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesOrderLines_Products_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderLines_SalesOrders_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalSchema: "dbo",
                        principalTable: "SalesOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesReturns",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RMANumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ReturnType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceivedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReturns_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesReturns_CustomerInvoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalSchema: "dbo",
                        principalTable: "CustomerInvoices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesReturns_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesReturns_SalesOrders_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalSchema: "dbo",
                        principalTable: "SalesOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SOShipments",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SalesOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShippingMethod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShippingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MetrcManifestNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MetrcManifestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PackedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShippedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ShippedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOShipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SOShipments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SOShipments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SOShipments_SalesOrders_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalSchema: "dbo",
                        principalTable: "SalesOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SOShipments_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalSchema: "dbo",
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesReturnLines",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesReturnId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesOrderLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InventoryItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RestockingFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReturnLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReturnLines_Products_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesReturnLines_SalesOrderLines_SalesOrderLineId",
                        column: x => x.SalesOrderLineId,
                        principalSchema: "dbo",
                        principalTable: "SalesOrderLines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesReturnLines_SalesReturns_SalesReturnId",
                        column: x => x.SalesReturnId,
                        principalSchema: "dbo",
                        principalTable: "SalesReturns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SOShipmentLines",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesOrderLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuantityShipped = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BatchLotId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BinLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOShipmentLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SOShipmentLines_ProductBatches_BatchLotId",
                        column: x => x.BatchLotId,
                        principalSchema: "dbo",
                        principalTable: "ProductBatches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SOShipmentLines_Products_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SOShipmentLines_SOShipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalSchema: "dbo",
                        principalTable: "SOShipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SOShipmentLines_SalesOrderLines_SalesOrderLineId",
                        column: x => x.SalesOrderLineId,
                        principalSchema: "dbo",
                        principalTable: "SalesOrderLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FASBTopics",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "IsSuperseded", "SupersededBy", "TopicCode", "TopicName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04de1214-2685-43c9-8850-a507e719b161"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, false, false, null, "944", "Financial Services—Insurance", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("0623d725-405c-47e8-91a3-da7f69f6f75c"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5066), null, null, false, false, null, "450", "Contingencies", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5066) },
                    { new Guid("076bf486-a3f8-4d9a-9921-8ff802d66512"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8921), null, null, false, false, null, "948", "Financial Services—Mortgage Banking", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8921) },
                    { new Guid("08197df4-9a2b-4d11-b377-5efcf2c14d07"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3746), null, null, false, false, null, "220", "Income Statement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3746) },
                    { new Guid("09fda948-1ff2-42b0-a258-425b9bf4af7a"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4136), null, null, false, false, null, "280", "Segment Reporting", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("0eeb2a3a-6285-4792-b690-a8eaed9a0d4f"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3931), null, null, false, false, null, "250", "Accounting Changes and Error Corrections", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3931) },
                    { new Guid("0f58938a-7727-4a51-8526-154110be1c37"), "Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5809), null, null, false, false, null, "712", "Compensation—Nonretirement Postemployment Benefits", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5809) },
                    { new Guid("1c7fdf97-8dcf-459c-8c36-77d2eae7f8c2"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7321), null, null, false, false, null, "852", "Reorganizations", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7321) },
                    { new Guid("1cb486ef-a290-443c-8564-2099bd7658be"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(754), null, null, false, false, null, "985", "Software", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(754) },
                    { new Guid("1e8f8644-915c-44ff-90d2-2288d08a1d4c"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7607), null, null, false, false, null, "910", "Contractors—Construction", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7607) },
                    { new Guid("1f16a8be-50df-4fff-83e4-a6dcd5c8b467"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5129), null, null, false, false, null, "460", "Guarantees", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5129) },
                    { new Guid("200d1e19-22dd-4122-826a-6d6879535719"), "Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998), null, null, false, false, null, "718", "Compensation—Stock Compensation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("22116056-935c-486b-af4d-9f0bf0f43a6b"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531), null, null, false, false, null, "978", "Real Estate—Time-Sharing Activities", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531) },
                    { new Guid("2293a310-1b1c-4b08-a4f7-b24d39ae3e9a"), "Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6290), null, null, false, false, null, "730", "Research and Development", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6290) },
                    { new Guid("22d74ce5-8186-4fca-bd54-b79708bde34b"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6633), null, null, false, false, null, "810", "Consolidation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6633) },
                    { new Guid("22eb2c64-d0c4-4167-818c-594075501dea"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4532), null, null, false, false, null, "330", "Inventory", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4532) },
                    { new Guid("234217d5-f383-4731-94e8-30943260ad96"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7741), null, null, false, false, null, "920", "Entertainment—Broadcasters", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7741) },
                    { new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "Revenue", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, false, true, "ASC 606", "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("270d2594-1e13-4c6c-bb31-d13d96c09236"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137), null, null, false, false, null, "940", "Financial Services—Brokers and Dealers", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137) },
                    { new Guid("2a44c184-515f-43a5-a66d-cd867293f4ee"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7290), null, null, false, false, null, "850", "Related Party Disclosures", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7290) },
                    { new Guid("2c86c46d-43c5-4aa1-82b9-78ebaed76e3d"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7899), null, null, false, false, null, "926", "Entertainment—Films", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7899) },
                    { new Guid("337ecdbf-e355-4ab1-b6f1-32eac4a5a215"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4296), null, null, false, false, null, "321", "Investments—Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4296) },
                    { new Guid("33c5982d-c1a4-4467-9392-8a4766b81ee2"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8073), null, null, false, false, null, "932", "Extractive Activities—Oil and Gas", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8073) },
                    { new Guid("3ffc9610-010d-4ed8-a49d-ec937fa2eea1"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5274), null, null, false, false, null, "480", "Distinguishing Liabilities from Equity", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5274) },
                    { new Guid("410c9e8b-9eb8-4f81-a349-82386daadbe5"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645), null, null, false, false, null, "350", "Intangibles—Goodwill and Other", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645) },
                    { new Guid("425cb621-4be5-49a3-a26d-5bd923a5e949"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161), null, null, false, false, null, "470", "Debt", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161) },
                    { new Guid("4315bf8d-c939-4d46-8d0a-2fd05b29dcce"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127), null, null, false, false, null, "842", "Leases", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127) },
                    { new Guid("4485d6f0-e553-4fc9-8be1-fb9553d3e905"), "Revenue", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5602), null, null, false, false, null, "606", "Revenue from Contracts with Customers", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5602) },
                    { new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, false, false, null, "958", "Not-for-Profit Entities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("4bf2f375-c5a9-49c7-953a-23575087162a"), "Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5714), null, null, false, false, null, "705", "Cost of Sales and Services", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5714) },
                    { new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, false, false, null, "970", "Real Estate—General", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("56905d50-30fb-41c8-a4dd-11dc20f5a8c8"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3402), null, null, false, false, null, "205", "Presentation of Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3402) },
                    { new Guid("5acf7c1a-46df-493a-a190-530148bbfb88"), "Equity", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308), null, null, false, false, null, "505", "Equity", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308) },
                    { new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, false, false, null, "942", "Financial Services—Depository and Lending", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, false, false, null, "720", "Other Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("679b504d-6533-49c3-8408-0f3ad2697e30"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4103), null, null, false, false, null, "274", "Personal Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4103) },
                    { new Guid("6b3ccf85-dc9c-4f58-995d-98a9a71fffcf"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564), null, null, false, false, null, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564) },
                    { new Guid("6c5ada2e-1480-4e10-b861-82825090f066"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3794), null, null, false, false, null, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3794) },
                    { new Guid("6d3180ac-73ee-4500-bf63-9c21ecacb51b"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4071), null, null, false, false, null, "273", "Corporate Joint Ventures", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4071) },
                    { new Guid("71e52f46-62d6-4bb5-85a0-aa102713b92e"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3691), null, null, false, false, null, "210", "Balance Sheet", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3691) },
                    { new Guid("76a60c3f-1e99-446f-bbb0-104bd0bbb028"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4037), null, null, false, false, null, "272", "Limited Liability Entities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4037) },
                    { new Guid("784697f1-e30b-4b89-a5e4-35ca5e8c118d"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7852), null, null, false, false, null, "924", "Entertainment—Casinos", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7852) },
                    { new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, false, false, null, "805", "Business Combinations", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("80013570-a38f-4aa8-b1e7-5e7572f85954"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7962), null, null, false, false, null, "928", "Entertainment—Music", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7962) },
                    { new Guid("83d3c3b2-9a6e-4409-8a55-559edc1874fe"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4168), null, null, false, false, null, "305", "Cash and Cash Equivalents", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4168) },
                    { new Guid("85482aa7-5f83-4035-83e5-d60a5764a73e"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4002), null, null, false, false, null, "270", "Interim Reporting", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4002) },
                    { new Guid("855e87af-eea0-4ce0-b2fb-bd357e31e41d"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617), null, null, false, false, null, "960", "Plan Accounting—Defined Benefit Pension Plans", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617) },
                    { new Guid("871bb9a3-dacc-4647-8889-46adce138e4d"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(484), null, null, false, true, "ASC 606", "976", "Real Estate—Retail Land", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(484) },
                    { new Guid("87d9459d-e429-401e-9e96-bf1cdaa47725"), "Revenue", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5650), null, null, false, false, null, "610", "Other Income", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5650) },
                    { new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, false, false, null, "974", "Real Estate—Real Estate Investment Trusts", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("929ef6c5-bc8e-4066-8f7f-d0437532d07f"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7368), null, null, false, false, null, "855", "Subsequent Events", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7368) },
                    { new Guid("92f367db-07cc-44af-8d69-9998ae4a0569"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6950), null, null, false, false, null, "835", "Interest", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6950) },
                    { new Guid("942f835e-4816-4cdd-b530-37aeda9f53a8"), "Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5761), null, null, false, false, null, "710", "Compensation—General", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5761) },
                    { new Guid("95785526-9732-40eb-8bab-775ffed3adef"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3898), null, null, false, false, null, "235", "Notes to Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3898) },
                    { new Guid("9b2ad909-ff27-4861-adb1-bcb171aaaea1"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(160), null, null, false, false, null, "972", "Real Estate—Common Interest Realty Associations", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(160) },
                    { new Guid("9f51f52a-7d81-4f64-b7c4-9e837537e7ff"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4329), null, null, false, false, null, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4329) },
                    { new Guid("a0bba39f-20d8-4806-8c4b-0eaa600ec375"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7559), null, null, false, false, null, "908", "Airlines", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7559) },
                    { new Guid("a4277175-8ab2-4a56-afed-160ad0d241ea"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4264), null, null, false, true, "ASC 321 and ASC 326", "320", "Investments—Debt Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4264) },
                    { new Guid("a4edbb9c-b599-49e5-abe1-73c42880e77e"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6839), null, null, false, false, null, "825", "Financial Instruments", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6839) },
                    { new Guid("a92243a9-81a2-4540-a7f2-b521f7173190"), "Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337), null, null, false, false, null, "740", "Income Taxes", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337) },
                    { new Guid("a9a7d783-6b01-4ad2-b92a-a47d1df9c889"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048), null, null, false, true, "ASC 842", "840", "Leases", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048) },
                    { new Guid("b17a4cd4-b48d-4055-bd78-d06d38ee94fd"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4901), null, null, false, false, null, "410", "Asset Retirement and Environmental Obligations", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4901) },
                    { new Guid("b1e39780-de1c-4e5b-b843-5d85fc285e0a"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3962), null, null, false, false, null, "260", "Earnings Per Share", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3962) },
                    { new Guid("b4e28f37-adf9-4bcb-9931-fecbb09a9fb0"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733), null, null, false, false, null, "962", "Plan Accounting—Defined Contribution Pension Plans", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733) },
                    { new Guid("b6ffb347-42c6-4b67-8d28-e4bfc539fe79"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8010), null, null, false, false, null, "930", "Extractive Activities—Mining", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8010) },
                    { new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, false, false, null, "946", "Financial Services—Investment Companies", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("b980f5bc-e46c-4979-91e2-503b535150ae"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4964), null, null, false, false, null, "420", "Exit or Disposal Cost Obligations", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4964) },
                    { new Guid("ba70a63b-9065-44b4-9708-2cbb37d6806c"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7804), null, null, false, false, null, "922", "Entertainment—Cable Television", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7804) },
                    { new Guid("bd5bbdaf-2d73-4f1b-91f7-33eefc96087c"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8984), null, null, false, false, null, "950", "Financial Services—Title Plant", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8984) },
                    { new Guid("bd9d29b9-c2cc-4047-b9b3-a4acd32c884c"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377), null, null, false, false, null, "325", "Investments—Other", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377) },
                    { new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, false, false, null, "815", "Derivatives and Hedging", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("c23df90c-1b41-48ef-8dde-aef3e1d1be8f"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6602), null, null, false, false, null, "808", "Collaborative Arrangements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6602) },
                    { new Guid("c6a9828b-97df-4f47-9550-c00cc399c73a"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6808), null, null, false, false, null, "820", "Fair Value Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6808) },
                    { new Guid("c8a4fbd1-36b0-4bde-8681-800182a8c880"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4996), null, null, false, true, "ASC 606", "430", "Deferred Revenue", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4996) },
                    { new Guid("ca832adb-d194-48e0-9b09-af467008c64a"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871), null, null, false, false, null, "830", "Foreign Currency Matters", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871) },
                    { new Guid("dd338588-7063-445f-800c-686163eca2a9"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827), null, null, false, false, null, "965", "Plan Accounting—Health and Welfare Benefit Plans", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("de5f4ed4-77cb-4e78-a70a-2068535f6245"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805), null, null, false, false, null, "405", "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805) },
                    { new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, false, false, null, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("e27b1da5-bb83-4269-92fe-9fd3718de4de"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4756), null, null, false, false, null, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4756) },
                    { new Guid("e2e6e115-402a-451c-8abe-3a0e2de15c4b"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4200), null, null, false, false, null, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4200) },
                    { new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, false, false, null, "980", "Regulated Operations", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("e7a7d05c-e691-4111-b567-b122e7dff8f3"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7227), null, null, false, false, null, "845", "Nonmonetary Transactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7227) },
                    { new Guid("e9f79ce3-dfb5-4da6-89e7-1d384bf5eafa"), "Assets", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4460), null, null, false, false, null, "326", "Financial Instruments—Credit Losses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4460) },
                    { new Guid("ed18bbf3-3633-4b34-8d96-8e775c165381"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400), null, null, false, false, null, "860", "Transfers and Servicing", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400) },
                    { new Guid("f1232c25-e521-431e-9346-fb9ec6450bef"), "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3852), null, null, false, false, null, "230", "Statement of Cash Flows", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3852) },
                    { new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, false, false, null, "954", "Health Care Entities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("f48e9490-d0bc-467a-a291-df46f9fd8821"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7495), null, null, false, false, null, "905", "Agriculture", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7495) },
                    { new Guid("fc614853-a1f5-4f16-9f9b-87acfefa8004"), "Industry", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655), null, null, false, false, null, "912", "Contractors—Federal Government", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655) },
                    { new Guid("fe205890-09cb-4911-a05d-8d5a8795f8aa"), "BroadTransactions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7258), null, null, false, false, null, "848", "Reference Rate Reform", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7258) },
                    { new Guid("feeb7d75-f0b0-4038-bf9e-2258d4fcacd0"), "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5028), null, null, false, false, null, "440", "Commitments", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5028) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FASBSubtopics",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "FASBTopicId", "FullReference", "IsDeleted", "IsRepealed", "SubtopicCode", "SubtopicName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00084b33-08c3-430e-bb1f-14b680cd41ae"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4532), null, null, new Guid("22eb2c64-d0c4-4167-818c-594075501dea"), "ASC 330-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4532) },
                    { new Guid("00c49468-564f-4c16-aa0d-dd4b3c12e74a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805), null, null, new Guid("de5f4ed4-77cb-4e78-a70a-2068535f6245"), "ASC 405-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805) },
                    { new Guid("013bed1d-c594-4d4b-a761-2f66174944b1"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4103), null, null, new Guid("679b504d-6533-49c3-8408-0f3ad2697e30"), "ASC 274-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4103) },
                    { new Guid("01f6dd0a-c8cc-4726-8647-ce236d35487b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127), null, null, new Guid("4315bf8d-c939-4d46-8d0a-2fd05b29dcce"), "ASC 842-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127) },
                    { new Guid("028415f7-32d3-4385-a812-79612036042b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "ASC 815-25", false, false, "25", "Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("033cf02a-8ffe-403d-8363-a60c0f796413"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805), null, null, new Guid("de5f4ed4-77cb-4e78-a70a-2068535f6245"), "ASC 405-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805) },
                    { new Guid("04742d12-db87-4b09-a658-56b490e8e4af"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998), null, null, new Guid("200d1e19-22dd-4122-826a-6d6879535719"), "ASC 718-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("065dd83d-ffb5-4366-8b37-5cbfbf9e9ac1"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(484), null, null, new Guid("871bb9a3-dacc-4647-8889-46adce138e4d"), "ASC 976-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(484) },
                    { new Guid("078978d2-2df2-47b1-846d-de095be0db08"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("07a7624e-ff4c-4b7e-b322-adbe63f55436"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3402), null, null, new Guid("56905d50-30fb-41c8-a4dd-11dc20f5a8c8"), "ASC 205-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3402) },
                    { new Guid("07d4b154-e123-496c-a4a7-bdde0406e65d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("07dfc26f-dede-4d2c-8d01-be3b98217fec"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048), null, null, new Guid("a9a7d783-6b01-4ad2-b92a-a47d1df9c889"), "ASC 840-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048) },
                    { new Guid("08ec1977-a13d-447b-8da1-6a67dd65b2a4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("09ddbd35-138a-4d4d-81f2-4138c2ab92b9"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733), null, null, new Guid("b4e28f37-adf9-4bcb-9931-fecbb09a9fb0"), "ASC 962-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733) },
                    { new Guid("0a5f7312-3fbd-4c69-a73b-ec7055d24b55"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("0ab2b740-260f-4a8c-95cb-3702e8c8e967"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "ASC 815-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("0ade51c5-adc0-4897-a75b-4c2e2b776daf"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-205", false, false, "205", "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("0b0ed602-dbe1-4640-a648-9e7c52a68f07"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4756), null, null, new Guid("e27b1da5-bb83-4269-92fe-9fd3718de4de"), "ASC 360-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4756) },
                    { new Guid("0b42756a-454d-48b0-a047-ea5ed1984810"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("0bd7aed4-cbc0-40f6-aa11-5a2693604983"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6290), null, null, new Guid("2293a310-1b1c-4b08-a4f7-b24d39ae3e9a"), "ASC 730-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6290) },
                    { new Guid("0c0125bb-2e2c-4290-958c-221a912440d5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-470", false, false, "470", "Debt", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("0c1403ac-c285-466c-880f-5856d28d9176"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6633), null, null, new Guid("22d74ce5-8186-4fca-bd54-b79708bde34b"), "ASC 810-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6633) },
                    { new Guid("0c55797e-622d-4afc-8279-59dea06a9dd2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7495), null, null, new Guid("f48e9490-d0bc-467a-a291-df46f9fd8821"), "ASC 905-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7495) },
                    { new Guid("0e63993a-1266-45d1-b85f-68c2219daea2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8073), null, null, new Guid("33c5982d-c1a4-4467-9392-8a4766b81ee2"), "ASC 932-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8073) },
                    { new Guid("0e989dd8-9c9b-4068-a4d3-a5fc6c1302aa"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(160), null, null, new Guid("9b2ad909-ff27-4861-adb1-bcb171aaaea1"), "ASC 972-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(160) },
                    { new Guid("0ea0246f-fb72-4f54-bdb4-87e8a3eacca6"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("1172272c-36cd-49e4-a126-22fe3bbee43e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337), null, null, new Guid("a92243a9-81a2-4540-a7f2-b521f7173190"), "ASC 740-270", false, false, "270", "Interim Reporting", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337) },
                    { new Guid("118e1f95-9f9b-48c8-b233-201bc28fa511"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "ASC 715-70", false, false, "70", "Grandfathered Guidance", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("11d604d5-c138-419d-9fde-b79d26dbed3c"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("133a509a-a622-4ba1-87a8-81a1ca05202c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4901), null, null, new Guid("b17a4cd4-b48d-4055-bd78-d06d38ee94fd"), "ASC 410-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4901) },
                    { new Guid("136544f3-6e41-42f6-a968-18f141c1d912"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "ASC 980-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("13bd2cd9-2221-406d-85e6-525eb3b9bbdf"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-505", false, false, "505", "Equity", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("13dbe201-3a11-436f-a8cf-df727259d444"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "ASC 715-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("13dd14dd-a17d-491d-b1fa-3a4119ff9649"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827), null, null, new Guid("dd338588-7063-445f-800c-686163eca2a9"), "ASC 965-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("14325e5d-043b-4461-a4b2-62c5d6754cff"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161), null, null, new Guid("425cb621-4be5-49a3-a26d-5bd923a5e949"), "ASC 470-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161) },
                    { new Guid("1531c270-671b-4f9b-a191-7524cbd4ea48"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617), null, null, new Guid("855e87af-eea0-4ce0-b2fb-bd357e31e41d"), "ASC 960-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617) },
                    { new Guid("153ddb9f-4886-4e4e-931f-6e235d2260d0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("15bd4e93-07d7-4b0c-8007-cf439f5b8524"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617), null, null, new Guid("855e87af-eea0-4ce0-b2fb-bd357e31e41d"), "ASC 960-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617) },
                    { new Guid("16b80d27-361e-42c7-b0e6-8761e82ca40d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5650), null, null, new Guid("87d9459d-e429-401e-9e96-bf1cdaa47725"), "ASC 610-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5650) },
                    { new Guid("1908336c-1aa4-4c91-8895-275f55ad2e66"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("19452c4b-6a53-4776-aedd-f94eb931ebdb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-60", false, false, "60", "Relationships", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("195c65d4-b745-4ea1-91c6-022e1211722e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7741), null, null, new Guid("234217d5-f383-4731-94e8-30943260ad96"), "ASC 920-350", false, false, "350", "Intangibles—Goodwill and Other", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7741) },
                    { new Guid("1a9472af-9138-4ccd-9cf4-126f0e918129"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3746), null, null, new Guid("08197df4-9a2b-4d11-b377-5efcf2c14d07"), "ASC 220-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3746) },
                    { new Guid("1af69ff7-fa2d-4d22-84a4-345512df9c20"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5274), null, null, new Guid("3ffc9610-010d-4ed8-a49d-ec937fa2eea1"), "ASC 480-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5274) },
                    { new Guid("1b859437-6fbb-44e0-8bd4-1734d2812db9"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7368), null, null, new Guid("929ef6c5-bc8e-4066-8f7f-d0437532d07f"), "ASC 855-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7368) },
                    { new Guid("1c08d218-1424-4bff-9de7-70399156d086"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5129), null, null, new Guid("1f16a8be-50df-4fff-83e4-a6dcd5c8b467"), "ASC 460-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5129) },
                    { new Guid("1dc42de6-a087-4265-b70a-4a0306d6c703"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("1e4e0729-e88e-4ec9-aea7-dc78f40802f6"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-15", false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("1f542ecd-ab27-424c-bd1d-8479ec32be94"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7258), null, null, new Guid("fe205890-09cb-4911-a05d-8d5a8795f8aa"), "ASC 848-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7258) },
                    { new Guid("2013509d-16bb-4a0f-b75a-e8ae68cc136f"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127), null, null, new Guid("4315bf8d-c939-4d46-8d0a-2fd05b29dcce"), "ASC 842-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127) },
                    { new Guid("20a99d31-3683-4605-9009-6ca945947b2a"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(754), null, null, new Guid("1cb486ef-a290-443c-8564-2099bd7658be"), "ASC 985-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(754) },
                    { new Guid("20fc0190-411a-4d0b-b0ea-326e2476f080"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3691), null, null, new Guid("71e52f46-62d6-4bb5-85a0-aa102713b92e"), "ASC 210-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3691) },
                    { new Guid("2169d16b-dba8-4b14-a2e1-3d03cb44b714"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8010), null, null, new Guid("b6ffb347-42c6-4b67-8d28-e4bfc539fe79"), "ASC 930-330", false, false, "330", "Inventory", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8010) },
                    { new Guid("217e3c87-6c37-491c-a08d-831b295de983"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655), null, null, new Guid("fc614853-a1f5-4f16-9f9b-87acfefa8004"), "ASC 912-330", false, false, "330", "Inventory", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655) },
                    { new Guid("21f9652d-ba1a-4e99-909b-6c85915de6e3"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7227), null, null, new Guid("e7a7d05c-e691-4111-b567-b122e7dff8f3"), "ASC 845-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7227) },
                    { new Guid("2349edf0-6acc-4156-bd7f-20b875cb2ca9"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4460), null, null, new Guid("e9f79ce3-dfb5-4da6-89e7-1d384bf5eafa"), "ASC 326-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4460) },
                    { new Guid("243ef8ac-fe12-4712-b71e-fb8729acf46a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("252d6eb8-a39a-4573-a0fc-05e4e108f423"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7962), null, null, new Guid("80013570-a38f-4aa8-b1e7-5e7572f85954"), "ASC 928-340", false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7962) },
                    { new Guid("25f8ca10-2a43-41c4-b34e-51d145c6fc45"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-825", false, false, "825", "Financial Instruments", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("260d75c6-8d6e-473e-9798-81ef4f623df0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161), null, null, new Guid("425cb621-4be5-49a3-a26d-5bd923a5e949"), "ASC 470-60", false, false, "60", "Relationships", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161) },
                    { new Guid("26eb7ba5-1174-48bf-9403-7a5bb5f1848c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-825", false, false, "825", "Financial Instruments", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("2791ebdb-00f1-4df0-b863-fb84a498453d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7962), null, null, new Guid("80013570-a38f-4aa8-b1e7-5e7572f85954"), "ASC 928-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7962) },
                    { new Guid("2b0790a0-db9f-4d78-84d7-a8c4f9ec6af4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "ASC 815-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("2cbf34ff-5de8-4059-96d2-b6749336d9f9"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048), null, null, new Guid("a9a7d783-6b01-4ad2-b92a-a47d1df9c889"), "ASC 840-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048) },
                    { new Guid("2cd29cb7-9dbd-4524-a507-94c2a170a388"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-15", false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("2d765ba7-4188-4818-9e07-81d6e173ab04"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "ASC 815-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("2e6a1d20-16c8-4276-b19a-7fe2f9ff4a32"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827), null, null, new Guid("dd338588-7063-445f-800c-686163eca2a9"), "ASC 965-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("2e9bf2a7-7b6a-4de0-aeb4-80493560339a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308), null, null, new Guid("5acf7c1a-46df-493a-a190-530148bbfb88"), "ASC 505-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308) },
                    { new Guid("2ec699db-54e1-476e-a2ec-ba7546eeaad9"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137), null, null, new Guid("270d2594-1e13-4c6c-bb31-d13d96c09236"), "ASC 940-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137) },
                    { new Guid("2f24f3df-bc2e-4951-90a1-2f43f2840311"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400), null, null, new Guid("ed18bbf3-3633-4b34-8d96-8e775c165381"), "ASC 860-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400) },
                    { new Guid("2f542e73-d845-44a3-8e0e-22df395e251f"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(160), null, null, new Guid("9b2ad909-ff27-4861-adb1-bcb171aaaea1"), "ASC 972-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(160) },
                    { new Guid("2fc18f94-975a-40a6-8bf1-741668f7d740"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308), null, null, new Guid("5acf7c1a-46df-493a-a190-530148bbfb88"), "ASC 505-60", false, false, "60", "Relationships", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308) },
                    { new Guid("2fedcacb-5d1e-4541-852a-723b224ee435"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531), null, null, new Guid("22116056-935c-486b-af4d-9f0bf0f43a6b"), "ASC 978-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531) },
                    { new Guid("3066b238-b6c3-4804-b32a-d4ef239021af"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7607), null, null, new Guid("1e8f8644-915c-44ff-90d2-2288d08a1d4c"), "ASC 910-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7607) },
                    { new Guid("314c7f8e-e5e4-43d0-a862-40c0b9739cbc"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("32d95959-1ec1-46d7-8c5a-74d3f83ec229"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("3360d0e5-444b-46db-abab-5138f66e4a7e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8984), null, null, new Guid("bd5bbdaf-2d73-4f1b-91f7-33eefc96087c"), "ASC 950-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8984) },
                    { new Guid("340ca4ab-0140-465b-930d-fe2279971842"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("342ddacd-bb02-4b4c-bb63-ecdfe62a793b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048), null, null, new Guid("a9a7d783-6b01-4ad2-b92a-a47d1df9c889"), "ASC 840-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048) },
                    { new Guid("3496c8a8-6d3d-4520-8252-d33d59392e7f"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4460), null, null, new Guid("e9f79ce3-dfb5-4da6-89e7-1d384bf5eafa"), "ASC 326-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4460) },
                    { new Guid("355b7c83-50f0-4ad8-9433-02d9b697bf01"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3931), null, null, new Guid("0eeb2a3a-6285-4792-b690-a8eaed9a0d4f"), "ASC 250-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3931) },
                    { new Guid("35a249ce-ce8d-49e3-b5de-eee728c413c4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400), null, null, new Guid("ed18bbf3-3633-4b34-8d96-8e775c165381"), "ASC 860-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400) },
                    { new Guid("37dd9f8a-20f1-4014-a1b2-88f10a80e631"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("3872970b-34da-4eb7-9386-7e186cdbfcdb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5602), null, null, new Guid("4485d6f0-e553-4fc9-8be1-fb9553d3e905"), "ASC 606-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5602) },
                    { new Guid("38fc1435-f5ed-4213-9977-b42107b867ac"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617), null, null, new Guid("855e87af-eea0-4ce0-b2fb-bd357e31e41d"), "ASC 960-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617) },
                    { new Guid("3ab32de2-473b-4de4-a2f1-4526a55e953e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3691), null, null, new Guid("71e52f46-62d6-4bb5-85a0-aa102713b92e"), "ASC 210-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3691) },
                    { new Guid("3ac2e98b-9494-4b40-8b0a-6a3d47d864eb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("3b44b064-9200-4961-a4bb-b98b3740d0e0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("3be33d30-fdff-4efe-a7c7-3dd01f229f76"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127), null, null, new Guid("4315bf8d-c939-4d46-8d0a-2fd05b29dcce"), "ASC 842-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127) },
                    { new Guid("3c6ea3dc-8691-4af1-94ed-23cd0b14c94a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-45", false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("3ca6f88b-7d96-4653-8b1f-38b05af902b1"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("3d8c520a-0c5b-44f5-ae42-13cf27960e9b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6950), null, null, new Guid("92f367db-07cc-44af-8d69-9998ae4a0569"), "ASC 835-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6950) },
                    { new Guid("3dffa688-691d-4dd6-8c52-6a6f50c6190e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6839), null, null, new Guid("a4edbb9c-b599-49e5-abe1-73c42880e77e"), "ASC 825-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6839) },
                    { new Guid("3f76aeed-1879-442f-af2e-2900e141636a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8921), null, null, new Guid("076bf486-a3f8-4d9a-9921-8ff802d66512"), "ASC 948-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8921) },
                    { new Guid("400b3343-d4a1-4b40-9152-eaf37a0da1e4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("400d3b31-867b-448f-aa8a-03c90a54d157"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5809), null, null, new Guid("0f58938a-7727-4a51-8526-154110be1c37"), "ASC 712-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5809) },
                    { new Guid("41bc73cb-f3b3-4fb7-a819-20105ca56334"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-958", false, false, "958", "Not-for-Profit Entities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("41c4d8f4-8840-457b-93dd-98955fd87cbc"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308), null, null, new Guid("5acf7c1a-46df-493a-a190-530148bbfb88"), "ASC 505-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308) },
                    { new Guid("42400bf7-6d2b-47c7-aa88-37828a507c6c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8010), null, null, new Guid("b6ffb347-42c6-4b67-8d28-e4bfc539fe79"), "ASC 930-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8010) },
                    { new Guid("45851957-3e50-4fdf-85a9-538923474be7"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655), null, null, new Guid("fc614853-a1f5-4f16-9f9b-87acfefa8004"), "ASC 912-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655) },
                    { new Guid("46572146-c1f4-4bd8-b42f-d90bba631439"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531), null, null, new Guid("22116056-935c-486b-af4d-9f0bf0f43a6b"), "ASC 978-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531) },
                    { new Guid("469a9571-f5eb-47c4-bd24-b88dbce7a57e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617), null, null, new Guid("855e87af-eea0-4ce0-b2fb-bd357e31e41d"), "ASC 960-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617) },
                    { new Guid("46f68a88-826e-4ac6-8e3c-57f14c532723"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161), null, null, new Guid("425cb621-4be5-49a3-a26d-5bd923a5e949"), "ASC 470-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161) },
                    { new Guid("482ff298-6b81-42ad-8dcf-657df8f4f08f"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("489ddca9-5099-4379-940c-466558383d04"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308), null, null, new Guid("5acf7c1a-46df-493a-a190-530148bbfb88"), "ASC 505-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308) },
                    { new Guid("49d35f9e-4c22-42c8-b533-8ace9beb3638"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7495), null, null, new Guid("f48e9490-d0bc-467a-a291-df46f9fd8821"), "ASC 905-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7495) },
                    { new Guid("4a2ee404-01f6-4103-bc5d-a445550501b8"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137), null, null, new Guid("270d2594-1e13-4c6c-bb31-d13d96c09236"), "ASC 940-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137) },
                    { new Guid("4aa70efa-3cbd-4c69-86b8-3420625231f4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827), null, null, new Guid("dd338588-7063-445f-800c-686163eca2a9"), "ASC 965-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("4ad3800d-288c-4d0d-92f4-759c901f38f8"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7804), null, null, new Guid("ba70a63b-9065-44b4-9708-2cbb37d6806c"), "ASC 922-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7804) },
                    { new Guid("4b2a66f6-ba4a-471d-93b8-d4d00ccdd8df"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-825", false, false, "825", "Financial Instruments", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("4b9a8949-c480-43c5-8d93-980e8119aa14"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871), null, null, new Guid("ca832adb-d194-48e0-9b09-af467008c64a"), "ASC 830-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871) },
                    { new Guid("4c4be596-0f2b-40b4-b964-fd9b654b9e7d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("4dccc160-fa4a-4a8d-b1e7-4009c502e514"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3898), null, null, new Guid("95785526-9732-40eb-8bab-775ffed3adef"), "ASC 235-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3898) },
                    { new Guid("4e00c468-b459-4dd3-adb9-7ca84c53269d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617), null, null, new Guid("855e87af-eea0-4ce0-b2fb-bd357e31e41d"), "ASC 960-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617) },
                    { new Guid("4e5c3643-3514-4f7f-b45d-85d4ad6819f3"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998), null, null, new Guid("200d1e19-22dd-4122-826a-6d6879535719"), "ASC 718-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("4ed53ac1-35d0-4f54-91f5-f2f079b2b532"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377), null, null, new Guid("bd9d29b9-c2cc-4047-b9b3-a4acd32c884c"), "ASC 325-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377) },
                    { new Guid("4fc0a532-389d-449e-8b8e-2fee3201875b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4136), null, null, new Guid("09fda948-1ff2-42b0-a258-425b9bf4af7a"), "ASC 280-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("51035c5e-a185-4d04-a99a-4a8a24351dfb"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "ASC 980-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("5137a927-ddd3-4581-8543-91988165527a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "ASC 715-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("52238401-39ec-4283-8c58-6af75bca1257"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-45", false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("527b5c58-efbf-47e1-ad07-146630f5c761"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4296), null, null, new Guid("337ecdbf-e355-4ab1-b6f1-32eac4a5a215"), "ASC 321-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4296) },
                    { new Guid("544a339a-55eb-4740-9c23-f25dd82afea1"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("5455015f-360d-4635-a2f5-711909145af4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-450", false, false, "450", "Contingencies", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("54f455b4-f4b7-48be-bd6d-72e9a45c7e83"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-954", false, false, "954", "Health Care Entities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("551ef24f-ee2c-4b36-a433-17eda9ad4b92"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161), null, null, new Guid("425cb621-4be5-49a3-a26d-5bd923a5e949"), "ASC 470-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161) },
                    { new Guid("55be7206-5529-4a9f-a1af-ee934e46b550"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3962), null, null, new Guid("b1e39780-de1c-4e5b-b843-5d85fc285e0a"), "ASC 260-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3962) },
                    { new Guid("566b5833-e8b9-4cb7-95db-1fd393dde2dd"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("56fac55f-ce5d-4b3b-97f7-b309fe36d4fc"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5761), null, null, new Guid("942f835e-4816-4cdd-b530-37aeda9f53a8"), "ASC 710-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5761) },
                    { new Guid("57c31206-5d92-42d1-b0f4-0fa145572f35"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337), null, null, new Guid("a92243a9-81a2-4540-a7f2-b521f7173190"), "ASC 740-323", false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337) },
                    { new Guid("5818ed91-2cab-4e3d-bf8f-52531038919d"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "ASC 980-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("58259601-bc60-458e-a9cc-cb21c23cee85"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645), null, null, new Guid("410c9e8b-9eb8-4f81-a349-82386daadbe5"), "ASC 350-60", false, false, "60", "Relationships", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645) },
                    { new Guid("58440537-550d-4984-8ce9-fbd472c68b13"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645), null, null, new Guid("410c9e8b-9eb8-4f81-a349-82386daadbe5"), "ASC 350-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645) },
                    { new Guid("5ab6e584-f055-4fa0-9b38-4b26838717d2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("5c887f95-7133-4038-bae0-cc581ac2d4cd"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("5da202ba-d318-4667-9edd-e9d67f4642c8"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805), null, null, new Guid("de5f4ed4-77cb-4e78-a70a-2068535f6245"), "ASC 405-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805) },
                    { new Guid("5e776f09-5895-4e07-81fc-ec1978cdebd0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4071), null, null, new Guid("6d3180ac-73ee-4500-bf63-9c21ecacb51b"), "ASC 273-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4071) },
                    { new Guid("603a8fe1-e25e-4a41-ae42-080a7c4a871f"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("606a360d-a95e-4b77-b8eb-37dd6ea7b52d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4996), null, null, new Guid("c8a4fbd1-36b0-4bde-8681-800182a8c880"), "ASC 430-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4996) },
                    { new Guid("61a625dc-972c-4f55-a1bf-bd684361f8a4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("61c0384b-191a-412f-84de-7579bd631ae3"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("62191a50-7a96-4999-8c34-cbad2db77973"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("6310b03c-2cdf-4a52-a0d5-b525686ce37d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("6326ab86-a577-4ae6-ace4-71c193ee19e9"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("638fda43-4cee-41e4-aa3e-706e1f8647e1"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7741), null, null, new Guid("234217d5-f383-4731-94e8-30943260ad96"), "ASC 920-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7741) },
                    { new Guid("63bfa188-f8b9-425f-b62d-581b41ab9f5a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733), null, null, new Guid("b4e28f37-adf9-4bcb-9931-fecbb09a9fb0"), "ASC 962-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733) },
                    { new Guid("6664c05b-68c8-4d75-a25a-136131e66592"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7559), null, null, new Guid("a0bba39f-20d8-4806-8c4b-0eaa600ec375"), "ASC 908-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7559) },
                    { new Guid("669f3b00-6b39-4c55-9fcf-b1bb68a308fc"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4460), null, null, new Guid("e9f79ce3-dfb5-4da6-89e7-1d384bf5eafa"), "ASC 326-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4460) },
                    { new Guid("68d8b9b6-a7b7-4ec3-ac5e-c3a351766263"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("68e1c9e8-5192-4092-ab92-7375d7ae90c2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3746), null, null, new Guid("08197df4-9a2b-4d11-b377-5efcf2c14d07"), "ASC 220-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3746) },
                    { new Guid("69435f36-c641-48f8-aec7-b7139ed2df70"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("6951db85-0816-4a2a-9ab9-4a674f2491ed"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("696a02ab-e8ff-4daa-85ac-1f70da46ca6e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("69e1fdde-c693-4115-afd8-71b772a99176"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("6b188f1d-2a9d-4752-9bde-09f936d69341"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3852), null, null, new Guid("f1232c25-e521-431e-9346-fb9ec6450bef"), "ASC 230-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3852) },
                    { new Guid("6c7fcad4-8e22-4ee6-92e2-9a9f02c8a322"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("6dccb33f-e6de-4f1f-8230-f1521f30e775"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3402), null, null, new Guid("56905d50-30fb-41c8-a4dd-11dc20f5a8c8"), "ASC 205-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3402) },
                    { new Guid("6edc8fbc-0c5e-4d7f-9be1-d2eb0b1437fd"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7495), null, null, new Guid("f48e9490-d0bc-467a-a291-df46f9fd8821"), "ASC 905-330", false, false, "330", "Inventory", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7495) },
                    { new Guid("7006e03f-47ee-4ee6-a800-c6a594d7f33f"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-720", false, false, "720", "Other Expenses", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("71977706-a6fc-4566-9c44-1cee327861e6"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("71f0b477-56b8-4ab8-b2bd-046fff0f1172"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617), null, null, new Guid("855e87af-eea0-4ce0-b2fb-bd357e31e41d"), "ASC 960-205", false, false, "205", "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9617) },
                    { new Guid("722225d2-e044-4592-a13c-abc0ccbabf7c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4329), null, null, new Guid("9f51f52a-7d81-4f64-b7c4-9e837537e7ff"), "ASC 323-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4329) },
                    { new Guid("72a0efd7-2758-49f8-aaa7-e92cde8df460"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4264), null, null, new Guid("a4277175-8ab2-4a56-afed-160ad0d241ea"), "ASC 320-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4264) },
                    { new Guid("7350fe8d-3758-4006-be09-170c5ffc9434"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-323", false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("749ca2ee-e861-45c5-9247-002bd7c679a2"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "ASC 980-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("75117b2a-0ca6-448e-8dd6-90a8016194ff"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("77c3c7e5-b73e-4054-9fdc-0277077f12ef"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "ASC 715-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("787b65ad-650d-41a3-bcc7-3e33a75c08ab"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3402), null, null, new Guid("56905d50-30fb-41c8-a4dd-11dc20f5a8c8"), "ASC 205-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3402) },
                    { new Guid("78da6559-8bd1-4ab7-b2c1-cdcb16ce85c5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("78de3259-11e2-433b-8e24-fcd8a4fd9227"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645), null, null, new Guid("410c9e8b-9eb8-4f81-a349-82386daadbe5"), "ASC 350-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645) },
                    { new Guid("7a413a0d-a820-40f9-a48e-84edf4b2bb6c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161), null, null, new Guid("425cb621-4be5-49a3-a26d-5bd923a5e949"), "ASC 470-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161) },
                    { new Guid("7b62e8bf-9fd5-4abe-83b7-bc7f77dcf983"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7321), null, null, new Guid("1c7fdf97-8dcf-459c-8c36-77d2eae7f8c2"), "ASC 852-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7321) },
                    { new Guid("7bc59a9a-e21e-4815-84bc-3ae04380f4b5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("7c3e30c5-3b46-4f14-b42a-ce6bfd259c22"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4901), null, null, new Guid("b17a4cd4-b48d-4055-bd78-d06d38ee94fd"), "ASC 410-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4901) },
                    { new Guid("7caac03e-0302-435f-b5e2-949b961f394c"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "ASC 980-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("7cee67b0-e228-4025-933b-89c82343358d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-340", false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("7ee711f3-520d-42b3-8ae5-f5bf60bd988d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5066), null, null, new Guid("0623d725-405c-47e8-91a3-da7f69f6f75c"), "ASC 450-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5066) },
                    { new Guid("7ef9f45a-fceb-4ae4-8dee-b3be6f8c4e8c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998), null, null, new Guid("200d1e19-22dd-4122-826a-6d6879535719"), "ASC 718-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("7f30e858-1f3c-4e8a-bd08-54916b4156ab"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-815", false, false, "815", "Derivatives and Hedging", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("7f76295a-3ca6-49bd-b037-134145d49289"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "ASC 715-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("803b85ee-bdb8-46ca-b96c-5b2af56c3686"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5809), null, null, new Guid("0f58938a-7727-4a51-8526-154110be1c37"), "ASC 712-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5809) },
                    { new Guid("806ce214-6f36-4a3b-95cd-b032042f2c4e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137), null, null, new Guid("270d2594-1e13-4c6c-bb31-d13d96c09236"), "ASC 940-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137) },
                    { new Guid("807393ff-cc8f-426f-8bb4-4b23b2e2545c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("818061c2-576c-4e51-8f72-abda11fd0e34"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5066), null, null, new Guid("0623d725-405c-47e8-91a3-da7f69f6f75c"), "ASC 450-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5066) },
                    { new Guid("82018aa6-b50e-4bca-9871-939f93fa2321"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-470", false, false, "470", "Debt", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("82340195-0717-4be4-b2ec-e90c3a42145d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6950), null, null, new Guid("92f367db-07cc-44af-8d69-9998ae4a0569"), "ASC 835-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6950) },
                    { new Guid("824c49b7-423a-4923-8392-e1e7ecd8ca01"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(160), null, null, new Guid("9b2ad909-ff27-4861-adb1-bcb171aaaea1"), "ASC 972-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(160) },
                    { new Guid("82f3c32c-0980-4b17-8bb6-90b8e0e4f647"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("83695b96-eda3-46eb-8e74-52f6c87dc44b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6602), null, null, new Guid("c23df90c-1b41-48ef-8dde-aef3e1d1be8f"), "ASC 808-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6602) },
                    { new Guid("850e00fe-34e7-4073-a7e5-8f9720bd12c5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-606", false, false, "606", "Revenue from Contracts with Customers", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("85374e3b-d1ef-440c-a5e8-47d3c709c3bc"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-740", false, false, "740", "Income Taxes", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("85749535-afcf-4931-acce-f75fae2cee03"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5602), null, null, new Guid("4485d6f0-e553-4fc9-8be1-fb9553d3e905"), "ASC 606-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5602) },
                    { new Guid("85cac14f-6dca-4f8c-8c17-28037c5b4237"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377), null, null, new Guid("bd9d29b9-c2cc-4047-b9b3-a4acd32c884c"), "ASC 325-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377) },
                    { new Guid("88104263-bb85-4cbe-ad4a-5c1177263779"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-225", false, false, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("88861097-2fd7-4c9e-a336-73bb76123daa"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "ASC 815-15", false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("88b98437-a8d6-4430-993a-e6b12e76895a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564), null, null, new Guid("6b3ccf85-dc9c-4f58-995d-98a9a71fffcf"), "ASC 340-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564) },
                    { new Guid("8ab7fa72-25fb-40d2-958c-fc73339f4037"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655), null, null, new Guid("fc614853-a1f5-4f16-9f9b-87acfefa8004"), "ASC 912-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655) },
                    { new Guid("8bc132ff-34b8-429f-8272-ecc347966770"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7559), null, null, new Guid("a0bba39f-20d8-4806-8c4b-0eaa600ec375"), "ASC 908-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7559) },
                    { new Guid("8c0239d0-fa4e-4958-ace8-371dfd64b5ab"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4901), null, null, new Guid("b17a4cd4-b48d-4055-bd78-d06d38ee94fd"), "ASC 410-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4901) },
                    { new Guid("8cbddb37-74c1-4d5e-9de0-9354e2f412bb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733), null, null, new Guid("b4e28f37-adf9-4bcb-9931-fecbb09a9fb0"), "ASC 962-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733) },
                    { new Guid("8f235fe6-acc9-4d87-b3fc-fc079bf553fe"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805), null, null, new Guid("de5f4ed4-77cb-4e78-a70a-2068535f6245"), "ASC 405-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805) },
                    { new Guid("9064011a-ac2e-4d15-a362-fe84ac364ba5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("919e49ef-50fa-49bf-9705-10cfff6eeb59"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-815", false, false, "815", "Derivatives and Hedging", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("91ab6b4c-2257-48cc-82df-d1dbba9a571d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337), null, null, new Guid("a92243a9-81a2-4540-a7f2-b521f7173190"), "ASC 740-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337) },
                    { new Guid("9226d34f-830a-4866-aff8-94c192a31868"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7852), null, null, new Guid("784697f1-e30b-4b89-a5e4-35ca5e8c118d"), "ASC 924-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7852) },
                    { new Guid("94986d81-80c8-458e-93d9-3ba7dae5b762"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("951985d3-7dac-47fe-8158-63748bbc4cb2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("962cc1e2-4f42-49ff-9720-760deb47bfb7"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("968f6670-02c7-4e7b-9736-a330a47b3f01"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("99741a8e-7526-4d65-a69c-3f8e20a49f02"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("9992bc77-9dc9-4cd4-b3ac-932bd5c1eb4b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161), null, null, new Guid("425cb621-4be5-49a3-a26d-5bd923a5e949"), "ASC 470-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5161) },
                    { new Guid("99b85dec-5297-48e5-a0be-ffff5489cc61"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("9d883ea2-3a57-4ee7-a6db-043c79d24408"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645), null, null, new Guid("410c9e8b-9eb8-4f81-a349-82386daadbe5"), "ASC 350-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645) },
                    { new Guid("9e3263e8-50b3-4e37-9b8b-fe85cba2bccf"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(484), null, null, new Guid("871bb9a3-dacc-4647-8889-46adce138e4d"), "ASC 976-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(484) },
                    { new Guid("9ead88d5-9703-4451-8fcf-da58b5a8a0e7"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4002), null, null, new Guid("85482aa7-5f83-4035-83e5-d60a5764a73e"), "ASC 270-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4002) },
                    { new Guid("9f77893b-ad6d-4d3f-9cc2-07ffa04156af"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564), null, null, new Guid("6b3ccf85-dc9c-4f58-995d-98a9a71fffcf"), "ASC 340-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564) },
                    { new Guid("9fbc4b2a-6e1d-4919-8d49-aa3559e4cbf4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("a092bad8-23a3-4a20-af04-e721247ce6b0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("a09f6cdb-8b56-4634-8c6e-548c7b222a17"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4329), null, null, new Guid("9f51f52a-7d81-4f64-b7c4-9e837537e7ff"), "ASC 323-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4329) },
                    { new Guid("a22d41cc-1193-4f72-9bc9-87d34c3fb2f2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3794), null, null, new Guid("6c5ada2e-1480-4e10-b861-82825090f066"), "ASC 225-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3794) },
                    { new Guid("a303eb54-a1f7-4af1-a67e-5bdee5846ae7"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("a39167af-b89f-4208-b239-7fc0838a44c4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-830", false, false, "830", "Foreign Currency Matters", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("a41c0480-ea35-4a15-b388-3a6c475a035a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4200), null, null, new Guid("e2e6e115-402a-451c-8abe-3a0e2de15c4b"), "ASC 310-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4200) },
                    { new Guid("a47e54f2-a3d9-4f0c-b535-183782e92775"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733), null, null, new Guid("b4e28f37-adf9-4bcb-9931-fecbb09a9fb0"), "ASC 962-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733) },
                    { new Guid("a53ab08b-4618-45ca-b918-c23155d83d48"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048), null, null, new Guid("a9a7d783-6b01-4ad2-b92a-a47d1df9c889"), "ASC 840-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7048) },
                    { new Guid("a71d53e0-ad7c-47a7-9eba-a27546c10e4b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("a901808a-8687-481d-b4cb-952dd98848f0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7899), null, null, new Guid("2c86c46d-43c5-4aa1-82b9-78ebaed76e3d"), "ASC 926-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7899) },
                    { new Guid("a9c23ee7-de3e-4768-b63c-1680d00bcc3b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4168), null, null, new Guid("83d3c3b2-9a6e-4409-8a55-559edc1874fe"), "ASC 305-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4168) },
                    { new Guid("aadd5ebd-0a31-4f5a-861a-8c0b258f6642"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-205", false, false, "205", "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("aaf742ea-74e9-47aa-bfbf-92ec4939a9fa"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998), null, null, new Guid("200d1e19-22dd-4122-826a-6d6879535719"), "ASC 718-60", false, false, "60", "Relationships", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("aafe444b-eebc-45f3-9865-883092e1b775"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7321), null, null, new Guid("1c7fdf97-8dcf-459c-8c36-77d2eae7f8c2"), "ASC 852-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7321) },
                    { new Guid("ab3a44c7-3353-40df-914f-e71041f757aa"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "ASC 815-35", false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("ab6da580-7535-4364-910f-ee7267250cac"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-450", false, false, "450", "Contingencies", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("abb9a22a-7fe7-4493-a125-8df0f94272d2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("ac5f6803-d53e-48bf-b449-dd7e0f1d87b1"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("ad53b99c-6707-4046-adeb-e308fdd45e97"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("ae3ee838-45db-4d06-8ade-260ff4649ae0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7290), null, null, new Guid("2a44c184-515f-43a5-a66d-cd867293f4ee"), "ASC 850-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7290) },
                    { new Guid("ae748ca8-6279-426b-affb-1cbe6b7da9e0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "ASC 715-80", false, false, "80", "Multiemployer Plans", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("b03af9bb-dd86-40e7-9897-3bc3c5b1a342"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("b10c72f6-0b53-4487-b8f6-8adae1d72cf0"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127), null, null, new Guid("4315bf8d-c939-4d46-8d0a-2fd05b29dcce"), "ASC 842-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127) },
                    { new Guid("b2355405-36ea-4eb1-a129-f27c86d9d50d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("b2be5b35-16a5-41d2-a668-a354585dfe91"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8073), null, null, new Guid("33c5982d-c1a4-4467-9392-8a4766b81ee2"), "ASC 932-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8073) },
                    { new Guid("b320c446-dfb5-4d11-9c83-ff52487cecbd"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827), null, null, new Guid("dd338588-7063-445f-800c-686163eca2a9"), "ASC 965-205", false, false, "205", "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("b394495d-54ca-4024-8436-44bf2cd71aeb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7899), null, null, new Guid("2c86c46d-43c5-4aa1-82b9-78ebaed76e3d"), "ASC 926-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7899) },
                    { new Guid("b4263598-f7c9-4ea1-9024-6a604e6afc5a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7607), null, null, new Guid("1e8f8644-915c-44ff-90d2-2288d08a1d4c"), "ASC 910-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7607) },
                    { new Guid("b4c9bad4-b340-4f81-a2ed-1773b15acd10"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-225", false, false, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("b4d6bbba-bb63-4102-9146-51d038208ba6"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("b50f5556-cba9-4802-9cd1-2a56dd525cbc"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("b51e3330-e3c8-4aef-bed6-d610885eae7c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6290), null, null, new Guid("2293a310-1b1c-4b08-a4f7-b24d39ae3e9a"), "ASC 730-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6290) },
                    { new Guid("b5dd31fe-f240-4804-accf-bc251ec5c143"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("b61831aa-e532-40e6-b900-4bb41f598db9"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4964), null, null, new Guid("b980f5bc-e46c-4979-91e2-503b535150ae"), "ASC 420-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4964) },
                    { new Guid("b88ae792-c31c-4d5f-bb5a-7133734738be"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-230", false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("b8e6051b-d669-448c-8bc0-a6b5a0aaca11"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-230", false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("b9c2dde9-fd81-474b-afd9-b3981cff2af1"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6808), null, null, new Guid("c6a9828b-97df-4f47-9550-c00cc399c73a"), "ASC 820-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6808) },
                    { new Guid("ba65a0de-85d3-429a-b2bf-0748462371d6"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645), null, null, new Guid("410c9e8b-9eb8-4f81-a349-82386daadbe5"), "ASC 350-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645) },
                    { new Guid("ba756631-f2d9-4561-9442-756781d4bdbe"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645), null, null, new Guid("410c9e8b-9eb8-4f81-a349-82386daadbe5"), "ASC 350-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4645) },
                    { new Guid("bb09e275-1957-4aec-9f9e-47fb73d65abd"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377), null, null, new Guid("bd9d29b9-c2cc-4047-b9b3-a4acd32c884c"), "ASC 325-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377) },
                    { new Guid("bb584b03-6640-4d9b-9e5d-35e18621b8b6"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("bb66f64f-7487-46cf-a861-0bbb26c03274"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827), null, null, new Guid("dd338588-7063-445f-800c-686163eca2a9"), "ASC 965-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("bb7521b0-9100-45b6-9a21-c26d260cac9a"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531), null, null, new Guid("22116056-935c-486b-af4d-9f0bf0f43a6b"), "ASC 978-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531) },
                    { new Guid("bc8bd3ed-2287-4c84-9f1a-6cd80ebe345b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998), null, null, new Guid("200d1e19-22dd-4122-826a-6d6879535719"), "ASC 718-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("bca38fc2-76f7-452f-87eb-b2512fc00abb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-205", false, false, "205", "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("bcefe70d-b20d-48a7-97df-7387e4c7d65c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827), null, null, new Guid("dd338588-7063-445f-800c-686163eca2a9"), "ASC 965-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("bd6369c1-7ab7-4e7f-85c6-831f0edab3dc"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5650), null, null, new Guid("87d9459d-e429-401e-9e96-bf1cdaa47725"), "ASC 610-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5650) },
                    { new Guid("bff75c9c-3c5a-4131-9bac-a8bec92479a5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-835", false, false, "835", "Interest", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("c05e77d6-5c69-4c4a-8724-d6b6070c3e3d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998), null, null, new Guid("200d1e19-22dd-4122-826a-6d6879535719"), "ASC 718-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("c1aa1b39-7ca8-458e-b3c9-b7b040108f64"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "ASC 815-45", false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("c3355bbf-b494-407f-a907-1e907f88c7a6"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-920", false, false, "920", "Entertainment—Broadcasters", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("c34b4bba-4bb0-4025-a836-ef61bd967c59"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400), null, null, new Guid("ed18bbf3-3633-4b34-8d96-8e775c165381"), "ASC 860-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400) },
                    { new Guid("c415bb2e-607d-4ee4-9766-730d573627e3"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564), null, null, new Guid("6b3ccf85-dc9c-4f58-995d-98a9a71fffcf"), "ASC 340-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564) },
                    { new Guid("c448dfa3-3e8d-472b-bb8f-cdde067e9a82"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("c47a0281-8658-4e84-b2bb-e7502647368d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733), null, null, new Guid("b4e28f37-adf9-4bcb-9931-fecbb09a9fb0"), "ASC 962-205", false, false, "205", "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9733) },
                    { new Guid("c5314381-1005-4c62-9bdd-87e753be4818"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-505", false, false, "505", "Equity", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("c600372e-3f9c-446b-a45b-10619870aa6c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127), null, null, new Guid("4315bf8d-c939-4d46-8d0a-2fd05b29dcce"), "ASC 842-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7127) },
                    { new Guid("c6cb96f4-04bf-4006-a443-de6bf4904e4b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5066), null, null, new Guid("0623d725-405c-47e8-91a3-da7f69f6f75c"), "ASC 450-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5066) },
                    { new Guid("c72bbdbe-e2c5-4bbb-a04f-7adcac8477f6"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("c801b3a5-8f85-48ae-8960-0e69292094ae"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400), null, null, new Guid("ed18bbf3-3633-4b34-8d96-8e775c165381"), "ASC 860-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400) },
                    { new Guid("c87af0a7-8e86-4266-9280-377d74ebcb89"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5714), null, null, new Guid("4bf2f375-c5a9-49c7-953a-23575087162a"), "ASC 705-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5714) },
                    { new Guid("c8a85a9e-d56c-41d9-8c30-f3cc21226b7c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("c9182ff3-0982-4717-a765-066396023de2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("c9d444ca-84e1-433c-bee8-7a46898ed828"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400), null, null, new Guid("ed18bbf3-3633-4b34-8d96-8e775c165381"), "ASC 860-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7400) },
                    { new Guid("ca8a729f-cf0d-42bd-847c-a0683367ebf4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "ASC 715-60", false, false, "60", "Relationships", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("cb27501e-9cc9-4e63-8207-5f81c78ead70"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5714), null, null, new Guid("4bf2f375-c5a9-49c7-953a-23575087162a"), "ASC 705-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5714) },
                    { new Guid("cb6ccb71-ba53-4636-9abb-9b7ecd67efef"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("cba229f1-0b88-4e3a-ad18-004c52129fd5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564), null, null, new Guid("6b3ccf85-dc9c-4f58-995d-98a9a71fffcf"), "ASC 340-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4564) },
                    { new Guid("cbc80728-efaf-4ccc-8e95-4285c36b3524"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-440", false, false, "440", "Commitments", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("cc2d0a19-3678-4236-8709-b82d43cf1972"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8073), null, null, new Guid("33c5982d-c1a4-4467-9392-8a4766b81ee2"), "ASC 932-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8073) },
                    { new Guid("cc4f661c-f6b6-4cb9-bd9b-6acbb30e1855"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-470", false, false, "470", "Debt", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("cc8ea70d-fa42-4ec9-a00a-7ca78c9519b8"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693), null, null, new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"), "ASC 946-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8693) },
                    { new Guid("cf04f670-bad8-446e-9c20-340d009211bc"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("cf1ac17e-8f72-4dfb-ac66-647d30882456"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-323", false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("cf8199ab-7ad3-4fb1-8a0f-8bed2672592b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("d0f890a4-066e-4aba-8d98-f8ffbfbd8503"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-35", false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("d1f59835-f279-49f4-8e26-79675fca9ca9"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8921), null, null, new Guid("076bf486-a3f8-4d9a-9921-8ff802d66512"), "ASC 948-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8921) },
                    { new Guid("d449693d-8adc-4504-90f2-d8c17e21a5f1"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4756), null, null, new Guid("e27b1da5-bb83-4269-92fe-9fd3718de4de"), "ASC 360-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4756) },
                    { new Guid("d44aefa9-7d4a-4d5d-a789-4aca257ad6e3"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805), null, null, new Guid("de5f4ed4-77cb-4e78-a70a-2068535f6245"), "ASC 405-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4805) },
                    { new Guid("d4affe15-529a-4bff-b2c4-53a30c893d8b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8010), null, null, new Guid("b6ffb347-42c6-4b67-8d28-e4bfc539fe79"), "ASC 930-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8010) },
                    { new Guid("d555968c-d9e2-4763-be2c-b7da79c40217"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034), null, null, new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"), "ASC 954-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9034) },
                    { new Guid("d5d1a409-457f-4339-8cfc-78a4efb22a22"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8921), null, null, new Guid("076bf486-a3f8-4d9a-9921-8ff802d66512"), "ASC 948-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8921) },
                    { new Guid("d686541d-7984-4cf8-a585-ce67058351af"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5650), null, null, new Guid("87d9459d-e429-401e-9e96-bf1cdaa47725"), "ASC 610-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5650) },
                    { new Guid("d686b9f0-62d6-42e9-8fe2-771546bb64e5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3794), null, null, new Guid("6c5ada2e-1480-4e10-b861-82825090f066"), "ASC 225-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(3794) },
                    { new Guid("d6b1072d-1c1d-4f0c-b093-39717c8fb1a2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666), null, null, new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"), "ASC 815-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("d6c86b77-0428-4128-b012-d54ff41826fb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5028), null, null, new Guid("feeb7d75-f0b0-4038-bf9e-2258d4fcacd0"), "ASC 440-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5028) },
                    { new Guid("d6e57f5d-6e4e-4ee1-b99b-458b7a19ef48"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "ASC 980-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("d77bdd4a-8217-4fb7-9ff8-9575a1476990"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("d8482080-a11f-4a86-80bd-7471b05999f4"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7852), null, null, new Guid("784697f1-e30b-4b89-a5e4-35ca5e8c118d"), "ASC 924-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7852) },
                    { new Guid("d8cdd3c9-a49c-424e-9b7b-bd677ea32d9c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4037), null, null, new Guid("76a60c3f-1e99-446f-bbb0-104bd0bbb028"), "ASC 272-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4037) },
                    { new Guid("d8e3837c-b76f-46b1-ad6b-f0d71f8c050f"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "ASC 980-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("d9cb34f0-4e43-4ea4-9c1f-23fcb2d9ea29"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308), null, null, new Guid("5acf7c1a-46df-493a-a190-530148bbfb88"), "ASC 505-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308) },
                    { new Guid("da6c7aec-bdb2-4085-b3d8-ae2ed11c47ca"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871), null, null, new Guid("ca832adb-d194-48e0-9b09-af467008c64a"), "ASC 830-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871) },
                    { new Guid("da7e8964-be76-4fdb-85d3-c9f8e2219aaa"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("dcaa2df5-10f3-4a1a-b1be-55b49d21741a"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("de1bb5c8-1a51-4fdc-ace3-284dcc776a1e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308), null, null, new Guid("5acf7c1a-46df-493a-a190-530148bbfb88"), "ASC 505-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5308) },
                    { new Guid("de3df739-74bf-489e-841f-c3db69d477a2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4200), null, null, new Guid("e2e6e115-402a-451c-8abe-3a0e2de15c4b"), "ASC 310-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4200) },
                    { new Guid("dea4298f-9c5d-4398-ab62-5c9e338648fe"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-35", false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("df776df6-6d90-4643-9ac3-a6a7a679df76"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655), null, null, new Guid("fc614853-a1f5-4f16-9f9b-87acfefa8004"), "ASC 912-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7655) },
                    { new Guid("dfd483c8-975a-4589-9436-6d6e3dabaa59"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856), null, null, new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"), "ASC 715-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("e2a82d18-c25a-43e6-a5a4-fe2f82f9b3f5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4200), null, null, new Guid("e2e6e115-402a-451c-8abe-3a0e2de15c4b"), "ASC 310-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4200) },
                    { new Guid("e406b06d-cc36-433b-9ef4-24a6de87cd9c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137), null, null, new Guid("270d2594-1e13-4c6c-bb31-d13d96c09236"), "ASC 940-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137) },
                    { new Guid("e4796284-ab2e-4933-9f65-6ea581192e2c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5761), null, null, new Guid("942f835e-4816-4cdd-b530-37aeda9f53a8"), "ASC 710-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5761) },
                    { new Guid("e6a40976-3c68-4601-afee-c74f67a570ca"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871), null, null, new Guid("ca832adb-d194-48e0-9b09-af467008c64a"), "ASC 830-230", false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871) },
                    { new Guid("e6a75206-6a0e-4ceb-8892-c55125392557"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("e6d96133-8dee-4f7e-ac9c-ab7d164ee6be"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-28", false, false, "28", "Subtopic 28", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("e739d0f0-29da-4ead-a148-b9902573b0ed"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(754), null, null, new Guid("1cb486ef-a290-443c-8564-2099bd7658be"), "ASC 985-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(754) },
                    { new Guid("e80085ed-1e34-40ca-b093-5d3534f6d43e"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998), null, null, new Guid("200d1e19-22dd-4122-826a-6d6879535719"), "ASC 718-740", false, false, "740", "Income Taxes", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("e95684a8-bb78-4810-9ee5-c90dee17e0ef"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7741), null, null, new Guid("234217d5-f383-4731-94e8-30943260ad96"), "ASC 920-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7741) },
                    { new Guid("ea30a76d-690b-43dd-a8e8-6c82ee4627c8"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("ec2fee68-4215-4243-a4b5-326eea99596b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938), null, null, new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"), "ASC 970-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("ed26b61d-08bf-4a00-92df-51d6ce5f1d61"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8984), null, null, new Guid("bd5bbdaf-2d73-4f1b-91f7-33eefc96087c"), "ASC 950-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8984) },
                    { new Guid("ee732b42-b0be-4309-bd0c-540d4e14db80"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337), null, null, new Guid("a92243a9-81a2-4540-a7f2-b521f7173190"), "ASC 740-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337) },
                    { new Guid("f0df3e14-d7dc-4546-a941-15a10890d15c"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871), null, null, new Guid("ca832adb-d194-48e0-9b09-af467008c64a"), "ASC 830-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6871) },
                    { new Guid("f124e6e8-f87b-42ba-a7e5-8565c18a127a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"), "ASC 958-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("f22a1730-5d09-470b-a108-ef855ecf911b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7899), null, null, new Guid("2c86c46d-43c5-4aa1-82b9-78ebaed76e3d"), "ASC 926-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7899) },
                    { new Guid("f496275e-1181-4af4-a593-448f8086c9ff"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531), null, null, new Guid("22116056-935c-486b-af4d-9f0bf0f43a6b"), "ASC 978-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(531) },
                    { new Guid("f5094e77-0521-4ee5-b064-b87f172d36fb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-10", false, false, "10", "Overall", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("f5b5f9c8-b1cd-471e-95de-53c68fc9ad9a"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243), null, null, new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"), "ASC 942-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8243) },
                    { new Guid("f5c769b5-73aa-481c-8d55-b3fcc2145d6d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435), null, null, new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"), "ASC 805-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6435) },
                    { new Guid("f66e26d9-b2b2-490d-bcb4-6f099e76b90d"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-25", false, false, "25", "Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("f6b10310-8431-46f8-a10f-b098face30ea"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377), null, null, new Guid("bd9d29b9-c2cc-4047-b9b3-a4acd32c884c"), "ASC 325-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(4377) },
                    { new Guid("f73e36c4-a8e4-4dce-80ba-bfe3e405aa4d"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("f7a250dc-d71a-476b-b150-a4ca9d0833b5"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6950), null, null, new Guid("92f367db-07cc-44af-8d69-9998ae4a0569"), "ASC 835-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6950) },
                    { new Guid("f98f1ef4-94bd-45da-8de4-a2551e26a08f"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131), null, null, new Guid("618f209e-4184-4046-966d-94e694bbc5f0"), "ASC 720-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6131) },
                    { new Guid("fa51ca11-6993-459b-b2d3-196543fe36cb"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421), null, null, new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"), "ASC 605-25", false, false, "25", "Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(5421) },
                    { new Guid("fa5ab3ca-d255-4d01-a4bc-aff0656851c2"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-505", false, false, "505", "Equity", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) },
                    { new Guid("fabbc005-5e30-4eb1-8167-bff4c7ad1706"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-470", false, false, "470", "Debt", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("fb55331e-a8db-4379-bb52-a430d821206b"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137), null, null, new Guid("270d2594-1e13-4c6c-bb31-d13d96c09236"), "ASC 940-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8137) },
                    { new Guid("fca18f9a-79e5-4407-9443-15355ef7c885"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225), null, null, new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"), "ASC 974-205", false, false, "205", "Presentation", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(225) },
                    { new Guid("fcc5f851-7618-4b22-b9b7-5301692edb01"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(754), null, null, new Guid("1cb486ef-a290-443c-8564-2099bd7658be"), "ASC 985-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(754) },
                    { new Guid("fcc689ea-9044-4a09-b7c3-44f76be0b334"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7804), null, null, new Guid("ba70a63b-9065-44b4-9708-2cbb37d6806c"), "ASC 922-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(7804) },
                    { new Guid("fd72c2de-f879-4bec-bc22-4406a20b7481"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337), null, null, new Guid("a92243a9-81a2-4540-a7f2-b521f7173190"), "ASC 740-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(6337) },
                    { new Guid("fe9d03c0-1764-4df8-9068-7f9b46565377"), new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612), null, null, new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"), "ASC 980-340", false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 7, 6, 5, 57, 90, DateTimeKind.Utc).AddTicks(612) },
                    { new Guid("febad975-238a-4486-9b1f-e40bcbe0cb81"), new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454), null, null, new Guid("04de1214-2685-43c9-8850-a507e719b161"), "ASC 944-310", false, false, "310", "Receivables", new DateTime(2026, 2, 7, 6, 5, 57, 89, DateTimeKind.Utc).AddTicks(8454) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCountTracking_LicenseId_RecordedAt",
                schema: "dbo",
                table: "EmployeeCountTracking",
                columns: new[] { "LicenseId", "RecordedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_LicenseKey",
                schema: "dbo",
                table: "Licenses",
                column: "LicenseKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanFeatures_LicenseId_FeatureCode",
                schema: "dbo",
                table: "PlanFeatures",
                columns: new[] { "LicenseId", "FeatureCode" });

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLines_InventoryItemId",
                schema: "dbo",
                table: "SalesOrderLines",
                column: "InventoryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLines_RevenueAccountId",
                schema: "dbo",
                table: "SalesOrderLines",
                column: "RevenueAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLines_SalesOrderId",
                schema: "dbo",
                table: "SalesOrderLines",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_CompanyId",
                schema: "dbo",
                table: "SalesOrders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_CustomerId",
                schema: "dbo",
                table: "SalesOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_WarehouseId",
                schema: "dbo",
                table: "SalesOrders",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnLines_InventoryItemId",
                schema: "dbo",
                table: "SalesReturnLines",
                column: "InventoryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnLines_SalesOrderLineId",
                schema: "dbo",
                table: "SalesReturnLines",
                column: "SalesOrderLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnLines_SalesReturnId",
                schema: "dbo",
                table: "SalesReturnLines",
                column: "SalesReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturns_CompanyId",
                schema: "dbo",
                table: "SalesReturns",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturns_CustomerId",
                schema: "dbo",
                table: "SalesReturns",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturns_InvoiceId",
                schema: "dbo",
                table: "SalesReturns",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturns_SalesOrderId",
                schema: "dbo",
                table: "SalesReturns",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SOShipmentLines_BatchLotId",
                schema: "dbo",
                table: "SOShipmentLines",
                column: "BatchLotId");

            migrationBuilder.CreateIndex(
                name: "IX_SOShipmentLines_InventoryItemId",
                schema: "dbo",
                table: "SOShipmentLines",
                column: "InventoryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SOShipmentLines_SalesOrderLineId",
                schema: "dbo",
                table: "SOShipmentLines",
                column: "SalesOrderLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SOShipmentLines_ShipmentId",
                schema: "dbo",
                table: "SOShipmentLines",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SOShipments_CompanyId",
                schema: "dbo",
                table: "SOShipments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SOShipments_CustomerId",
                schema: "dbo",
                table: "SOShipments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SOShipments_SalesOrderId",
                schema: "dbo",
                table: "SOShipments",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SOShipments_WarehouseId",
                schema: "dbo",
                table: "SOShipments",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionHistory_LicenseId_OccurredAt",
                schema: "dbo",
                table: "SubscriptionHistory",
                columns: new[] { "LicenseId", "OccurredAt" });

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_FASBSubtopics_FASBSubtopicId",
                schema: "dbo",
                table: "Accounts",
                column: "FASBSubtopicId",
                principalSchema: "dbo",
                principalTable: "FASBSubtopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_FASBTopics_FASBTopicId",
                schema: "dbo",
                table: "Accounts",
                column: "FASBTopicId",
                principalSchema: "dbo",
                principalTable: "FASBTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_FASBSubtopics_FASBSubtopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_FASBTopics_FASBTopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "EmployeeCountTracking",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PlanFeatures",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesReturnLines",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SOShipmentLines",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SubscriptionHistory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesReturns",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SOShipments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesOrderLines",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Licenses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesOrders",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("00084b33-08c3-430e-bb1f-14b680cd41ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("00c49468-564f-4c16-aa0d-dd4b3c12e74a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("013bed1d-c594-4d4b-a761-2f66174944b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("01f6dd0a-c8cc-4726-8647-ce236d35487b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("028415f7-32d3-4385-a812-79612036042b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("033cf02a-8ffe-403d-8363-a60c0f796413"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("04742d12-db87-4b09-a658-56b490e8e4af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("065dd83d-ffb5-4366-8b37-5cbfbf9e9ac1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("078978d2-2df2-47b1-846d-de095be0db08"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("07a7624e-ff4c-4b7e-b322-adbe63f55436"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("07d4b154-e123-496c-a4a7-bdde0406e65d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("07dfc26f-dede-4d2c-8d01-be3b98217fec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("08ec1977-a13d-447b-8da1-6a67dd65b2a4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("09ddbd35-138a-4d4d-81f2-4138c2ab92b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0a5f7312-3fbd-4c69-a73b-ec7055d24b55"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0ab2b740-260f-4a8c-95cb-3702e8c8e967"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0ade51c5-adc0-4897-a75b-4c2e2b776daf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0b0ed602-dbe1-4640-a648-9e7c52a68f07"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0b42756a-454d-48b0-a047-ea5ed1984810"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0bd7aed4-cbc0-40f6-aa11-5a2693604983"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0c0125bb-2e2c-4290-958c-221a912440d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0c1403ac-c285-466c-880f-5856d28d9176"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0c55797e-622d-4afc-8279-59dea06a9dd2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0e63993a-1266-45d1-b85f-68c2219daea2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0e989dd8-9c9b-4068-a4d3-a5fc6c1302aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0ea0246f-fb72-4f54-bdb4-87e8a3eacca6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1172272c-36cd-49e4-a126-22fe3bbee43e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("118e1f95-9f9b-48c8-b233-201bc28fa511"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("11d604d5-c138-419d-9fde-b79d26dbed3c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("133a509a-a622-4ba1-87a8-81a1ca05202c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("136544f3-6e41-42f6-a968-18f141c1d912"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("13bd2cd9-2221-406d-85e6-525eb3b9bbdf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("13dbe201-3a11-436f-a8cf-df727259d444"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("13dd14dd-a17d-491d-b1fa-3a4119ff9649"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("14325e5d-043b-4461-a4b2-62c5d6754cff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1531c270-671b-4f9b-a191-7524cbd4ea48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("153ddb9f-4886-4e4e-931f-6e235d2260d0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("15bd4e93-07d7-4b0c-8007-cf439f5b8524"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("16b80d27-361e-42c7-b0e6-8761e82ca40d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1908336c-1aa4-4c91-8895-275f55ad2e66"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("19452c4b-6a53-4776-aedd-f94eb931ebdb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("195c65d4-b745-4ea1-91c6-022e1211722e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1a9472af-9138-4ccd-9cf4-126f0e918129"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1af69ff7-fa2d-4d22-84a4-345512df9c20"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1b859437-6fbb-44e0-8bd4-1734d2812db9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1c08d218-1424-4bff-9de7-70399156d086"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1dc42de6-a087-4265-b70a-4a0306d6c703"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1e4e0729-e88e-4ec9-aea7-dc78f40802f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1f542ecd-ab27-424c-bd1d-8479ec32be94"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2013509d-16bb-4a0f-b75a-e8ae68cc136f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("20a99d31-3683-4605-9009-6ca945947b2a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("20fc0190-411a-4d0b-b0ea-326e2476f080"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2169d16b-dba8-4b14-a2e1-3d03cb44b714"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("217e3c87-6c37-491c-a08d-831b295de983"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("21f9652d-ba1a-4e99-909b-6c85915de6e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2349edf0-6acc-4156-bd7f-20b875cb2ca9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("243ef8ac-fe12-4712-b71e-fb8729acf46a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("252d6eb8-a39a-4573-a0fc-05e4e108f423"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("25f8ca10-2a43-41c4-b34e-51d145c6fc45"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("260d75c6-8d6e-473e-9798-81ef4f623df0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("26eb7ba5-1174-48bf-9403-7a5bb5f1848c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2791ebdb-00f1-4df0-b863-fb84a498453d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2b0790a0-db9f-4d78-84d7-a8c4f9ec6af4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2cbf34ff-5de8-4059-96d2-b6749336d9f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2cd29cb7-9dbd-4524-a507-94c2a170a388"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2d765ba7-4188-4818-9e07-81d6e173ab04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2e6a1d20-16c8-4276-b19a-7fe2f9ff4a32"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2e9bf2a7-7b6a-4de0-aeb4-80493560339a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2ec699db-54e1-476e-a2ec-ba7546eeaad9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2f24f3df-bc2e-4951-90a1-2f43f2840311"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2f542e73-d845-44a3-8e0e-22df395e251f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2fc18f94-975a-40a6-8bf1-741668f7d740"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2fedcacb-5d1e-4541-852a-723b224ee435"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3066b238-b6c3-4804-b32a-d4ef239021af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("314c7f8e-e5e4-43d0-a862-40c0b9739cbc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("32d95959-1ec1-46d7-8c5a-74d3f83ec229"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3360d0e5-444b-46db-abab-5138f66e4a7e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("340ca4ab-0140-465b-930d-fe2279971842"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("342ddacd-bb02-4b4c-bb63-ecdfe62a793b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3496c8a8-6d3d-4520-8252-d33d59392e7f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("355b7c83-50f0-4ad8-9433-02d9b697bf01"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("35a249ce-ce8d-49e3-b5de-eee728c413c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("37dd9f8a-20f1-4014-a1b2-88f10a80e631"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3872970b-34da-4eb7-9386-7e186cdbfcdb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("38fc1435-f5ed-4213-9977-b42107b867ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3ab32de2-473b-4de4-a2f1-4526a55e953e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3ac2e98b-9494-4b40-8b0a-6a3d47d864eb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3b44b064-9200-4961-a4bb-b98b3740d0e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3be33d30-fdff-4efe-a7c7-3dd01f229f76"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3c6ea3dc-8691-4af1-94ed-23cd0b14c94a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3ca6f88b-7d96-4653-8b1f-38b05af902b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3d8c520a-0c5b-44f5-ae42-13cf27960e9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3dffa688-691d-4dd6-8c52-6a6f50c6190e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3f76aeed-1879-442f-af2e-2900e141636a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("400b3343-d4a1-4b40-9152-eaf37a0da1e4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("400d3b31-867b-448f-aa8a-03c90a54d157"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("41bc73cb-f3b3-4fb7-a819-20105ca56334"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("41c4d8f4-8840-457b-93dd-98955fd87cbc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("42400bf7-6d2b-47c7-aa88-37828a507c6c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("45851957-3e50-4fdf-85a9-538923474be7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("46572146-c1f4-4bd8-b42f-d90bba631439"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("469a9571-f5eb-47c4-bd24-b88dbce7a57e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("46f68a88-826e-4ac6-8e3c-57f14c532723"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("482ff298-6b81-42ad-8dcf-657df8f4f08f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("489ddca9-5099-4379-940c-466558383d04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("49d35f9e-4c22-42c8-b533-8ace9beb3638"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4a2ee404-01f6-4103-bc5d-a445550501b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4aa70efa-3cbd-4c69-86b8-3420625231f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4ad3800d-288c-4d0d-92f4-759c901f38f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4b2a66f6-ba4a-471d-93b8-d4d00ccdd8df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4b9a8949-c480-43c5-8d93-980e8119aa14"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4c4be596-0f2b-40b4-b964-fd9b654b9e7d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4dccc160-fa4a-4a8d-b1e7-4009c502e514"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4e00c468-b459-4dd3-adb9-7ca84c53269d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4e5c3643-3514-4f7f-b45d-85d4ad6819f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4ed53ac1-35d0-4f54-91f5-f2f079b2b532"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4fc0a532-389d-449e-8b8e-2fee3201875b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("51035c5e-a185-4d04-a99a-4a8a24351dfb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5137a927-ddd3-4581-8543-91988165527a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("52238401-39ec-4283-8c58-6af75bca1257"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("527b5c58-efbf-47e1-ad07-146630f5c761"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("544a339a-55eb-4740-9c23-f25dd82afea1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5455015f-360d-4635-a2f5-711909145af4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("54f455b4-f4b7-48be-bd6d-72e9a45c7e83"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("551ef24f-ee2c-4b36-a433-17eda9ad4b92"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("55be7206-5529-4a9f-a1af-ee934e46b550"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("566b5833-e8b9-4cb7-95db-1fd393dde2dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("56fac55f-ce5d-4b3b-97f7-b309fe36d4fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("57c31206-5d92-42d1-b0f4-0fa145572f35"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5818ed91-2cab-4e3d-bf8f-52531038919d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("58259601-bc60-458e-a9cc-cb21c23cee85"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("58440537-550d-4984-8ce9-fbd472c68b13"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5ab6e584-f055-4fa0-9b38-4b26838717d2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5c887f95-7133-4038-bae0-cc581ac2d4cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5da202ba-d318-4667-9edd-e9d67f4642c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5e776f09-5895-4e07-81fc-ec1978cdebd0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("603a8fe1-e25e-4a41-ae42-080a7c4a871f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("606a360d-a95e-4b77-b8eb-37dd6ea7b52d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("61a625dc-972c-4f55-a1bf-bd684361f8a4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("61c0384b-191a-412f-84de-7579bd631ae3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("62191a50-7a96-4999-8c34-cbad2db77973"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6310b03c-2cdf-4a52-a0d5-b525686ce37d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6326ab86-a577-4ae6-ace4-71c193ee19e9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("638fda43-4cee-41e4-aa3e-706e1f8647e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("63bfa188-f8b9-425f-b62d-581b41ab9f5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6664c05b-68c8-4d75-a25a-136131e66592"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("669f3b00-6b39-4c55-9fcf-b1bb68a308fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("68d8b9b6-a7b7-4ec3-ac5e-c3a351766263"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("68e1c9e8-5192-4092-ab92-7375d7ae90c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("69435f36-c641-48f8-aec7-b7139ed2df70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6951db85-0816-4a2a-9ab9-4a674f2491ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("696a02ab-e8ff-4daa-85ac-1f70da46ca6e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("69e1fdde-c693-4115-afd8-71b772a99176"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6b188f1d-2a9d-4752-9bde-09f936d69341"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6c7fcad4-8e22-4ee6-92e2-9a9f02c8a322"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6dccb33f-e6de-4f1f-8230-f1521f30e775"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6edc8fbc-0c5e-4d7f-9be1-d2eb0b1437fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7006e03f-47ee-4ee6-a800-c6a594d7f33f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("71977706-a6fc-4566-9c44-1cee327861e6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("71f0b477-56b8-4ab8-b2bd-046fff0f1172"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("722225d2-e044-4592-a13c-abc0ccbabf7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("72a0efd7-2758-49f8-aaa7-e92cde8df460"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7350fe8d-3758-4006-be09-170c5ffc9434"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("749ca2ee-e861-45c5-9247-002bd7c679a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("75117b2a-0ca6-448e-8dd6-90a8016194ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("77c3c7e5-b73e-4054-9fdc-0277077f12ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("787b65ad-650d-41a3-bcc7-3e33a75c08ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("78da6559-8bd1-4ab7-b2c1-cdcb16ce85c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("78de3259-11e2-433b-8e24-fcd8a4fd9227"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7a413a0d-a820-40f9-a48e-84edf4b2bb6c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7b62e8bf-9fd5-4abe-83b7-bc7f77dcf983"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7bc59a9a-e21e-4815-84bc-3ae04380f4b5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7c3e30c5-3b46-4f14-b42a-ce6bfd259c22"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7caac03e-0302-435f-b5e2-949b961f394c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7cee67b0-e228-4025-933b-89c82343358d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7ee711f3-520d-42b3-8ae5-f5bf60bd988d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7ef9f45a-fceb-4ae4-8dee-b3be6f8c4e8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7f30e858-1f3c-4e8a-bd08-54916b4156ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7f76295a-3ca6-49bd-b037-134145d49289"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("803b85ee-bdb8-46ca-b96c-5b2af56c3686"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("806ce214-6f36-4a3b-95cd-b032042f2c4e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("807393ff-cc8f-426f-8bb4-4b23b2e2545c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("818061c2-576c-4e51-8f72-abda11fd0e34"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("82018aa6-b50e-4bca-9871-939f93fa2321"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("82340195-0717-4be4-b2ec-e90c3a42145d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("824c49b7-423a-4923-8392-e1e7ecd8ca01"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("82f3c32c-0980-4b17-8bb6-90b8e0e4f647"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("83695b96-eda3-46eb-8e74-52f6c87dc44b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("850e00fe-34e7-4073-a7e5-8f9720bd12c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("85374e3b-d1ef-440c-a5e8-47d3c709c3bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("85749535-afcf-4931-acce-f75fae2cee03"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("85cac14f-6dca-4f8c-8c17-28037c5b4237"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("88104263-bb85-4cbe-ad4a-5c1177263779"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("88861097-2fd7-4c9e-a336-73bb76123daa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("88b98437-a8d6-4430-993a-e6b12e76895a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8ab7fa72-25fb-40d2-958c-fc73339f4037"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8bc132ff-34b8-429f-8272-ecc347966770"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8c0239d0-fa4e-4958-ace8-371dfd64b5ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8cbddb37-74c1-4d5e-9de0-9354e2f412bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8f235fe6-acc9-4d87-b3fc-fc079bf553fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9064011a-ac2e-4d15-a362-fe84ac364ba5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("919e49ef-50fa-49bf-9705-10cfff6eeb59"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("91ab6b4c-2257-48cc-82df-d1dbba9a571d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9226d34f-830a-4866-aff8-94c192a31868"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("94986d81-80c8-458e-93d9-3ba7dae5b762"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("951985d3-7dac-47fe-8158-63748bbc4cb2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("962cc1e2-4f42-49ff-9720-760deb47bfb7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("968f6670-02c7-4e7b-9736-a330a47b3f01"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("99741a8e-7526-4d65-a69c-3f8e20a49f02"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9992bc77-9dc9-4cd4-b3ac-932bd5c1eb4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("99b85dec-5297-48e5-a0be-ffff5489cc61"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9d883ea2-3a57-4ee7-a6db-043c79d24408"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9e3263e8-50b3-4e37-9b8b-fe85cba2bccf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9ead88d5-9703-4451-8fcf-da58b5a8a0e7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9f77893b-ad6d-4d3f-9cc2-07ffa04156af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9fbc4b2a-6e1d-4919-8d49-aa3559e4cbf4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a092bad8-23a3-4a20-af04-e721247ce6b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a09f6cdb-8b56-4634-8c6e-548c7b222a17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a22d41cc-1193-4f72-9bc9-87d34c3fb2f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a303eb54-a1f7-4af1-a67e-5bdee5846ae7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a39167af-b89f-4208-b239-7fc0838a44c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a41c0480-ea35-4a15-b388-3a6c475a035a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a47e54f2-a3d9-4f0c-b535-183782e92775"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a53ab08b-4618-45ca-b918-c23155d83d48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a71d53e0-ad7c-47a7-9eba-a27546c10e4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a901808a-8687-481d-b4cb-952dd98848f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a9c23ee7-de3e-4768-b63c-1680d00bcc3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("aadd5ebd-0a31-4f5a-861a-8c0b258f6642"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("aaf742ea-74e9-47aa-bfbf-92ec4939a9fa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("aafe444b-eebc-45f3-9865-883092e1b775"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ab3a44c7-3353-40df-914f-e71041f757aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ab6da580-7535-4364-910f-ee7267250cac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("abb9a22a-7fe7-4493-a125-8df0f94272d2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ac5f6803-d53e-48bf-b449-dd7e0f1d87b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ad53b99c-6707-4046-adeb-e308fdd45e97"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ae3ee838-45db-4d06-8ade-260ff4649ae0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ae748ca8-6279-426b-affb-1cbe6b7da9e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b03af9bb-dd86-40e7-9897-3bc3c5b1a342"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b10c72f6-0b53-4487-b8f6-8adae1d72cf0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b2355405-36ea-4eb1-a129-f27c86d9d50d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b2be5b35-16a5-41d2-a668-a354585dfe91"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b320c446-dfb5-4d11-9c83-ff52487cecbd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b394495d-54ca-4024-8436-44bf2cd71aeb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b4263598-f7c9-4ea1-9024-6a604e6afc5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b4c9bad4-b340-4f81-a2ed-1773b15acd10"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b4d6bbba-bb63-4102-9146-51d038208ba6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b50f5556-cba9-4802-9cd1-2a56dd525cbc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b51e3330-e3c8-4aef-bed6-d610885eae7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b5dd31fe-f240-4804-accf-bc251ec5c143"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b61831aa-e532-40e6-b900-4bb41f598db9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b88ae792-c31c-4d5f-bb5a-7133734738be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b8e6051b-d669-448c-8bc0-a6b5a0aaca11"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b9c2dde9-fd81-474b-afd9-b3981cff2af1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ba65a0de-85d3-429a-b2bf-0748462371d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ba756631-f2d9-4561-9442-756781d4bdbe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb09e275-1957-4aec-9f9e-47fb73d65abd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb584b03-6640-4d9b-9e5d-35e18621b8b6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb66f64f-7487-46cf-a861-0bbb26c03274"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb7521b0-9100-45b6-9a21-c26d260cac9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bc8bd3ed-2287-4c84-9f1a-6cd80ebe345b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bca38fc2-76f7-452f-87eb-b2512fc00abb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bcefe70d-b20d-48a7-97df-7387e4c7d65c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bd6369c1-7ab7-4e7f-85c6-831f0edab3dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bff75c9c-3c5a-4131-9bac-a8bec92479a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c05e77d6-5c69-4c4a-8724-d6b6070c3e3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c1aa1b39-7ca8-458e-b3c9-b7b040108f64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c3355bbf-b494-407f-a907-1e907f88c7a6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c34b4bba-4bb0-4025-a836-ef61bd967c59"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c415bb2e-607d-4ee4-9766-730d573627e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c448dfa3-3e8d-472b-bb8f-cdde067e9a82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c47a0281-8658-4e84-b2bb-e7502647368d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c5314381-1005-4c62-9bdd-87e753be4818"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c600372e-3f9c-446b-a45b-10619870aa6c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c6cb96f4-04bf-4006-a443-de6bf4904e4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c72bbdbe-e2c5-4bbb-a04f-7adcac8477f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c801b3a5-8f85-48ae-8960-0e69292094ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c87af0a7-8e86-4266-9280-377d74ebcb89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c8a85a9e-d56c-41d9-8c30-f3cc21226b7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c9182ff3-0982-4717-a765-066396023de2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c9d444ca-84e1-433c-bee8-7a46898ed828"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ca8a729f-cf0d-42bd-847c-a0683367ebf4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cb27501e-9cc9-4e63-8207-5f81c78ead70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cb6ccb71-ba53-4636-9abb-9b7ecd67efef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cba229f1-0b88-4e3a-ad18-004c52129fd5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cbc80728-efaf-4ccc-8e95-4285c36b3524"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cc2d0a19-3678-4236-8709-b82d43cf1972"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cc4f661c-f6b6-4cb9-bd9b-6acbb30e1855"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cc8ea70d-fa42-4ec9-a00a-7ca78c9519b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cf04f670-bad8-446e-9c20-340d009211bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cf1ac17e-8f72-4dfb-ac66-647d30882456"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cf8199ab-7ad3-4fb1-8a0f-8bed2672592b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d0f890a4-066e-4aba-8d98-f8ffbfbd8503"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d1f59835-f279-49f4-8e26-79675fca9ca9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d449693d-8adc-4504-90f2-d8c17e21a5f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d44aefa9-7d4a-4d5d-a789-4aca257ad6e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d4affe15-529a-4bff-b2c4-53a30c893d8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d555968c-d9e2-4763-be2c-b7da79c40217"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d5d1a409-457f-4339-8cfc-78a4efb22a22"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d686541d-7984-4cf8-a585-ce67058351af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d686b9f0-62d6-42e9-8fe2-771546bb64e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d6b1072d-1c1d-4f0c-b093-39717c8fb1a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d6c86b77-0428-4128-b012-d54ff41826fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d6e57f5d-6e4e-4ee1-b99b-458b7a19ef48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d77bdd4a-8217-4fb7-9ff8-9575a1476990"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d8482080-a11f-4a86-80bd-7471b05999f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d8cdd3c9-a49c-424e-9b7b-bd677ea32d9c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d8e3837c-b76f-46b1-ad6b-f0d71f8c050f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d9cb34f0-4e43-4ea4-9c1f-23fcb2d9ea29"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("da6c7aec-bdb2-4085-b3d8-ae2ed11c47ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("da7e8964-be76-4fdb-85d3-c9f8e2219aaa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("dcaa2df5-10f3-4a1a-b1be-55b49d21741a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("de1bb5c8-1a51-4fdc-ace3-284dcc776a1e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("de3df739-74bf-489e-841f-c3db69d477a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("dea4298f-9c5d-4398-ab62-5c9e338648fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("df776df6-6d90-4643-9ac3-a6a7a679df76"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("dfd483c8-975a-4589-9436-6d6e3dabaa59"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e2a82d18-c25a-43e6-a5a4-fe2f82f9b3f5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e406b06d-cc36-433b-9ef4-24a6de87cd9c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e4796284-ab2e-4933-9f65-6ea581192e2c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e6a40976-3c68-4601-afee-c74f67a570ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e6a75206-6a0e-4ceb-8892-c55125392557"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e6d96133-8dee-4f7e-ac9c-ab7d164ee6be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e739d0f0-29da-4ead-a148-b9902573b0ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e80085ed-1e34-40ca-b093-5d3534f6d43e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e95684a8-bb78-4810-9ee5-c90dee17e0ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ea30a76d-690b-43dd-a8e8-6c82ee4627c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ec2fee68-4215-4243-a4b5-326eea99596b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ed26b61d-08bf-4a00-92df-51d6ce5f1d61"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ee732b42-b0be-4309-bd0c-540d4e14db80"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f0df3e14-d7dc-4546-a941-15a10890d15c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f124e6e8-f87b-42ba-a7e5-8565c18a127a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f22a1730-5d09-470b-a108-ef855ecf911b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f496275e-1181-4af4-a593-448f8086c9ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f5094e77-0521-4ee5-b064-b87f172d36fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f5b5f9c8-b1cd-471e-95de-53c68fc9ad9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f5c769b5-73aa-481c-8d55-b3fcc2145d6d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f66e26d9-b2b2-490d-bcb4-6f099e76b90d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f6b10310-8431-46f8-a10f-b098face30ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f73e36c4-a8e4-4dce-80ba-bfe3e405aa4d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f7a250dc-d71a-476b-b150-a4ca9d0833b5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f98f1ef4-94bd-45da-8de4-a2551e26a08f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fa51ca11-6993-459b-b2d3-196543fe36cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fa5ab3ca-d255-4d01-a4bc-aff0656851c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fabbc005-5e30-4eb1-8167-bff4c7ad1706"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fb55331e-a8db-4379-bb52-a430d821206b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fca18f9a-79e5-4407-9443-15355ef7c885"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fcc5f851-7618-4b22-b9b7-5301692edb01"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fcc689ea-9044-4a09-b7c3-44f76be0b334"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fd72c2de-f879-4bec-bc22-4406a20b7481"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fe9d03c0-1764-4df8-9068-7f9b46565377"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("febad975-238a-4486-9b1f-e40bcbe0cb81"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("04de1214-2685-43c9-8850-a507e719b161"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0623d725-405c-47e8-91a3-da7f69f6f75c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("076bf486-a3f8-4d9a-9921-8ff802d66512"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("08197df4-9a2b-4d11-b377-5efcf2c14d07"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("09fda948-1ff2-42b0-a258-425b9bf4af7a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0eeb2a3a-6285-4792-b690-a8eaed9a0d4f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0f58938a-7727-4a51-8526-154110be1c37"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1c7fdf97-8dcf-459c-8c36-77d2eae7f8c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1cb486ef-a290-443c-8564-2099bd7658be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1e8f8644-915c-44ff-90d2-2288d08a1d4c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1f16a8be-50df-4fff-83e4-a6dcd5c8b467"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("200d1e19-22dd-4122-826a-6d6879535719"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("22116056-935c-486b-af4d-9f0bf0f43a6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("2293a310-1b1c-4b08-a4f7-b24d39ae3e9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("22d74ce5-8186-4fca-bd54-b79708bde34b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("22eb2c64-d0c4-4167-818c-594075501dea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("234217d5-f383-4731-94e8-30943260ad96"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("253bb9ff-417b-4ef9-978c-0be44ee2f96a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("270d2594-1e13-4c6c-bb31-d13d96c09236"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("2a44c184-515f-43a5-a66d-cd867293f4ee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("2c86c46d-43c5-4aa1-82b9-78ebaed76e3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("337ecdbf-e355-4ab1-b6f1-32eac4a5a215"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("33c5982d-c1a4-4467-9392-8a4766b81ee2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("3ffc9610-010d-4ed8-a49d-ec937fa2eea1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("410c9e8b-9eb8-4f81-a349-82386daadbe5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("425cb621-4be5-49a3-a26d-5bd923a5e949"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4315bf8d-c939-4d46-8d0a-2fd05b29dcce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4485d6f0-e553-4fc9-8be1-fb9553d3e905"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("487da968-b5ac-4757-b0be-0fc5477c9444"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4bf2f375-c5a9-49c7-953a-23575087162a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4cd09eba-bd74-4024-bbe1-7283350ded5c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("56905d50-30fb-41c8-a4dd-11dc20f5a8c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5acf7c1a-46df-493a-a190-530148bbfb88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5f6d7fef-492a-4b60-b62a-4a49e5925c4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("618f209e-4184-4046-966d-94e694bbc5f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("679b504d-6533-49c3-8408-0f3ad2697e30"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("6b3ccf85-dc9c-4f58-995d-98a9a71fffcf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("6c5ada2e-1480-4e10-b861-82825090f066"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("6d3180ac-73ee-4500-bf63-9c21ecacb51b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("71e52f46-62d6-4bb5-85a0-aa102713b92e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("76a60c3f-1e99-446f-bbb0-104bd0bbb028"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("784697f1-e30b-4b89-a5e4-35ca5e8c118d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("7d8ae2c0-c052-44eb-a1eb-99d1617dfba8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("80013570-a38f-4aa8-b1e7-5e7572f85954"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("83d3c3b2-9a6e-4409-8a55-559edc1874fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("85482aa7-5f83-4035-83e5-d60a5764a73e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("855e87af-eea0-4ce0-b2fb-bd357e31e41d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("871bb9a3-dacc-4647-8889-46adce138e4d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("87d9459d-e429-401e-9e96-bf1cdaa47725"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("90e3a116-ba25-4971-8500-afe0aaadd2be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("929ef6c5-bc8e-4066-8f7f-d0437532d07f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("92f367db-07cc-44af-8d69-9998ae4a0569"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("942f835e-4816-4cdd-b530-37aeda9f53a8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("95785526-9732-40eb-8bab-775ffed3adef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("9b2ad909-ff27-4861-adb1-bcb171aaaea1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("9f51f52a-7d81-4f64-b7c4-9e837537e7ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a0bba39f-20d8-4806-8c4b-0eaa600ec375"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a4277175-8ab2-4a56-afed-160ad0d241ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a4edbb9c-b599-49e5-abe1-73c42880e77e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a92243a9-81a2-4540-a7f2-b521f7173190"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a9a7d783-6b01-4ad2-b92a-a47d1df9c889"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b17a4cd4-b48d-4055-bd78-d06d38ee94fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b1e39780-de1c-4e5b-b843-5d85fc285e0a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b4e28f37-adf9-4bcb-9931-fecbb09a9fb0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b6ffb347-42c6-4b67-8d28-e4bfc539fe79"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b8b2e4bd-ceaf-4666-bdec-7b4f7c255616"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b980f5bc-e46c-4979-91e2-503b535150ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("ba70a63b-9065-44b4-9708-2cbb37d6806c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("bd5bbdaf-2d73-4f1b-91f7-33eefc96087c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("bd9d29b9-c2cc-4047-b9b3-a4acd32c884c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c0225360-6750-4582-9f5d-05cb62a82fbb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c23df90c-1b41-48ef-8dde-aef3e1d1be8f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c6a9828b-97df-4f47-9550-c00cc399c73a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c8a4fbd1-36b0-4bde-8681-800182a8c880"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("ca832adb-d194-48e0-9b09-af467008c64a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("dd338588-7063-445f-800c-686163eca2a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("de5f4ed4-77cb-4e78-a70a-2068535f6245"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e02880f7-b239-4fb9-875d-1fb63906c8a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e27b1da5-bb83-4269-92fe-9fd3718de4de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e2e6e115-402a-451c-8abe-3a0e2de15c4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e2eeafd7-48be-46e9-beb3-6fa60afb0e7e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e7a7d05c-e691-4111-b567-b122e7dff8f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e9f79ce3-dfb5-4da6-89e7-1d384bf5eafa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("ed18bbf3-3633-4b34-8d96-8e775c165381"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f1232c25-e521-431e-9346-fb9ec6450bef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f1574109-b405-47ce-bd19-6d021e43fd28"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f48e9490-d0bc-467a-a291-df46f9fd8821"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("fc614853-a1f5-4f16-9f9b-87acfefa8004"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("fe205890-09cb-4911-a05d-8d5a8795f8aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("feeb7d75-f0b0-4038-bf9e-2258d4fcacd0"));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FASBTopics",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "IsSuperseded", "SupersededBy", "TopicCode", "TopicName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a80cf3c-126b-499b-adfc-90365ec76731"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190), null, null, false, false, null, "965", "Plan Accounting—Health and Welfare Benefit Plans", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190) },
                    { new Guid("0bab2718-4916-4468-9993-8572a6882f7f"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935), null, null, false, false, null, "470", "Debt", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935) },
                    { new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, false, false, null, "980", "Regulated Operations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("0f82980a-1dfc-419a-b99a-fa081c7d7589"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(9052), null, null, false, false, null, "985", "Software", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(9052) },
                    { new Guid("0fb93137-ae54-4758-9933-881c13b20809"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3358), null, null, false, false, null, "330", "Inventory", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3358) },
                    { new Guid("11ddc8e2-1154-458b-9b7d-15f1def71110"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8796), null, null, false, true, "ASC 606", "976", "Real Estate—Retail Land", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8796) },
                    { new Guid("13f1aa2d-9cab-4e47-b016-ebee1899826d"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607), null, null, false, false, null, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607) },
                    { new Guid("140669f0-9543-45bd-ae29-765473abcfe7"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5456), null, null, false, false, null, "820", "Fair Value Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5456) },
                    { new Guid("1e7905d2-5e14-4190-b0e3-44584949a981"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6057), null, null, false, false, null, "905", "Agriculture", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6057) },
                    { new Guid("2051ef90-2112-4e62-bbd7-fed074247313"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215), null, null, false, false, null, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215) },
                    { new Guid("20b16cc7-30b3-4e6b-b7bf-bb551e2b0b35"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2872), null, null, false, false, null, "270", "Interim Reporting", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2872) },
                    { new Guid("20c94d8d-3a64-4858-a19b-a0834e5eda87"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002), null, null, false, false, null, "960", "Plan Accounting—Defined Benefit Pension Plans", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002) },
                    { new Guid("26b0bc87-ba06-42b1-95ef-b47413d5f0ab"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514), null, null, false, false, null, "830", "Foreign Currency Matters", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514) },
                    { new Guid("26e07710-3918-4bf0-b327-c6466e635576"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649), null, null, false, false, null, "940", "Financial Services—Brokers and Dealers", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649) },
                    { new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, false, false, null, "958", "Not-for-Profit Entities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("311082fb-cca2-4507-a64e-64b7998debd9"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6483), null, null, false, false, null, "928", "Entertainment—Music", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6483) },
                    { new Guid("331a667b-c7c5-45cc-8c5c-04a93807034d"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8503), null, null, false, false, null, "972", "Real Estate—Common Interest Realty Associations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8503) },
                    { new Guid("33603828-3d97-4630-aa08-30182a3116b1"), "Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4487), null, null, false, false, null, "710", "Compensation—General", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4487) },
                    { new Guid("37cd1131-3500-4c1a-90ce-b9dbfcb806e9"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5268), null, null, false, false, null, "808", "Collaborative Arrangements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5268) },
                    { new Guid("3995e9be-88fa-4f50-9702-6c0cb0e44636"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724), null, null, false, false, null, "842", "Leases", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724) },
                    { new Guid("3ebaa5cb-e6b5-41cb-bb33-a715ea5d086f"), "Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4443), null, null, false, false, null, "705", "Cost of Sales and Services", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4443) },
                    { new Guid("3f5b3a32-9bd0-4245-8c92-88410cc3b83a"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460), null, null, false, false, null, "350", "Intangibles—Goodwill and Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460) },
                    { new Guid("40843736-5c8d-44d0-8a81-b7304b276609"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840), null, null, false, false, null, "978", "Real Estate—Time-Sharing Activities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, false, false, null, "720", "Other Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("48ded176-92fe-45d5-a422-0ad570370a88"), "Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019), null, null, false, false, null, "740", "Income Taxes", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019) },
                    { new Guid("4a7b9ce7-07a8-469c-b63e-51acb7ca8e4c"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969), null, null, false, false, null, "860", "Transfers and Servicing", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969) },
                    { new Guid("4e7dfdfe-0ba5-4a5b-9902-1e26a45abe1b"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2902), null, null, false, false, null, "272", "Limited Liability Entities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2902) },
                    { new Guid("4ff63ca9-8e4f-454a-9df9-0d6ca1a213f7"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2687), null, null, false, false, null, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2687) },
                    { new Guid("508a714a-ca3b-4acc-9e44-97857ef949fa"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2991), null, null, false, false, null, "280", "Segment Reporting", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2991) },
                    { new Guid("508cf940-b141-4f77-9bdf-aaf0dfa15075"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651), null, null, false, true, "ASC 842", "840", "Leases", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651) },
                    { new Guid("54dd4c12-c037-4169-84c8-78da96e26e1f"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3848), null, null, false, false, null, "450", "Contingencies", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3848) },
                    { new Guid("5a5dfcd8-d1a2-40f1-9edb-03c01e459145"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5940), null, null, false, false, null, "855", "Subsequent Events", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5940) },
                    { new Guid("5bdae584-cd61-4471-9481-2200f1daa86a"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3905), null, null, false, false, null, "460", "Guarantees", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3905) },
                    { new Guid("5c7a4384-70cf-4959-ae78-252f029a08e3"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5485), null, null, false, false, null, "825", "Financial Instruments", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5485) },
                    { new Guid("5d6fd464-38a4-47db-a2b0-d43c3f2fa319"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3053), null, null, false, false, null, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3053) },
                    { new Guid("5dd91913-6cc1-4134-abb9-6034604f53e7"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6340), null, null, false, false, null, "922", "Entertainment—Cable Television", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6340) },
                    { new Guid("5e6cb7d9-0cb6-4f3b-a165-e56a8923337d"), "Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4530), null, null, false, false, null, "712", "Compensation—Nonretirement Postemployment Benefits", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4530) },
                    { new Guid("6084f16f-0cae-4b5e-91cf-a8a2602581b0"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5897), null, null, false, false, null, "852", "Reorganizations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5897) },
                    { new Guid("612110f5-28e0-4b9a-9661-d4921d84e22c"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6426), null, null, false, false, null, "926", "Entertainment—Films", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6426) },
                    { new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, false, false, null, "815", "Derivatives and Hedging", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("6c5bd89e-91bb-4057-bef0-5f6589b0a629"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3022), null, null, false, false, null, "305", "Cash and Cash Equivalents", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3022) },
                    { new Guid("6e6d7609-fffc-45ca-b9f6-0ec66d3316a1"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2814), null, null, false, false, null, "250", "Accounting Changes and Error Corrections", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2814) },
                    { new Guid("72b48ffd-3ca1-4a63-93d9-5082f902a89e"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5868), null, null, false, false, null, "850", "Related Party Disclosures", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5868) },
                    { new Guid("73bdd1e8-dcf8-482a-8ae4-ef2b1673c8a2"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2843), null, null, false, false, null, "260", "Earnings Per Share", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2843) },
                    { new Guid("73c3f842-71ac-449b-91b5-14e7999c2226"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5594), null, null, false, false, null, "835", "Interest", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5594) },
                    { new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, false, false, null, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("7a99ca57-ff36-4cd5-9458-58729748dea4"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3299), null, null, false, false, null, "326", "Financial Instruments—Credit Losses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3299) },
                    { new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, false, false, null, "974", "Real Estate—Real Estate Investment Trusts", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("7fcec6a5-68e6-4e7c-94f6-1c7f4f4189d6"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6282), null, null, false, false, null, "920", "Entertainment—Broadcasters", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6282) },
                    { new Guid("80388014-bf69-4c8d-a6df-0e7f963073e3"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3752), null, null, false, false, null, "420", "Exit or Disposal Cost Obligations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3752) },
                    { new Guid("8556d81f-1d65-4f82-b254-b098d88a460e"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208), null, null, false, false, null, "912", "Contractors—Federal Government", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208) },
                    { new Guid("868579dc-b374-4864-8380-f7fe6d73f438"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6121), null, null, false, false, null, "908", "Airlines", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6121) },
                    { new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, false, false, null, "946", "Financial Services—Investment Companies", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("8c233cfd-d89c-47b3-a08c-c123fe2f674c"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4037), null, null, false, false, null, "480", "Distinguishing Liabilities from Equity", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4037) },
                    { new Guid("8c8da832-9a43-429a-93f4-865a3f5c3a8b"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2961), null, null, false, false, null, "274", "Personal Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2961) },
                    { new Guid("8c8f4c68-7004-49e7-80f2-1efde75c55fd"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5839), null, null, false, false, null, "848", "Reference Rate Reform", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5839) },
                    { new Guid("8ff41b56-db70-4785-9b6a-72731c7aabab"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2774), null, null, false, false, null, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2774) },
                    { new Guid("90855ac4-9f5c-4d4a-a187-5efaf9f29c35"), "Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4975), null, null, false, false, null, "730", "Research and Development", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4975) },
                    { new Guid("92d6440c-f5b0-4d5a-b349-e050ce561315"), "Equity", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069), null, null, false, false, null, "505", "Equity", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069) },
                    { new Guid("968d2799-9a5e-459d-a781-762af032cba2"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2595), null, null, false, false, null, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2595) },
                    { new Guid("98203b8f-8f43-4c82-a0e1-f78acb36db24"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3694), null, null, false, false, null, "410", "Asset Retirement and Environmental Obligations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3694) },
                    { new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, false, false, null, "954", "Health Care Entities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, false, false, null, "970", "Real Estate—General", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("a565b1ee-acff-4236-96de-b7bb96620f4b"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5810), null, null, false, false, null, "845", "Nonmonetary Transactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5810) },
                    { new Guid("a57dec8c-ae88-4d01-bfd8-7d01660da54b"), "Revenue", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4340), null, null, false, false, null, "606", "Revenue from Contracts with Customers", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4340) },
                    { new Guid("a7a4e2cd-9c72-4531-a004-bc716420cbc4"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3171), null, null, false, false, null, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3171) },
                    { new Guid("a980c07a-27d2-42fb-a3a9-853b8e2858dd"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2933), null, null, false, false, null, "273", "Corporate Joint Ventures", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2933) },
                    { new Guid("af448d74-6f8f-4f1f-b189-05b63f7d3806"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7359), null, null, false, false, null, "948", "Financial Services—Mortgage Banking", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7359) },
                    { new Guid("b4b4b69b-223b-41f2-b296-517c26c1c1bc"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387), null, null, false, false, null, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387) },
                    { new Guid("bd35979f-8bc1-4b02-83c2-006fe0ef8a2e"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2496), null, null, false, false, null, "205", "Presentation of Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2496) },
                    { new Guid("bdd61938-8803-475a-9a09-7a9fbfd0f5e8"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3819), null, null, false, false, null, "440", "Commitments", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3819) },
                    { new Guid("bebfc796-5a16-4902-8d02-39a3152984d6"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2738), null, null, false, false, null, "230", "Statement of Cash Flows", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2738) },
                    { new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "Revenue", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, false, true, "ASC 606", "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, false, false, null, "944", "Financial Services—Insurance", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("d0657f37-3d70-4f1f-b88a-4b3ba2e74c38"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6164), null, null, false, false, null, "910", "Contractors—Construction", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6164) },
                    { new Guid("d43d4832-2dcb-4cac-b837-a9dad2ba16eb"), "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3789), null, null, false, true, "ASC 606", "430", "Deferred Revenue", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3789) },
                    { new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, false, false, null, "805", "Business Combinations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("dac30188-680e-46e5-97ff-efb3a0de4801"), "Revenue", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4384), null, null, false, false, null, "610", "Other Income", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4384) },
                    { new Guid("dda2660b-f000-48a8-b02d-d31029e07cff"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5297), null, null, false, false, null, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5297) },
                    { new Guid("de8c2abc-63d9-4ced-aa81-8ae605379d73"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3112), null, null, false, true, "ASC 321 and ASC 326", "320", "Investments—Debt Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3112) },
                    { new Guid("e11e1e10-fa8f-43b9-be78-a91c68791130"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103), null, null, false, false, null, "962", "Plan Accounting—Defined Contribution Pension Plans", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103) },
                    { new Guid("e4fe5587-f9ba-45d4-aae6-18b4f098ae04"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6527), null, null, false, false, null, "930", "Extractive Activities—Mining", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6527) },
                    { new Guid("e931f435-ae90-40c4-b044-c3f2c58646e5"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3562), null, null, false, false, null, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3562) },
                    { new Guid("ec7225f8-c8c6-4530-a1db-a51d385facf7"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7417), null, null, false, false, null, "950", "Financial Services—Title Plant", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7417) },
                    { new Guid("eea6366a-82a7-4672-8f59-fcbcf64abdfd"), "Assets", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3141), null, null, false, false, null, "321", "Investments—Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3141) },
                    { new Guid("efa8e7f4-0a44-4537-a0cc-1ab0480a6627"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6383), null, null, false, false, null, "924", "Entertainment—Casinos", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6383) },
                    { new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"), "Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704), null, null, false, false, null, "718", "Compensation—Stock Compensation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704) },
                    { new Guid("f73eee2c-ae4e-4ef5-a720-2d56e5399c09"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6591), null, null, false, false, null, "932", "Extractive Activities—Oil and Gas", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6591) },
                    { new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "Industry", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, false, false, null, "942", "Financial Services—Depository and Lending", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("fd700a75-fef2-4700-8dc6-4215819155dd"), "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2642), null, null, false, false, null, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2642) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FASBSubtopics",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "FASBTopicId", "FullReference", "IsDeleted", "IsRepealed", "SubtopicCode", "SubtopicName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("006afc48-bb4d-4daa-a06a-efc1ffd52b42"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387), null, null, new Guid("b4b4b69b-223b-41f2-b296-517c26c1c1bc"), "ASC 340-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387) },
                    { new Guid("01cfd371-a7ee-4281-87ff-3f68b2f9c41d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2687), null, null, new Guid("4ff63ca9-8e4f-454a-9df9-0d6ca1a213f7"), "ASC 225-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2687) },
                    { new Guid("02139fe6-c949-435f-b886-0398600b0a9d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("03eab407-68a7-4c8e-a284-e8e66465f662"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002), null, null, new Guid("20c94d8d-3a64-4858-a19b-a0834e5eda87"), "ASC 960-205", false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002) },
                    { new Guid("054ae04e-ceba-450f-99fb-b2937f57e2de"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("05788d35-4286-4ba7-9586-7e073aadbd94"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607), null, null, new Guid("13f1aa2d-9cab-4e47-b016-ebee1899826d"), "ASC 405-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607) },
                    { new Guid("073443b6-057f-4489-982d-fa192dfea3f7"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "ASC 815-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("095098b6-518d-4733-bd56-28ec782dfd0b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935), null, null, new Guid("0bab2718-4916-4468-9993-8572a6882f7f"), "ASC 470-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935) },
                    { new Guid("0a7381aa-fa67-4e11-b8c4-950489d9205e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-606", false, false, "606", "Revenue from Contracts with Customers", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("0b5b1bde-8b0b-4f2c-891c-54bbc352796c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7417), null, null, new Guid("ec7225f8-c8c6-4530-a1db-a51d385facf7"), "ASC 950-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7417) },
                    { new Guid("0e17efe9-19e0-4f3d-82b3-0df30f51e40c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103), null, null, new Guid("e11e1e10-fa8f-43b9-be78-a91c68791130"), "ASC 962-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103) },
                    { new Guid("0ef65bdf-5466-452d-9f5e-3ed5f531aed4"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019), null, null, new Guid("48ded176-92fe-45d5-a422-0ad570370a88"), "ASC 740-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019) },
                    { new Guid("0f2e5e09-ff1f-4f8e-b108-b1e168732700"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935), null, null, new Guid("0bab2718-4916-4468-9993-8572a6882f7f"), "ASC 470-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935) },
                    { new Guid("0f494812-e424-4013-b8c1-7790d1cdd34e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "ASC 980-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("0fded2d2-1a3e-489a-b041-b1d5dda46182"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-60", false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("11007b8c-cb60-4a1b-8d23-c0a5ca690c75"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3562), null, null, new Guid("e931f435-ae90-40c4-b044-c3f2c58646e5"), "ASC 360-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3562) },
                    { new Guid("115ddac9-69f8-4710-a1fd-54771966f318"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3112), null, null, new Guid("de8c2abc-63d9-4ced-aa81-8ae605379d73"), "ASC 320-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3112) },
                    { new Guid("11bad2ea-7e97-4501-8147-87757ce97323"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069), null, null, new Guid("92d6440c-f5b0-4d5a-b349-e050ce561315"), "ASC 505-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069) },
                    { new Guid("120bc7f6-99ef-4f4c-8369-c686f04183b9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("12fd3a8b-f9a2-4c38-aef9-36525d6c1818"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6282), null, null, new Guid("7fcec6a5-68e6-4e7c-94f6-1c7f4f4189d6"), "ASC 920-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6282) },
                    { new Guid("13d6e2c2-e47c-4cfb-8d97-603330444378"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-25", false, false, "25", "Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("162e4908-3ce5-4692-a83f-0100e2746ba6"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840), null, null, new Guid("40843736-5c8d-44d0-8a81-b7304b276609"), "ASC 978-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("17737085-54a3-4723-ba28-8c73ddf89d56"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-323", false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("17998002-0fd1-434f-a563-e705879f01bf"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("1a557148-aec7-4599-af80-011a77374262"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-920", false, false, "920", "Entertainment—Broadcasters", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("1b504b7e-34e5-49fc-a658-a3254ef26813"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("1c25fed3-f860-4631-b523-c65531ef3762"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("1c9e0bd7-2251-46a1-a782-b5a5e401c1df"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("1cce5572-46c2-48f8-881f-84958cff2b83"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("1d771ad0-8a13-4323-b349-c5bf5070aef7"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "ASC 815-35", false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("1f30ec5d-24b8-4de3-bad0-5c85ed843671"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460), null, null, new Guid("3f5b3a32-9bd0-4245-8c92-88410cc3b83a"), "ASC 350-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460) },
                    { new Guid("1f901080-169e-468f-ab51-691fe0cf079c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("206e39fa-6af9-4b51-b4f4-56b894ede286"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("20ea0702-61f0-4e8f-bd78-1bf0d211e45c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-505", false, false, "505", "Equity", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("20f1812a-588a-415d-a557-2f2864eab331"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("212f0997-9dca-41fb-9bf5-dea6148790fb"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103), null, null, new Guid("e11e1e10-fa8f-43b9-be78-a91c68791130"), "ASC 962-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103) },
                    { new Guid("23b43bd5-78a1-451c-beb6-4463ed9429fe"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5940), null, null, new Guid("5a5dfcd8-d1a2-40f1-9edb-03c01e459145"), "ASC 855-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5940) },
                    { new Guid("24477952-a987-4136-96a2-819f7b2f385e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "ASC 980-340", false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("264aa248-93d7-4bf0-a253-7d9077825257"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649), null, null, new Guid("26e07710-3918-4bf0-b327-c6466e635576"), "ASC 940-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649) },
                    { new Guid("2684bf37-4bbf-4b17-8467-ce36d5327a09"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969), null, null, new Guid("4a7b9ce7-07a8-469c-b63e-51acb7ca8e4c"), "ASC 860-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969) },
                    { new Guid("2733e275-1701-40fd-bc55-7ca2dd486c15"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3848), null, null, new Guid("54dd4c12-c037-4169-84c8-78da96e26e1f"), "ASC 450-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3848) },
                    { new Guid("27ca4619-4681-4593-b53e-f5ba4598469a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3848), null, null, new Guid("54dd4c12-c037-4169-84c8-78da96e26e1f"), "ASC 450-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3848) },
                    { new Guid("28abb56a-30df-41eb-afac-9bc9626d99bc"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-28", false, false, "28", "Subtopic 28", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("290fb12c-254b-4352-8f33-06457e38aaf3"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("2a3e0cab-fea8-46bd-b9f2-8d99c999ebb1"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4975), null, null, new Guid("90855ac4-9f5c-4d4a-a187-5efaf9f29c35"), "ASC 730-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4975) },
                    { new Guid("2a9678c7-df12-4219-9254-093dc52d7647"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103), null, null, new Guid("e11e1e10-fa8f-43b9-be78-a91c68791130"), "ASC 962-205", false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103) },
                    { new Guid("2ae640b8-2791-4dec-85c1-df98d3870fac"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("2b2d8202-313b-405f-8a2f-37c741c550ed"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(9052), null, null, new Guid("0f82980a-1dfc-419a-b99a-fa081c7d7589"), "ASC 985-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(9052) },
                    { new Guid("2b6f4abe-d73c-4c43-a806-e7fb6fee2c89"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-205", false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("2df53f2a-ad80-4378-b4e3-e25d2f20b53d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5297), null, null, new Guid("dda2660b-f000-48a8-b02d-d31029e07cff"), "ASC 810-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5297) },
                    { new Guid("2e5e3bd9-3192-4128-962b-b96e109bc3cd"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387), null, null, new Guid("b4b4b69b-223b-41f2-b296-517c26c1c1bc"), "ASC 340-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387) },
                    { new Guid("2e6790d4-b06b-4577-9efa-a5ca7d524174"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5594), null, null, new Guid("73c3f842-71ac-449b-91b5-14e7999c2226"), "ASC 835-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5594) },
                    { new Guid("2f5347ce-dd0d-4641-9faf-6cc055f9e173"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("2f77e28a-83aa-456a-a91b-e28b7cb5d575"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6591), null, null, new Guid("f73eee2c-ae4e-4ef5-a720-2d56e5399c09"), "ASC 932-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6591) },
                    { new Guid("2fa706e3-2d98-486f-b560-1288bda2612d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651), null, null, new Guid("508cf940-b141-4f77-9bdf-aaf0dfa15075"), "ASC 840-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651) },
                    { new Guid("2fe77f84-b13e-40ce-a392-08bf3fb00c45"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-815", false, false, "815", "Derivatives and Hedging", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("302d8abb-399f-4e82-ab7f-676c2aef6203"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208), null, null, new Guid("8556d81f-1d65-4f82-b254-b098d88a460e"), "ASC 912-330", false, false, "330", "Inventory", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208) },
                    { new Guid("308a0402-c861-49c4-a448-4d21279aa0f6"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6282), null, null, new Guid("7fcec6a5-68e6-4e7c-94f6-1c7f4f4189d6"), "ASC 920-350", false, false, "350", "Intangibles—Goodwill and Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6282) },
                    { new Guid("30e3a467-2aa6-4e6c-99aa-5a49939b401a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2843), null, null, new Guid("73bdd1e8-dcf8-482a-8ae4-ef2b1673c8a2"), "ASC 260-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2843) },
                    { new Guid("31276716-b39c-41c7-8443-78093775e925"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935), null, null, new Guid("0bab2718-4916-4468-9993-8572a6882f7f"), "ASC 470-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935) },
                    { new Guid("3196b28c-e891-4b72-a880-031656f1c7d8"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("32375f76-0d00-43f0-98c9-a6bec042dd25"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-450", false, false, "450", "Contingencies", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("32bd5ec6-b19b-478c-9d55-da2f437809b4"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("32ee97a9-19d5-411a-8573-e0d096392270"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(9052), null, null, new Guid("0f82980a-1dfc-419a-b99a-fa081c7d7589"), "ASC 985-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(9052) },
                    { new Guid("332d3abc-d550-4e12-bf6d-88641c8c7826"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-15", false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("3342e8b8-8f68-4822-a373-11d85bddbe0c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-25", false, false, "25", "Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("34771f76-5428-4f7a-8e3b-cd48c020aec4"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("34e236c1-c0fd-40e5-8379-cfe7a78abc26"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("3510bc13-9338-45d4-b7ce-93f092eed3cf"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2872), null, null, new Guid("20b16cc7-30b3-4e6b-b7bf-bb551e2b0b35"), "ASC 270-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2872) },
                    { new Guid("351c82e6-0517-4439-a401-b58b18b1a3c0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6057), null, null, new Guid("1e7905d2-5e14-4190-b0e3-44584949a981"), "ASC 905-330", false, false, "330", "Inventory", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6057) },
                    { new Guid("36255ee6-4a70-4668-8424-17be68541544"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4037), null, null, new Guid("8c233cfd-d89c-47b3-a08c-c123fe2f674c"), "ASC 480-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4037) },
                    { new Guid("36d79ca7-9c8c-46b5-a9e1-c8d2f65ef4ac"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215), null, null, new Guid("2051ef90-2112-4e62-bbd7-fed074247313"), "ASC 325-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215) },
                    { new Guid("383eba15-e13f-4fe6-a49a-0d1b85f84e91"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3022), null, null, new Guid("6c5bd89e-91bb-4057-bef0-5f6589b0a629"), "ASC 305-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3022) },
                    { new Guid("38806a68-6d44-4f84-b37d-7e1fc73c89b6"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5485), null, null, new Guid("5c7a4384-70cf-4959-ae78-252f029a08e3"), "ASC 825-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5485) },
                    { new Guid("38de07f4-7f1b-42fa-adc6-7e38a96ba562"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935), null, null, new Guid("0bab2718-4916-4468-9993-8572a6882f7f"), "ASC 470-60", false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935) },
                    { new Guid("3a324e3c-fb84-4ae7-9dda-44e18cfbf233"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-470", false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("3a775203-cac8-4279-8b42-c07635408d64"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("3a883878-074f-4b94-9856-d74fda640d8e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935), null, null, new Guid("0bab2718-4916-4468-9993-8572a6882f7f"), "ASC 470-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935) },
                    { new Guid("3ae23533-2c0b-4ca7-8e58-4ec845a3454c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3562), null, null, new Guid("e931f435-ae90-40c4-b044-c3f2c58646e5"), "ASC 360-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3562) },
                    { new Guid("3af0a415-b4c8-412e-b1bf-b2f06a3f8052"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6591), null, null, new Guid("f73eee2c-ae4e-4ef5-a720-2d56e5399c09"), "ASC 932-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6591) },
                    { new Guid("3b1c3de5-6c81-4d6b-af3f-e305d5508d1f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("3b394308-5485-4f63-9fb3-3a3380886123"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "ASC 715-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("3cc95d57-9d67-45bc-bf7d-901616caff30"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "ASC 715-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("3d1ff7eb-a1c9-4dc1-9370-a8f4ade878a0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("3d511cc6-f98b-422e-810b-80c21a900546"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7417), null, null, new Guid("ec7225f8-c8c6-4530-a1db-a51d385facf7"), "ASC 950-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7417) },
                    { new Guid("3ea2d7c2-306c-416c-a700-9701ea3d66db"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("3ed6b758-e77c-46ef-8b3b-8ed0851a2473"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6527), null, null, new Guid("e4fe5587-f9ba-45d4-aae6-18b4f098ae04"), "ASC 930-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6527) },
                    { new Guid("40cdb484-e0f9-4cf5-a569-3e3cf4228d00"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3299), null, null, new Guid("7a99ca57-ff36-4cd5-9458-58729748dea4"), "ASC 326-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3299) },
                    { new Guid("4113021a-f8db-4705-b3a2-02a72a18666e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4443), null, null, new Guid("3ebaa5cb-e6b5-41cb-bb33-a715ea5d086f"), "ASC 705-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4443) },
                    { new Guid("42a27edd-5352-4700-b6d2-2cd5a5e75a66"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5594), null, null, new Guid("73c3f842-71ac-449b-91b5-14e7999c2226"), "ASC 835-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5594) },
                    { new Guid("43dee448-6ea4-4496-a02d-d384ac892ff5"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019), null, null, new Guid("48ded176-92fe-45d5-a422-0ad570370a88"), "ASC 740-270", false, false, "270", "Interim Reporting", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019) },
                    { new Guid("443f8888-9cb4-4c90-a1d3-c506fb7df591"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("468f6232-8eb2-4e21-94a7-ba6550719192"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("46fc0bf4-2a93-4bf6-ae71-d9a2bb4c3cbd"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("48766df4-6970-4faa-b995-b26b5890c413"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("49c2ae54-f237-4030-83ae-a08899459468"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "ASC 980-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("4ac3fdf2-2320-4c5e-aed3-f8ee9c42f52d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649), null, null, new Guid("26e07710-3918-4bf0-b327-c6466e635576"), "ASC 940-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649) },
                    { new Guid("4b656b6d-0ba2-4fe6-b93f-69cda18bc20f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("4c7d8cf2-5296-4c67-ab1e-4b4440a164f1"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651), null, null, new Guid("508cf940-b141-4f77-9bdf-aaf0dfa15075"), "ASC 840-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651) },
                    { new Guid("4d60abfa-b25c-4eef-9d78-a0e57d93146f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704), null, null, new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"), "ASC 718-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704) },
                    { new Guid("4e0da4c1-2ffe-4d68-852e-ebce5b4cfbe5"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "ASC 715-60", false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("4e204740-02db-440d-8d38-cc628eba2e00"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("4eb34567-dc5b-4d5d-afd7-5d25ef509e34"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103), null, null, new Guid("e11e1e10-fa8f-43b9-be78-a91c68791130"), "ASC 962-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103) },
                    { new Guid("4f5a5c28-0583-4ba7-8433-54e9886ca585"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("4fdf5b58-25df-433e-be2d-4941ad548df3"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-35", false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("50c96d93-22eb-4068-857b-6f3e24e1f75a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2595), null, null, new Guid("968d2799-9a5e-459d-a781-762af032cba2"), "ASC 210-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2595) },
                    { new Guid("511482f3-e79a-44ad-b169-598b1d749902"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514), null, null, new Guid("26b0bc87-ba06-42b1-95ef-b47413d5f0ab"), "ASC 830-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514) },
                    { new Guid("51dda8a2-150e-410a-81c1-8f8ed77d1c89"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-230", false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("526e70a2-0679-4cb4-bf68-bf930bf019b2"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6591), null, null, new Guid("f73eee2c-ae4e-4ef5-a720-2d56e5399c09"), "ASC 932-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6591) },
                    { new Guid("52aed62b-f590-49ee-b4b8-8a42c9515806"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7359), null, null, new Guid("af448d74-6f8f-4f1f-b189-05b63f7d3806"), "ASC 948-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7359) },
                    { new Guid("53872a41-c248-4e6d-b278-e57c3866afcd"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002), null, null, new Guid("20c94d8d-3a64-4858-a19b-a0834e5eda87"), "ASC 960-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002) },
                    { new Guid("53b31ede-1d1f-4b9d-80ee-42cdf44c0ca1"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("542783dc-bc49-4240-b934-8a981fe6f3f9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5897), null, null, new Guid("6084f16f-0cae-4b5e-91cf-a8a2602581b0"), "ASC 852-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5897) },
                    { new Guid("5492dc15-2dfd-4d1b-aafd-138c16e81da9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "ASC 715-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("55ed87eb-fc6c-4c78-a2c9-221c86646092"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724), null, null, new Guid("3995e9be-88fa-4f50-9702-6c0cb0e44636"), "ASC 842-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724) },
                    { new Guid("5695e75b-560c-4135-be53-4ab2fcf52a6b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460), null, null, new Guid("3f5b3a32-9bd0-4245-8c92-88410cc3b83a"), "ASC 350-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460) },
                    { new Guid("5725ca32-f32e-4506-ac2a-afe55645f12d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215), null, null, new Guid("2051ef90-2112-4e62-bbd7-fed074247313"), "ASC 325-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215) },
                    { new Guid("59c90420-f536-4ab0-a092-b0f9e6f1d3c5"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("59ef7798-e41f-40ad-be65-8bcc507f55a9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190), null, null, new Guid("0a80cf3c-126b-499b-adfc-90365ec76731"), "ASC 965-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190) },
                    { new Guid("5a864278-51fc-45bc-bdbd-0c879c429154"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460), null, null, new Guid("3f5b3a32-9bd0-4245-8c92-88410cc3b83a"), "ASC 350-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460) },
                    { new Guid("5af7a7c3-110c-47d4-aa52-5b7510a26aeb"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-954", false, false, "954", "Health Care Entities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("5b035f34-fe03-49d5-a0e5-8fa9b3910df3"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208), null, null, new Guid("8556d81f-1d65-4f82-b254-b098d88a460e"), "ASC 912-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208) },
                    { new Guid("5bf0029e-7355-45f6-aae1-00811ae40ff8"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "ASC 715-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("5c4ff64e-d71d-4965-a438-667142ff63e6"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3299), null, null, new Guid("7a99ca57-ff36-4cd5-9458-58729748dea4"), "ASC 326-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3299) },
                    { new Guid("5c542d87-4436-4d6a-97a1-e39bd145376f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-205", false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("5e70a924-bbd6-4350-8aa2-ca33993f9af5"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208), null, null, new Guid("8556d81f-1d65-4f82-b254-b098d88a460e"), "ASC 912-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208) },
                    { new Guid("5fbb0ee2-bdeb-40af-b8aa-2b10dfedd82d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8503), null, null, new Guid("331a667b-c7c5-45cc-8c5c-04a93807034d"), "ASC 972-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8503) },
                    { new Guid("6034bfdd-b3f9-49fe-88fb-56341290e3f2"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-470", false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("60cd9973-a01f-4997-bc46-4a0d281fd7e2"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019), null, null, new Guid("48ded176-92fe-45d5-a422-0ad570370a88"), "ASC 740-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019) },
                    { new Guid("612fd488-13ef-417a-9ac7-c53eb761d372"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("61b03f62-5e8c-4526-b05b-9a6ddec97583"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("61e82f04-c0f1-4c0b-92dd-8377a12b2c18"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651), null, null, new Guid("508cf940-b141-4f77-9bdf-aaf0dfa15075"), "ASC 840-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651) },
                    { new Guid("61ee0edf-8d5e-4e9a-a7ca-51ed9aa09166"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("6212fc8c-f53e-4615-95e2-7f5f4beba0ca"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190), null, null, new Guid("0a80cf3c-126b-499b-adfc-90365ec76731"), "ASC 965-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190) },
                    { new Guid("62b628e2-f706-4949-a3e1-5a08941cfa88"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6527), null, null, new Guid("e4fe5587-f9ba-45d4-aae6-18b4f098ae04"), "ASC 930-330", false, false, "330", "Inventory", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6527) },
                    { new Guid("6334ea8e-5322-42bb-8d26-e35b49d38ce9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("63ba1212-d384-4ff6-bbbb-54c5c49efb4b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6383), null, null, new Guid("efa8e7f4-0a44-4537-a0cc-1ab0480a6627"), "ASC 924-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6383) },
                    { new Guid("63c30b3f-0928-41ce-8391-037655384e7b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3171), null, null, new Guid("a7a4e2cd-9c72-4531-a004-bc716420cbc4"), "ASC 323-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3171) },
                    { new Guid("6466bbfb-381b-45f1-a951-65d4aff05b77"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-810", false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("649e4ce9-75c9-4a50-8567-931cf701da76"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-45", false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("653e60d6-ea67-4ba1-b3ff-fcba0fe60afe"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "ASC 980-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("657f3216-e42a-4b10-be0b-9c4399bd94c8"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-720", false, false, "720", "Other Expenses", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("65e1ade8-d72f-45d8-997f-696080765893"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651), null, null, new Guid("508cf940-b141-4f77-9bdf-aaf0dfa15075"), "ASC 840-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5651) },
                    { new Guid("677763d1-d1f2-459d-9364-e7158cf40eae"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("69184902-221e-443b-bcde-469e3d2d6bcc"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840), null, null, new Guid("40843736-5c8d-44d0-8a81-b7304b276609"), "ASC 978-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("69c7fcc5-e58d-4922-89a0-3571de2223f3"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514), null, null, new Guid("26b0bc87-ba06-42b1-95ef-b47413d5f0ab"), "ASC 830-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514) },
                    { new Guid("69ef82b6-98b4-42d7-a275-2e45e081d87a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("6b02abd2-4886-4f98-ac62-c2ea001a55bb"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5868), null, null, new Guid("72b48ffd-3ca1-4a63-93d9-5082f902a89e"), "ASC 850-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5868) },
                    { new Guid("6b7a8dc7-ae1a-4a8a-a23f-67f10c034f8a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("6c10f3e7-e5e5-42d4-9b4e-5929f0f2b85c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6426), null, null, new Guid("612110f5-28e0-4b9a-9661-d4921d84e22c"), "ASC 926-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6426) },
                    { new Guid("6cff6635-e8e2-4343-b7fb-8f9156326122"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6426), null, null, new Guid("612110f5-28e0-4b9a-9661-d4921d84e22c"), "ASC 926-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6426) },
                    { new Guid("6e66146b-197f-49ff-9639-a2f4d0d9fa31"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("707e726a-52ac-4f4f-92cc-0b5ce8c379d4"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "ASC 715-80", false, false, "80", "Multiemployer Plans", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("70cbc79e-accb-4ecd-b4a6-e7a4ba5a5a17"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4975), null, null, new Guid("90855ac4-9f5c-4d4a-a187-5efaf9f29c35"), "ASC 730-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4975) },
                    { new Guid("70d5641f-1125-4d0f-b28b-eaae857ba773"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("712b089f-5b12-405d-8638-3ad0db533738"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("72053b56-31fe-4481-a1a6-96cc5b9a95f8"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724), null, null, new Guid("3995e9be-88fa-4f50-9702-6c0cb0e44636"), "ASC 842-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724) },
                    { new Guid("72187175-99d6-4ab5-9cca-0dba084fb95b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724), null, null, new Guid("3995e9be-88fa-4f50-9702-6c0cb0e44636"), "ASC 842-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724) },
                    { new Guid("7248046a-a071-4546-9662-fe3d82bab4d0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("75065260-728d-4db4-b420-4f6e0b5b048c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2642), null, null, new Guid("fd700a75-fef2-4700-8dc6-4215819155dd"), "ASC 220-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2642) },
                    { new Guid("75c63d98-7311-4640-89d6-7c1c4b47918d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514), null, null, new Guid("26b0bc87-ba06-42b1-95ef-b47413d5f0ab"), "ASC 830-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514) },
                    { new Guid("763b7b4c-51b5-4174-910e-06bf67dfc224"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("768b2224-fd7c-468d-bf47-f5bde7893ddc"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969), null, null, new Guid("4a7b9ce7-07a8-469c-b63e-51acb7ca8e4c"), "ASC 860-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969) },
                    { new Guid("785fa3c1-5720-4152-bbd7-8558cd275065"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190), null, null, new Guid("0a80cf3c-126b-499b-adfc-90365ec76731"), "ASC 965-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190) },
                    { new Guid("79d65b23-5657-4d8c-8fe9-05e70e224ebf"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002), null, null, new Guid("20c94d8d-3a64-4858-a19b-a0834e5eda87"), "ASC 960-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002) },
                    { new Guid("7bb515ab-0f6e-4019-a952-2a91fd8f0805"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("7c6c9ddf-80d4-4784-b1fd-c17bf18e583c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6164), null, null, new Guid("d0657f37-3d70-4f1f-b88a-4b3ba2e74c38"), "ASC 910-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6164) },
                    { new Guid("7ca07817-c869-46ec-8d21-555cf7897638"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-205", false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("7d94e11c-f1fa-4ef4-ae63-6b95745732c9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3905), null, null, new Guid("5bdae584-cd61-4471-9481-2200f1daa86a"), "ASC 460-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3905) },
                    { new Guid("80c1c487-4f5a-4082-8685-7283b7481fe6"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "ASC 980-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("82de3b3b-dd17-4607-85e6-c4fdfd79b39f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-470", false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("82fa8157-35c5-4577-8be1-21305753fb36"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5839), null, null, new Guid("8c8f4c68-7004-49e7-80f2-1efde75c55fd"), "ASC 848-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5839) },
                    { new Guid("832560d5-e0f3-480c-9df1-f11656600232"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7359), null, null, new Guid("af448d74-6f8f-4f1f-b189-05b63f7d3806"), "ASC 948-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7359) },
                    { new Guid("83392d6c-10a4-4a3f-a096-82631a1b6db3"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "ASC 715-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("8400f141-07b4-4182-9e36-d051465d2a89"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8503), null, null, new Guid("331a667b-c7c5-45cc-8c5c-04a93807034d"), "ASC 972-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8503) },
                    { new Guid("8432cd01-b516-4d73-8efc-b0f9ecf74223"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019), null, null, new Guid("48ded176-92fe-45d5-a422-0ad570370a88"), "ASC 740-323", false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019) },
                    { new Guid("84c3f9e6-b037-4611-ab0e-397d6860fab6"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-958", false, false, "958", "Not-for-Profit Entities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("8552d153-5e88-46e6-80bd-d65f84cc516c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-835", false, false, "835", "Interest", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("859d56dc-90c0-4df3-8b14-d69fd2a8a507"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("85dacc06-3fcd-46a7-844c-b9bcefe01f1b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("862e2ba2-3f1b-4168-9cf3-08254ff8c84f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("86551bae-a9ae-4eba-8240-e0d2e76f48d0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724), null, null, new Guid("3995e9be-88fa-4f50-9702-6c0cb0e44636"), "ASC 842-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724) },
                    { new Guid("86e83ceb-b598-46b5-90a4-958f367b4886"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573), null, null, new Guid("762551f9-e70a-465e-a4be-7c4d99f1bf00"), "ASC 715-70", false, false, "70", "Grandfathered Guidance", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4573) },
                    { new Guid("87842a1e-1daf-4ef0-8fe0-0cca273e076d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2774), null, null, new Guid("8ff41b56-db70-4785-9b6a-72731c7aabab"), "ASC 235-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2774) },
                    { new Guid("884abe49-ecf4-4d33-9832-ff7552291759"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("8987e20a-c2e1-4d30-9f73-12f8f76e8e23"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969), null, null, new Guid("4a7b9ce7-07a8-469c-b63e-51acb7ca8e4c"), "ASC 860-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969) },
                    { new Guid("8a80be9f-3b80-4e8f-80f0-c2ae554cba87"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069), null, null, new Guid("92d6440c-f5b0-4d5a-b349-e050ce561315"), "ASC 505-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069) },
                    { new Guid("8a9dfaa7-2824-45d6-9536-dfc59551488a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("8cac6ec4-d53b-44a5-a776-b15c5dcd7860"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649), null, null, new Guid("26e07710-3918-4bf0-b327-c6466e635576"), "ASC 940-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649) },
                    { new Guid("8cbb5133-56b8-4fd7-ad2d-bb2311892a24"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("8d40353a-0572-4f63-983f-f9963c2371b4"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("8f26b1ac-7a55-45fa-96ee-edd7b4235d93"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514), null, null, new Guid("26b0bc87-ba06-42b1-95ef-b47413d5f0ab"), "ASC 830-230", false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5514) },
                    { new Guid("8f4bfc63-b48e-417d-b2f3-54c6d5f8900a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460), null, null, new Guid("3f5b3a32-9bd0-4245-8c92-88410cc3b83a"), "ASC 350-60", false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460) },
                    { new Guid("8f4ec71e-167f-4dd5-a56d-c8ef4e731f7f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2902), null, null, new Guid("4e7dfdfe-0ba5-4a5b-9902-1e26a45abe1b"), "ASC 272-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2902) },
                    { new Guid("8f7d015f-97bb-48ae-b051-f21d34037e44"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387), null, null, new Guid("b4b4b69b-223b-41f2-b296-517c26c1c1bc"), "ASC 340-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387) },
                    { new Guid("8ffa20d7-e8b2-4329-bb57-f89eaaf288d3"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5897), null, null, new Guid("6084f16f-0cae-4b5e-91cf-a8a2602581b0"), "ASC 852-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5897) },
                    { new Guid("90983952-8dce-4f74-927c-833da5667353"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969), null, null, new Guid("4a7b9ce7-07a8-469c-b63e-51acb7ca8e4c"), "ASC 860-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969) },
                    { new Guid("913622d4-5e5b-4562-8733-34d72d4e9e74"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("918a9afd-e20d-4c66-93e8-4c3288aeab3a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6164), null, null, new Guid("d0657f37-3d70-4f1f-b88a-4b3ba2e74c38"), "ASC 910-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6164) },
                    { new Guid("91b157a7-0de4-46c0-b2d0-e490acbad717"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2933), null, null, new Guid("a980c07a-27d2-42fb-a3a9-853b8e2858dd"), "ASC 273-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2933) },
                    { new Guid("91b5fc8d-3913-401b-a876-076b7200994c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-450", false, false, "450", "Contingencies", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("92c24558-c8ae-447d-91e9-ca28c2a5e0ba"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704), null, null, new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"), "ASC 718-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704) },
                    { new Guid("933785d6-1089-4d01-b85c-b70363dd751f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6483), null, null, new Guid("311082fb-cca2-4507-a64e-64b7998debd9"), "ASC 928-340", false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6483) },
                    { new Guid("945ea77b-ca50-4467-92b2-b8d3a010c29e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "ASC 815-45", false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("94bec5cd-e754-4042-a990-69aeeb365c03"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4384), null, null, new Guid("dac30188-680e-46e5-97ff-efb3a0de4801"), "ASC 610-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4384) },
                    { new Guid("95b2a906-1ed8-490b-8d12-09cd2cd16f58"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("96320718-7b96-4187-888f-a4bfd77fdae8"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-830", false, false, "830", "Foreign Currency Matters", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("966c6a84-72b4-4441-92d6-5259aff9d743"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649), null, null, new Guid("26e07710-3918-4bf0-b327-c6466e635576"), "ASC 940-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649) },
                    { new Guid("96bdd269-61f8-4f4a-85af-93f729e8ddd3"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("977f3665-55bb-462e-b895-87ed6db6f69b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840), null, null, new Guid("40843736-5c8d-44d0-8a81-b7304b276609"), "ASC 978-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("9784b037-d171-4bcf-9a50-293ea7fb31d2"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969), null, null, new Guid("4a7b9ce7-07a8-469c-b63e-51acb7ca8e4c"), "ASC 860-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5969) },
                    { new Guid("978f97df-a81b-495e-9c14-253a3f8227af"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(9052), null, null, new Guid("0f82980a-1dfc-419a-b99a-fa081c7d7589"), "ASC 985-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(9052) },
                    { new Guid("97c2ff6d-676d-4344-966e-a048a35d3ddb"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("9879f86e-c5e6-4020-a5a9-37f2a7ba8c73"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607), null, null, new Guid("13f1aa2d-9cab-4e47-b016-ebee1899826d"), "ASC 405-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607) },
                    { new Guid("9b9bebd3-f38f-43a7-b2a9-731364a212ba"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215), null, null, new Guid("2051ef90-2112-4e62-bbd7-fed074247313"), "ASC 325-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215) },
                    { new Guid("9cacb247-661e-4308-b759-388c3ced129a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4340), null, null, new Guid("a57dec8c-ae88-4d01-bfd8-7d01660da54b"), "ASC 606-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4340) },
                    { new Guid("9d18d787-15db-41f2-bdd8-5a4829f9aa26"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("9d85e686-8d27-4502-9eab-93d3fc9afd31"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6057), null, null, new Guid("1e7905d2-5e14-4190-b0e3-44584949a981"), "ASC 905-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6057) },
                    { new Guid("9ddb2cc4-1f0e-456c-b266-965a1579c98b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("9df2291a-4475-460e-be1a-0bc8fe0778f7"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3171), null, null, new Guid("a7a4e2cd-9c72-4531-a004-bc716420cbc4"), "ASC 323-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3171) },
                    { new Guid("a159e660-bb27-499d-b458-cfc4cb9770a1"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6340), null, null, new Guid("5dd91913-6cc1-4134-abb9-6034604f53e7"), "ASC 922-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6340) },
                    { new Guid("a1ef57a6-2bba-4ccd-8e89-27658a0aa17b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("a20f8ef1-fd78-4ead-918a-ed29373887ae"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5594), null, null, new Guid("73c3f842-71ac-449b-91b5-14e7999c2226"), "ASC 835-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5594) },
                    { new Guid("a2801c3a-a7db-409f-b2db-ed0eb2cb4676"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-225", false, false, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("a2d5161c-4138-4378-ae85-c47f5794dc06"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("a5c91a1d-d46e-4827-85b0-1c290ea27a1e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002), null, null, new Guid("20c94d8d-3a64-4858-a19b-a0834e5eda87"), "ASC 960-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002) },
                    { new Guid("a5ee9ff7-a9a6-4e60-b686-d84a837b0e29"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3694), null, null, new Guid("98203b8f-8f43-4c82-a0e1-f78acb36db24"), "ASC 410-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3694) },
                    { new Guid("a5f5445b-cb53-4377-8545-84fd0d39882a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208), null, null, new Guid("8556d81f-1d65-4f82-b254-b098d88a460e"), "ASC 912-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6208) },
                    { new Guid("a6da4411-39e2-46e7-8cd2-5b8772fa96c5"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704), null, null, new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"), "ASC 718-740", false, false, "740", "Income Taxes", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704) },
                    { new Guid("a6e26866-727f-4703-83fb-7dea1e5fd600"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704), null, null, new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"), "ASC 718-60", false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704) },
                    { new Guid("a7471542-51b0-4b2d-ba4b-5e11e1ff1cb9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190), null, null, new Guid("0a80cf3c-126b-499b-adfc-90365ec76731"), "ASC 965-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190) },
                    { new Guid("a7a5a21a-b407-4e09-9d4b-d394dea84252"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("a7fa6116-6864-4021-b583-bb47dd165f30"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5810), null, null, new Guid("a565b1ee-acff-4236-96de-b7bb96620f4b"), "ASC 845-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5810) },
                    { new Guid("a82e25cb-c9d5-4a84-9dc5-8e5165dd139d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2991), null, null, new Guid("508a714a-ca3b-4acc-9e44-97857ef949fa"), "ASC 280-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2991) },
                    { new Guid("a9382478-5890-4c1e-9be5-3fd1daca0d73"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("aa5fbe22-f69c-4036-9127-dd8529167c87"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "ASC 815-15", false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("aa97997e-4137-4acf-bd51-352d63ea28b9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704), null, null, new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"), "ASC 718-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704) },
                    { new Guid("ab240088-4a18-4e41-9292-2087c019b15f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3848), null, null, new Guid("54dd4c12-c037-4169-84c8-78da96e26e1f"), "ASC 450-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3848) },
                    { new Guid("ad7c10f6-8523-498d-b04c-bceb509d3974"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935), null, null, new Guid("0bab2718-4916-4468-9993-8572a6882f7f"), "ASC 470-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3935) },
                    { new Guid("ae7ffcf3-7b0e-4e0f-bcdb-d86b5811ea2e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704), null, null, new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"), "ASC 718-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704) },
                    { new Guid("b01090ed-771e-4111-8ec1-63ff7e9935bf"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460), null, null, new Guid("3f5b3a32-9bd0-4245-8c92-88410cc3b83a"), "ASC 350-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460) },
                    { new Guid("b0118891-a710-4615-a804-ee2516d0f3e4"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5456), null, null, new Guid("140669f0-9543-45bd-ae29-765473abcfe7"), "ASC 820-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5456) },
                    { new Guid("b088a41b-c7a8-47a8-89dd-58cdc7876105"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-205", false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("b0d50f0f-e3d6-40ff-94de-8b7c6fc9695b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2595), null, null, new Guid("968d2799-9a5e-459d-a781-762af032cba2"), "ASC 210-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2595) },
                    { new Guid("b10de13b-014c-49ff-96c2-93e52c7bbc61"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("b170bc18-ac47-4c86-9330-59e8f452aba0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108), null, null, new Guid("da66bd0d-cab5-4356-876e-52b3f07393de"), "ASC 805-740", false, false, "740", "Income Taxes", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5108) },
                    { new Guid("b268f77c-4f5f-4e09-bda3-7fe1f1d1696b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2738), null, null, new Guid("bebfc796-5a16-4902-8d02-39a3152984d6"), "ASC 230-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2738) },
                    { new Guid("b2d5a544-9350-4290-a292-353601feae2b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "ASC 980-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("b34531a0-8cc4-4641-b5df-2d05c0e502f4"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("b5f97618-779e-4a83-939b-3072a6c6422c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069), null, null, new Guid("92d6440c-f5b0-4d5a-b349-e050ce561315"), "ASC 505-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069) },
                    { new Guid("b7048920-c5aa-4762-9f0d-346cb0e7cd66"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "ASC 815-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("b83079ac-9248-4103-a191-e54b12cee5e0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4530), null, null, new Guid("5e6cb7d9-0cb6-4f3b-a165-e56a8923337d"), "ASC 712-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4530) },
                    { new Guid("b891cb1c-852c-42b9-9d59-e576d1653a20"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "ASC 815-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("b89528ec-1fab-4294-b9c8-8e8f9eb40d22"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("b8d72613-5678-4999-b5f5-c74455eb7ae0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069), null, null, new Guid("92d6440c-f5b0-4d5a-b349-e050ce561315"), "ASC 505-60", false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069) },
                    { new Guid("b9232506-d812-4e57-99d2-d1c58fbb0034"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5268), null, null, new Guid("37cd1131-3500-4c1a-90ce-b9dbfcb806e9"), "ASC 808-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5268) },
                    { new Guid("b930ef8e-9a68-4edd-bcd4-c3df358d6c27"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3299), null, null, new Guid("7a99ca57-ff36-4cd5-9458-58729748dea4"), "ASC 326-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3299) },
                    { new Guid("b937dc32-669d-44b3-a563-3e4409872e95"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607), null, null, new Guid("13f1aa2d-9cab-4e47-b016-ebee1899826d"), "ASC 405-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607) },
                    { new Guid("b991847d-8de3-4fe1-a8f5-c6af145746f5"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190), null, null, new Guid("0a80cf3c-126b-499b-adfc-90365ec76731"), "ASC 965-205", false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190) },
                    { new Guid("b9f1c190-7d6f-46cf-91e5-84036f071d48"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6282), null, null, new Guid("7fcec6a5-68e6-4e7c-94f6-1c7f4f4189d6"), "ASC 920-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6282) },
                    { new Guid("b9fcc2b6-e91f-4385-8fc7-43cf14859d16"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-505", false, false, "505", "Equity", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("ba43060c-b207-4019-a33a-c97cf2933024"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("ba7a5223-7c9d-4531-a801-2fdf3b6e7858"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4487), null, null, new Guid("33603828-3d97-4630-aa08-30182a3116b1"), "ASC 710-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4487) },
                    { new Guid("bb1b3f59-7e17-49dc-acbe-5d65741edd24"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3694), null, null, new Guid("98203b8f-8f43-4c82-a0e1-f78acb36db24"), "ASC 410-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3694) },
                    { new Guid("bb282b37-5f9e-4636-a0e7-f3951f848466"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2814), null, null, new Guid("6e6d7609-fffc-45ca-b9f6-0ec66d3316a1"), "ASC 250-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2814) },
                    { new Guid("bb72f98b-d392-4400-ac8e-b8c2d4b0229a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3141), null, null, new Guid("eea6366a-82a7-4672-8f59-fcbcf64abdfd"), "ASC 321-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3141) },
                    { new Guid("bc3aff30-cb44-4e8b-8e19-cfa739afc31c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("bd77d122-ad67-4873-9032-0107b4f9a371"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("be6fa73b-a62c-46c9-a272-c916e922a653"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("c0856748-76dd-4196-9967-7ddb96ac28a3"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6426), null, null, new Guid("612110f5-28e0-4b9a-9661-d4921d84e22c"), "ASC 926-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6426) },
                    { new Guid("c11d530a-ed89-4045-97c7-d6e1bc673285"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6340), null, null, new Guid("5dd91913-6cc1-4134-abb9-6034604f53e7"), "ASC 922-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6340) },
                    { new Guid("c1b613c6-7508-4441-bf7f-9dd749c221e1"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8796), null, null, new Guid("11ddc8e2-1154-458b-9b7d-15f1def71110"), "ASC 976-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8796) },
                    { new Guid("c264bc8f-372d-41bc-a305-641a7acf4f4e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-825", false, false, "825", "Financial Instruments", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("c4462925-b821-4e10-981b-9062597e4e67"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460), null, null, new Guid("3f5b3a32-9bd0-4245-8c92-88410cc3b83a"), "ASC 350-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3460) },
                    { new Guid("c4ae74bc-839f-4f89-ab6e-6ae9610b6129"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8503), null, null, new Guid("331a667b-c7c5-45cc-8c5c-04a93807034d"), "ASC 972-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8503) },
                    { new Guid("c7a33ad7-e706-4213-a1cc-959023f4fcc9"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2496), null, null, new Guid("bd35979f-8bc1-4b02-83c2-006fe0ef8a2e"), "ASC 205-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2496) },
                    { new Guid("c9774100-3146-4d99-865e-37d26be54f17"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069), null, null, new Guid("92d6440c-f5b0-4d5a-b349-e050ce561315"), "ASC 505-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069) },
                    { new Guid("ca1370aa-2daa-451c-8db1-86a89e1335e5"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4384), null, null, new Guid("dac30188-680e-46e5-97ff-efb3a0de4801"), "ASC 610-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4384) },
                    { new Guid("ca2ccd56-ce08-4c71-b4ef-b38de616ff28"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2687), null, null, new Guid("4ff63ca9-8e4f-454a-9df9-0d6ca1a213f7"), "ASC 225-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2687) },
                    { new Guid("ca36d2b1-317d-49cd-a72f-ae4cbbc783f2"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("cb3bb55c-364a-45a1-bb5a-8c23a86ff846"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6483), null, null, new Guid("311082fb-cca2-4507-a64e-64b7998debd9"), "ASC 928-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6483) },
                    { new Guid("ccb4c09c-f3b0-41f7-8dce-62984a765c61"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "ASC 815-25", false, false, "25", "Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("ccbbed03-0896-41ec-ab9e-62336018c1b7"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6383), null, null, new Guid("efa8e7f4-0a44-4537-a0cc-1ab0480a6627"), "ASC 924-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6383) },
                    { new Guid("cce28a7d-4034-4cfe-97c0-bf57f46c69a0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840), null, null, new Guid("40843736-5c8d-44d0-8a81-b7304b276609"), "ASC 978-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("cdb826b3-c308-4890-8740-1ae607ce5192"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3694), null, null, new Guid("98203b8f-8f43-4c82-a0e1-f78acb36db24"), "ASC 410-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3694) },
                    { new Guid("ced9b602-82be-4c4c-bec1-ce1006ef7fa5"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4487), null, null, new Guid("33603828-3d97-4630-aa08-30182a3116b1"), "ASC 710-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4487) },
                    { new Guid("ceef44e8-d813-4c45-ad63-f11f4ec6da68"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-323", false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("cf188434-114f-475a-8eb5-1a07b63db612"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("cf7bc84c-d954-46e8-9bd7-92d197fc4ae1"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019), null, null, new Guid("48ded176-92fe-45d5-a422-0ad570370a88"), "ASC 740-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5019) },
                    { new Guid("cfb89a0d-033e-4d4c-a1df-e547dab25fa6"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3819), null, null, new Guid("bdd61938-8803-475a-9a09-7a9fbfd0f5e8"), "ASC 440-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3819) },
                    { new Guid("d114abf2-a0d6-4ca8-99e4-6a8ce6fee0a7"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3053), null, null, new Guid("5d6fd464-38a4-47db-a2b0-d43c3f2fa319"), "ASC 310-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3053) },
                    { new Guid("d3952621-60d4-4533-b418-c09324304328"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387), null, null, new Guid("b4b4b69b-223b-41f2-b296-517c26c1c1bc"), "ASC 340-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3387) },
                    { new Guid("d4029560-12ee-42d8-a268-4cfab2eb42d7"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-815", false, false, "815", "Derivatives and Hedging", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("d4785396-d91a-42c0-a818-2ec0a97a6b88"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3053), null, null, new Guid("5d6fd464-38a4-47db-a2b0-d43c3f2fa319"), "ASC 310-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3053) },
                    { new Guid("d482491d-8c10-494f-91ae-cccd7ea4febd"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "ASC 980-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("d584e1f4-3ca0-48be-9722-1566e1b0daeb"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-230", false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("d5884d3c-080c-4c3c-a92f-27567a1e112c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-210", false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("d5bf2853-a771-431b-a727-d84b34d70b51"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002), null, null, new Guid("20c94d8d-3a64-4858-a19b-a0834e5eda87"), "ASC 960-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002) },
                    { new Guid("d5bfe6d3-d35c-4aa9-9b6a-63452720b555"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-220", false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("d6188a7b-5df4-4178-9cce-eab5aa681190"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3752), null, null, new Guid("80388014-bf69-4c8d-a6df-0e7f963073e3"), "ASC 420-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3752) },
                    { new Guid("d65639bc-dbac-4a67-a8bc-d59c0af3e374"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4443), null, null, new Guid("3ebaa5cb-e6b5-41cb-bb33-a715ea5d086f"), "ASC 705-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4443) },
                    { new Guid("d7132967-f2e9-4c5b-b17f-70d72ab03c89"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-235", false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("d7e5deee-9187-4531-a53e-cbf0cdbfe17b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-825", false, false, "825", "Financial Instruments", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("d9a1f9d0-03ba-4551-a0fb-80e976568d40"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326), null, null, new Guid("6a442129-9af3-4ef0-8e7a-c68fb52f8665"), "ASC 815-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5326) },
                    { new Guid("d9c2fd7f-57eb-4ad7-9dee-75e8bb299a42"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2496), null, null, new Guid("bd35979f-8bc1-4b02-83c2-006fe0ef8a2e"), "ASC 205-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2496) },
                    { new Guid("d9e09e52-e687-4b68-af58-c6f609f3ba3f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607), null, null, new Guid("13f1aa2d-9cab-4e47-b016-ebee1899826d"), "ASC 405-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607) },
                    { new Guid("db6c6268-5ac9-4a18-a797-3085957d9ae8"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-225", false, false, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("db893652-241b-41dd-a079-70ccfc519a09"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-35", false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("dd15cabb-0247-4f76-a499-39726c0f3c3c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069), null, null, new Guid("92d6440c-f5b0-4d5a-b349-e050ce561315"), "ASC 505-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4069) },
                    { new Guid("dd8133de-2045-423f-9888-9ff07c5d8a15"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("ddfd5513-dc96-490e-a912-a8b64f9c62c1"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("deccbb30-9212-44cd-b83d-229f9450a82c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103), null, null, new Guid("e11e1e10-fa8f-43b9-be78-a91c68791130"), "ASC 962-325", false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8103) },
                    { new Guid("e1623c5e-f5f2-40ae-a515-94db29591907"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3053), null, null, new Guid("5d6fd464-38a4-47db-a2b0-d43c3f2fa319"), "ASC 310-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3053) },
                    { new Guid("e2020cc6-1032-4e84-8b2d-b41dddb48bf0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-405", false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("e4494f16-295d-4de7-9934-da31e1647154"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6121), null, null, new Guid("868579dc-b374-4864-8380-f7fe6d73f438"), "ASC 908-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6121) },
                    { new Guid("e493ee8f-dd0a-43bc-a1c8-3b29ea72cffd"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4530), null, null, new Guid("5e6cb7d9-0cb6-4f3b-a165-e56a8923337d"), "ASC 712-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4530) },
                    { new Guid("e64da626-b5ed-4c29-94e5-edd0d3f6066a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("e6c6debb-b9a8-4f0d-b137-c479c0db4941"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704), null, null, new Guid("f3afacac-e0a1-41e9-be41-651333013d0a"), "ASC 718-50", false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4704) },
                    { new Guid("e6ef7e1d-935e-4c0a-bbc0-5e1b95c62755"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829), null, null, new Guid("47e7d3dc-7491-4fc5-952c-b15c378dc883"), "ASC 720-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4829) },
                    { new Guid("e7780a84-1dfb-41ab-a7fd-52eabd072a8d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190), null, null, new Guid("0a80cf3c-126b-499b-adfc-90365ec76731"), "ASC 965-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8190) },
                    { new Guid("e7baf798-5770-4f14-a82a-f40164bb059d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3789), null, null, new Guid("d43d4832-2dcb-4cac-b837-a9dad2ba16eb"), "ASC 430-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3789) },
                    { new Guid("e9d94689-2b1c-4250-aa64-c8dbe386270e"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("ed3b7131-e1d9-4c61-9d9b-83327e46ae0d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-505", false, false, "505", "Equity", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("ee93ce2a-0b2e-4421-a362-e49340e5fc91"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738), null, null, new Guid("f810c4b7-8a42-4eb6-b184-edc455d8031c"), "ASC 942-470", false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6738) },
                    { new Guid("ef42e821-e09a-4405-8f25-a0782b53364d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6057), null, null, new Guid("1e7905d2-5e14-4190-b0e3-44584949a981"), "ASC 905-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6057) },
                    { new Guid("f0611c17-8940-4311-a477-3fd0efc87721"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-825", false, false, "825", "Financial Instruments", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("f07b192c-5096-45a9-87ce-9786039afd2a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649), null, null, new Guid("26e07710-3918-4bf0-b327-c6466e635576"), "ASC 940-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6649) },
                    { new Guid("f1435e20-a012-408a-8f1a-83abb5f386ae"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293), null, null, new Guid("a43f68ed-1e00-4306-8fbe-4daecf79ce7a"), "ASC 970-340", false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8293) },
                    { new Guid("f144a4de-f67f-48fe-9862-78da8682a85b"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461), null, null, new Guid("9c59f402-cf05-48d2-8707-ee0b5debc587"), "ASC 954-440", false, false, "440", "Commitments", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7461) },
                    { new Guid("f3ec4be7-60d2-490d-89d0-02cb6e6d1e93"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607), null, null, new Guid("13f1aa2d-9cab-4e47-b016-ebee1899826d"), "ASC 405-30", false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3607) },
                    { new Guid("f5a65d80-7c89-4e7a-a280-d0cb47ec61fb"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002), null, null, new Guid("20c94d8d-3a64-4858-a19b-a0834e5eda87"), "ASC 960-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8002) },
                    { new Guid("f5afb076-246b-47c4-ae4b-a8f296682634"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8796), null, null, new Guid("11ddc8e2-1154-458b-9b7d-15f1def71110"), "ASC 976-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8796) },
                    { new Guid("f5c6f7a3-13ea-47db-bb50-981d36bd3a77"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3358), null, null, new Guid("0fb93137-ae54-4758-9933-881c13b20809"), "ASC 330-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3358) },
                    { new Guid("f664b54f-0cb1-4b38-b0fc-1ab737a6bb61"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4340), null, null, new Guid("a57dec8c-ae88-4d01-bfd8-7d01660da54b"), "ASC 606-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4340) },
                    { new Guid("f6c96070-f5ab-40e0-8d65-f31c6d9e77f0"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7359), null, null, new Guid("af448d74-6f8f-4f1f-b189-05b63f7d3806"), "ASC 948-605", false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7359) },
                    { new Guid("f6eee19a-3c6d-47a0-838f-cd033b7c4c03"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("f74b15a6-2ccc-4f00-94c2-21e9e0735b65"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-45", false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("f7703242-8697-4eff-bf15-2fbbd1779837"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930), null, null, new Guid("c61dfb77-85d0-4bd6-91ff-771066e99b14"), "ASC 944-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("f7b9e500-dc45-4aae-952f-5d95442a28ea"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689), null, null, new Guid("27519e3c-97bc-4f50-8e4f-0747067ad655"), "ASC 958-715", false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("f877d306-873f-4add-9b07-b65a8ad5d5c8"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2961), null, null, new Guid("8c8da832-9a43-429a-93f4-865a3f5c3a8b"), "ASC 274-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2961) },
                    { new Guid("f89975ce-be91-4330-b01d-8b01a3bc29f8"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215), null, null, new Guid("2051ef90-2112-4e62-bbd7-fed074247313"), "ASC 325-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(3215) },
                    { new Guid("f8d3b8b9-d448-4527-8cca-d01b5bc06005"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2496), null, null, new Guid("bd35979f-8bc1-4b02-83c2-006fe0ef8a2e"), "ASC 205-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2496) },
                    { new Guid("f92c72f2-cc66-4b1b-b583-b303881aca15"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4384), null, null, new Guid("dac30188-680e-46e5-97ff-efb3a0de4801"), "ASC 610-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4384) },
                    { new Guid("f96041bd-7ff0-4764-bf89-897e00bcf86f"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724), null, null, new Guid("3995e9be-88fa-4f50-9702-6c0cb0e44636"), "ASC 842-40", false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(5724) },
                    { new Guid("f96aac50-f697-44b4-b8da-21c69eba1b3c"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6121), null, null, new Guid("868579dc-b374-4864-8380-f7fe6d73f438"), "ASC 908-360", false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6121) },
                    { new Guid("f9964295-7507-4b2e-ac53-7d8698e35996"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2642), null, null, new Guid("fd700a75-fef2-4700-8dc6-4215819155dd"), "ASC 220-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(2642) },
                    { new Guid("fab2efcc-2dc5-4acf-a10b-a32c07aef997"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6527), null, null, new Guid("e4fe5587-f9ba-45d4-aae6-18b4f098ae04"), "ASC 930-10", false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(6527) },
                    { new Guid("fbd89cd0-1cb9-4eba-8709-8c82f09ae56d"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156), null, null, new Guid("88db397c-7c88-4f4a-95e2-a951d587f9e4"), "ASC 946-310", false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("fc846537-8634-47a4-8084-60dd52d20c0a"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564), null, null, new Guid("7b44c979-8c98-4c1a-997e-b97e21cc1464"), "ASC 974-320", false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8564) },
                    { new Guid("ff622bb8-b1a8-4236-9cee-d4320c52cbbe"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912), null, null, new Guid("0c8a1211-4e80-4723-9ad6-1a0af7f686b9"), "ASC 980-20", false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("ffd91a95-f58f-48cf-bae9-2b4b935686bd"), new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171), null, null, new Guid("c0811370-c923-4771-a419-9e06a60afeaf"), "ASC 605-15", false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 5, 1, 47, 25, 672, DateTimeKind.Utc).AddTicks(4171) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_FASBSubtopics_FASBSubtopicId",
                schema: "dbo",
                table: "Accounts",
                column: "FASBSubtopicId",
                principalSchema: "dbo",
                principalTable: "FASBSubtopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_FASBTopics_FASBTopicId",
                schema: "dbo",
                table: "Accounts",
                column: "FASBTopicId",
                principalSchema: "dbo",
                principalTable: "FASBTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
