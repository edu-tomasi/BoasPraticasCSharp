using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_ImpostosCompostos
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP() { }

        public ICPP(Imposto outroImposto) : base(outroImposto) { }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) => orcamento.Valor >= 500;

        public override double CalculaMaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.07;

        public override double CalculaMinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.05;
    }
}
