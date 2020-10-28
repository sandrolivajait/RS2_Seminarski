using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class kvarovi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZaposlenikId",
                table: "Narudzbe");

            migrationBuilder.CreateTable(
                name: "Kvarovi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumKvara = table.Column<DateTime>(nullable: false),
                    OpisKvara = table.Column<string>(nullable: true),
                    StanjeKvara = table.Column<int>(nullable: false),
                    BrojMobitela = table.Column<string>(nullable: true),
                    NazivMobitela = table.Column<string>(nullable: true),
                    KupacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kvarovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kvarovi_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Kvarovi_KupacId",
                table: "Kvarovi",
                column: "KupacId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kvarovi");

            migrationBuilder.AddColumn<int>(
                name: "ZaposlenikId",
                table: "Narudzbe",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 10, 8, 20, 30, 50, 569, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 10, 8, 20, 30, 50, 568, DateTimeKind.Local).AddTicks(3728), new DateTime(2020, 10, 8, 20, 30, 50, 565, DateTimeKind.Local).AddTicks(9129) });
        }
    }
}
