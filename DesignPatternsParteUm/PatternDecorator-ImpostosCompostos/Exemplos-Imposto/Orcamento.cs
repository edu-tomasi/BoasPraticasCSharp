using System.Collections.Generic;

namespace PatternDecorator_ImpostosCompostos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; private set; }
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }

    public class Item
    {
        public string Descricao { get; }
        public double Valor { get; }

        public Item(string descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}