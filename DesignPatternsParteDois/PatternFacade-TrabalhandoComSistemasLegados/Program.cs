using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade_TrabalhandoComSistemasLegados
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf = "010.185.309-24";

            #region Maneira "Manual"
            //Cliente cliente = new ClienteDao().BuscaPorCpf(cpf);

            //Fatura fatura = new Fatura(cliente, 5000);

            //Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            //cobranca.Emite();


            //ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            //contato.Dispara(); 
            #endregion

            #region Com uso do Facade
            EmpresaFacade facade = new EmpresaFacade();
            var cliente = facade.BuscaCliente(cpf);
            var fatura = facade.CriaFatura(cliente, 5000);
            var cobranca = facade.GeraCobranca(fatura);
            facade.FazContato(cliente, cobranca);
            
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Exemplo TutorialsPoint
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
            Console.ReadKey();
            #endregion
        }
    }
}
