using System;

namespace PatternCommand_DiferentesAcoes
{
    public class SellStock : Order
    {
        private Stock _stock;

        public SellStock(Stock stock)
        {
            this._stock = stock;
        }

        public void Execute()
        {
            _stock.sell();
        }
    }
}
