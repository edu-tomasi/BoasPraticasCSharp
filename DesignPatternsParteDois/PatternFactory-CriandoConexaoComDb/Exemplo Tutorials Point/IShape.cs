using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_CriandoConexaoComDb
{
    public interface IShape
    {
        void Draw();
        IShape getShape();
    }
}
