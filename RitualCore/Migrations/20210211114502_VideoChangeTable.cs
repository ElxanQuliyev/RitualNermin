using Microsoft.EntityFrameworkCore.Migrations;

namespace RitualCore.Migrations
{
    public partial class VideoChangeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoPictures");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Viseoapics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PictureID",
                table: "Viseoapics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink",
                table: "Viseoapics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Viseoapics_PictureID",
                table: "Viseoapics",
                column: "PictureID");

            migrationBuilder.AddForeignKey(
                name: "FK_Viseoapics_Pictures_PictureID",
                table: "Viseoapics",
                column: "PictureID",
                principalTable: "Pictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viseoapics_Pictures_PictureID",
                table: "Viseoapics");

            migrationBuilder.DropIndex(
                name: "IX_Viseoapics_PictureID",
                table: "Viseoapics");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Viseoapics");

            migrationBuilder.DropColumn(
                name: "PictureID",
                table: "Viseoapics");

            migrationBuilder.DropColumn(
                name: "YoutubeLink",
                table: "Viseoapics");

            migrationBuilder.CreateTable(
                name: "VideoPictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureId = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoPictures_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoPictures_PictureId",
                table: "VideoPictures",
                column: "PictureId");
        }
    }
}
