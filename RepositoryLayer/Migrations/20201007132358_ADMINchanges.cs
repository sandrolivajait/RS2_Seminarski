using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class ADMINchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSuperAdmin",
                table: "Administratori");

            migrationBuilder.UpdateData(
                table: "Administratori",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 10, 7, 15, 23, 57, 651, DateTimeKind.Local).AddTicks(1504));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSuperAdmin",
                table: "Administratori",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Administratori",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsSuperAdmin", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { true, null, null });

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
    }
}
