using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFelixR.Migrations
{
    /// <inheritdoc />
    public partial class RemoveFieldsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "custom_int1_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int1_state",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int2_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int2_state",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int3_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int3_state",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int4_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_int4_state",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string1_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string1_state",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string2_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string2_state",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string3_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string3_state",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string4_question",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "custom_string4_state",
                table: "Templates");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Templates",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "Templates",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Templates",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Templates",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Templates",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "topic_id",
                table: "Templates",
                newName: "TopicId");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Templates",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Templates",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Templates",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Templates",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Templates",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Templates",
                newName: "topic_id");

            migrationBuilder.AlterColumn<string>(
                name: "imageUrl",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "custom_int1_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "custom_int1_state",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "custom_int2_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "custom_int2_state",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "custom_int3_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "custom_int3_state",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "custom_int4_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "custom_int4_state",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "custom_string1_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "custom_string1_state",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "custom_string2_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "custom_string2_state",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "custom_string3_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "custom_string3_state",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "custom_string4_question",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "custom_string4_state",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
