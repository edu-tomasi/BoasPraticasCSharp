﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility_DescontosOrçamento.ExemploCurso_Formato
{
    public class RequisicaoSemFormato : IRequisicao
    {
        public IRequisicao Proxima { get; set; }

        public string Responder(Conta conta, Formato formato)
        {
            return "";
        }
    }
}
