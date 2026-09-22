using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetoFimModulo.Migrations
{
    /// <inheritdoc />
    public partial class ajust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Categorias_CategoriaId",
                table: "Chamados");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Chamados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Categorias_CategoriaId",
                table: "Chamados",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Categorias_CategoriaId",
                table: "Chamados");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Chamados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Categorias_CategoriaId",
                table: "Chamados",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }
    }
}
