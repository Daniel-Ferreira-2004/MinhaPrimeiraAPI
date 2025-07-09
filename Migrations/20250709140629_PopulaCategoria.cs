using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaPrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO categorias (Nome, ImagemURL) VALUES " +
                  "('Bebidas', 'https://localhost:5001/images/categorias/bebidas.jpg')," +
                  "('Higiene Pessoal', 'https://localhost:5001/images/categorias/higiene-pessoal.jpg')," +
                  "('Limpeza', 'https://localhost:5001/images/categorias/limpeza.jpg')," +
                  "('Alimentos', 'https://localhost:5001/images/categorias/alimentos.jpg')," +
                  "('Roupas', 'https://localhost:5001/images/categorias/roupas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM categorias WHERE Nome IN ('Bebidas', 'Higiene Pessoal', 'Limpeza', 'Alimentos', 'Roupas')");
        }
    }
}
