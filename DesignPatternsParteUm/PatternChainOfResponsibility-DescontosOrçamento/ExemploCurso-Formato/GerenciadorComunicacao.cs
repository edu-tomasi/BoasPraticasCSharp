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
            RequisicaoCsv r1 = new RequisicaoCsv();
            RequisicaoPercentual r2 = new RequisicaoPercentual();
            RequisicaoXml r3 = new RequisicaoXml();
            RequisicaoSemFormato r4 = new RequisicaoSemFormato();

            r1.Proxima = r2;
            r2.Proxima = r3;
            r3.Proxima = r4;

            return r1.Responder(conta, formato);
        }
    }
}
