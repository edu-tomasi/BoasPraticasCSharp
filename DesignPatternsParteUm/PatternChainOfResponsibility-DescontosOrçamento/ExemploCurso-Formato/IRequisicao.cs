using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploCurso_Formato
{
    public interface IRequisicao
    {
        IRequisicao Proxima { get; }
        string Responder(Conta conta, Formato formato);
    }
}
