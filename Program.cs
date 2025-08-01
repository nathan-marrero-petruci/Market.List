

using System;
using Market.List;

class Program
{
    static ListaDeCompras lista = new ListaDeCompras();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Lista de Compras ---");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Listar itens");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    AdicionarItem();
                    break;
                case "2":
                    RemoverItem();
                    break;
                case "3":
                    ListarItens();
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void AdicionarItem()
    {
        Console.Write("Digite o nome do item: ");
        var nome = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nome))
        {
            lista.Adicionar(new Item(nome));
            Console.WriteLine($"Item '{nome}' adicionado!");
        }
        else
        {
            Console.WriteLine("Nome do item não pode ser vazio.");
        }
    }

    static void RemoverItem()
    {
        ListarItens();
        if (lista.Contar() == 0)
            return;
        Console.Write("Digite o número do item para remover: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= lista.Contar())
        {
            var itemRemovido = lista.Listar()[indice - 1].Nome;
            lista.Remover(indice - 1);
            Console.WriteLine($"Item '{itemRemovido}' removido!");
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }
    }

    static void ListarItens()
    {
        var itens = lista.Listar();
        if (itens.Count == 0)
        {
            Console.WriteLine("A lista está vazia.");
        }
        else
        {
            Console.WriteLine("Itens na lista:");
            for (int i = 0; i < itens.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {itens[i].Nome}");
            }
        }
    }
}
