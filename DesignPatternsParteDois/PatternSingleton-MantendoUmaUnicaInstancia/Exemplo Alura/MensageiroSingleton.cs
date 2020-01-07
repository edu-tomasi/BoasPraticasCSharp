namespace PatternSingleton_MantendoUmaUnicaInstancia
{
    public class MensageiroSingleton
    {
        private static Mensageiro instancia = new Mensageiro();

        public Mensageiro Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}
