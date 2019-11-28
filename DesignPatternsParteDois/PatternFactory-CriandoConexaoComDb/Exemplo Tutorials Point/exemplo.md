### Design Pattern - Factory Pattern

No __Factory Pattern__ nós criamos um objeto sem expor a lógica de criação ao cliente, e fazemos a referência ao objeto recém criado utilizando uma interface em comum.
Este padrão de projeto está relacionado dentro dos __Padrões  Criacionais__ e provém uma das melhores maneiras de criar um objeto.

Implementação: Iremos criar uma _interface Shape_ e classes concretas que implementam ela. Uma classe factory _ShapeFactory_ será definida como próximo passo.

Passo à passo:
 * Crie a _interface_ IShape.
 * Crie as classes concretas que irão implementar a interface: `Rectangle`, `Square` e `Circle`.
 * Crie a classe Factory que será responsável por gerar os objetos concretos baseado na solicitação de criação.
 * Use a classe Factory para criar os objetos concretos solicitados.

 Exemplos de Código:
 * Program.cs
 ```
     class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            IShape shape1 = shapeFactory.getShape("CIRCLE");
            //call draw method of Circle.
            shape1.Draw();

            //get an object of Rectangle and call its draw method.
            IShape shape2 = shapeFactory.getShape("RECTANGLE");
            //call draw method of Rectangle.
            shape2.Draw();

            //get an object of Square and call its draw method.
            IShape shape3 = shapeFactory.getShape("SQUARE");
            //call draw method of Square.
            shape3.Draw();

            //get an object of Circle using a basis constructor.
            IShape shape4 = shapeFactory.getShape(new Circle());
            shape4.Draw();

            Console.ReadKey();
        }
    }
 ```

 * ShapeFactory.cs
 ```
     public class ShapeFactory
    {
        //use getShape method to get object of type shape
        public IShape getShape(string shapeType)
        {
            if (String.IsNullOrEmpty(shapeType)) return null;

            if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase)) return new Circle();
            if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase)) return new Rectangle();
            if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase)) return new Square();

            return null;
        }

        public IShape getShape(IShape shapeRequired)
        {
            return shapeRequired.getShape();
        }
    }
 ```

 * IShape.cs
 ```
     public interface IShape
    {
        void Draw();
        IShape getShape();
    }
 ```

 * Circle.cs
 ```
     public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::Draw() method.");
        }

        public IShape getShape()
        {
            return new Circle();
        }
    }
```

* Square.cs
```
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::Draw() method.");
        }

        public IShape getShape()
        {
            return new Square();
        }
    }
```

* Rectangle.cs
```
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::Draw() method.");
        }

        public IShape getShape()
        {
            return new Rectangle();
        }
    }
```
