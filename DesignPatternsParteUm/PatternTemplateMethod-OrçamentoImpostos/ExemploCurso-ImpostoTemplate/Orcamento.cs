using System.Collections;
using System.Collections.Generic;

namespace PatternTemplateMethod_OrçamentoImpostos
{
    public class Orcamento
    {
        public double Valor { get; }
        public IList<Item> Itens { get; }



        public Orcamento(double valor)
        {
            this.Valor = valor;
            Itens = new List<Item>();
        }

        public void Adicionar(Item item)
        {
            this.Itens.Add(item);
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