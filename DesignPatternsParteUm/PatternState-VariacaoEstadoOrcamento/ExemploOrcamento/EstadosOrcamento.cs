using System;

namespace PatternState_VariacaoEstadoOrcamento
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public bool DescontoConcedido { get; private set; }
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoConcedido)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                DescontoConcedido = true;
            } else
            {
                throw new Exception("O desconto já foi concedido!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            // do estado atual "em aprovacao" eu posso aprovar o orçamento.
            orcamento.Estado = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            // do estado atual "em aprovacao" eu não posso finalizar o orçamento.
            throw new Exception("Orçamento em aprovação não pode ir para finalizado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            // do estado atual "em aprovacao" eu posso reprovar o orçamento.
            orcamento.Estado = new Reprovado();
        }
    }

    public class Aprovado : IEstadoDeUmOrcamento
    {
        public bool DesconsoConcedido { get; private set; }
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!DesconsoConcedido)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                DesconsoConcedido = true;
            } else
            {
                throw new Exception("O desconto já foi concedido!");
            }
            
        }

        public void Aprova(Orcamento orcamento)
        {
            // do estado atual "aprovado" eu não posso aprovar o orçamento.;
            throw new Exception("Orçamento já está em estado de aprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            // do estado atual "aprovado" eu posso finalizar o orçamento.
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            // do estado atual "aprovado" eu não posso reprovar o orçamento.
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado.");
        }
    }

    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => throw new Exception("Orçamentos reprovados não recebem desconto extra.");

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não podem ser aprovados.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não podem ser finalizados.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não podem ser reprovados.");
        }
    }

    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => throw new Exception("Orçamentos finalizados não recebem desconto extra.");

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não podem ser aprovados.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não podem ser finalizados.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não podem ser reprovados.");
        }
    }
}
