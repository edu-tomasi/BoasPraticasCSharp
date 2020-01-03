using System;

namespace PatternCommand_DiferentesAcoes
{
    public class Stock
    {
        private string _name = "ABC";
        private int _quantity = 10;

        public void buy()
        {
            Console.WriteLine($"Stock [Name: {_name}, Quantity: {_quantity}] bought.");
        }

        public void sell()
        {
            Console.WriteLine($"Stock [Name: {_name}, Quantity: {_quantity}] sold.");
        }
    }
}
