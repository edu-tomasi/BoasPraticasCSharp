namespace PatternCommand_DiferentesAcoes
{
    public class BuyStock : Order
    {
        private Stock _stock;

        public BuyStock(Stock stock)
        {
            this._stock = stock;
        }

        public void Execute()
        {
            _stock.buy();
        }

    }
}
