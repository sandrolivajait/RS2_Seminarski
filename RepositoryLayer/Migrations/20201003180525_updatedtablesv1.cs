using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class updatedtablesv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slike");

            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaFull",
                table: "Mobiteli",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaThumb",
                table: "Mobiteli",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 10, 3, 20, 5, 24, 648, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 10, 3, 20, 5, 24, 648, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 10, 3, 20, 5, 24, 647, DateTimeKind.Local).AddTicks(1230), new DateTime(2020, 10, 3, 20, 5, 24, 644, DateTimeKind.Local).AddTicks(6283) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlikaFull",
                table: "Mobiteli");

            migrationBuilder.DropColumn(
                name: "SlikaThumb",
                table: "Mobiteli");

            migrationBuilder.CreateTable(
                name: "Slike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobitelId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SlikaFull = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slike_Mobiteli_MobitelId",
                        column: x => x.MobitelId,
                        principalTable: "Mobiteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 9, 23, 4, 19, 35, 117, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 9, 23, 4, 19, 35, 118, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 9, 23, 4, 19, 35, 116, DateTimeKind.Local).AddTicks(9684), new DateTime(2020, 9, 23, 4, 19, 35, 114, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.CreateIndex(
                name: "IX_Slike_MobitelId",
                table: "Slike",
                column: "MobitelId");
        }
    }
}
