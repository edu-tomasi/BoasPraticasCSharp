using System;

namespace PatternDecorator_ImpostosCompostos
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public Conta(double saldo, DateTime dataAbertura)
        {
            Saldo = saldo;
            DataAbertura = dataAbertura;
        }

        public override string ToString()
        {
            return $"{Saldo} - {DataAbertura}";
        }
    }
}