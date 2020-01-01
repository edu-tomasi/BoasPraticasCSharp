using System;

namespace PatternBridge_EnvioDeMensagens
{
    public class MensagemCliente : IMensagem
    {
        private string Nome;
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            this.Nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Mensagem para o cliente {0}", Nome);
        }
    }
}
