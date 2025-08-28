using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson_4_EntityFrameworkCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class RemovePasswordConfirm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordConfirm",
                table: "AppUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordConfirm",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
