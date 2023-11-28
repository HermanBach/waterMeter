using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace waterMeter.Migrations
{
    /// <inheritdoc />
    public partial class editMeterReplacementHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Meter_MeterId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_MeterReplacementHistory_Meter_MeterId",
                table: "MeterReplacementHistory");

            migrationBuilder.RenameColumn(
                name: "MeterId",
                table: "MeterReplacementHistory",
                newName: "OldMeterId");

            migrationBuilder.RenameIndex(
                name: "IX_MeterReplacementHistory_MeterId",
                table: "MeterReplacementHistory",
                newName: "IX_MeterReplacementHistory_OldMeterId");

            migrationBuilder.AddColumn<int>(
                name: "NewMeterId",
                table: "MeterReplacementHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeterId",
                table: "Apartment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_MeterReplacementHistory_NewMeterId",
                table: "MeterReplacementHistory",
                column: "NewMeterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Meter_MeterId",
                table: "Apartment",
                column: "MeterId",
                principalTable: "Meter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MeterReplacementHistory_Meter_NewMeterId",
                table: "MeterReplacementHistory",
                column: "NewMeterId",
                principalTable: "Meter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MeterReplacementHistory_Meter_OldMeterId",
                table: "MeterReplacementHistory",
                column: "OldMeterId",
                principalTable: "Meter",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Meter_MeterId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_MeterReplacementHistory_Meter_NewMeterId",
                table: "MeterReplacementHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_MeterReplacementHistory_Meter_OldMeterId",
                table: "MeterReplacementHistory");

            migrationBuilder.DropIndex(
                name: "IX_MeterReplacementHistory_NewMeterId",
                table: "MeterReplacementHistory");

            migrationBuilder.DropColumn(
                name: "NewMeterId",
                table: "MeterReplacementHistory");

            migrationBuilder.RenameColumn(
                name: "OldMeterId",
                table: "MeterReplacementHistory",
                newName: "MeterId");

            migrationBuilder.RenameIndex(
                name: "IX_MeterReplacementHistory_OldMeterId",
                table: "MeterReplacementHistory",
                newName: "IX_MeterReplacementHistory_MeterId");

            migrationBuilder.AlterColumn<int>(
                name: "MeterId",
                table: "Apartment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Meter_MeterId",
                table: "Apartment",
                column: "MeterId",
                principalTable: "Meter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeterReplacementHistory_Meter_MeterId",
                table: "MeterReplacementHistory",
                column: "MeterId",
                principalTable: "Meter",
                principalColumn: "Id");
        }
    }
}
