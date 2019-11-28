using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_CriandoConexaoComDb
{
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
}
