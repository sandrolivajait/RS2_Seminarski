using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class kvarovistanje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StanjeKvara",
                table: "Kvarovi");

            migrationBuilder.AddColumn<int>(
                name: "StanjeKvaraId",
                table: "Kvarovi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StanjeKvara",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanjeKvara", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 10, 29, 10, 42, 12, 307, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.InsertData(
                table: "Kvarovi",
                columns: new[] { "Id", "BrojMobitela", "DatumKvara", "KupacId", "NazivMobitela", "OpisKvara", "StanjeKvaraId" },
                values: new object[] { 1, "063513758", new DateTime(2020, 10, 29, 7, 42, 12, 308, DateTimeKind.Utc).AddTicks(1048), 1, "iPhone 10 XR", "otisao mu displej, ispao mi na beton.", 1 });

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 10, 29, 10, 42, 12, 306, DateTimeKind.Local).AddTicks(4268), new DateTime(2020, 10, 29, 10, 42, 12, 305, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.InsertData(
                table: "StanjeKvara",
                columns: new[] { "Id", "Opis" },
                values: new object[,]
                {
                    { 1, "zahtjev poslan" },
                    { 2, "mobitel zaprimljen" },
                    { 3, "mobitel popravljen" },
                    { 4, "mobitel vracen korisniku" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kvarovi_StanjeKvaraId",
                table: "Kvarovi",
                column: "StanjeKvaraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kvarovi_Kvarovi_StanjeKvaraId",
                table: "Kvarovi",
                column: "StanjeKvaraId",
                principalTable: "Kvarovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kvarovi_Kvarovi_StanjeKvaraId",
                table: "Kvarovi");

            migrationBuilder.DropTable(
                name: "StanjeKvara");

            migrationBuilder.DropIndex(
                name: "IX_Kvarovi_StanjeKvaraId",
                table: "Kvarovi");

            migrationBuilder.DeleteData(
                table: "Kvarovi",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "StanjeKvaraId",
                table: "Kvarovi");

            migrationBuilder.AddColumn<int>(
                name: "StanjeKvara",
                table: "Kvarovi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 10, 28, 15, 18, 46, 644, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 10, 28, 15, 18, 46, 642, DateTimeKind.Local).AddTicks(6846), new DateTime(2020, 10, 28, 15, 18, 46, 640, DateTimeKind.Local).AddTicks(725) });
        }
    }
}
