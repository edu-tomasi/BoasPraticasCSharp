using System;

namespace PatternFacade_TrabalhandoComSistemasLegados
{
    public class ClienteDao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Cliente BuscaPorCpf(string cpf)
        {
            return new Cliente() { CPF = cpf, Nome = "Eduardo Tomasi" };
        }
    }
}