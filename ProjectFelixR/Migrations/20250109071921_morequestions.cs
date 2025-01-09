using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFelixR.Migrations
{
    /// <inheritdoc />
    public partial class morequestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "custom_int1_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_int2_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_int3_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_int4_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_text1_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_text2_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_text3_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_text4_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "custom_int1_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int2_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int3_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int4_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_text1_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_text2_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_text3_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_text4_question",
                table: "Templates");
        }
    }
}
