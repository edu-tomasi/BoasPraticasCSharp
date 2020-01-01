using System;

namespace PatternBridge_EnvioDeMensagens
{
    public class MensagemAdministrativa : IMensagem
    {
        private string Nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            this.Nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Enviando a mensagem para o administrador {0}", Nome);
        }
    }
}
