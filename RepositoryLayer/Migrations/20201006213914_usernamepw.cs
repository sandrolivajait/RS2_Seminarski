using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class usernamepw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Kupci",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaSalt",
                table: "Kupci",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Administratori",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaSalt",
                table: "Administratori",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 10, 6, 23, 39, 13, 828, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 10, 6, 23, 39, 13, 829, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 10, 6, 23, 39, 13, 827, DateTimeKind.Local).AddTicks(9007), new DateTime(2020, 10, 6, 23, 39, 13, 823, DateTimeKind.Local).AddTicks(2691) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Kupci");

            migrationBuilder.DropColumn(
                name: "LozinkaSalt",
                table: "Kupci");

            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Administratori");

            migrationBuilder.DropColumn(
                name: "LozinkaSalt",
                table: "Administratori");

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
    }
}
