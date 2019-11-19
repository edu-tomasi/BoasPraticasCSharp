using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_ImpostosCompostos
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public TemplateImpostoCondicional() { }
        public TemplateImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            double valorImposto;
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                
                valorImposto = CalculaMaximaTaxacao(orcamento);
            }
            valorImposto = CalculaMinimaTaxacao(orcamento);

            return valorImposto + OutroImposto.Calcula(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double CalculaMinimaTaxacao(Orcamento orcamento);
        public abstract double CalculaMaximaTaxacao(Orcamento orcamento);
        
    }
}
