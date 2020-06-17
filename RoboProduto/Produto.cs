using System.Globalization;

namespace RoboProduto
{
    public class Produto
    {

        public string Nome;

        public double Preco;

        public int Quantidade;

        //sobrecarga 
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 15;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto()
        {
        }

        // ctor tab tab contrutor automatico

        public double ValorEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarQuantidadeEstoque(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverQuantidadeEstoque(int qtd)
        {
            Quantidade -= qtd;
        }

        //sobrepor
        public override string ToString()
        {
            return Nome
                + " $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades "
                + " Total em estoque: valor $"
                + ValorEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
