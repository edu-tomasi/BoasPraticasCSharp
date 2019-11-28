using PatternObserver_ExecutandoAcoesDiferentes;
using System;
using System.Collections.Generic;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        public IList<ItemDaNota> TodosItens = new List<ItemDaNota>();
        private IList<IAcaoAposGererNota> todasAcoesASeremExecutadas = new List<IAcaoAposGererNota>();

        public NotaFiscalBuilder(List<IAcaoAposGererNota> todasAcoesAExecutar)
        {
            this.todasAcoesASeremExecutadas = todasAcoesAExecutar;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, TodosItens, Observacoes);

            foreach (IAcaoAposGererNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionarAcao(IAcaoAposGererNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }


        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            this.ValorTotal += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes; 
            return this;
        }
        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }
    }
}
