using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedFASBData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
