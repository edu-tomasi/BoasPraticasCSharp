﻿using PatternBuilder_GeradorDeNotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver_ExecutandoAcoesDiferentes
{
    public class EnviadorDeEmail : IAcaoAposGererNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Ação: Enviando e-mail.");
        }
    }
}
