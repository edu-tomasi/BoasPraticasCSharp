### Design Pattern - Bridge Pattern

No __Brigde Pattern__ implementamos um exemplo que separa uma abstração de sua implementação para que as duas possam variar independentemente. Esse tipo de Design Pattern se enquadra no __Padrão Estrutural__, pois desacopla a classe de implementação e a classe abstrata, fornecendo uma estrutura de ponte entre eles.
Esse padrão envolve uma interface que atua como uma ponte que torna a funcionalidade de  classes concretas independente das classes do implementador da interface. Ambos os tipos de classes podem ser alterados estruturalmente sem se afetarem.

Estamos demonstrando o uso do Bridge Pattern através do exemplo a seguir, no qual um círculo pode ser desenhado em cores diferentes usando o mesmo método de classe abstrata mas diferentes classes de implementadores de ponte.

Mais informações podem ser obtidas neste [endereço](https://www.tutorialspoint.com/design_pattern/bridge_pattern.htm).

Implementação: Temos uma _interface DrawAPI_ que atua como implementador de ponte e as _classes concretas RedCircle_, _GreenCircle_ implementando a _interface DrawAPI_. _Shape_ é uma classe abtrata e usará o objeto _DrawAPI_. A _classe Program_ usará _Shape_ para desenhar diferentes círculos coloridos.

Passo à passo:
* Crie a interface _IDrawAPI_.
* Criar as classes implementadores da ponte concreta implementando a interface _IDrawAPI_.
* Crie uma classe abstrata _Shape_ usando a interface _IDrawAPI_.
* Crie uma classe concreta implementando a interface _Shape_.
* Use as classes _Shape_ e _IDrawAPI_ para desenhar diferentes círculos coloridos.

Exemplos de código:
* Program.cs
```
class Program
{
	static void Main(string[] args)
    {
    	Shape circleOne = new Circle(0, 0, 3, new RedCircle());
        circleOne.Draw();

        Shape circleTwo = new Circle(1, 1, 4, new GreenCircle());
        circleTwo.Draw();

        Console.ReadKey();
        Console.Clear(); 
    }
}
```

* Circle.cs
```
public class Circle : Shape
{
    private int x;
    private int y;
    private int radius;

    public Circle(int x, int y, int radius, IDrawAPI drawAPI) : base(drawAPI)
    {
    	this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override void Draw()
    {
    	DrawAPI.drawCircle(radius, x, y);
	}
}
```

* Shape.cs
```
public abstract class Shape
{
	protected IDrawAPI DrawAPI;

    public Shape(IDrawAPI drawAPI)
    {
    	this.DrawAPI = drawAPI;
	}

	public abstract void Draw();
}
```

* IDrawAPI.cs
```
public interface IDrawAPI
{
	void drawCircle(int radius, int x, int y);
}
```

* RedCircle.cs
```
public class RedCircle : IDrawAPI
{
	public void drawCircle(int radius, int x, int y)
    {
    	Console.WriteLine($"Drawing Circle [ color: red, radius: {radius}, x: {x}, y: {y} ]");
	}
}
```

* GreenCircle.cs
```
    public class GreenCircle : IDrawAPI
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Circle [ color: green, radius: {radius}, x: {x}, y: {y} ]");
        }
    }
```