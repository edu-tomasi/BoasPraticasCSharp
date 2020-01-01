using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge_EnvioDeMensagens
{
    public class GreenCircle : IDrawAPI
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Circle [ color: green, radius: {radius}, x: {x}, y: {y} ]");
        }
    }
}
