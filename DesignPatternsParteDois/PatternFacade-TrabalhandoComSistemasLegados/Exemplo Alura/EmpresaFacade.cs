using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade_TrabalhandoComSistemasLegados
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf) => new ClienteDao().BuscaPorCpf(cpf);

        public Fatura CriaFatura(Cliente cliente, double valor) => new Fatura(cliente, valor);

        public Cobranca GeraCobranca(Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }
}
