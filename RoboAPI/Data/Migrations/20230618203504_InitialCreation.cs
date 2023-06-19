using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboAPI.Data.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcaoBracoCotovelo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcaoBracoCotovelo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcaoBracoPulso",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcaoBracoPulso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcaoCabecaInclinacao",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcaoCabecaInclinacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcaoCabecaRotacao",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcaoCabecaRotacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Robo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CotoveloEsquerdo = table.Column<long>(type: "INTEGER", nullable: false),
                    CotoveloDireito = table.Column<long>(type: "INTEGER", nullable: false),
                    PulsoEsquerdo = table.Column<long>(type: "INTEGER", nullable: false),
                    PulsoDireito = table.Column<long>(type: "INTEGER", nullable: false),
                    CabecaRotacao = table.Column<long>(type: "INTEGER", nullable: false),
                    CabecaInclinacao = table.Column<long>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Robo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AcaoBracoCotovelo",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 1L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5665), "Em Repouso" });

            migrationBuilder.InsertData(
                table: "AcaoBracoCotovelo",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 2L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5669), "Levemente Contraído" });

            migrationBuilder.InsertData(
                table: "AcaoBracoCotovelo",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 3L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5669), "Contraído" });

            migrationBuilder.InsertData(
                table: "AcaoBracoCotovelo",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 4L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5670), "Fortemente Contraído" });

            migrationBuilder.InsertData(
                table: "AcaoBracoPulso",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 1L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5777), "Rotação para -90°" });

            migrationBuilder.InsertData(
                table: "AcaoBracoPulso",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 2L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5778), "Rotação para -45°" });

            migrationBuilder.InsertData(
                table: "AcaoBracoPulso",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 3L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5778), "Em Repouso" });

            migrationBuilder.InsertData(
                table: "AcaoBracoPulso",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 4L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5779), "Rotação para 45°" });

            migrationBuilder.InsertData(
                table: "AcaoBracoPulso",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 5L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5779), "Rotação para 90°" });

            migrationBuilder.InsertData(
                table: "AcaoBracoPulso",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 6L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5780), "Rotação para 135°" });

            migrationBuilder.InsertData(
                table: "AcaoBracoPulso",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 7L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5780), "Rotação para 180°" });

            migrationBuilder.InsertData(
                table: "AcaoCabecaInclinacao",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 1L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5790), "Para Cima" });

            migrationBuilder.InsertData(
                table: "AcaoCabecaInclinacao",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 2L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5791), "Em Repouso" });

            migrationBuilder.InsertData(
                table: "AcaoCabecaInclinacao",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 3L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5791), "Para Baixo" });

            migrationBuilder.InsertData(
                table: "AcaoCabecaRotacao",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 1L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5798), "Rotação -90°" });

            migrationBuilder.InsertData(
                table: "AcaoCabecaRotacao",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 2L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5799), "Rotação -45°" });

            migrationBuilder.InsertData(
                table: "AcaoCabecaRotacao",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 3L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5800), "Em Repouso" });

            migrationBuilder.InsertData(
                table: "AcaoCabecaRotacao",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 4L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5800), "Rotação 45°" });

            migrationBuilder.InsertData(
                table: "AcaoCabecaRotacao",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao" },
                values: new object[] { 5L, null, new DateTime(2023, 6, 18, 20, 35, 4, 293, DateTimeKind.Utc).AddTicks(5801), "Rotação 90°" });

            migrationBuilder.InsertData(
                table: "Robo",
                columns: new[] { "Id", "CabecaInclinacao", "CabecaRotacao", "CotoveloDireito", "CotoveloEsquerdo", "DataAtualizacao", "DataCriacao", "PulsoDireito", "PulsoEsquerdo" },
                values: new object[] { 1L, 2L, 3L, 1L, 1L, null, null, 3L, 3L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcaoBracoCotovelo");

            migrationBuilder.DropTable(
                name: "AcaoBracoPulso");

            migrationBuilder.DropTable(
                name: "AcaoCabecaInclinacao");

            migrationBuilder.DropTable(
                name: "AcaoCabecaRotacao");

            migrationBuilder.DropTable(
                name: "Robo");
        }
    }
}
