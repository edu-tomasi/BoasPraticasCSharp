using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploCurso_Formato
{
    public class RequisicaoPercentual : IRequisicao
    {
        public IRequisicao Proxima { get; }

        public RequisicaoPercentual(IRequisicao proxima)
        {
            Proxima = proxima;
        }

        public string Responder(Conta conta, Formato formato)
        {
            if (formato == Formato.PORCENTO)
                return $"{conta.Nome}%{conta.Saldo}";

            return Proxima.Responder(conta, formato);
        }
    }
}
