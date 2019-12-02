using System;
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

            Console.WriteLine(c.Tipo);

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(c.Tipo);

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);

            Console.ReadKey();
            Console.Clear();

            Originator originator = new Originator();
            CakeTaker careTaker = new CakeTaker();

            originator.State = "State #1";
            originator.State = "State #2";
            careTaker.Add(originator.saveStateToMemento());

            originator.State = "State #3";
            careTaker.Add(originator.saveStateToMemento());

            originator.State = "State #4";
            Console.WriteLine($"Current State: {originator.State}!");

            originator.getStateFromMemento(careTaker.Get(0));
            Console.WriteLine($"First saved State: {originator.State}!");
            originator.getStateFromMemento(careTaker.Get(1));
            Console.WriteLine($"Second saved State: {originator.State}!");

            Console.ReadKey();
        }
    }
}
