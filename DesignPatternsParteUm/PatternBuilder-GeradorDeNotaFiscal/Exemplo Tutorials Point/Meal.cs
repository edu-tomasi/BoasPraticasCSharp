using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    public class Meal
    {
        private IList<IItem> items = new List<IItem>();

        public void addItem(IItem item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            float cost = 0.0f;

            foreach(IItem item in items)
            {
                cost += item.price();
            }

            return cost;
        }

        public void showItems()
        {
            foreach (IItem item in items)
            {
                Console.Write($"Item: {item.name()}");
                Console.Write($", Packing: {item.packing()}");
                Console.Write($", Price: {item.price()}{Environment.NewLine}");
            }
        }
    }
}
