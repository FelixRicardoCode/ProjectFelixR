using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFelixR.Migrations
{
    /// <inheritdoc />
    public partial class PendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    topic_id = table.Column<int>(type: "int", nullable: false),
                    custom_string1_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_string1_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_string2_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_string2_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_string3_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_string3_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_string4_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_string4_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_int1_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_int1_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_int2_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_int2_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_int3_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_int3_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_int4_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_int4_question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    custom_int1_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_int1_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_int2_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_int2_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_int3_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_int3_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_int4_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_int4_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_string1_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_string1_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_string2_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_string2_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_string3_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_string3_state = table.Column<bool>(type: "bit", nullable: false),
                    custom_string4_question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custom_string4_state = table.Column<bool>(type: "bit", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topic_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.id);
                });
        }
    }
}
