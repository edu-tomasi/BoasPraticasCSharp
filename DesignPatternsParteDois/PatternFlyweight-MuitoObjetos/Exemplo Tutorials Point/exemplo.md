### Design Pattern - Flyweight Pattern

No __Flyweight Pattern__ o objetivo é reduzir o número de objetos instanciados, e com isso reduzir o consumo de memória pela aplicação. 
Este padrão de projeto está relacionado dentro dos __Padrões Estruturais__.

Mais informações podem ser obtidas neste [endereço](https://www.tutorialspoint.com/design_pattern/flyweight_pattern.htm).

Implementação: iremos criar uma _interface IShape_ e uma classe concreta _Circle_ que implementará o _IShape_.

Passo à passo:
 * Crie a _interface_ IShape.
 * Crie a _classe concreta_ Circle.
 * Crie a _classe concreta_ que implementa o padrão Flyweight.

Exemplos de Código:
 * Program.cs
 ```
    class Program
    
        private static string[] colors = { "Red", "Green", "Blue", "White", "Black" };

        static void Main(string[] args)
        {
            #region Exemplo Tutorials Point
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.xPos = getRandomX();
                circle.yPos = getRandomY();
                circle.radius = 100;
                circle.Draw();
            }
            #endregion

            Console.ReadKey();
        }

        private static string getRandomColor()
        {
            return colors[new Random().Next(0, 4)];
        }

        private static int getRandomX()
        {
            return new Random().Next() * 100;
        }

        private static int getRandomY()
        {
            return new Random().Next() * 100;
        }

    }
 ```

 * ShapeFactory.cs
 ```
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
 ```

 * IShape.cs
 ```
    public interface IShape
    {
        void Draw();
    }
 ```

 * Circle.cs
 ```
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
 ```