### Design Patterns - Decoration Pattenr

Mais informações sobre este exemplo podem ser encontradas no seguinte [endereço](https://www.tutorialspoint.com/design_pattern/decorator_pattern.htm).

Este exemplo irá demonstrar o uso do __Decorator Pattern__ através do exemplo em que nós iremos compor um "shape" com algumas cores sem alterar a classe "shape".

Passo à passo:
 * Criar a interface `IShape`.
 * Criar as classes concretas que implementam a mesma interface, `Rectangle` e `Circle`.
 * Criar a Classe Abstrata de Decoração (__ShapeDecorator__) que implementa a _interface_ __IShape__.
 * Criar a Classe Concreta de Decoração (__RedShapeDecorator__)que extende a _classe_ __ShapeDecorator__.
 * Criar a classe Program onde usa a classe __RedShapeDecorator__ para decorar os objetos __Shape__.

Segue trecho dos códigos:

### IShape.cs
```
    public interface IShape
    {
        void Draw();
    }
```

### Rectangle.cs
```
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
```

### Circle.cs
```
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
```

### ShapeDecorator.cs
```
    public abstract class ShapeDecorator : IShape
    {
        public IShape DecoratedShape { get; }

        public ShapeDecorator(IShape decoratedShape)
        {
            DecoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            DecoratedShape.Draw();
        }
    }
```

### RedShapeDecorator.cs
```
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            setRedBorder(DecoratedShape);
        }

        private void setRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red.");
        }
    }
```