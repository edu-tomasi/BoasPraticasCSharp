using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFlyweight_MuitoObjetos
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> circleMap = new Dictionary<string, IShape>();

        public static IShape getCircle(string color)
        {
            circleMap.TryGetValue(color, out IShape circle);

            if (circle == null)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine($"Creating circle of color : {color}");
            }

            return circle;
        }
    }
}
