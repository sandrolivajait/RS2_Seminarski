using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class removedkomentari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.UpdateData(
                table: "Administratori",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "NImQS18rkBZDPyanRdPitQ4LRF4=", "OM4df9qc3pJdXZbuJMDxfQ==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Komentari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    KupacId = table.Column<int>(type: "int", nullable: false),
                    MobitelId = table.Column<int>(type: "int", nullable: false),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentari_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komentari_Mobiteli_MobitelId",
                        column: x => x.MobitelId,
                        principalTable: "Mobiteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Administratori",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "", "" });

            migrationBuilder.InsertData(
                table: "Komentari",
                columns: new[] { "Id", "Datum", "IsDeleted", "KupacId", "MobitelId", "Sadrzaj" },
                values: new object[] { 1, new DateTime(2020, 10, 7, 15, 23, 57, 651, DateTimeKind.Local).AddTicks(1504), false, 1, 1, null });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 10, 7, 15, 23, 57, 651, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 10, 7, 15, 23, 57, 650, DateTimeKind.Local).AddTicks(857), new DateTime(2020, 10, 7, 15, 23, 57, 647, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_KupacId",
                table: "Komentari",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_MobitelId",
                table: "Komentari",
                column: "MobitelId");
        }
    }
}
