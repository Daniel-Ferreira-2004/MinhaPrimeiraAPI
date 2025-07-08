using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace MinhaPrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categoria (Nome, ImagemURL) VALUES ('FPS', 'fps.png')");
            mb.Sql("INSERT INTO Categoria (Nome, ImagemURL) VALUES ('Terror', 'terror.png')");
            mb.Sql("INSERT INTO Categoria (Nome, ImagemURL) VALUES ('Corrida', 'corrida.png')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categoria");
        }
    }
}
