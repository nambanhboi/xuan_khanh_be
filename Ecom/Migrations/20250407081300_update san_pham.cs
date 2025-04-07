using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.Migrations
{
    /// <inheritdoc />
    public partial class updatesan_pham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "size",
                table: "san_pham",
                newName: "loai_nuoc_hoa");

            migrationBuilder.RenameColumn(
                name: "mau_sac",
                table: "san_pham",
                newName: "dung_tich");

            migrationBuilder.AlterColumn<string>(
                name: "ten_danh_muc",
                table: "danh_muc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ma_danh_muc",
                table: "danh_muc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "loai_nuoc_hoa",
                table: "san_pham",
                newName: "size");

            migrationBuilder.RenameColumn(
                name: "dung_tich",
                table: "san_pham",
                newName: "mau_sac");

            migrationBuilder.AlterColumn<string>(
                name: "ten_danh_muc",
                table: "danh_muc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ma_danh_muc",
                table: "danh_muc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
