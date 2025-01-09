using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFelixR.Migrations
{
    /// <inheritdoc />
    public partial class AddedQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "custom_string1_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_string2_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_string3_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_string4_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "custom_string1_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string2_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string3_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string4_question",
                table: "Templates");
        }
    }
}
