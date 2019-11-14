using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploCurso_Formato
{
    public class RequisicaoCsv : IRequisicao
    {
        public IRequisicao Proxima { get; }

        public RequisicaoCsv(IRequisicao proxima)
        {
            Proxima = proxima;
        }

        public string Responder(Conta conta, Formato formato)
        {
            if (formato == Formato.CSV)
                return $"{conta.Nome},{conta.Saldo}";

            return Proxima.Responder(conta, formato);
        }
    }
}
