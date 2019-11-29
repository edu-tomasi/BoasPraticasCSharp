using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFlyweight_MuitoObjetos
{
    class Circle : IShape
    {
        private string color;
        public int xPos { get; set; }
        public int yPos { get; set; }
        public int radius { get; set; }

        public Circle(string color)
        {
            this.color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Circle: Draw() [Color : {color}, xPosition : {xPos}, yPosition : {yPos}, radius : {radius}]");
        }
    }
}
