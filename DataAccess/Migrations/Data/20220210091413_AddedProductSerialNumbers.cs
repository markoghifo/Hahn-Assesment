using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations.Data
{
    public partial class AddedProductSerialNumbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandModels_ModelId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Products",
                newName: "BrandModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ModelId",
                table: "Products",
                newName: "IX_Products_BrandModelId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 10, 10, 14, 13, 493, DateTimeKind.Local).AddTicks(5956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 10, 9, 52, 35, 918, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.AddColumn<string>(
                name: "SerialNumbers",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandModels_BrandModelId",
                table: "Products",
                column: "BrandModelId",
                principalTable: "BrandModels",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandModels_BrandModelId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SerialNumbers",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "BrandModelId",
                table: "Products",
                newName: "ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BrandModelId",
                table: "Products",
                newName: "IX_Products_ModelId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 10, 9, 52, 35, 918, DateTimeKind.Local).AddTicks(4181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 10, 10, 14, 13, 493, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandModels_ModelId",
                table: "Products",
                column: "ModelId",
                principalTable: "BrandModels",
                principalColumn: "Id");
        }
    }
}
