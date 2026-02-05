using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceCOAWithFASBStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // CLEAN SLATE APPROACH: Delete all existing accounts
            // This is necessary because we're replacing AccountSubType with FASB structure
            // All accounts must be recreated with proper FASB Topic/Subtopic references
            migrationBuilder.Sql(@"
                -- Delete all account-related data first (cascade delete through related tables)
                DELETE FROM [dbo].[GeneralLedgerEntries];
                DELETE FROM [dbo].[JournalEntries];
                DELETE FROM [dbo].[InvoiceLineItems];
                DELETE FROM [dbo].[BillLineItems];
                DELETE FROM [dbo].[Accounts];
            ");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("022724a3-c3e6-4026-ae37-5d6d1e7e3295"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("02297461-5975-4f93-8b13-6636923fb06a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("02c2b15e-f54d-40b2-bc8e-6a7b47a84ade"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("031c2cc4-77db-4920-aff8-d7fd6b4456d0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("04c776d5-194f-4f0e-ae4e-7c3a1f8618a6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("05083391-f60a-45ff-a30e-d1b6488184dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0510cd39-3d85-420f-a88b-b916ad58b83d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("093aee74-acce-45d0-b811-ed563b3bb474"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0c04146e-4791-4fb7-8b1c-2009eea13080"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0c4ce124-8466-4555-965e-43616f04badc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0cb24741-6056-43cd-bcd1-abcad1bf334f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0d849caf-d1cd-41f4-afb3-74e0fa5f23f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0df6eff0-0c69-4484-9fba-7e6a9e8fe1a7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("0f81af12-adac-404d-b83c-14d15dd13575"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("10015003-e605-4176-946c-8b23fa3dbab4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("10040513-046c-4aec-b2c2-a17745af13ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("104b6f35-eef6-409c-8cf6-656588ba096f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("110e4126-ff5c-44ca-aa25-42ecce60d9f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("121dbe4c-b6e4-46d3-a84e-3e4859939804"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("12b5746d-f96a-4d62-8e75-57ff012c6a40"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("12e856eb-9a50-4b58-a5cc-25010b44d25b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("147979e9-4fb4-45b8-916b-d9732a181d6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("186b92c4-c2ce-4e68-9967-a91cbab59ba7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("187a03b1-bb43-40f8-a063-f72cdf641f60"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("19404167-e4a4-4a5e-aa76-bb9799fe462e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1a2baed4-aadd-4804-889a-865a54b20f66"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1abf5d07-0f6a-4b28-86a5-4c23924c7cd4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1dd890e2-fcec-417a-affb-43ae0777733e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1e485794-026d-409c-89bf-9a487d6391a6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1e74700e-6e9c-434a-821f-fc72ef2354f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1e833f37-1099-4935-8d78-f4f782fc89fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1e910a9c-eb75-4890-864c-e4b71cff4c0b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1ee37a99-582b-4865-aa43-34641447693c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1ee75559-9deb-44dc-9e91-2467ea790fc7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1f294379-a919-46eb-8bad-5c12213c85c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("1f6f0cd9-8b6b-4e81-95d5-41b5ab3661c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("20fe42c8-fccd-4ffa-b856-f795aca644fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2125d9c6-a916-426f-8b08-a07e300500d1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2132be2f-0caa-430f-ba4c-f013195d464e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("21a53163-5338-4eea-9379-d813a14b0fe3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("21d7ed9e-05b1-4716-a728-0ef575fe9bb9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("221a0d47-25c3-4fbe-b0c1-6e1b41a9ff71"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("22390509-17ef-4972-9db7-b78c41a841c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("22a9698e-57de-4a30-9033-3f54ff841574"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("240de2be-dc6c-4654-ba7c-bbe236a95bf0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2595bffa-03f0-4ace-90c5-7e813fb2dbdf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("26d63d5f-9e85-4905-a722-57335fa23e02"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("26e33ded-4d28-4ecc-adf7-86267cc95cff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("27db4212-825d-4b51-8f47-9a056080ba69"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2897e92d-db4d-4bae-ba3a-9ae4adc95ee3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2a99e346-e66b-49c2-b9b9-537abbba6e1f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2b9b4ddc-1b2c-473b-8c24-983b689f63a8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2c2004c3-b9ce-4316-8455-8f4bd8093a82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2cb8a4b6-20e9-429f-9f1e-8f046016098a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2cbebb11-a172-42a7-bf6a-f0747b7157e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2d9c46c2-7066-4b85-98ac-2bce987e91e4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2e17cec7-7afa-4a90-84bc-f547a1842cbf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2e812ede-6d92-428c-aaab-5f2e8dd30cdf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2f0ec353-3ed8-416b-b785-5b9074d6c69d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("2f5e0f9b-0b99-4395-a1fa-38f023e914f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("305c6635-272c-4160-a754-81c8e14e553d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3109cb2a-4c66-4a29-9126-6d0868447dda"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("311d35ed-befe-4708-a817-1594b82ec3f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("31ea1d6b-3abb-4022-950e-57c0d6e66c98"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("326fb234-8a93-452e-9840-678c0c7959ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("32ba1911-bef5-4c39-a31b-614456410d4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("335fade9-ed0b-4b42-9fbf-87a80c242703"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3406e9cb-b0db-4145-bc5e-0baff7f2a5ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("341565bb-264d-45bd-aa80-197a5b01776e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3459188a-d156-419f-a74f-23ea566167c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("346e44e2-f500-442a-9c56-7d76b67b81a4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("366c3c68-421c-46cc-80d7-f83b8748ec15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3671a8fe-2412-4adf-bbdb-ca0895d85002"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("368f940c-29bd-486f-95a5-23d13353d01c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("36a9812b-44dd-49fa-af1b-d3bbad3b3384"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3725d713-33a1-4cb5-908d-d8955b659a7d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("37ee6123-144b-426f-a908-186b98d9ec99"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("396a4145-a61f-48d3-80fa-17633c420ca8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("39b856fd-8a11-48f5-a2d6-8921aaf12c52"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("39ce7517-227e-4753-b987-5e025b6fcf30"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3a3f1b1f-6422-409a-b68b-c9cbfb0b7af8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3b15b4c1-c31e-40d0-871f-e9127a03c2c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3b1d7acd-05a5-4a82-9c36-9b5f510b76ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("3e0bf1a5-01b3-489d-8caa-e6a7279718e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4188ba96-e740-41d1-96fa-c3dfb91e50aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("42774e38-393c-41b9-9bbc-2f6c80994f60"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("428b8be2-b25d-40df-9db7-3ec67da2ea6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("430cb918-77c1-4fb5-afc5-0898d6e16db8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("431c4dff-5df0-42f0-84a9-ec8ffc3dcdfa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("443d12d9-cbf6-4cd8-a020-26d0a4d10ff1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("44415019-6b38-464e-98a5-5711c4a80e93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("45e13bb8-0fa0-4d67-9b7d-6cd6e9b49da6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("460dee9e-63a8-41f3-9f3b-ac4e72b37676"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("46ee13fc-35d4-44a7-8ab0-0f906cec553f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("47125dbf-2664-4dd3-a36b-551795623758"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("474ca193-7252-4943-9c32-1b00f4bb24bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("479abe29-80d7-472f-8f70-4835c76ba4ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("47b494a5-e9b3-4a7d-a39b-d3278c7cb3de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("48ebb203-7795-4c80-b77f-c722b5ddbe69"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4984e0ac-a8e3-46e0-9a1f-837c89db0bb1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4a86c7ca-9a94-440d-81c7-c961fb352ea1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4ac591b4-b4a7-4b3b-9c41-76aee73533c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4ba5bcd7-9980-49fa-b842-5ff272d20d9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4bdc76d0-d0a3-42ff-b8a6-bebaeec4efcd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4bdfacac-4c51-46a5-9e9e-5b3aa811e277"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4cd48ebe-ddd6-423c-8541-d0ea526d3b17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4eedb118-01eb-496c-9ec5-16dc54965bc0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4fbc2128-54bd-4f24-8821-99a4ffced0f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("4ff6dff9-0bdd-4959-b5ce-4555757a2b24"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("507bff94-9ed3-4173-be74-222a24a58b03"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("51151fdc-eda7-41ed-a528-ef39acb91697"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("51a0d710-7648-4eea-b914-f7e42ae9fae8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("524152bf-e9c0-47fa-ab02-47d41f4cc467"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5316c034-49e0-4953-8fcc-bf87b282ac15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("534b80a6-994b-45e3-8338-d25be209ea4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("534f7c56-cbb0-4c9e-82df-347186518fb1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5364f921-f8a7-463a-aeb7-6d8ddd83cce9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("59674570-4ad9-4947-93fd-da57a73e1c46"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("59ac3698-4bab-4e9b-b7a1-924ad15110de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5c0b15d4-5f10-4b1e-a75e-f3783e96ae4d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5c62be59-2476-4e8e-ae44-ea6113aee20f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5d361f50-0ccd-4d40-b507-683a32846854"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5e6a4268-b7cc-4654-8147-5330b3f07772"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5ef638f7-747e-45f3-bc07-c2ebd4e0ca42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("5fd2ae26-711d-4ef4-b21e-897bb30078d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("60d71167-6565-4ea7-80ed-8c391a682af0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("621fe394-2a6a-45ca-a350-aca3544d4e73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("62332f9c-94f8-4ad8-9abc-601521509111"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("62d66487-197e-4dd4-976a-9927741d9640"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("64a38cc5-e545-4f17-bfe6-7d1b79c157e7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("654723c1-d5ba-4d18-b9f9-5b98bbc8b68c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("65632c2a-8118-4958-bf32-9bc81b4da92b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("66a49c08-a7ff-46b6-8aa9-780e550c20c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("673b292c-8a36-4467-b353-28c471f78989"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("69574527-7ebb-4c85-a7f0-406519cdf31a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("699c3c2d-5c74-4be8-aec8-d4579901f593"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6aac3764-91aa-414a-8f34-5fefdd422d0f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6b99fb80-8b66-4279-9833-634f30bd234c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6be847f6-665a-4ebf-a106-9b5f7b094f43"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6bf4a42c-949f-4c93-9358-cc4c4052113b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6c81130b-026e-49f0-9bef-a571431a5ca1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6d8106c0-2f9c-4505-bfda-8ed0740a57dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6e31f1aa-bd11-4d30-86a8-84ed6ccb1927"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6f1eee59-1059-47bc-8901-2cdcf57d1cbc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("6f281adb-9405-423b-bd11-1279e146beae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("70bee8ac-ce07-40ab-9f1c-a2d2f10df4de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("710bf3ca-7be0-48b5-9b2c-67b473dd6635"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("71e27427-baa0-4f89-b5a2-9772a5d64fa4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("725e1c63-349e-4e91-b00c-fc9525e11f8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("729e8626-f9d2-475e-8f56-6b1865277bca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7383ffc0-7323-4b6d-a4be-0c28b8c0e8ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("73fecd87-c98e-4177-a748-1ca2e075a05c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("74627b55-49b8-4a9f-9b50-2c2732b424b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("74681fd2-72fd-4424-b2ca-b2eed5b88a32"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("74ce2c07-08a7-4ff0-bfce-4df7baf719fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("76714024-b947-46ff-8cd1-d418f26ca7ee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("76be04c0-8fbe-44ab-b425-419fbd8fd817"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("77ae65e6-eb66-45dd-93de-9b9626e90c47"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("79eb6745-b1fa-4a8f-8f77-4d708aa12128"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7b3d7dcb-d9b3-4562-bc6e-2c89843f970d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7bd3b89a-7399-4d8f-898d-4ae0252ef399"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7be2a8cf-6a39-4032-ace8-af4d8391dd54"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7cda642c-54ea-4dfc-aa6a-90192c7cd0f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("7fdf274a-f832-4d9b-852d-5cb41e0b663f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("810f49ba-5e9d-42c2-ad45-cbfd4a8d95ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("81171485-6c3e-421d-b1fb-9793a394684d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("81a532d8-1bc9-4929-9f22-c0f87c2d87aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("82be44b9-5c50-43a0-b93c-61a3fecaa8c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("839b8b68-72fd-4482-b819-a315c5f16de9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("840d7263-2c8d-4f29-b755-1ce5785fa6a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("848977f1-4850-4b36-adde-4ac29985d4cc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8529f9f9-d279-4658-abf9-d6be1a331b23"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8674f4eb-c5d8-4038-b259-5b217d5c469d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8734630e-418b-43d7-aedc-73b2d935dbd8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8743efbe-0e58-4cd4-bf49-0577f6c92445"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8803c491-cfaf-4c46-b1f6-71fd3c343e89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("889efff3-e919-4af8-8d9a-cba1a113382a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("89104e94-3aba-4cf0-a770-da4b6489e1c1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8987eeae-4d96-48d0-b10a-93c3413d36a6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8a096eee-f758-48c4-a643-61e4eeefc16d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8a5310ad-6239-4f11-be7e-24f8d84b2955"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8aedde19-c094-4a7e-bc19-4c26d022b19a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8b0d7c88-21a7-4d12-b928-6b05fb874c5e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8b1116fe-f3d5-4a79-bd76-66809afbe061"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8b6f7685-dd5e-4546-96e9-830ae6c8e3a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8cf5bfcc-aaf6-434e-b020-3c32f6c45db8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8d2f7e48-f72a-49f0-9691-a48d6ad40557"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("8eb7b29f-6996-46ad-8898-136eef87f6d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("90bd6f29-7a07-4362-b4f2-71973df0f45c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("91432621-a983-4b7f-9058-b5e80be1a5a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("917dd495-f93a-469b-9a2c-a1aca7c61609"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("92d8b985-d188-4d4e-ab36-81fe8fd7907a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("92df0da0-1e92-43ae-9a4c-a8056ac9f97e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("93710aba-cecf-4228-9e28-c9c2c263e2f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("938fd4b6-60fb-42b3-9489-dbddd571f932"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9397c243-193d-44f6-bba8-252d6d2ba4e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("961e9726-44bf-4a48-99db-90df63ec2282"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("967a1fd6-f0cf-4e9b-9340-932700364020"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9717e9b3-f6fd-4f48-a2fe-88cb95c7a9c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("979a10b6-871c-4a8d-b652-b8eb8efa8f5c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("981a324a-19a8-42f5-ae45-184f046a4cd1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9a9e622c-1336-43de-960b-3f9df9955caa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9afc6031-c76b-479c-8c2d-33d888cb0437"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9b82269c-9960-40a4-9dbc-da7eca3b8385"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9bead029-1c06-4afe-833a-5edaa627241d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9c4b0926-4a02-4d7a-b717-99a04846354b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9c5a8069-2927-43aa-914e-706696fcaff1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9c716dcc-634e-4a68-b1bd-346999f77e14"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9d6e0186-dc03-440d-9349-06aa62524392"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9ebe2e50-0d72-42e5-9650-3a5c06ff0331"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9f4435f9-7fb9-43eb-8f78-d27a8e2fc0aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("9fd49da3-307f-4b85-b524-33f4b6885cba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a01c2f0b-76b8-49c1-ba81-c790413cd444"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a03312c0-8467-4a41-801b-6daa4e8d224a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a035bc11-774a-4f6a-8639-438441dcdd94"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a056f601-635d-4b96-8c48-a4d3109e4cd1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a0d25492-ebc5-4f00-9ed1-b45dbf2a289a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a1013f87-5f3f-482a-b311-f50e435a81c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a1a9980e-6212-494d-944d-35202b910e4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a1f3d5e8-73a7-4404-a802-d11b20a09dbe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a2401c06-b400-4617-a078-46881ac1e39e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a2701ff9-0596-49c4-be48-7afd709ee27c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a2a7bcdc-ff64-47b6-a3a1-8af091540a9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a2cbd04f-3f70-4eb2-99b3-49a72ac3861a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a3bb1346-2a41-419e-972e-4b54baad58fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a4c19edc-9482-4254-96b1-48ec833d4ace"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a4fc9061-ebd3-48b5-96d4-fe0b09d638c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a5a02d4a-1f19-4ff7-a457-d22d2a824556"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a5afc66e-3c74-40ef-9db0-3a2e0cd33ecd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a6afb832-1f1d-48f0-950b-8e7f5166f977"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a6c62dd4-560a-451e-80fe-55c01d2745b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a86b091e-cb0f-4613-94a7-777caba3b2bf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a8be3807-88d4-4508-873e-2bc195687366"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a9037a3f-23e1-46ed-bd5b-bb5ac3c2c3ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("a97b4731-3410-4bc5-a991-75b51af6ea02"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("aa32d18b-d493-48f2-a52e-b7f656477fa4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("aaa1b612-93a8-4f77-949a-d9d3be916e6f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ab9e7504-f4ed-4b47-88fe-033b534bfdb1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ac251d36-dc16-4829-bb3b-ff67458484a8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ac2bde9c-10b4-4802-b58b-cb3d243ced82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ace2193d-4ffe-4bad-9209-817eb1bdd902"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ad9eb12e-92f3-4753-b245-ee5b12a566ec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("af23ed82-ef48-4d30-b9d6-292f0c9bbb7e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("af80cd05-b588-4fd5-9dcf-2d9ec566c7b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b04e29a1-c94a-4f99-aba8-e771cac99e77"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b1286510-e69f-41c2-a72d-4c8f037bba82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b1b12337-facc-458a-88d8-1aaccd456f0b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b36ef923-7b43-4e13-b1ba-51292e627107"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b4ff2bf1-be69-4f0a-9b43-c382e5b8f3c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b589b813-ad20-4679-8e8d-25b1b0a18ba2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b636b4bc-aeb6-4786-9298-9b0987c1c3f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b6b4f63e-4422-48cf-8bdc-2a5f96cac1d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b770e52a-a016-4988-ad2f-fb433b54f5b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b8809b6f-b8d3-42ae-a0a0-16d015013c89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("b905ed4b-3ff8-4a2c-8f35-574561139704"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ba020035-3ac7-4c89-95f0-e604c8653ae1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bafdd369-0175-4533-851b-c1dc14ecf28f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb04a44e-4378-4cb8-a245-7c8d3e7a3070"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb2a5866-73bb-403d-92f3-6e8b5c5c3753"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bb8e3616-73ae-46b3-af35-0b53433975e6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bdfc9fc7-9759-4902-a90a-f544cc7701c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("be93fce6-b972-40c7-9ef0-244bd1575b3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("beb5598c-d5c5-41c3-88a6-ca367c83eaa4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("bfc0db20-72c3-49a6-acc7-9fd2ce593a51"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c02d64ba-3e3c-4ec7-93b3-bbbf822a1486"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c0a658de-11c3-4bf9-8618-2fc782589f06"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c231d65d-4173-4038-b70c-841ec05df8a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c27f5458-693b-44d1-915c-c54495a93bf9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c2ecd065-cc8d-43ad-929d-84ec2ced4f3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c4086211-3556-4f5d-bef2-6c028e86330f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c48933ae-2627-4cac-aea4-c2831b0aa4c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c4a4f660-95bf-4b40-bba6-7b6d8193d20e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c50da3b5-f6f3-4166-8829-114fdf342bf4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c57840ed-5d5b-42c9-8ce4-e04f508005fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c74faab1-8399-49b7-ad5c-57658b106e8a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c82b2106-9ffe-4ee6-b45e-f73e4d52399a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c8a810e7-71b8-48d6-8d29-49d2c1d921fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c8d561bd-87bb-4b6f-b849-098ab30cf3c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("c8ec5211-9454-4cc2-a142-48701c16c2f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ca703255-5f74-4795-8f19-2ea97cb3a61c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cacb162a-22a8-4fec-b062-fe827ce0791a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cc527773-e038-42e8-98cb-4afa77bf1fe7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cce1e6ba-e336-43cd-97c6-ebcb432ea2bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cf05daee-9888-4a34-9a48-309bd2935c4e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cf529e67-49d0-4b47-8f97-76e66dc74075"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("cfdee926-70ba-4f5b-aa7d-56ff78e3c7ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d06fd3b7-d652-4b18-9a50-085c2b398981"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d166a035-116c-4223-8bed-725806fb364d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d1a2c307-c2b5-4c18-b558-4900bfba7277"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d1e32d6f-9e5a-45e0-bcc4-ab6634813fa5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d2a55e8c-4998-405f-9b13-c1364a34b082"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d2bad42f-952c-4f37-8767-431999fef28c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d5646c9b-cba0-4c3a-8367-dee2e17cd711"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d5c3fb69-45d2-434a-98f4-f1d3512c9e62"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d6290e5e-82c7-4ec8-a9f2-f46165fa4003"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d637726f-95ee-4ea1-a5fa-fac7bbbb4774"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d71e54e1-5dcd-4cd2-86c4-6a10aa082d80"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d731ea43-3b4e-459b-8af6-f8d8f5445379"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d73bcf63-22a7-47d1-92a5-0dc86578aa07"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d8e61ba6-2c60-4cff-91f0-abc4649bcca2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("d9692bc4-e0c2-402f-8da6-58cca2be09c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("da1109d9-0f22-4e04-a5ed-8b4f815640af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("da8d179a-c81a-40e4-bec0-79674d7b40d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("dcfbe04e-9eb0-43c0-9f05-de90812b16b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ddd852f4-e91f-4634-bb9f-b91783539263"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("de83ef20-d8d8-4ef2-9d74-4fa1f4c1ab7d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("de880108-3ab9-41a2-b96b-b9764ea0a0a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("dfb0cad6-2372-4194-b0a9-03cc5e1871e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e1176984-8d51-4d49-adfc-ef26ced18454"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e2df33e0-fdcc-4264-849d-1d78f04d0750"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e3b7dda9-0d12-40ae-960a-9e45930d803e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e41c4eb8-bc8e-4dc7-8c13-cbc4ad61d430"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e442a6f1-8daf-4c46-9a60-310e11c411e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e65d3616-850b-4f6a-b349-3090b06ad50e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e6ac2a4a-ed0d-47d2-88b7-89e3ae72a5b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e6c87466-957d-4160-b493-1d572701e27f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e7422167-599e-4bef-9431-0e4c6e534379"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e7c44c14-1292-451d-a4a8-b3af33e5e50c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e95e8edd-745f-40ad-833f-8bbe3efb2b11"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("e9e0a24e-971f-4092-9132-1c5ba3252ebf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ebb48d6a-385e-415f-9694-acdc15e23692"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ec1c4ba8-97bf-495d-909b-2efa5660f734"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("edc98ab7-501b-4c6f-abc2-184c3370441a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("edd08602-df09-4b46-8259-5e5de5168131"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ee445a03-678f-4f38-b8f4-d7ce1600f896"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("eef5d9c5-995f-484f-84f8-ce32c10f2c83"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("ef3a0d35-d347-4cd9-b0bf-af879a704de7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f101d41e-967f-4fd6-a520-f33c701f881f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f1ed6111-eee4-4508-9b02-578e43043eec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f20d03a8-1f90-4382-aaac-050dce4b8f0a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f23053a7-9659-4444-af6f-d6a0ca9bbc13"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f2853007-6822-44ab-9850-f76760b72374"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f29ac324-c080-4f1f-ad62-48a30e9170e9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f2eff332-fd4b-4b23-8082-4453ab5c2f37"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f39c82fb-f1c7-47d9-8aa7-05e5cd59fcbf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f48473d9-c0ec-424e-a6a3-9cd7382c66cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f4b59e60-a1d0-4156-8fe7-48d7b04cc075"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f5702034-535c-4239-95f4-604457ecd65f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f737233f-ba91-4617-8159-4f87f24f01c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f82a9221-0160-4407-bd98-6de8f5b1061e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f8b50246-7eea-4e49-978c-5e178fa56c88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("f949c56e-728d-46e6-94c7-7483e23d8920"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fa646c01-191c-4b51-9ad1-bac032829664"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fcb730a5-b62d-4c2b-b849-8cba04a6abcf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fcdc31aa-01b7-4b1a-834d-6ca39f976657"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fd8a2774-c2f4-43bd-8901-d8a6beb6bf02"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fd936a00-3b1f-4a10-a048-9c96b523f627"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fe469019-59ae-475e-b48a-e4d34db78c0c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fe680f7a-db5e-4bf5-b7f6-3035c5ef8562"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("fe861194-b686-4731-96fb-8af7310d0586"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBSubtopics",
                keyColumn: "Id",
                keyValue: new Guid("febb448f-b4f9-4a3f-a743-0b3c5b9e7bdf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("081a1622-7203-4c98-87f2-9bf861a83e80"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("098c58a5-9441-4dfb-b0a0-592d412f3154"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0b3ee28f-55d0-4d80-a023-c32ea8920856"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0be9134f-56d9-44f9-97f2-5f904f4cce27"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0ca5797d-c9c4-46c7-9d2e-b29d1aea45db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0d81730a-3607-4fe6-9852-feb2ce7eea4c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("0ec218ce-6071-4ac9-9808-2bb824dea6cc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("16284996-2f43-47d6-af60-ff8272c4f0aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("178e982d-72ba-4064-820d-11c88cea740b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("18007ecc-eb81-4e56-a6b7-a396d0e230c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1807c66b-86ef-4439-b96b-9f2204d0c257"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1c2ec657-5e0d-4ff5-b2ad-49a5af224884"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1d27437a-1744-4dd5-a2d6-380191de61dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1d756c4c-2680-44cb-9d17-79e37187c659"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("1f11b050-0bac-4a96-a34e-b2991e9281b5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("214c676c-6349-4940-848d-cff8c3141a09"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("25594cec-d5e7-49af-bd40-3b10c19e570d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("26b2997f-0e36-4edc-a678-e5207db96898"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("28f359f9-ab5e-47c0-9e1d-071ac9d455ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("29dc43b1-a99b-41d9-9b47-0fec6a4e3124"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("2afa13cf-1984-4d86-aedd-0e97fc734cfc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("2ed90a88-3116-4ecc-9ad3-09ac74ac1915"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("31302466-738d-4316-95ec-ce6b1bc0679d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("359b90ee-04d0-4184-85da-4548d812b140"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("3da4db82-0a62-4dd1-a74d-a6196d03fbc9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("429c43c7-fa96-4096-8f33-7e2b8900a585"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4978ebe5-166d-4dab-828f-224cffac82d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("497a60c3-eb5a-4ebf-b1d9-451a2af4f629"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("4c51ee1e-9c7a-49eb-b973-70e9e7632cdb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5560bf9e-a614-4ab8-a3f9-fbb7c6359322"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("56952455-b442-448a-bdf0-fc41289e2be9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5c885d37-9e10-4001-9f1e-e1290770f58d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("5e4dbabc-3416-493c-b465-3458f7a9bbee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("61e71516-c11e-4349-97b8-d32bb1481c48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("6f1e5da9-fad7-4417-a109-ad047796f945"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("794eb9b2-0aab-4738-855f-4520ceb516e7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("810fa345-d498-4029-a26d-720408a1cda4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("83d7f58d-be1c-49b8-9d04-fb66e72d483b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("8ba16523-0b7d-46fb-9d2d-8d555a214652"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("8f9563da-90e3-490c-a364-1cd1f407f321"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("90d2d541-0140-4e60-b88a-981edd77223a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("91efc065-19a5-4a57-b45e-50676d81af48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("9816b756-467b-4ebd-8d4b-1f752fb1f58c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("9ce3d5a1-0e1e-46e8-a84b-ee1f5c6c26bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a585a905-db77-4ff8-b7b3-371bce1bc127"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a66d675e-d5e3-4ea2-9b65-f0fde65c7bf8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a68624a1-8e5a-4313-b286-97f24a63b59e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("a9b336ad-088d-4c89-a757-9a94d4ff6f17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("ac798a0b-b401-465a-9f11-4d6ac4656ca2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("af59becf-f214-4bda-8496-be00d5757472"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b0a0756d-fb45-4179-a519-bae64d958bcc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b169b287-7126-4a74-84a9-cc7caa5b57c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b288d337-e8cf-4482-b3fb-a1d9c9d28163"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("b62761c3-79cf-499c-8208-49ed50c86293"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("bbf9f843-f9f7-4189-ac89-eb0851450b83"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c2a26076-d2f0-403a-9ed0-a0212d615236"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c6478d8d-c7f1-40be-b437-69ba1b87d064"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("c8011b6e-daee-4c1f-aa39-10238cd509e6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("ca533595-5526-4d8e-944a-f7c16f75a006"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("cb2457c1-8102-4cb8-b0cc-8e2169403a8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("d09638f3-b46d-4ea1-b006-ed12937386d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("d1b5ebf9-5f93-4700-9b7b-046ecdf096e9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("d45e976d-7856-4be4-9d32-d7191b89a7ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("d6e3f0e7-54a7-439f-9f23-1d2ca2a595b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("d8885516-6676-4105-898e-582b710318c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("daba6f6b-f5fc-42e4-8648-c903539ac53d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("dcc88983-49c0-4c0c-bbfe-a674e4426c22"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("de6c09f4-75c4-4cb3-ad75-1145dcea5f54"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("de92e77b-2d9e-4590-94a0-118dee25c201"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("ded54546-a8fa-4cc4-b430-bef74b089002"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e2b5a99e-a8f4-4edc-af08-045267462356"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e38acad2-2f6a-42bc-9915-ed906faf8160"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e584ae7a-d9d8-4926-aced-f4f9f6f705f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e6cb5488-8593-46f1-af07-f781966891eb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("e6ea05a6-dd64-41c8-a04d-d62752aa6cb0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("efc0ac27-b630-41ea-a340-2b30a6b9f159"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f333ffb2-6485-4e5e-b855-a5d7fc4d89df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("fe4ce9e5-fd8b-4981-a32a-5fd74e3e0c0d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FASBTopics",
                keyColumn: "Id",
                keyValue: new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"));

            migrationBuilder.DropColumn(
                name: "SubType",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "SupersededBy",
                schema: "dbo",
                table: "FASBTopics",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullReference",
                schema: "dbo",
                table: "FASBSubtopics",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "FASBTopicId",
                schema: "dbo",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FASBSubtopicId",
                schema: "dbo",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FASBReference",
                schema: "dbo",
                table: "Accounts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_FASBSubtopics_FullReference",
                schema: "dbo",
                table: "FASBSubtopics",
                column: "FullReference",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_FASBReference",
                schema: "dbo",
                table: "Accounts",
                column: "FASBReference");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FASBSubtopics_FullReference",
                schema: "dbo",
                table: "FASBSubtopics");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_FASBReference",
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

            migrationBuilder.DropColumn(
                name: "SupersededBy",
                schema: "dbo",
                table: "FASBTopics");

            migrationBuilder.DropColumn(
                name: "FullReference",
                schema: "dbo",
                table: "FASBSubtopics");

            migrationBuilder.AlterColumn<Guid>(
                name: "FASBTopicId",
                schema: "dbo",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FASBSubtopicId",
                schema: "dbo",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "FASBReference",
                schema: "dbo",
                table: "Accounts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "SubType",
                schema: "dbo",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FASBTopics",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "IsSuperseded", "TopicCode", "TopicName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("081a1622-7203-4c98-87f2-9bf861a83e80"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3635), null, null, false, false, "280", "Segment Reporting", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3635) },
                    { new Guid("098c58a5-9441-4dfb-b0a0-592d412f3154"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4483), null, null, false, true, "430", "Deferred Revenue", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4483) },
                    { new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, false, false, "980", "Regulated Operations", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("0b3ee28f-55d0-4d80-a023-c32ea8920856"), "Revenue", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5359), null, null, false, false, "610", "Other Income", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5359) },
                    { new Guid("0be9134f-56d9-44f9-97f2-5f904f4cce27"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183), null, null, false, false, "978", "Real Estate—Time-Sharing Activities", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183) },
                    { new Guid("0ca5797d-c9c4-46c7-9d2e-b29d1aea45db"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4389), null, null, false, false, "410", "Asset Retirement and Environmental Obligations", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4389) },
                    { new Guid("0d81730a-3607-4fe6-9852-feb2ce7eea4c"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816), null, null, false, false, "842", "Leases", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816) },
                    { new Guid("0ec218ce-6071-4ac9-9808-2bb824dea6cc"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6674), null, null, false, false, "835", "Interest", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6674) },
                    { new Guid("16284996-2f43-47d6-af60-ff8272c4f0aa"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4749), null, null, false, false, "480", "Distinguishing Liabilities from Equity", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4749) },
                    { new Guid("178e982d-72ba-4064-820d-11c88cea740b"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7182), null, null, false, false, "905", "Agriculture", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7182) },
                    { new Guid("18007ecc-eb81-4e56-a6b7-a396d0e230c3"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6971), null, null, false, false, "850", "Related Party Disclosures", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6971) },
                    { new Guid("1807c66b-86ef-4439-b96b-9f2204d0c257"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4544), null, null, false, false, "450", "Contingencies", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4544) },
                    { new Guid("1c2ec657-5e0d-4ff5-b2ad-49a5af224884"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3373), null, null, false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3373) },
                    { new Guid("1d27437a-1744-4dd5-a2d6-380191de61dd"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823), null, null, false, false, "940", "Financial Services—Brokers and Dealers", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823) },
                    { new Guid("1d756c4c-2680-44cb-9d17-79e37187c659"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3962), null, null, false, false, "326", "Financial Instruments—Credit Losses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3962) },
                    { new Guid("1f11b050-0bac-4a96-a34e-b2991e9281b5"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6348), null, null, false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6348) },
                    { new Guid("214c676c-6349-4940-848d-cff8c3141a09"), "Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("25594cec-d5e7-49af-bd40-3b10c19e570d"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3219), null, null, false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3219) },
                    { new Guid("26b2997f-0e36-4edc-a678-e5207db96898"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3413), null, null, false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3413) },
                    { new Guid("28f359f9-ab5e-47c0-9e1d-071ac9d455ea"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282), null, null, false, false, "960", "Plan Accounting—Defined Benefit Pension Plans", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("29dc43b1-a99b-41d9-9b47-0fec6a4e3124"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7482), null, null, false, false, "922", "Entertainment—Cable Television", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7482) },
                    { new Guid("2afa13cf-1984-4d86-aedd-0e97fc734cfc"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595), null, null, false, false, "830", "Foreign Currency Matters", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595) },
                    { new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), "Revenue", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, false, true, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("2ed90a88-3116-4ecc-9ad3-09ac74ac1915"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6939), null, null, false, false, "848", "Reference Rate Reform", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6939) },
                    { new Guid("31302466-738d-4316-95ec-ce6b1bc0679d"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8642), null, null, false, false, "950", "Financial Services—Title Plant", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8642) },
                    { new Guid("359b90ee-04d0-4184-85da-4548d812b140"), "Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5422), null, null, false, false, "705", "Cost of Sales and Services", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5422) },
                    { new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, false, false, "942", "Financial Services—Depository and Lending", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("3da4db82-0a62-4dd1-a74d-a6196d03fbc9"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291), null, null, false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291) },
                    { new Guid("429c43c7-fa96-4096-8f33-7e2b8900a585"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057), null, null, false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057) },
                    { new Guid("4978ebe5-166d-4dab-828f-224cffac82d7"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883), null, null, false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883) },
                    { new Guid("497a60c3-eb5a-4ebf-b1d9-451a2af4f629"), "Equity", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782), null, null, false, false, "505", "Equity", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782) },
                    { new Guid("4c51ee1e-9c7a-49eb-b973-70e9e7632cdb"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7577), null, null, false, false, "926", "Entertainment—Films", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7577) },
                    { new Guid("5560bf9e-a614-4ab8-a3f9-fbb7c6359322"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3803), null, null, false, false, "321", "Investments—Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3803) },
                    { new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, false, false, "958", "Not-for-Profit Entities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("56952455-b442-448a-bdf0-fc41289e2be9"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7049), null, null, false, false, "855", "Subsequent Events", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7049) },
                    { new Guid("5c885d37-9e10-4001-9f1e-e1290770f58d"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6561), null, null, false, false, "825", "Financial Instruments", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6561) },
                    { new Guid("5e4dbabc-3416-493c-b465-3458f7a9bbee"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7751), null, null, false, false, "932", "Extractive Activities—Oil and Gas", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7751) },
                    { new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, false, false, "954", "Health Care Entities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("61e71516-c11e-4349-97b8-d32bb1481c48"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3119), null, null, false, false, "205", "Presentation of Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3119) },
                    { new Guid("6f1e5da9-fad7-4417-a109-ad047796f945"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3475), null, null, false, false, "260", "Earnings Per Share", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3475) },
                    { new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, false, false, "974", "Real Estate—Real Estate Investment Trusts", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"), "Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705), null, null, false, false, "718", "Compensation—Stock Compensation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705) },
                    { new Guid("794eb9b2-0aab-4738-855f-4520ceb516e7"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638), null, null, false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638) },
                    { new Guid("810fa345-d498-4029-a26d-720408a1cda4"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4026), null, null, false, false, "330", "Inventory", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4026) },
                    { new Guid("83d7f58d-be1c-49b8-9d04-fb66e72d483b"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7292), null, null, false, false, "910", "Contractors—Construction", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7292) },
                    { new Guid("8ba16523-0b7d-46fb-9d2d-8d555a214652"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7002), null, null, false, false, "852", "Reorganizations", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7002) },
                    { new Guid("8f9563da-90e3-490c-a364-1cd1f407f321"), "Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5515), null, null, false, false, "712", "Compensation—Nonretirement Postemployment Benefits", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5515) },
                    { new Guid("90d2d541-0140-4e60-b88a-981edd77223a"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082), null, null, false, false, "860", "Transfers and Servicing", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082) },
                    { new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, false, false, "944", "Financial Services—Insurance", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("9816b756-467b-4ebd-8d4b-1f752fb1f58c"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8580), null, null, false, false, "948", "Financial Services—Mortgage Banking", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8580) },
                    { new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), "Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, false, false, "720", "Other Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("9ce3d5a1-0e1e-46e8-a84b-ee1f5c6c26bb"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(410), null, null, false, false, "985", "Software", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(410) },
                    { new Guid("a585a905-db77-4ff8-b7b3-371bce1bc127"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7245), null, null, false, false, "908", "Airlines", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7245) },
                    { new Guid("a66d675e-d5e3-4ea2-9b65-f0fde65c7bf8"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9822), null, null, false, false, "972", "Real Estate—Common Interest Realty Associations", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9822) },
                    { new Guid("a68624a1-8e5a-4313-b286-97f24a63b59e"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3270), null, null, false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3270) },
                    { new Guid("a9b336ad-088d-4c89-a757-9a94d4ff6f17"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3444), null, null, false, false, "250", "Accounting Changes and Error Corrections", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3444) },
                    { new Guid("ac798a0b-b401-465a-9f11-4d6ac4656ca2"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7639), null, null, false, false, "928", "Entertainment—Music", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7639) },
                    { new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, false, false, "970", "Real Estate—General", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("af59becf-f214-4bda-8496-be00d5757472"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339), null, null, false, false, "912", "Contractors—Federal Government", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339) },
                    { new Guid("b0a0756d-fb45-4179-a519-bae64d958bcc"), "Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5469), null, null, false, false, "710", "Compensation—General", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5469) },
                    { new Guid("b169b287-7126-4a74-84a9-cc7caa5b57c9"), "Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040), null, null, false, false, "740", "Income Taxes", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040) },
                    { new Guid("b288d337-e8cf-4482-b3fb-a1d9c9d28163"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3699), null, null, false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3699) },
                    { new Guid("b62761c3-79cf-499c-8208-49ed50c86293"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7419), null, null, false, false, "920", "Entertainment—Broadcasters", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7419) },
                    { new Guid("bbf9f843-f9f7-4189-ac89-eb0851450b83"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3772), null, null, false, true, "320", "Investments—Debt Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3772) },
                    { new Guid("c2a26076-d2f0-403a-9ed0-a0212d615236"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6908), null, null, false, false, "845", "Nonmonetary Transactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6908) },
                    { new Guid("c6478d8d-c7f1-40be-b437-69ba1b87d064"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136), null, null, false, false, "350", "Intangibles—Goodwill and Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("c8011b6e-daee-4c1f-aa39-10238cd509e6"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3667), null, null, false, false, "305", "Cash and Cash Equivalents", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3667) },
                    { new Guid("ca533595-5526-4d8e-944a-f7c16f75a006"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4606), null, null, false, false, "460", "Guarantees", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4606) },
                    { new Guid("cb2457c1-8102-4cb8-b0cc-8e2169403a8b"), "Revenue", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5312), null, null, false, false, "606", "Revenue from Contracts with Customers", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5312) },
                    { new Guid("d09638f3-b46d-4ea1-b006-ed12937386d8"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7528), null, null, false, false, "924", "Entertainment—Casinos", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7528) },
                    { new Guid("d1b5ebf9-5f93-4700-9b7b-046ecdf096e9"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3318), null, null, false, false, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3318) },
                    { new Guid("d45e976d-7856-4be4-9d32-d7191b89a7ae"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3506), null, null, false, false, "270", "Interim Reporting", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3506) },
                    { new Guid("d6e3f0e7-54a7-439f-9f23-1d2ca2a595b9"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737), null, null, false, true, "840", "Leases", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737) },
                    { new Guid("d8885516-6676-4105-898e-582b710318c8"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484), null, null, false, false, "965", "Plan Accounting—Health and Welfare Benefit Plans", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484) },
                    { new Guid("daba6f6b-f5fc-42e4-8648-c903539ac53d"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4244), null, null, false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4244) },
                    { new Guid("dcc88983-49c0-4c0c-bbfe-a674e4426c22"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391), null, null, false, false, "962", "Plan Accounting—Defined Contribution Pension Plans", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391) },
                    { new Guid("de6c09f4-75c4-4cb3-ad75-1145dcea5f54"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(136), null, null, false, true, "976", "Real Estate—Retail Land", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(136) },
                    { new Guid("de92e77b-2d9e-4590-94a0-118dee25c201"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4452), null, null, false, false, "420", "Exit or Disposal Cost Obligations", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4452) },
                    { new Guid("ded54546-a8fa-4cc4-b430-bef74b089002"), "Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5992), null, null, false, false, "730", "Research and Development", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5992) },
                    { new Guid("e2b5a99e-a8f4-4edc-af08-045267462356"), "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4514), null, null, false, false, "440", "Commitments", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4514) },
                    { new Guid("e38acad2-2f6a-42bc-9915-ed906faf8160"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6315), null, null, false, false, "808", "Collaborative Arrangements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6315) },
                    { new Guid("e584ae7a-d9d8-4926-aced-f4f9f6f705f7"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3603), null, null, false, false, "274", "Personal Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3603) },
                    { new Guid("e6cb5488-8593-46f1-af07-f781966891eb"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3538), null, null, false, false, "272", "Limited Liability Entities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3538) },
                    { new Guid("e6ea05a6-dd64-41c8-a04d-d62752aa6cb0"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7687), null, null, false, false, "930", "Extractive Activities—Mining", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7687) },
                    { new Guid("efc0ac27-b630-41ea-a340-2b30a6b9f159"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6529), null, null, false, false, "820", "Fair Value Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6529) },
                    { new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, false, false, "815", "Derivatives and Hedging", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("f333ffb2-6485-4e5e-b855-a5d7fc4d89df"), "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3571), null, null, false, false, "273", "Corporate Joint Ventures", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3571) },
                    { new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), "Industry", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, false, false, "946", "Financial Services—Investment Companies", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("fe4ce9e5-fd8b-4981-a32a-5fd74e3e0c0d"), "Assets", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3836), null, null, false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3836) },
                    { new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), "BroadTransactions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, false, false, "805", "Business Combinations", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FASBSubtopics",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "FASBTopicId", "IsDeleted", "IsRepealed", "SubtopicCode", "SubtopicName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("022724a3-c3e6-4026-ae37-5d6d1e7e3295"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6561), null, null, new Guid("5c885d37-9e10-4001-9f1e-e1290770f58d"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6561) },
                    { new Guid("02297461-5975-4f93-8b13-6636923fb06a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8580), null, null, new Guid("9816b756-467b-4ebd-8d4b-1f752fb1f58c"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8580) },
                    { new Guid("02c2b15e-f54d-40b2-bc8e-6a7b47a84ade"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8580), null, null, new Guid("9816b756-467b-4ebd-8d4b-1f752fb1f58c"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8580) },
                    { new Guid("031c2cc4-77db-4920-aff8-d7fd6b4456d0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7002), null, null, new Guid("8ba16523-0b7d-46fb-9d2d-8d555a214652"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7002) },
                    { new Guid("04c776d5-194f-4f0e-ae4e-7c3a1f8618a6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823), null, null, new Guid("1d27437a-1744-4dd5-a2d6-380191de61dd"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823) },
                    { new Guid("05083391-f60a-45ff-a30e-d1b6488184dc"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082), null, null, new Guid("90d2d541-0140-4e60-b88a-981edd77223a"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082) },
                    { new Guid("0510cd39-3d85-420f-a88b-b916ad58b83d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7577), null, null, new Guid("4c51ee1e-9c7a-49eb-b973-70e9e7632cdb"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7577) },
                    { new Guid("093aee74-acce-45d0-b811-ed563b3bb474"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3270), null, null, new Guid("a68624a1-8e5a-4313-b286-97f24a63b59e"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3270) },
                    { new Guid("0c04146e-4791-4fb7-8b1c-2009eea13080"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("0c4ce124-8466-4555-965e-43616f04badc"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7751), null, null, new Guid("5e4dbabc-3416-493c-b465-3458f7a9bbee"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7751) },
                    { new Guid("0cb24741-6056-43cd-bcd1-abcad1bf334f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("0d849caf-d1cd-41f4-afb3-74e0fa5f23f3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("0df6eff0-0c69-4484-9fba-7e6a9e8fe1a7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082), null, null, new Guid("90d2d541-0140-4e60-b88a-981edd77223a"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082) },
                    { new Guid("0f81af12-adac-404d-b83c-14d15dd13575"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823), null, null, new Guid("1d27437a-1744-4dd5-a2d6-380191de61dd"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823) },
                    { new Guid("10015003-e605-4176-946c-8b23fa3dbab4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("10040513-046c-4aec-b2c2-a17745af13ff"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "28", "Subtopic 28", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("104b6f35-eef6-409c-8cf6-656588ba096f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7049), null, null, new Guid("56952455-b442-448a-bdf0-fc41289e2be9"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7049) },
                    { new Guid("110e4126-ff5c-44ca-aa25-42ecce60d9f8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "815", "Derivatives and Hedging", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("121dbe4c-b6e4-46d3-a84e-3e4859939804"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("12b5746d-f96a-4d62-8e75-57ff012c6a40"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3538), null, null, new Guid("e6cb5488-8593-46f1-af07-f781966891eb"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3538) },
                    { new Guid("12e856eb-9a50-4b58-a5cc-25010b44d25b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391), null, null, new Guid("dcc88983-49c0-4c0c-bbfe-a674e4426c22"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391) },
                    { new Guid("147979e9-4fb4-45b8-916b-d9732a181d6b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595), null, null, new Guid("2afa13cf-1984-4d86-aedd-0e97fc734cfc"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595) },
                    { new Guid("186b92c4-c2ce-4e68-9967-a91cbab59ba7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8580), null, null, new Guid("9816b756-467b-4ebd-8d4b-1f752fb1f58c"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8580) },
                    { new Guid("187a03b1-bb43-40f8-a063-f72cdf641f60"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("19404167-e4a4-4a5e-aa76-bb9799fe462e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136), null, null, new Guid("c6478d8d-c7f1-40be-b437-69ba1b87d064"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("1a2baed4-aadd-4804-889a-865a54b20f66"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("1abf5d07-0f6a-4b28-86a5-4c23924c7cd4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("1dd890e2-fcec-417a-affb-43ae0777733e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("28f359f9-ab5e-47c0-9e1d-071ac9d455ea"), false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("1e485794-026d-409c-89bf-9a487d6391a6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, new Guid("214c676c-6349-4940-848d-cff8c3141a09"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("1e74700e-6e9c-434a-821f-fc72ef2354f1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782), null, null, new Guid("497a60c3-eb5a-4ebf-b1d9-451a2af4f629"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782) },
                    { new Guid("1e833f37-1099-4935-8d78-f4f782fc89fc"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3699), null, null, new Guid("b288d337-e8cf-4482-b3fb-a1d9c9d28163"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3699) },
                    { new Guid("1e910a9c-eb75-4890-864c-e4b71cff4c0b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7639), null, null, new Guid("ac798a0b-b401-465a-9f11-4d6ac4656ca2"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7639) },
                    { new Guid("1ee37a99-582b-4865-aa43-34641447693c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3667), null, null, new Guid("c8011b6e-daee-4c1f-aa39-10238cd509e6"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3667) },
                    { new Guid("1ee75559-9deb-44dc-9e91-2467ea790fc7"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("1f294379-a919-46eb-8bad-5c12213c85c0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("1f6f0cd9-8b6b-4e81-95d5-41b5ab3661c3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("20fe42c8-fccd-4ffa-b856-f795aca644fd"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("2125d9c6-a916-426f-8b08-a07e300500d1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("2132be2f-0caa-430f-ba4c-f013195d464e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("21a53163-5338-4eea-9379-d813a14b0fe3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883), null, null, new Guid("4978ebe5-166d-4dab-828f-224cffac82d7"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883) },
                    { new Guid("21d7ed9e-05b1-4716-a728-0ef575fe9bb9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "606", "Revenue from Contracts with Customers", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("221a0d47-25c3-4fbe-b0c1-6e1b41a9ff71"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8642), null, null, new Guid("31302466-738d-4316-95ec-ce6b1bc0679d"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8642) },
                    { new Guid("22390509-17ef-4972-9db7-b78c41a841c2"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("22a9698e-57de-4a30-9033-3f54ff841574"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3373), null, null, new Guid("1c2ec657-5e0d-4ff5-b2ad-49a5af224884"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3373) },
                    { new Guid("240de2be-dc6c-4654-ba7c-bbe236a95bf0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("2595bffa-03f0-4ace-90c5-7e813fb2dbdf"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816), null, null, new Guid("0d81730a-3607-4fe6-9852-feb2ce7eea4c"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816) },
                    { new Guid("26d63d5f-9e85-4905-a722-57335fa23e02"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391), null, null, new Guid("dcc88983-49c0-4c0c-bbfe-a674e4426c22"), false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391) },
                    { new Guid("26e33ded-4d28-4ecc-adf7-86267cc95cff"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, new Guid("214c676c-6349-4940-848d-cff8c3141a09"), false, false, "70", "Grandfathered Guidance", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("27db4212-825d-4b51-8f47-9a056080ba69"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705), null, null, new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"), false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705) },
                    { new Guid("2897e92d-db4d-4bae-ba3a-9ae4adc95ee3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3219), null, null, new Guid("25594cec-d5e7-49af-bd40-3b10c19e570d"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3219) },
                    { new Guid("2a99e346-e66b-49c2-b9b9-537abbba6e1f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3603), null, null, new Guid("e584ae7a-d9d8-4926-aced-f4f9f6f705f7"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3603) },
                    { new Guid("2b9b4ddc-1b2c-473b-8c24-983b689f63a8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("2c2004c3-b9ce-4316-8455-8f4bd8093a82"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("2cb8a4b6-20e9-429f-9f1e-8f046016098a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("2cbebb11-a172-42a7-bf6a-f0747b7157e3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("2d9c46c2-7066-4b85-98ac-2bce987e91e4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484), null, null, new Guid("d8885516-6676-4105-898e-582b710318c8"), false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484) },
                    { new Guid("2e17cec7-7afa-4a90-84bc-f547a1842cbf"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "825", "Financial Instruments", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("2e812ede-6d92-428c-aaab-5f2e8dd30cdf"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("2f0ec353-3ed8-416b-b785-5b9074d6c69d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737), null, null, new Guid("d6e3f0e7-54a7-439f-9f23-1d2ca2a595b9"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737) },
                    { new Guid("2f5e0f9b-0b99-4395-a1fa-38f023e914f7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057), null, null, new Guid("429c43c7-fa96-4096-8f33-7e2b8900a585"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057) },
                    { new Guid("305c6635-272c-4160-a754-81c8e14e553d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6908), null, null, new Guid("c2a26076-d2f0-403a-9ed0-a0212d615236"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6908) },
                    { new Guid("3109cb2a-4c66-4a29-9126-6d0868447dda"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082), null, null, new Guid("90d2d541-0140-4e60-b88a-981edd77223a"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082) },
                    { new Guid("311d35ed-befe-4708-a817-1594b82ec3f0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "740", "Income Taxes", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("31ea1d6b-3abb-4022-950e-57c0d6e66c98"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3219), null, null, new Guid("25594cec-d5e7-49af-bd40-3b10c19e570d"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3219) },
                    { new Guid("326fb234-8a93-452e-9840-678c0c7959ef"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7292), null, null, new Guid("83d7f58d-be1c-49b8-9d04-fb66e72d483b"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7292) },
                    { new Guid("32ba1911-bef5-4c39-a31b-614456410d4a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3772), null, null, new Guid("bbf9f843-f9f7-4189-ac89-eb0851450b83"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3772) },
                    { new Guid("335fade9-ed0b-4b42-9fbf-87a80c242703"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("3406e9cb-b0db-4145-bc5e-0baff7f2a5ea"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7419), null, null, new Guid("b62761c3-79cf-499c-8208-49ed50c86293"), false, false, "350", "Intangibles—Goodwill and Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7419) },
                    { new Guid("341565bb-264d-45bd-aa80-197a5b01776e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("3459188a-d156-419f-a74f-23ea566167c2"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3444), null, null, new Guid("a9b336ad-088d-4c89-a757-9a94d4ff6f17"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3444) },
                    { new Guid("346e44e2-f500-442a-9c56-7d76b67b81a4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705), null, null, new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705) },
                    { new Guid("366c3c68-421c-46cc-80d7-f83b8748ec15"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816), null, null, new Guid("0d81730a-3607-4fe6-9852-feb2ce7eea4c"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816) },
                    { new Guid("3671a8fe-2412-4adf-bbdb-ca0895d85002"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(136), null, null, new Guid("de6c09f4-75c4-4cb3-ad75-1145dcea5f54"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(136) },
                    { new Guid("368f940c-29bd-486f-95a5-23d13353d01c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7182), null, null, new Guid("178e982d-72ba-4064-820d-11c88cea740b"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7182) },
                    { new Guid("36a9812b-44dd-49fa-af1b-d3bbad3b3384"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5515), null, null, new Guid("8f9563da-90e3-490c-a364-1cd1f407f321"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5515) },
                    { new Guid("3725d713-33a1-4cb5-908d-d8955b659a7d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7528), null, null, new Guid("d09638f3-b46d-4ea1-b006-ed12937386d8"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7528) },
                    { new Guid("37ee6123-144b-426f-a908-186b98d9ec99"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7687), null, null, new Guid("e6ea05a6-dd64-41c8-a04d-d62752aa6cb0"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7687) },
                    { new Guid("396a4145-a61f-48d3-80fa-17633c420ca8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("39b856fd-8a11-48f5-a2d6-8921aaf12c52"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, new Guid("214c676c-6349-4940-848d-cff8c3141a09"), false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("39ce7517-227e-4753-b987-5e025b6fcf30"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("3a3f1b1f-6422-409a-b68b-c9cbfb0b7af8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("3b15b4c1-c31e-40d0-871f-e9127a03c2c2"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782), null, null, new Guid("497a60c3-eb5a-4ebf-b1d9-451a2af4f629"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782) },
                    { new Guid("3b1d7acd-05a5-4a82-9c36-9b5f510b76ae"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("3e0bf1a5-01b3-489d-8caa-e6a7279718e1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("4188ba96-e740-41d1-96fa-c3dfb91e50aa"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040), null, null, new Guid("b169b287-7126-4a74-84a9-cc7caa5b57c9"), false, false, "270", "Interim Reporting", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040) },
                    { new Guid("42774e38-393c-41b9-9bbc-2f6c80994f60"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("428b8be2-b25d-40df-9db7-3ec67da2ea6b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782), null, null, new Guid("497a60c3-eb5a-4ebf-b1d9-451a2af4f629"), false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782) },
                    { new Guid("430cb918-77c1-4fb5-afc5-0898d6e16db8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "25", "Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("431c4dff-5df0-42f0-84a9-ec8ffc3dcdfa"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(410), null, null, new Guid("9ce3d5a1-0e1e-46e8-a84b-ee1f5c6c26bb"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(410) },
                    { new Guid("443d12d9-cbf6-4cd8-a020-26d0a4d10ff1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("44415019-6b38-464e-98a5-5711c4a80e93"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705), null, null, new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705) },
                    { new Guid("45e13bb8-0fa0-4d67-9b7d-6cd6e9b49da6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5515), null, null, new Guid("8f9563da-90e3-490c-a364-1cd1f407f321"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5515) },
                    { new Guid("460dee9e-63a8-41f3-9f3b-ac4e72b37676"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "505", "Equity", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("46ee13fc-35d4-44a7-8ab0-0f906cec553f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("47125dbf-2664-4dd3-a36b-551795623758"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5422), null, null, new Guid("359b90ee-04d0-4184-85da-4548d812b140"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5422) },
                    { new Guid("474ca193-7252-4943-9c32-1b00f4bb24bb"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("479abe29-80d7-472f-8f70-4835c76ba4ff"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("47b494a5-e9b3-4a7d-a39b-d3278c7cb3de"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("48ebb203-7795-4c80-b77f-c722b5ddbe69"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3962), null, null, new Guid("1d756c4c-2680-44cb-9d17-79e37187c659"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3962) },
                    { new Guid("4984e0ac-a8e3-46e0-9a1f-837c89db0bb1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5469), null, null, new Guid("b0a0756d-fb45-4179-a519-bae64d958bcc"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5469) },
                    { new Guid("4a86c7ca-9a94-440d-81c7-c961fb352ea1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638), null, null, new Guid("794eb9b2-0aab-4738-855f-4520ceb516e7"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638) },
                    { new Guid("4ac591b4-b4a7-4b3b-9c41-76aee73533c7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4544), null, null, new Guid("1807c66b-86ef-4439-b96b-9f2204d0c257"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4544) },
                    { new Guid("4ba5bcd7-9980-49fa-b842-5ff272d20d9b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("4bdc76d0-d0a3-42ff-b8a6-bebaeec4efcd"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7528), null, null, new Guid("d09638f3-b46d-4ea1-b006-ed12937386d8"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7528) },
                    { new Guid("4bdfacac-4c51-46a5-9e9e-5b3aa811e277"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291), null, null, new Guid("3da4db82-0a62-4dd1-a74d-a6196d03fbc9"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291) },
                    { new Guid("4cd48ebe-ddd6-423c-8541-d0ea526d3b17"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("4eedb118-01eb-496c-9ec5-16dc54965bc0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9822), null, null, new Guid("a66d675e-d5e3-4ea2-9b65-f0fde65c7bf8"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9822) },
                    { new Guid("4fbc2128-54bd-4f24-8821-99a4ffced0f4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("4ff6dff9-0bdd-4959-b5ce-4555757a2b24"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("507bff94-9ed3-4173-be74-222a24a58b03"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("51151fdc-eda7-41ed-a528-ef39acb91697"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, new Guid("214c676c-6349-4940-848d-cff8c3141a09"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("51a0d710-7648-4eea-b914-f7e42ae9fae8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3506), null, null, new Guid("d45e976d-7856-4be4-9d32-d7191b89a7ae"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3506) },
                    { new Guid("524152bf-e9c0-47fa-ab02-47d41f4cc467"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("5316c034-49e0-4953-8fcc-bf87b282ac15"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("534b80a6-994b-45e3-8338-d25be209ea4b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638), null, null, new Guid("794eb9b2-0aab-4738-855f-4520ceb516e7"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638) },
                    { new Guid("534f7c56-cbb0-4c9e-82df-347186518fb1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("5364f921-f8a7-463a-aeb7-6d8ddd83cce9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057), null, null, new Guid("429c43c7-fa96-4096-8f33-7e2b8900a585"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057) },
                    { new Guid("59674570-4ad9-4947-93fd-da57a73e1c46"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7482), null, null, new Guid("29dc43b1-a99b-41d9-9b47-0fec6a4e3124"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7482) },
                    { new Guid("59ac3698-4bab-4e9b-b7a1-924ad15110de"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("5c0b15d4-5f10-4b1e-a75e-f3783e96ae4d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("5c62be59-2476-4e8e-ae44-ea6113aee20f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3836), null, null, new Guid("fe4ce9e5-fd8b-4981-a32a-5fd74e3e0c0d"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3836) },
                    { new Guid("5d361f50-0ccd-4d40-b507-683a32846854"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("5e6a4268-b7cc-4654-8147-5330b3f07772"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3836), null, null, new Guid("fe4ce9e5-fd8b-4981-a32a-5fd74e3e0c0d"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3836) },
                    { new Guid("5ef638f7-747e-45f3-bc07-c2ebd4e0ca42"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("5fd2ae26-711d-4ef4-b21e-897bb30078d7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("60d71167-6565-4ea7-80ed-8c391a682af0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883), null, null, new Guid("4978ebe5-166d-4dab-828f-224cffac82d7"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883) },
                    { new Guid("621fe394-2a6a-45ca-a350-aca3544d4e73"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4452), null, null, new Guid("de92e77b-2d9e-4590-94a0-118dee25c201"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4452) },
                    { new Guid("62332f9c-94f8-4ad8-9abc-601521509111"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("62d66487-197e-4dd4-976a-9927741d9640"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "25", "Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("64a38cc5-e545-4f17-bfe6-7d1b79c157e7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7419), null, null, new Guid("b62761c3-79cf-499c-8208-49ed50c86293"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7419) },
                    { new Guid("654723c1-d5ba-4d18-b9f9-5b98bbc8b68c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4389), null, null, new Guid("0ca5797d-c9c4-46c7-9d2e-b29d1aea45db"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4389) },
                    { new Guid("65632c2a-8118-4958-bf32-9bc81b4da92b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("66a49c08-a7ff-46b6-8aa9-780e550c20c2"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7182), null, null, new Guid("178e982d-72ba-4064-820d-11c88cea740b"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7182) },
                    { new Guid("673b292c-8a36-4467-b353-28c471f78989"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823), null, null, new Guid("1d27437a-1744-4dd5-a2d6-380191de61dd"), false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823) },
                    { new Guid("69574527-7ebb-4c85-a7f0-406519cdf31a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "505", "Equity", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("699c3c2d-5c74-4be8-aec8-d4579901f593"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040), null, null, new Guid("b169b287-7126-4a74-84a9-cc7caa5b57c9"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040) },
                    { new Guid("6aac3764-91aa-414a-8f34-5fefdd422d0f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("6b99fb80-8b66-4279-9833-634f30bd234c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082), null, null, new Guid("90d2d541-0140-4e60-b88a-981edd77223a"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082) },
                    { new Guid("6be847f6-665a-4ebf-a106-9b5f7b094f43"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, new Guid("214c676c-6349-4940-848d-cff8c3141a09"), false, false, "80", "Multiemployer Plans", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("6bf4a42c-949f-4c93-9358-cc4c4052113b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3962), null, null, new Guid("1d756c4c-2680-44cb-9d17-79e37187c659"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3962) },
                    { new Guid("6c81130b-026e-49f0-9bef-a571431a5ca1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136), null, null, new Guid("c6478d8d-c7f1-40be-b437-69ba1b87d064"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("6d8106c0-2f9c-4505-bfda-8ed0740a57dc"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7292), null, null, new Guid("83d7f58d-be1c-49b8-9d04-fb66e72d483b"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7292) },
                    { new Guid("6e31f1aa-bd11-4d30-86a8-84ed6ccb1927"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6674), null, null, new Guid("0ec218ce-6071-4ac9-9808-2bb824dea6cc"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6674) },
                    { new Guid("6f1eee59-1059-47bc-8901-2cdcf57d1cbc"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4244), null, null, new Guid("daba6f6b-f5fc-42e4-8648-c903539ac53d"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4244) },
                    { new Guid("6f281adb-9405-423b-bd11-1279e146beae"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595), null, null, new Guid("2afa13cf-1984-4d86-aedd-0e97fc734cfc"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595) },
                    { new Guid("70bee8ac-ce07-40ab-9f1c-a2d2f10df4de"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4544), null, null, new Guid("1807c66b-86ef-4439-b96b-9f2204d0c257"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4544) },
                    { new Guid("710bf3ca-7be0-48b5-9b2c-67b473dd6635"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5312), null, null, new Guid("cb2457c1-8102-4cb8-b0cc-8e2169403a8b"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5312) },
                    { new Guid("71e27427-baa0-4f89-b5a2-9772a5d64fa4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782), null, null, new Guid("497a60c3-eb5a-4ebf-b1d9-451a2af4f629"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782) },
                    { new Guid("725e1c63-349e-4e91-b00c-fc9525e11f8b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "715", "Compensation—Retirement Benefits", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("729e8626-f9d2-475e-8f56-6b1865277bca"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("28f359f9-ab5e-47c0-9e1d-071ac9d455ea"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("7383ffc0-7323-4b6d-a4be-0c28b8c0e8ae"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883), null, null, new Guid("4978ebe5-166d-4dab-828f-224cffac82d7"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883) },
                    { new Guid("73fecd87-c98e-4177-a748-1ca2e075a05c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "954", "Health Care Entities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("74627b55-49b8-4a9f-9b50-2c2732b424b8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705), null, null, new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705) },
                    { new Guid("74681fd2-72fd-4424-b2ca-b2eed5b88a32"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136), null, null, new Guid("c6478d8d-c7f1-40be-b437-69ba1b87d064"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("74ce2c07-08a7-4ff0-bfce-4df7baf719fb"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7687), null, null, new Guid("e6ea05a6-dd64-41c8-a04d-d62752aa6cb0"), false, false, "330", "Inventory", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7687) },
                    { new Guid("76714024-b947-46ff-8cd1-d418f26ca7ee"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6674), null, null, new Guid("0ec218ce-6071-4ac9-9808-2bb824dea6cc"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6674) },
                    { new Guid("76be04c0-8fbe-44ab-b425-419fbd8fd817"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("77ae65e6-eb66-45dd-93de-9b9626e90c47"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), false, false, "25", "Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("79eb6745-b1fa-4a8f-8f77-4d708aa12128"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7482), null, null, new Guid("29dc43b1-a99b-41d9-9b47-0fec6a4e3124"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7482) },
                    { new Guid("7b3d7dcb-d9b3-4562-bc6e-2c89843f970d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7577), null, null, new Guid("4c51ee1e-9c7a-49eb-b973-70e9e7632cdb"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7577) },
                    { new Guid("7bd3b89a-7399-4d8f-898d-4ae0252ef399"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("7be2a8cf-6a39-4032-ace8-af4d8391dd54"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(410), null, null, new Guid("9ce3d5a1-0e1e-46e8-a84b-ee1f5c6c26bb"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(410) },
                    { new Guid("7cda642c-54ea-4dfc-aa6a-90192c7cd0f9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "225", "Income Statement—Discontinued Operations", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("7fdf274a-f832-4d9b-852d-5cb41e0b663f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484), null, null, new Guid("d8885516-6676-4105-898e-582b710318c8"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484) },
                    { new Guid("810f49ba-5e9d-42c2-ad45-cbfd4a8d95ef"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("81171485-6c3e-421d-b1fb-9793a394684d"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(410), null, null, new Guid("9ce3d5a1-0e1e-46e8-a84b-ee1f5c6c26bb"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(410) },
                    { new Guid("81a532d8-1bc9-4929-9f22-c0f87c2d87aa"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705), null, null, new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"), false, false, "740", "Income Taxes", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705) },
                    { new Guid("82be44b9-5c50-43a0-b93c-61a3fecaa8c8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595), null, null, new Guid("2afa13cf-1984-4d86-aedd-0e97fc734cfc"), false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595) },
                    { new Guid("839b8b68-72fd-4482-b819-a315c5f16de9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737), null, null, new Guid("d6e3f0e7-54a7-439f-9f23-1d2ca2a595b9"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737) },
                    { new Guid("840d7263-2c8d-4f29-b755-1ce5785fa6a1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7751), null, null, new Guid("5e4dbabc-3416-493c-b465-3458f7a9bbee"), false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7751) },
                    { new Guid("848977f1-4850-4b36-adde-4ac29985d4cc"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705), null, null, new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705) },
                    { new Guid("8529f9f9-d279-4658-abf9-d6be1a331b23"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391), null, null, new Guid("dcc88983-49c0-4c0c-bbfe-a674e4426c22"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391) },
                    { new Guid("8674f4eb-c5d8-4038-b259-5b217d5c469d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("8734630e-418b-43d7-aedc-73b2d935dbd8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291), null, null, new Guid("3da4db82-0a62-4dd1-a74d-a6196d03fbc9"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291) },
                    { new Guid("8743efbe-0e58-4cd4-bf49-0577f6c92445"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("8803c491-cfaf-4c46-b1f6-71fd3c343e89"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291), null, null, new Guid("3da4db82-0a62-4dd1-a74d-a6196d03fbc9"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291) },
                    { new Guid("889efff3-e919-4af8-8d9a-cba1a113382a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3119), null, null, new Guid("61e71516-c11e-4349-97b8-d32bb1481c48"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3119) },
                    { new Guid("89104e94-3aba-4cf0-a770-da4b6489e1c1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4389), null, null, new Guid("0ca5797d-c9c4-46c7-9d2e-b29d1aea45db"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4389) },
                    { new Guid("8987eeae-4d96-48d0-b10a-93c3413d36a6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("8a096eee-f758-48c4-a643-61e4eeefc16d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, new Guid("214c676c-6349-4940-848d-cff8c3141a09"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("8a5310ad-6239-4f11-be7e-24f8d84b2955"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(136), null, null, new Guid("de6c09f4-75c4-4cb3-ad75-1145dcea5f54"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(136) },
                    { new Guid("8aedde19-c094-4a7e-bc19-4c26d022b19a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7687), null, null, new Guid("e6ea05a6-dd64-41c8-a04d-d62752aa6cb0"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7687) },
                    { new Guid("8b0d7c88-21a7-4d12-b928-6b05fb874c5e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("8b1116fe-f3d5-4a79-bd76-66809afbe061"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("8b6f7685-dd5e-4546-96e9-830ae6c8e3a9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("8cf5bfcc-aaf6-434e-b020-3c32f6c45db8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7245), null, null, new Guid("a585a905-db77-4ff8-b7b3-371bce1bc127"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7245) },
                    { new Guid("8d2f7e48-f72a-49f0-9691-a48d6ad40557"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5469), null, null, new Guid("b0a0756d-fb45-4179-a519-bae64d958bcc"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5469) },
                    { new Guid("8eb7b29f-6996-46ad-8898-136eef87f6d6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638), null, null, new Guid("794eb9b2-0aab-4738-855f-4520ceb516e7"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638) },
                    { new Guid("90bd6f29-7a07-4362-b4f2-71973df0f45c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3699), null, null, new Guid("b288d337-e8cf-4482-b3fb-a1d9c9d28163"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3699) },
                    { new Guid("91432621-a983-4b7f-9058-b5e80be1a5a0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484), null, null, new Guid("d8885516-6676-4105-898e-582b710318c8"), false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484) },
                    { new Guid("917dd495-f93a-469b-9a2c-a1aca7c61609"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3413), null, null, new Guid("26b2997f-0e36-4edc-a678-e5207db96898"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3413) },
                    { new Guid("92d8b985-d188-4d4e-ab36-81fe8fd7907a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("92df0da0-1e92-43ae-9a4c-a8056ac9f97e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "45", "Other Presentation Matters", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("93710aba-cecf-4228-9e28-c9c2c263e2f6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("938fd4b6-60fb-42b3-9489-dbddd571f932"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638), null, null, new Guid("794eb9b2-0aab-4738-855f-4520ceb516e7"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638) },
                    { new Guid("9397c243-193d-44f6-bba8-252d6d2ba4e1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5422), null, null, new Guid("359b90ee-04d0-4184-85da-4548d812b140"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5422) },
                    { new Guid("961e9726-44bf-4a48-99db-90df63ec2282"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391), null, null, new Guid("dcc88983-49c0-4c0c-bbfe-a674e4426c22"), false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391) },
                    { new Guid("967a1fd6-f0cf-4e9b-9340-932700364020"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "815", "Derivatives and Hedging", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("9717e9b3-f6fd-4f48-a2fe-88cb95c7a9c5"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("979a10b6-871c-4a8d-b652-b8eb8efa8f5c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("981a324a-19a8-42f5-ae45-184f046a4cd1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3318), null, null, new Guid("d1b5ebf9-5f93-4700-9b7b-046ecdf096e9"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3318) },
                    { new Guid("9a9e622c-1336-43de-960b-3f9df9955caa"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823), null, null, new Guid("1d27437a-1744-4dd5-a2d6-380191de61dd"), false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823) },
                    { new Guid("9afc6031-c76b-479c-8c2d-33d888cb0437"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "825", "Financial Instruments", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("9b82269c-9960-40a4-9dbc-da7eca3b8385"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782), null, null, new Guid("497a60c3-eb5a-4ebf-b1d9-451a2af4f629"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782) },
                    { new Guid("9bead029-1c06-4afe-833a-5edaa627241d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("9c4b0926-4a02-4d7a-b717-99a04846354b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4514), null, null, new Guid("e2b5a99e-a8f4-4edc-af08-045267462356"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4514) },
                    { new Guid("9c5a8069-2927-43aa-914e-706696fcaff1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("9c716dcc-634e-4a68-b1bd-346999f77e14"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291), null, null, new Guid("3da4db82-0a62-4dd1-a74d-a6196d03fbc9"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291) },
                    { new Guid("9d6e0186-dc03-440d-9349-06aa62524392"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816), null, null, new Guid("0d81730a-3607-4fe6-9852-feb2ce7eea4c"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816) },
                    { new Guid("9ebe2e50-0d72-42e5-9650-3a5c06ff0331"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("9f4435f9-7fb9-43eb-8f78-d27a8e2fc0aa"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6315), null, null, new Guid("e38acad2-2f6a-42bc-9915-ed906faf8160"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6315) },
                    { new Guid("9fd49da3-307f-4b85-b524-33f4b6885cba"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3962), null, null, new Guid("1d756c4c-2680-44cb-9d17-79e37187c659"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3962) },
                    { new Guid("a01c2f0b-76b8-49c1-ba81-c790413cd444"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339), null, null, new Guid("af59becf-f214-4bda-8496-be00d5757472"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339) },
                    { new Guid("a03312c0-8467-4a41-801b-6daa4e8d224a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "440", "Commitments", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("a035bc11-774a-4f6a-8639-438441dcdd94"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("a056f601-635d-4b96-8c48-a4d3109e4cd1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("a0d25492-ebc5-4f00-9ed1-b45dbf2a289a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("a1013f87-5f3f-482a-b311-f50e435a81c7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5359), null, null, new Guid("0b3ee28f-55d0-4d80-a023-c32ea8920856"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5359) },
                    { new Guid("a1a9980e-6212-494d-944d-35202b910e4b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7182), null, null, new Guid("178e982d-72ba-4064-820d-11c88cea740b"), false, false, "330", "Inventory", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7182) },
                    { new Guid("a1f3d5e8-73a7-4404-a802-d11b20a09dbe"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339), null, null, new Guid("af59becf-f214-4bda-8496-be00d5757472"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339) },
                    { new Guid("a2401c06-b400-4617-a078-46881ac1e39e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3119), null, null, new Guid("61e71516-c11e-4349-97b8-d32bb1481c48"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3119) },
                    { new Guid("a2701ff9-0596-49c4-be48-7afd709ee27c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("a2a7bcdc-ff64-47b6-a3a1-8af091540a9b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5359), null, null, new Guid("0b3ee28f-55d0-4d80-a023-c32ea8920856"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5359) },
                    { new Guid("a2cbd04f-3f70-4eb2-99b3-49a72ac3861a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("a3bb1346-2a41-419e-972e-4b54baad58fe"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4389), null, null, new Guid("0ca5797d-c9c4-46c7-9d2e-b29d1aea45db"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4389) },
                    { new Guid("a4c19edc-9482-4254-96b1-48ec833d4ace"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391), null, null, new Guid("dcc88983-49c0-4c0c-bbfe-a674e4426c22"), false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9391) },
                    { new Guid("a4fc9061-ebd3-48b5-96d4-fe0b09d638c5"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5992), null, null, new Guid("ded54546-a8fa-4cc4-b430-bef74b089002"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5992) },
                    { new Guid("a5a02d4a-1f19-4ff7-a457-d22d2a824556"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040), null, null, new Guid("b169b287-7126-4a74-84a9-cc7caa5b57c9"), false, false, "323", "Investments—Equity Method and Joint Ventures", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040) },
                    { new Guid("a5afc66e-3c74-40ef-9db0-3a2e0cd33ecd"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4606), null, null, new Guid("ca533595-5526-4d8e-944a-f7c16f75a006"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4606) },
                    { new Guid("a6afb832-1f1d-48f0-950b-8e7f5166f977"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7577), null, null, new Guid("4c51ee1e-9c7a-49eb-b973-70e9e7632cdb"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7577) },
                    { new Guid("a6c62dd4-560a-451e-80fe-55c01d2745b2"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "505", "Equity", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("a86b091e-cb0f-4613-94a7-777caba3b2bf"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737), null, null, new Guid("d6e3f0e7-54a7-439f-9f23-1d2ca2a595b9"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737) },
                    { new Guid("a8be3807-88d4-4508-873e-2bc195687366"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3803), null, null, new Guid("5560bf9e-a614-4ab8-a3f9-fbb7c6359322"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3803) },
                    { new Guid("a9037a3f-23e1-46ed-bd5b-bb5ac3c2c3ce"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3571), null, null, new Guid("f333ffb2-6485-4e5e-b855-a5d7fc4d89df"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3571) },
                    { new Guid("a97b4731-3410-4bc5-a991-75b51af6ea02"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183), null, null, new Guid("0be9134f-56d9-44f9-97f2-5f904f4cce27"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183) },
                    { new Guid("aa32d18b-d493-48f2-a52e-b7f656477fa4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("aaa1b612-93a8-4f77-949a-d9d3be916e6f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6971), null, null, new Guid("18007ecc-eb81-4e56-a6b7-a396d0e230c3"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6971) },
                    { new Guid("ab9e7504-f4ed-4b47-88fe-033b534bfdb1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("ac251d36-dc16-4829-bb3b-ff67458484a8"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("ac2bde9c-10b4-4802-b58b-cb3d243ced82"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("28f359f9-ab5e-47c0-9e1d-071ac9d455ea"), false, false, "325", "Investments—Other", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("ace2193d-4ffe-4bad-9209-817eb1bdd902"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057), null, null, new Guid("429c43c7-fa96-4096-8f33-7e2b8900a585"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057) },
                    { new Guid("ad9eb12e-92f3-4753-b245-ee5b12a566ec"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339), null, null, new Guid("af59becf-f214-4bda-8496-be00d5757472"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339) },
                    { new Guid("af23ed82-ef48-4d30-b9d6-292f0c9bbb7e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("af80cd05-b588-4fd5-9dcf-2d9ec566c7b9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3270), null, null, new Guid("a68624a1-8e5a-4313-b286-97f24a63b59e"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3270) },
                    { new Guid("b04e29a1-c94a-4f99-aba8-e771cac99e77"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "450", "Contingencies", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("b1286510-e69f-41c2-a72d-4c8f037bba82"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183), null, null, new Guid("0be9134f-56d9-44f9-97f2-5f904f4cce27"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183) },
                    { new Guid("b1b12337-facc-458a-88d8-1aaccd456f0b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("b36ef923-7b43-4e13-b1ba-51292e627107"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "450", "Contingencies", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("b4ff2bf1-be69-4f0a-9b43-c382e5b8f3c6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7751), null, null, new Guid("5e4dbabc-3416-493c-b465-3458f7a9bbee"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7751) },
                    { new Guid("b589b813-ad20-4679-8e8d-25b1b0a18ba2"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "220", "Income Statement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("b636b4bc-aeb6-4786-9298-9b0987c1c3f1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823), null, null, new Guid("1d27437a-1744-4dd5-a2d6-380191de61dd"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7823) },
                    { new Guid("b6b4f63e-4422-48cf-8bdc-2a5f96cac1d7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("b770e52a-a016-4988-ad2f-fb433b54f5b3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, new Guid("214c676c-6349-4940-848d-cff8c3141a09"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("b8809b6f-b8d3-42ae-a0a0-16d015013c89"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("b905ed4b-3ff8-4a2c-8f35-574561139704"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6939), null, null, new Guid("2ed90a88-3116-4ecc-9ad3-09ac74ac1915"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6939) },
                    { new Guid("ba020035-3ac7-4c89-95f0-e604c8653ae1"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484), null, null, new Guid("d8885516-6676-4105-898e-582b710318c8"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484) },
                    { new Guid("bafdd369-0175-4533-851b-c1dc14ecf28f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6348), null, null, new Guid("1f11b050-0bac-4a96-a34e-b2991e9281b5"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6348) },
                    { new Guid("bb04a44e-4378-4cb8-a245-7c8d3e7a3070"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4244), null, null, new Guid("daba6f6b-f5fc-42e4-8648-c903539ac53d"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4244) },
                    { new Guid("bb2a5866-73bb-403d-92f3-6e8b5c5c3753"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6674), null, null, new Guid("0ec218ce-6071-4ac9-9808-2bb824dea6cc"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6674) },
                    { new Guid("bb8e3616-73ae-46b3-af35-0b53433975e6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("bdfc9fc7-9759-4902-a90a-f544cc7701c4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("be93fce6-b972-40c7-9ef0-244bd1575b3d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5312), null, null, new Guid("cb2457c1-8102-4cb8-b0cc-8e2169403a8b"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5312) },
                    { new Guid("beb5598c-d5c5-41c3-88a6-ca367c83eaa4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484), null, null, new Guid("d8885516-6676-4105-898e-582b710318c8"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484) },
                    { new Guid("bfc0db20-72c3-49a6-acc7-9fd2ce593a51"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("c02d64ba-3e3c-4ec7-93b3-bbbf822a1486"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "810", "Consolidation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("c0a658de-11c3-4bf9-8618-2fc782589f06"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "470", "Debt", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("c231d65d-4173-4038-b70c-841ec05df8a5"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040), null, null, new Guid("b169b287-7126-4a74-84a9-cc7caa5b57c9"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040) },
                    { new Guid("c27f5458-693b-44d1-915c-c54495a93bf9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("28f359f9-ab5e-47c0-9e1d-071ac9d455ea"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("c2ecd065-cc8d-43ad-929d-84ec2ced4f3b"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638), null, null, new Guid("794eb9b2-0aab-4738-855f-4520ceb516e7"), false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638) },
                    { new Guid("c4086211-3556-4f5d-bef2-6c028e86330f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "210", "Balance Sheet", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("c48933ae-2627-4cac-aea4-c2831b0aa4c3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705), null, null, new Guid("76d70c4e-ef63-41f3-a4e8-ff56eda8a7c4"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5705) },
                    { new Guid("c4a4f660-95bf-4b40-bba6-7b6d8193d20e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("c50da3b5-f6f3-4166-8829-114fdf342bf4"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339), null, null, new Guid("af59becf-f214-4bda-8496-be00d5757472"), false, false, "330", "Inventory", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7339) },
                    { new Guid("c57840ed-5d5b-42c9-8ce4-e04f508005fe"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3475), null, null, new Guid("6f1e5da9-fad7-4417-a109-ad047796f945"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3475) },
                    { new Guid("c74faab1-8399-49b7-ad5c-57658b106e8a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4483), null, null, new Guid("098c58a5-9441-4dfb-b0a0-592d412f3154"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4483) },
                    { new Guid("c82b2106-9ffe-4ee6-b45e-f73e4d52399a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "720", "Other Expenses", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("c8a810e7-71b8-48d6-8d29-49d2c1d921fb"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816), null, null, new Guid("0d81730a-3607-4fe6-9852-feb2ce7eea4c"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816) },
                    { new Guid("c8d561bd-87bb-4b6f-b849-098ab30cf3c4"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("c8ec5211-9454-4cc2-a142-48701c16c2f0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638), null, null, new Guid("794eb9b2-0aab-4738-855f-4520ceb516e7"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4638) },
                    { new Guid("ca703255-5f74-4795-8f19-2ea97cb3a61c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("cacb162a-22a8-4fec-b062-fe827ce0791a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057), null, null, new Guid("429c43c7-fa96-4096-8f33-7e2b8900a585"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4057) },
                    { new Guid("cc527773-e038-42e8-98cb-4afa77bf1fe7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("cce1e6ba-e336-43cd-97c6-ebcb432ea2bb"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("cf05daee-9888-4a34-9a48-309bd2935c4e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816), null, null, new Guid("0d81730a-3607-4fe6-9852-feb2ce7eea4c"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6816) },
                    { new Guid("cf529e67-49d0-4b47-8f97-76e66dc74075"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291), null, null, new Guid("3da4db82-0a62-4dd1-a74d-a6196d03fbc9"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4291) },
                    { new Guid("cfdee926-70ba-4f5b-aa7d-56ff78e3c7ce"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5992), null, null, new Guid("ded54546-a8fa-4cc4-b430-bef74b089002"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5992) },
                    { new Guid("d06fd3b7-d652-4b18-9a50-085c2b398981"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("d166a035-116c-4223-8bed-725806fb364d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484), null, null, new Guid("d8885516-6676-4105-898e-582b710318c8"), false, false, "205", "Presentation", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9484) },
                    { new Guid("d1a2c307-c2b5-4c18-b558-4900bfba7277"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595), null, null, new Guid("2afa13cf-1984-4d86-aedd-0e97fc734cfc"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6595) },
                    { new Guid("d1e32d6f-9e5a-45e0-bcc4-ab6634813fa5"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("d2a55e8c-4998-405f-9b13-c1364a34b082"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("d2bad42f-952c-4f37-8767-431999fef28c"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261), null, null, new Guid("0a1e97e8-0f65-4ec9-991b-3dc3cb8e2a5d"), false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(261) },
                    { new Guid("d5646c9b-cba0-4c3a-8367-dee2e17cd711"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3119), null, null, new Guid("61e71516-c11e-4349-97b8-d32bb1481c48"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3119) },
                    { new Guid("d5c3fb69-45d2-434a-98f4-f1d3512c9e62"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123), null, null, new Guid("91efc065-19a5-4a57-b45e-50676d81af48"), false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("d6290e5e-82c7-4ec8-a9f2-f46165fa4003"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("d637726f-95ee-4ea1-a5fa-fac7bbbb4774"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("d71e54e1-5dcd-4cd2-86c4-6a10aa082d80"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040), null, null, new Guid("b169b287-7126-4a74-84a9-cc7caa5b57c9"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6040) },
                    { new Guid("d731ea43-3b4e-459b-8af6-f8d8f5445379"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7245), null, null, new Guid("a585a905-db77-4ff8-b7b3-371bce1bc127"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7245) },
                    { new Guid("d73bcf63-22a7-47d1-92a5-0dc86578aa07"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561), null, null, new Guid("214c676c-6349-4940-848d-cff8c3141a09"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5561) },
                    { new Guid("d8e61ba6-2c60-4cff-91f0-abc4649bcca2"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136), null, null, new Guid("c6478d8d-c7f1-40be-b437-69ba1b87d064"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("d9692bc4-e0c2-402f-8da6-58cca2be09c0"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5359), null, null, new Guid("0b3ee28f-55d0-4d80-a023-c32ea8920856"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5359) },
                    { new Guid("da1109d9-0f22-4e04-a5ed-8b4f815640af"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("da8d179a-c81a-40e4-bec0-79674d7b40d6"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("dcfbe04e-9eb0-43c0-9f05-de90812b16b7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7419), null, null, new Guid("b62761c3-79cf-499c-8208-49ed50c86293"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7419) },
                    { new Guid("ddd852f4-e91f-4634-bb9f-b91783539263"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("de83ef20-d8d8-4ef2-9d74-4fa1f4c1ab7d"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("de880108-3ab9-41a2-b96b-b9764ea0a0a5"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4749), null, null, new Guid("16284996-2f43-47d6-af60-ff8272c4f0aa"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4749) },
                    { new Guid("dfb0cad6-2372-4194-b0a9-03cc5e1871e3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6529), null, null, new Guid("efc0ac27-b630-41ea-a340-2b30a6b9f159"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6529) },
                    { new Guid("e1176984-8d51-4d49-adfc-ef26ced18454"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136), null, null, new Guid("c6478d8d-c7f1-40be-b437-69ba1b87d064"), false, false, "60", "Relationships", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("e2df33e0-fdcc-4264-849d-1d78f04d0750"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "835", "Interest", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("e3b7dda9-0d12-40ae-960a-9e45930d803e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831), null, null, new Guid("9b9a33b8-a990-4696-8b0a-80c03f50a89b"), false, false, "35", "Subsequent Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5831) },
                    { new Guid("e41c4eb8-bc8e-4dc7-8c13-cbc4ad61d430"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("e442a6f1-8daf-4c46-9a60-310e11c411e3"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3318), null, null, new Guid("d1b5ebf9-5f93-4700-9b7b-046ecdf096e9"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3318) },
                    { new Guid("e65d3616-850b-4f6a-b349-3090b06ad50e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8642), null, null, new Guid("31302466-738d-4316-95ec-ce6b1bc0679d"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8642) },
                    { new Guid("e6ac2a4a-ed0d-47d2-88b7-89e3ae72a5b2"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("e6c87466-957d-4160-b493-1d572701e27f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951), null, null, new Guid("55f68858-27db-48b4-8866-8da7f95cfb91"), false, false, "825", "Financial Instruments", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8951) },
                    { new Guid("e7422167-599e-4bef-9431-0e4c6e534379"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4026), null, null, new Guid("810fa345-d498-4029-a26d-720408a1cda4"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4026) },
                    { new Guid("e7c44c14-1292-451d-a4a8-b3af33e5e50c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3699), null, null, new Guid("b288d337-e8cf-4482-b3fb-a1d9c9d28163"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3699) },
                    { new Guid("e95e8edd-745f-40ad-833f-8bbe3efb2b11"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("e9e0a24e-971f-4092-9132-1c5ba3252ebf"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("ebb48d6a-385e-415f-9694-acdc15e23692"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("ec1c4ba8-97bf-495d-909b-2efa5660f734"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136), null, null, new Guid("c6478d8d-c7f1-40be-b437-69ba1b87d064"), false, false, "50", "Disclosure", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4136) },
                    { new Guid("edc98ab7-501b-4c6f-abc2-184c3370441a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "958", "Not-for-Profit Entities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("edd08602-df09-4b46-8259-5e5de5168131"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885), null, null, new Guid("73daa868-68a8-45d8-8944-3e0511d331f1"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("ee445a03-678f-4f38-b8f4-d7ce1600f896"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883), null, null, new Guid("4978ebe5-166d-4dab-828f-224cffac82d7"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3883) },
                    { new Guid("eef5d9c5-995f-484f-84f8-ce32c10f2c83"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("ef3a0d35-d347-4cd9-b0bf-af879a704de7"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), false, false, "15", "Scope and Scope Exceptions", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("f101d41e-967f-4fd6-a520-f33c701f881f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145), null, null, new Guid("ffd3aa96-b5f4-4ee8-af6b-9481bbe914fe"), false, false, "920", "Entertainment—Broadcasters", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6145) },
                    { new Guid("f1ed6111-eee4-4508-9b02-578e43043eec"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3635), null, null, new Guid("081a1622-7203-4c98-87f2-9bf861a83e80"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(3635) },
                    { new Guid("f20d03a8-1f90-4382-aaac-050dce4b8f0a"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("28f359f9-ab5e-47c0-9e1d-071ac9d455ea"), false, false, "320", "Investments—Debt and Equity Securities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("f23053a7-9659-4444-af6f-d6a0ca9bbc13"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "830", "Foreign Currency Matters", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("f2853007-6822-44ab-9850-f76760b72374"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382), null, null, new Guid("f1580240-4175-4cd6-a380-df1f2ea3aa5d"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6382) },
                    { new Guid("f29ac324-c080-4f1f-ad62-48a30e9170e9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("f2eff332-fd4b-4b23-8082-4453ab5c2f37"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("f39c82fb-f1c7-47d9-8aa7-05e5cd59fcbf"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9822), null, null, new Guid("a66d675e-d5e3-4ea2-9b65-f0fde65c7bf8"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9822) },
                    { new Guid("f48473d9-c0ec-424e-a6a3-9cd7382c66cb"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282), null, null, new Guid("28f359f9-ab5e-47c0-9e1d-071ac9d455ea"), false, false, "310", "Receivables", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("f4b59e60-a1d0-4156-8fe7-48d7b04cc075"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356), null, null, new Guid("f8faf44e-d2cd-4091-bb26-ed7d4272d0d1"), false, false, "405", "Liabilities", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8356) },
                    { new Guid("f5702034-535c-4239-95f4-604457ecd65f"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082), null, null, new Guid("90d2d541-0140-4e60-b88a-981edd77223a"), false, false, "40", "Derecognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7082) },
                    { new Guid("f737233f-ba91-4617-8159-4f87f24f01c9"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130), null, null, new Guid("2b325406-a330-41d4-8e49-d388ef18a37c"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(5130) },
                    { new Guid("f82a9221-0160-4407-bd98-6de8f5b1061e"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700), null, null, new Guid("61ab2e50-1cd7-432f-894c-aef78f2bfa36"), false, false, "235", "Notes to Financial Statements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("f8b50246-7eea-4e49-978c-5e178fa56c88"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9822), null, null, new Guid("a66d675e-d5e3-4ea2-9b65-f0fde65c7bf8"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9822) },
                    { new Guid("f949c56e-728d-46e6-94c7-7483e23d8920"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4544), null, null, new Guid("1807c66b-86ef-4439-b96b-9f2204d0c257"), false, false, "20", "Specialized Industry Requirements", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4544) },
                    { new Guid("fa646c01-191c-4b51-9ad1-bac032829664"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183), null, null, new Guid("0be9134f-56d9-44f9-97f2-5f904f4cce27"), false, false, "605", "Revenue Recognition", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183) },
                    { new Guid("fcb730a5-b62d-4c2b-b849-8cba04a6abcf"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7639), null, null, new Guid("ac798a0b-b401-465a-9f11-4d6ac4656ca2"), false, false, "340", "Other Assets and Deferred Costs", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7639) },
                    { new Guid("fcdc31aa-01b7-4b1a-834d-6ca39f976657"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782), null, null, new Guid("497a60c3-eb5a-4ebf-b1d9-451a2af4f629"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(4782) },
                    { new Guid("fd8a2774-c2f4-43bd-8901-d8a6beb6bf02"), new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183), null, null, new Guid("0be9134f-56d9-44f9-97f2-5f904f4cce27"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 425, DateTimeKind.Utc).AddTicks(183) },
                    { new Guid("fd936a00-3b1f-4a10-a048-9c96b523f627"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("fe469019-59ae-475e-b48a-e4d34db78c0c"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919), null, null, new Guid("366d8d5b-9967-4463-bfee-55f16728ebbd"), false, false, "230", "Statement of Cash Flows", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7919) },
                    { new Guid("fe680f7a-db5e-4bf5-b7f6-3035c5ef8562"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7002), null, null, new Guid("8ba16523-0b7d-46fb-9d2d-8d555a214652"), false, false, "10", "Overall", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(7002) },
                    { new Guid("fe861194-b686-4731-96fb-8af7310d0586"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601), null, null, new Guid("acaed866-2971-43d0-85ff-f991c1c7b756"), false, false, "360", "Property, Plant, and Equipment", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(9601) },
                    { new Guid("febb448f-b4f9-4a3f-a743-0b3c5b9e7bdf"), new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737), null, null, new Guid("d6e3f0e7-54a7-439f-9f23-1d2ca2a595b9"), false, false, "30", "Initial Measurement", new DateTime(2026, 2, 5, 1, 34, 36, 424, DateTimeKind.Utc).AddTicks(6737) }
                });
        }
    }
}
