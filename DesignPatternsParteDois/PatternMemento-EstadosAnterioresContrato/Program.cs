﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMemento_EstadosAnterioresContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato c = new Contrato(DateTime.Now, "Eduardo Tomasi", TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());

            //Console.WriteLine(c.Tipo);

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(c.Tipo);

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);

            Console.ReadKey();



        }
    }
}
