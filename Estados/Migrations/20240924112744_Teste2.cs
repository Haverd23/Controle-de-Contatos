using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estados.Migrations
{
    /// <inheritdoc />
    public partial class Teste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Estados",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Estados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Estados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "Estados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Estados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Estados");
        }
    }
}
