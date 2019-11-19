using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_ImpostosCompostos
{
    public class IKCV : TemplateImpostoCondicional
    {
        public IKCV() { }

        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        public override double CalculaMaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.1;

        public override double CalculaMinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.06;

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) => temItemMaiorQue100ReaisNo(orcamento);

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}
