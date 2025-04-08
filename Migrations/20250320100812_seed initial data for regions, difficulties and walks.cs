using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZwalks.Migrations
{
    /// <inheritdoc />
    public partial class seedinitialdataforregionsdifficultiesandwalks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c306fab-d484-41fe-9a44-d6088bb75daf"), "Medium" },
                    { new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), "Easy" },
                    { new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"), "Difficult" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("176e331a-4eff-ee98-ea56-dc4a0e84757d"), "Lake", "East Madiebury", "https://loremflickr.com/320/240?lock=1020670308" },
                    { new Guid("29500c13-ffb9-6194-63d6-52daf930f59f"), "West", "Gorczanystad", "https://loremflickr.com/320/240?lock=726986386" },
                    { new Guid("4d05aca1-c10a-5317-bfe4-8c17096cb62a"), "New", "New Darwin", "https://loremflickr.com/320/240?lock=1159165972" },
                    { new Guid("6a58d5b2-92db-4890-094e-bc91f1ea68a4"), "West", "Veumside", "https://loremflickr.com/320/240?lock=1639072835" },
                    { new Guid("97930e56-f26e-611e-1820-46d1a0245995"), "Port", "West Maurineshire", "https://loremflickr.com/320/240?lock=842203058" }
                });

            migrationBuilder.InsertData(
                table: "Walks",
                columns: new[] { "Id", "Description", "DifficultyId", "LengthInKm", "Name", "RegionId", "WalkImageUrl" },
                values: new object[,]
                {
                    { new Guid("04c105c9-31a1-30ec-f890-20c60e21e9bb"), "Harum error magnam cupiditate in enim ut qui facere perspiciatis.", new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"), 17.0, "Mertz Plain", new Guid("29500c13-ffb9-6194-63d6-52daf930f59f"), null },
                    { new Guid("056994e3-11a9-493b-f6ae-550ff700a807"), "Aut ut eos cum voluptatem deleniti rem qui velit sit.", new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), 2.0, "Tyson Motorway", new Guid("97930e56-f26e-611e-1820-46d1a0245995"), null },
                    { new Guid("1b88ddc1-cef5-ae22-1522-8ab44d403b6b"), "Itaque quaerat suscipit sed veniam reiciendis et odit facilis qui.", new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), 2.0, "Little Curve", new Guid("4d05aca1-c10a-5317-bfe4-8c17096cb62a"), null },
                    { new Guid("2163e51e-aff2-43e6-a3af-18daacd38549"), "Voluptatem eveniet omnis soluta sed natus et minima id est.", new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), 35.0, "Lonnie Curve", new Guid("97930e56-f26e-611e-1820-46d1a0245995"), null },
                    { new Guid("2f993461-7b7d-40f4-2cad-d86dcc02befd"), "Accusantium fuga explicabo hic recusandae sint incidunt aliquid dolores et.", new Guid("0c306fab-d484-41fe-9a44-d6088bb75daf"), 28.0, "Schuster Glen", new Guid("29500c13-ffb9-6194-63d6-52daf930f59f"), null },
                    { new Guid("475ac313-0ccc-f968-ffe8-16addb9167c8"), "Ex occaecati ad occaecati est praesentium ullam tenetur dolorem quo.", new Guid("0c306fab-d484-41fe-9a44-d6088bb75daf"), 31.0, "Gulgowski Lake", new Guid("97930e56-f26e-611e-1820-46d1a0245995"), null },
                    { new Guid("58d12af7-69ef-e181-c452-1cdafdc19336"), "Qui blanditiis ut est doloremque eius et consequatur iusto quod.", new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"), 28.0, "Spinka Road", new Guid("4d05aca1-c10a-5317-bfe4-8c17096cb62a"), null },
                    { new Guid("6aa0cc72-8081-420f-30c0-de4b3678a3ef"), "In enim officia nihil dolorem mollitia officiis id occaecati id.", new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), 29.0, "Rosenbaum Island", new Guid("4d05aca1-c10a-5317-bfe4-8c17096cb62a"), null },
                    { new Guid("85b09ada-def0-06e2-131a-7c67cba917d4"), "Autem ut quo aut accusamus dolor consectetur provident sunt fugiat.", new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), 10.0, "Amir Stravenue", new Guid("29500c13-ffb9-6194-63d6-52daf930f59f"), null },
                    { new Guid("89a056fd-f3e5-f69f-6063-bd74ca2d01e5"), "Velit commodi ratione voluptas sit quia dicta maxime placeat pariatur.", new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"), 14.0, "Susie Lodge", new Guid("4d05aca1-c10a-5317-bfe4-8c17096cb62a"), null },
                    { new Guid("9706158a-e70f-2f57-cb0f-bb154984e8e8"), "Unde reprehenderit accusamus deserunt amet itaque provident dolores tempore ea.", new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"), 10.0, "Balistreri Port", new Guid("4d05aca1-c10a-5317-bfe4-8c17096cb62a"), null },
                    { new Guid("a2683ee5-9e0f-d546-e376-aba2bf6887e2"), "Eius sunt facere et consectetur ut sed sint voluptatum quasi.", new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), 23.0, "Fatima Rue", new Guid("4d05aca1-c10a-5317-bfe4-8c17096cb62a"), null },
                    { new Guid("b7e34453-27fc-7aed-1a44-db9b5db16e22"), "Minima odit nisi sunt aliquam qui nemo laboriosam veniam facere.", new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"), 4.0, "Fritsch Route", new Guid("29500c13-ffb9-6194-63d6-52daf930f59f"), null },
                    { new Guid("b829df0d-0698-f9f8-698c-0f7b45769eec"), "Mollitia quo odit aut est qui aut architecto enim velit.", new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), 2.0, "Valerie Green", new Guid("176e331a-4eff-ee98-ea56-dc4a0e84757d"), null },
                    { new Guid("cc7b775b-57c1-55b6-c25d-3fc5c24b1ab2"), "Vel voluptas dolorum maiores accusamus quo ut deserunt hic quidem.", new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"), 32.0, "Violet Summit", new Guid("176e331a-4eff-ee98-ea56-dc4a0e84757d"), null },
                    { new Guid("d8b1d412-edae-3c3d-aa0e-13f59a346ea9"), "Sed provident laudantium nam dicta sequi voluptas quasi officia non.", new Guid("0c306fab-d484-41fe-9a44-d6088bb75daf"), 26.0, "Toy Creek", new Guid("176e331a-4eff-ee98-ea56-dc4a0e84757d"), null },
                    { new Guid("df3bbb41-bee1-cbae-5b5a-3d1c2454275e"), "Exercitationem et reprehenderit aut natus cum beatae ullam nemo molestias.", new Guid("0c306fab-d484-41fe-9a44-d6088bb75daf"), 3.0, "Delphia Common", new Guid("97930e56-f26e-611e-1820-46d1a0245995"), null },
                    { new Guid("df94653f-ce3e-2549-6ecd-88cad731ad04"), "Est hic debitis consequatur error sint ad iusto corporis doloremque.", new Guid("0c306fab-d484-41fe-9a44-d6088bb75daf"), 21.0, "Denesik Turnpike", new Guid("6a58d5b2-92db-4890-094e-bc91f1ea68a4"), null },
                    { new Guid("e3cedb76-9150-0acb-e38d-6e45137038fa"), "Fugiat aspernatur tempore in doloremque eveniet molestias omnis voluptates recusandae.", new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"), 37.0, "Kenya Roads", new Guid("97930e56-f26e-611e-1820-46d1a0245995"), null },
                    { new Guid("edb32f54-419a-eb03-5377-fddcd2497cbc"), "Molestias nesciunt animi expedita ut distinctio blanditiis sunt eum dolorem.", new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"), 2.0, "Terry Station", new Guid("97930e56-f26e-611e-1820-46d1a0245995"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("04c105c9-31a1-30ec-f890-20c60e21e9bb"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("056994e3-11a9-493b-f6ae-550ff700a807"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("1b88ddc1-cef5-ae22-1522-8ab44d403b6b"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("2163e51e-aff2-43e6-a3af-18daacd38549"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("2f993461-7b7d-40f4-2cad-d86dcc02befd"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("475ac313-0ccc-f968-ffe8-16addb9167c8"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("58d12af7-69ef-e181-c452-1cdafdc19336"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("6aa0cc72-8081-420f-30c0-de4b3678a3ef"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("85b09ada-def0-06e2-131a-7c67cba917d4"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("89a056fd-f3e5-f69f-6063-bd74ca2d01e5"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("9706158a-e70f-2f57-cb0f-bb154984e8e8"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("a2683ee5-9e0f-d546-e376-aba2bf6887e2"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("b7e34453-27fc-7aed-1a44-db9b5db16e22"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("b829df0d-0698-f9f8-698c-0f7b45769eec"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("cc7b775b-57c1-55b6-c25d-3fc5c24b1ab2"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("d8b1d412-edae-3c3d-aa0e-13f59a346ea9"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("df3bbb41-bee1-cbae-5b5a-3d1c2454275e"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("df94653f-ce3e-2549-6ecd-88cad731ad04"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("e3cedb76-9150-0acb-e38d-6e45137038fa"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("edb32f54-419a-eb03-5377-fddcd2497cbc"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("0c306fab-d484-41fe-9a44-d6088bb75daf"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("42d731f8-d04e-4633-9c4f-1a4a27500b55"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("5895a33b-fafc-4798-9688-2c609d097fe6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("176e331a-4eff-ee98-ea56-dc4a0e84757d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("29500c13-ffb9-6194-63d6-52daf930f59f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4d05aca1-c10a-5317-bfe4-8c17096cb62a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6a58d5b2-92db-4890-094e-bc91f1ea68a4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("97930e56-f26e-611e-1820-46d1a0245995"));
        }
    }
}
