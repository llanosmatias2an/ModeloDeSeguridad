using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELOS.Migrations
{
    /// <inheritdoc />
    public partial class InitialUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioID",
                table: "Grupos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_UsuarioID",
                table: "Grupos",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioID",
                table: "Grupos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioID",
                table: "Grupos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_UsuarioID",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Grupos");
        }
    }
}
