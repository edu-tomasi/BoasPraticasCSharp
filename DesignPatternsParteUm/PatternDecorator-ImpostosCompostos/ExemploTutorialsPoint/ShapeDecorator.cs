using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_ImpostosCompostos.ExemploTutorialsPoint
{
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
}
