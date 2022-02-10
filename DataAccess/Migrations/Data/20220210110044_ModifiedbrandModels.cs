using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations.Data
{
    public partial class ModifiedbrandModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 10, 12, 0, 44, 834, DateTimeKind.Local).AddTicks(6172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 10, 11, 35, 57, 662, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.AddColumn<string>(
                name: "Models",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Models",
                table: "Brands");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 10, 11, 35, 57, 662, DateTimeKind.Local).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 10, 12, 0, 44, 834, DateTimeKind.Local).AddTicks(6172));
        }
    }
}
