using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploCurso_Formato
{
    public class GerenciadorComunicacao
    {
        public string Comunicar(Conta conta, Formato formato)
        {
            RequisicaoCsv r1 = new RequisicaoCsv(new RequisicaoPercentual(new RequisicaoXml(new RequisicaoSemFormato(null))));

            return r1.Responder(conta, formato);
        }
    }
}
