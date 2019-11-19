using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTemplateMethod_OrçamentoImpostos
{
    //public class IKCV : IImposto
    public class IKCV : TemplateImpostoCondicional
    {
        //public double Calcula(Orcamento orcamento)
        //{
        //    if (orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento))
        //    {
        //        return orcamento.Valor * 0.1;
        //    }
        //    else
        //    {
        //        return orcamento.Valor * 0.06;
        //    }
        //}

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }
    }
}
