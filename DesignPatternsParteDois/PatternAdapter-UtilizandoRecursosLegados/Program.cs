using System;

namespace PatternAdapter_UtilizandoRecursosLegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Name = "Eduardo";
            cliente.Endereco = "Rua Maria André de Freitas";
            cliente.DataDeNascimento = new DateTime(1994, 04, 29);


            String xml = new GeradorDeXml().GeraXml(cliente);
            Console.WriteLine(xml);

            Console.ReadKey();
        }
    }
}
