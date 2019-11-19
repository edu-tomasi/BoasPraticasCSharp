using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState_VariacaoEstadoOrcamento
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IEstadoDeUmOrcamento Estado { get; set; }

        public Orcamento(int valor)
        {
            Valor = valor;
            Estado = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            Estado.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            Estado.Aprova(this);
        }

        public void Reprova()
        {
            Estado.Reprova(this);
        }

        public void Finaliza()
        {
            Estado.Finaliza(this);
        }
    }
}
