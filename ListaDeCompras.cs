using System.Collections.Generic;

namespace Market.List
{
    public class ListaDeCompras
    {
        private readonly List<Item> itens = new List<Item>();

        public void Adicionar(Item item)
        {
            itens.Add(item);
        }

        public bool Remover(int indice)
        {
            if (indice >= 0 && indice < itens.Count)
            {
                itens.RemoveAt(indice);
                return true;
            }
            return false;
        }

        public IReadOnlyList<Item> Listar()
        {
            return itens.AsReadOnly();
        }

        public int Contar()
        {
            return itens.Count;
        }
    }
}
