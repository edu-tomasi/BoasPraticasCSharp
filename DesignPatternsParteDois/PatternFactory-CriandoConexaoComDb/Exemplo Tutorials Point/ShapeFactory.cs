using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_CriandoConexaoComDb
{
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
}
