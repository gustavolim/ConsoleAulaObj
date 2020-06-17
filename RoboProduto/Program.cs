using System;
using System.Globalization;

namespace RoboProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nome do Produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço do produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            //Produto produto = new Produto();
            Produto produto = new Produto("Arroz", 10.00, 0);
            Produto produtoA = new Produto("Feijao", 8.00);
            Produto produtoB = new Produto();
            // dois produtos 
            Console.WriteLine("Nome do Produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Preço do produto:");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade:");
            produto.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Produto: " + produto );

            Console.WriteLine();

            Console.WriteLine("Adicione mais produto " + produto.Nome + " no estoque: ");

            int addQtd = int.Parse(Console.ReadLine());

            produto.AdicionarQuantidadeEstoque(addQtd);

            Console.WriteLine();

            Console.WriteLine("Total Atualizado: " + produto);

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Remova produto " + produto.Nome + " no estoque: ");

            int rmvQtd = int.Parse(Console.ReadLine());

            produto.RemoverQuantidadeEstoque(rmvQtd);

            Console.WriteLine();

            Console.WriteLine("Total Atualizado: " + produto);



        }
    }
}
