
using System;
using System.Collections.Generic;

class Program
{
    static List<string> listaDeCompras = new List<string>();

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
        var item = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(item))
        {
            listaDeCompras.Add(item);
            Console.WriteLine($"Item '{item}' adicionado!");
        }
        else
        {
            Console.WriteLine("Nome do item não pode ser vazio.");
        }
    }

    static void RemoverItem()
    {
        ListarItens();
        Console.Write("Digite o número do item para remover: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= listaDeCompras.Count)
        {
            string removido = listaDeCompras[indice - 1];
            listaDeCompras.RemoveAt(indice - 1);
            Console.WriteLine($"Item '{removido}' removido!");
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }
    }

    static void ListarItens()
    {
        if (listaDeCompras.Count == 0)
        {
            Console.WriteLine("A lista está vazia.");
        }
        else
        {
            Console.WriteLine("Itens na lista:");
            for (int i = 0; i < listaDeCompras.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaDeCompras[i]}");
            }
        }
    }
}
