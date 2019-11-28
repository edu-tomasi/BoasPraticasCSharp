using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_CriandoConexaoComDb
{
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
}
