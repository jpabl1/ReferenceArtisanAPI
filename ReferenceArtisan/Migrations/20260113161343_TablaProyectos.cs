using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReferenceArtisan.Migrations
{
    /// <inheritdoc />
    public partial class TablaProyectos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Projects",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyWords",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "KeyWords",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Projects",
                newName: "CreateDate");
        }
    }
}
