using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaPrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO produto (Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES " +
                   "('Coca-Cola', 'Refrigerante de cola', 5.99, 'https://localhost:5001/images/produtos/coca-cola.jpg', 100, now(), 1)," +
                   "('Sabonete', 'Sabonete líquido para as mãos', 3.49, 'https://localhost:5001/images/produtos/sabonete.jpg', 200, now(), 2)," +
                   "('Detergente', 'Detergente para lavar louças', 2.99, 'https://localhost:5001/images/produtos/detergente.jpg', 150, now(), 3)," +
                   "('Arroz', 'Arroz branco tipo 1', 4.50, 'https://localhost:5001/images/produtos/arroz.jpg', 300, 09/07/2025, 4)," +
                   "('Camiseta', 'Camiseta de algodão tamanho M', 29.90, 'https://localhost:5001/images/produtos/camiseta.jpg', 50, now(), 5)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM produto WHERE Nome IN ('Coca-Cola', 'Sabonete', 'Detergente', 'Arroz', 'Camiseta')");
        }
    }
}
