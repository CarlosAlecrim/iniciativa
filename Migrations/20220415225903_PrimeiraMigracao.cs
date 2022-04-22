using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace iniciativa.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IniciativaWoman",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "varchar(80)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(512)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(150)", nullable: false),
                    url = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IniciativaWoman", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "varchar(80)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(250)", nullable: false),
                    Data = table.Column<DateTime>(type: "date", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(250)", nullable: false),
                    iniciativaWomanid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_IniciativaWoman_iniciativaWomanid",
                        column: x => x.iniciativaWomanid,
                        principalTable: "IniciativaWoman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evento_iniciativaWomanid",
                table: "Evento",
                column: "iniciativaWomanid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "IniciativaWoman");
        }
    }
}
