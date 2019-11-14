using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploCurso_Formato
{
    public class RequisicaoXml : IRequisicao
    {
        public IRequisicao Proxima { get; }

        public RequisicaoXml(IRequisicao proxima)
        {
            Proxima = proxima;
        }

        public string Responder(Conta conta, Formato formato)
        {
            if (formato == Formato.XML)
                return $"<conta><nome>{conta.Nome}</nome><saldo>{conta.Saldo}</saldo></conta>";
            else
            {
                if (Proxima != null)
                {
                    return Proxima.Responder(conta, formato);
                } else
                {
                    return "";
                }
            }
        }
    }
}
